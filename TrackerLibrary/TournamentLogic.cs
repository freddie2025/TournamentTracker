using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
	public static class TournamentLogic
	{
		// Order our list randomly of teams
		// Check if it is big enough - if not, add in byes - 2*2*2*2 - 2^4
		// Create our first round of matchups
		// Create every round after that - 8 matchups - 4 matchups - 2 matchups - 1 matchup

		public static void CreateRounds(TournamentModel model)
		{
			List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
			int rounds = FindNumberOfRounds(randomizedTeams.Count);
			int byes = NumberOfByes(rounds, randomizedTeams.Count);

			model.Rounds.Add(CreateFirstround(byes, randomizedTeams));

			CreateOtherRounds(model, rounds);

			UpdateTournamentResults(model);
		}

		public static void UpdateTournamentResults(TournamentModel model)
		{
			int startingRound = model.CheckCurrentRound();
			List<MatchupModel> toScore = new List<MatchupModel>();

			foreach (List<MatchupModel> round in model.Rounds)
			{
				foreach (MatchupModel rm in round)
				{
					if (rm.Winner == null && (rm.Entries.Any(x => x.Score != 0) || rm.Entries.Count == 1))
					{
						toScore.Add(rm);
					}
				}
			}

			MarkWinnersInMatchups(toScore);

			AdvancedWinners(toScore, model);

			toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchup(x));
			
			int endingRound = model.CheckCurrentRound();

			if (endingRound > startingRound)
			{
				model.AlertUsersToNewRound();
			}
		}

		public static void AlertUsersToNewRound(this TournamentModel model)
		{
			int currentRoundNumber = model.CheckCurrentRound();
			List<MatchupModel> currentRound = model.Rounds.Where(x => x.First().MatchupRound == currentRoundNumber).First();

			foreach (MatchupModel matchup in currentRound)
			{
				foreach (MatchupEntryModel me in matchup.Entries)
				{
					foreach (PersonModel p in me.TeamCompeting.TeamMembers)
					{
						AlertPersonToNewRound(p, me.TeamCompeting.TeamName, matchup.Entries.Where(x => x.TeamCompeting != me.TeamCompeting).FirstOrDefault());
					}
				}
			}
		}

		private static void AlertPersonToNewRound(PersonModel p, string teamName, MatchupEntryModel competitor)
		{
			if (p.EmailAddress.Length == 0)
			{
				return;
			}

			string toAddress = "";
			string subject = "";
			StringBuilder body = new StringBuilder();

			if (competitor != null)
			{
				subject = $"You have a new matchup with { competitor.TeamCompeting.TeamName }";

				body.AppendLine("<h1>You have a new matchup</h1>");
				body.Append("<strong>Competitor: </strong>");
				body.AppendLine(competitor.TeamCompeting.TeamName);
				body.AppendLine();
				body.AppendLine();
				body.AppendLine("Have a great time!");
				body.AppendLine("~Tournament Tracker");
			}
			else
			{
				subject = "You have a bye week this round";

				body.AppendLine("Enjoy your round off!");
				body.AppendLine("~Tournament Tracker");
			}

			toAddress = p.EmailAddress;

			EmailLogic.SendEmail(toAddress, subject, body.ToString());
		}

		private static int CheckCurrentRound(this TournamentModel model)
		{
			int output = 1;

			foreach (List<MatchupModel> rounds in model.Rounds)
			{
				if (rounds.All(x => x.Winner != null))
				{
					output += 1;
				}
			}

			return output;
		}

		private static void AdvancedWinners(List<MatchupModel> models, TournamentModel tournament)
		{
			foreach (MatchupModel m in models)
			{
				foreach (List<MatchupModel> round in tournament.Rounds)
				{
					foreach (MatchupModel rm in round)
					{
						foreach (MatchupEntryModel me in rm.Entries)
						{
							if (me.ParentMatchup != null)
							{
								if (me.ParentMatchup.Id == m.Id)
								{
									me.TeamCompeting = m.Winner;
									GlobalConfig.Connection.UpdateMatchup(rm);
								}
							}
						}
					}
				}
			}
		}

		private static void MarkWinnersInMatchups(List<MatchupModel> models)
		{
			// greater or lesser
			string greaterWins =  ConfigurationManager.AppSettings["greaterWins"];

			foreach (MatchupModel m in models)
			{
				// Checks for bye week entry
				if (m.Entries.Count == 1)
				{
					m.Winner = m.Entries[0].TeamCompeting;
					continue;
				}

				// 0 means false, or low score wins
				if (greaterWins == "0")
				{
					if (m.Entries[0].Score < m.Entries[1].Score)
					{
						m.Winner = m.Entries[0].TeamCompeting;
					}
					else if (m.Entries[1].Score < m.Entries[0].Score)
					{
						m.Winner = m.Entries[1].TeamCompeting;
					}
					else
					{
						throw new Exception("We do not allow ties in this application.");
					}
				}
				else
				{
					// 1 means true, or high score wins
					if (m.Entries[0].Score > m.Entries[1].Score)
					{
						m.Winner = m.Entries[0].TeamCompeting;
					}
					else if (m.Entries[1].Score > m.Entries[0].Score)
					{
						m.Winner = m.Entries[1].TeamCompeting;
					}
					else
					{
						throw new Exception("We do not allow ties in this application.");
					}
				}
			}
		}

		private static void CreateOtherRounds(TournamentModel model, int rounds)
		{
			int round = 2;
			List<MatchupModel> previousRound = model.Rounds[0];
			List<MatchupModel> currRound = new List<MatchupModel>();
			MatchupModel currMatchup = new MatchupModel();

			while (round <= rounds)
			{
				foreach (MatchupModel match in previousRound)
				{
					currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

					if (currMatchup.Entries.Count > 1)
					{
						currMatchup.MatchupRound = round;
						currRound.Add(currMatchup);
						currMatchup = new MatchupModel();
					}
				}

				model.Rounds.Add(currRound);
				previousRound = currRound;

				currRound = new List<MatchupModel>();
				round++;
			}
		}

		private static List<MatchupModel> CreateFirstround(int byes, List<TeamModel> teams)
		{
			List<MatchupModel> output = new List<MatchupModel>();
			MatchupModel curr = new MatchupModel();

			foreach (TeamModel team in teams)
			{
				curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

				if (byes > 0 || curr.Entries.Count > 1)
				{
					curr.MatchupRound = 1;
					output.Add(curr);
					curr = new MatchupModel();

					if (byes > 0)
					{
						byes--;
					}
				}
			}

			return output;
		}

		private static int NumberOfByes(int rounds, int numberOfTeams)
		{
			int output = 0;
			int totalTeams = 1;

			for (int i = 1; i < rounds; i++)
			{
				totalTeams *= 2;
			}

			output = totalTeams - numberOfTeams;

			return output;
		}

		private static int FindNumberOfRounds(int teamCount)
		{
			int output = 1;
			int val = 2;

			while (val < teamCount)
			{
				output++;
				val *= 2;
			}

			return output;
		}

		private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
		{
			return teams.OrderBy(x => Guid.NewGuid()).ToList();
		}
	}
}
