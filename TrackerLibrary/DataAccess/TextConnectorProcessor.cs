using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
	public static class TextConnectorProcessor
	{
		public static string FullFilePath(this string fileName)
		{
			// C:\data\TournamnetTracker\PrizeModels.csv
			return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
		}

		public static List<string> LoadFile(this string file)
		{
			if (!File.Exists(file))
			{
				return new List<string>();
			}

			return File.ReadAllLines(file).ToList();
		}

		public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
		{
			List<PrizeModel> output = new List<PrizeModel>();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				PrizeModel p = new PrizeModel
				{
					Id = int.Parse(cols[0]),
					PlaceNumber = int.Parse(cols[1]),
					PlaceName = cols[2],
					PrizeAmount = decimal.Parse(cols[3]),
					PrizePercentage = double.Parse(cols[4])
				};

				output.Add(p);
			}

			return output;
		}

		public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
		{
			List<PersonModel> output = new List<PersonModel>();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				PersonModel p = new PersonModel
				{
					Id = int.Parse(cols[0]),
					FirstName = cols[1],
					LastName = cols[2],
					EmailAddress = cols[3],
					CellPhoneNumber = cols[4]
				};

				output.Add(p);
			}

			return output;
		}

		public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
		{
			//Id, Team Name, list of IDs separated by pipe
			//3, Fred's Team, 1|3|5
			List<TeamModel> output = new List<TeamModel>();
			List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				TeamModel t = new TeamModel
				{
					Id = int.Parse(cols[0]),
					TeamName = cols[1],
				};

				string[] personIds = cols[2].Split('|');

				foreach (string id in personIds)
				{
					t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
				}

				output.Add(t);
			}

			return output;
		}

		public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)
		{
			// Id = 0
			// TournamentName = 1
			// EntryFee = 2
			// EnteredTeams = 3
			// Prizes = 4
			// Rounds = 5
			//Id, TournamentName, EntryFee, (Id|Id|Id - Entered Teams), (Id|Id|Id - Prizes), (Rounds - Id^Id^Id^|Id^Id^Id|Id^Id^Id)
			List<TournamentModel> output = new List<TournamentModel>();
			List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
			List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
			List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				TournamentModel tm = new TournamentModel();
				tm.Id = int.Parse(cols[0]);
				tm.TournamnetName = cols[1];
				tm.EntryFee = decimal.Parse(cols[2]);

				string[] teamIds = cols[3].Split('|');

				foreach (string Id in teamIds)
				{
					tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(Id)).First());
				}

				if (cols[4].Length > 0)
				{
					string[] prizeIds = cols[4].Split('|');

					foreach (string Id in prizeIds)
					{
						tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(Id)).First());
					} 
				}

				// Capture Rounds information
				string[] rounds = cols[5].Split('|');
				
				foreach (string round in rounds)
				{
					string[] msText = round.Split('^');
					List<MatchupModel> ms = new List<MatchupModel>();

					foreach (string matchupModelTextId in msText)
					{
						ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
					}

					tm.Rounds.Add(ms);
				}

				output.Add(tm);
			}

			return output;
		}
		public static void SaveToPrizeFile(this List<PrizeModel> models)
		{
			List<string> lines = new List<string>();

			foreach (PrizeModel p in models)
			{
				lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
			}

			File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
		}

		public static void SaveToPeopleFile(this List<PersonModel> models)
		{
			List<string> lines = new List<string>();

			foreach (PersonModel p in models)
			{
				lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellPhoneNumber }");
			}

			File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
		}

		public static void SaveToTeamFile(this List<TeamModel> models)
		{
			List<string> lines = new List<string>();

			foreach (TeamModel t in models)
			{
				lines.Add($"{ t.Id },{ t.TeamName },{ ConvertPeopleListToString(t.TeamMembers) }");
			}

			File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
		}

		public static void SaveRoundsToFile(this TournamentModel model)
		{
			// Loop through each round
			// Loop through each matchup
			// Get the id for the new matchup and save the record
			// Loop through each entry, get the id, and save it

			foreach (List<MatchupModel> round in model.Rounds)
			{
				foreach (MatchupModel matchup in round)
				{
					// Load all of the matchups from the file
					// Get the top id and add one
					// Store the if
					// Save the matchup record
					matchup.SaveMatchupToFile();
				}
			}
		}

		public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
		{
			// Id = 0, TeamCompeting = 1, Score = 2, ParentMatchup = 3
			List<MatchupEntryModel> output = new List<MatchupEntryModel>();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				MatchupEntryModel me = new MatchupEntryModel();

				me.Id = int.Parse(cols[0]);
				
				if (cols[1].Length == 0)
				{
					me.TeamCompeting = null;
				}
				else
				{
					me.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
				}
				
				me.Score = double.Parse(cols[2]);

				int parentId = 0;
				if (int.TryParse(cols[3], out parentId))
				{
					me.ParentMatchup = LookupMatchupById(parentId);
				}
				else 
				{
					me.ParentMatchup = null;
				}

				output.Add(me);
			}

			return output;
		}

		private static List<MatchupEntryModel> ConvertStingToMatchupEntryModels(string input)
		{
			string[] ids = input.Split('|');
			List<MatchupEntryModel> output = new List<MatchupEntryModel>();
			List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
			List<string> matchingEntries = new List<string>();

			foreach (string id in ids)
			{
				foreach (string entry in entries)
				{
					string[] cols = entry.Split(',');

					if (cols[0] == id)
					{
						matchingEntries.Add(entry);
					}
				}
			}

			output = matchingEntries.ConvertToMatchupEntryModels();

			return output;
		}

		private static TeamModel LookupTeamById(int id)
		{
			List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

			foreach (string team in teams)
			{
				string[] cols = team.Split(',');

				if (cols[0] == id.ToString())
				{
					List<string> matchingTeams = new List<string>();
					matchingTeams.Add(team);
					return matchingTeams.ConvertToTeamModels().First();
				}
			}

			return null;
		}

		private static MatchupModel LookupMatchupById(int id)
		{
			List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

			foreach (string matchup in matchups)
			{
				string[] cols = matchup.Split(',');

				if (cols[0] == id.ToString())
				{
					List<string> matchingMatchups = new List<string>();
					matchingMatchups.Add(matchup);
					return matchingMatchups.ConvertToMatchupModels().First();
				}
			}

			return null;
		}

		public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
		{
			// Id = 0, Entries = 1(pipe delimited by Id), Winner = 2, MatchupRound = 3
			List<MatchupModel> output = new List<MatchupModel>();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				MatchupModel m = new MatchupModel();

				m.Id = int.Parse(cols[0]); ;
				m.Entries = ConvertStingToMatchupEntryModels(cols[1]);

				if (cols[2].Length == 0)
				{
					m.Winner = null;
				}
				else
				{ 
					m.Winner = LookupTeamById(int.Parse(cols[2]));
				}

				m.MatchupRound = int.Parse(cols[3]);

				output.Add(m);
			}

			return output;
		}

		public static void SaveMatchupToFile(this MatchupModel matchup)
		{
			List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

			int currentId = 1;

			if (matchups.Count > 0)
			{
				currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
			}

			matchup.Id = currentId;

			matchups.Add(matchup);

			foreach (MatchupEntryModel entry in matchup.Entries)
			{
				entry.SaveEntryToFile();
			}

			List<string> lines = new List<string>();

			foreach (MatchupModel m in matchups)
			{
				string winner = "";
				if (m.Winner != null)
				{
					winner = m.Winner.Id.ToString();
				}
				lines.Add($"{ m.Id },{ ConvertMatchupEntryListToString(m.Entries) },{ winner },{ m.MatchupRound }");
			}

			File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
		}

		public static void UpdateMatchupToFile(this MatchupModel matchup)
		{
			List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

			MatchupModel oldMatchup = new MatchupModel();

			foreach (MatchupModel m in matchups)
			{
				if (m.Id == matchup.Id)
				{
					oldMatchup = m;
				}
			}

			matchups.Remove(oldMatchup);

			matchups.Add(matchup);

			foreach (MatchupEntryModel entry in matchup.Entries)
			{
				entry.UpdateEntryToFile();
			}

			List<string> lines = new List<string>();

			foreach (MatchupModel m in matchups)
			{
				string winner = "";
				if (m.Winner != null)
				{
					winner = m.Winner.Id.ToString();
				}
				lines.Add($"{ m.Id },{ ConvertMatchupEntryListToString(m.Entries) },{ winner },{ m.MatchupRound }");
			}

			File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
		}

		public static void SaveEntryToFile(this MatchupEntryModel entry)
		{
			List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

			int currentId = 1;

			if (entries.Count > 0)
			{
				currentId = entries.OrderByDescending(x => x.Id).First().Id + 1; ;
			}

			entry.Id = currentId;
			entries.Add(entry);

			List<string> lines = new List<string>();

			foreach (MatchupEntryModel e in entries)
			{
				string parent = "";
				if (e.ParentMatchup != null)
				{
					parent = e.ParentMatchup.Id.ToString();
				}

				string teamCompeting = "";
				if(e.TeamCompeting != null)
				{
					teamCompeting = e.TeamCompeting.Id.ToString(); 
				}

				lines.Add($"{ e.Id },{ teamCompeting },{ e.Score },{ parent }");
			}

			File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
		}

		public static void UpdateEntryToFile(this MatchupEntryModel entry)
		{
			List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
			MatchupEntryModel oldEntry = new MatchupEntryModel();

			foreach (MatchupEntryModel e in entries)
			{
				if (e.Id == entry.Id)
				{
					oldEntry = e;
				}
			}

			entries.Remove(oldEntry);

			entries.Add(entry);

			List<string> lines = new List<string>();

			foreach (MatchupEntryModel e in entries)
			{
				string parent = "";
				if (e.ParentMatchup != null)
				{
					parent = e.ParentMatchup.Id.ToString();
				}

				string teamCompeting = "";
				if (e.TeamCompeting != null)
				{
					teamCompeting = e.TeamCompeting.Id.ToString();
				}

				lines.Add($"{ e.Id },{ teamCompeting },{ e.Score },{ parent }");
			}

			File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
		}

		public static void SaveToTournamentFile(this List<TournamentModel> models)
		{
			// Id = 0
			// TournamentName = 1
			// EntryFee = 2
			// EnteredTeams = 3
			// Prizes = 4
			// Rounds = 5 (Id^Id^Id^|Id^Id^Id|Id^Id^Id)
			List<string> lines = new List<string>();

			foreach (TournamentModel tm in models)
			{
				lines.Add($"{ tm.Id },{ tm.TournamnetName },{ tm.EntryFee },{ ConvertTeamListToString(tm.EnteredTeams) },{ ConvertPrizeListToString(tm.Prizes) },{ ConvertRoundListToString(tm.Rounds) }");
			}

			File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);
		}

		private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
		{
			// (Id^Id^Id^|Id^Id^Id|Id^Id^Id)
			string output = string.Empty;

			if (rounds.Count == 0)
			{
				return "";
			}

			foreach (List<MatchupModel> r in rounds)
			{
				output += $"{ ConvertMatchupListToString(r) }|";
			}

			output = output.Substring(0, output.Length - 1);

			return output.Trim('|');
		}

		private static string ConvertMatchupListToString(List<MatchupModel> matchups)
		{
			string output = string.Empty;

			if (matchups.Count == 0)
			{
				return "";
			}

			foreach (MatchupModel m in matchups)
			{
				output += $"{ m.Id }^";
			}

			output = output.Substring(0, output.Length - 1);

			return output.Trim('|');
		}

		private static string ConvertPrizeListToString(List<PrizeModel> prizes)
		{
			string output = string.Empty;

			if (prizes.Count == 0)
			{
				return "";
			}

			foreach (PrizeModel p in prizes)
			{
				output += $"{ p.Id }|";
			}

			output = output.Substring(0, output.Length - 1);

			return output.Trim('|');
		}

		private static string ConvertTeamListToString(List<TeamModel> teams)
		{
			string output = string.Empty;

			if (teams.Count == 0)
			{
				return "";
			}

			foreach (TeamModel t in teams)
			{
				output += $"{ t.Id }|";
			}

			output = output.Substring(0, output.Length - 1);

			return output.Trim('|');
		}

		private static string ConvertPeopleListToString(List<PersonModel> people)
		{
			string output = string.Empty;

			if (people.Count == 0)
			{
				return "";
			}

			foreach (PersonModel p in people)
			{
				output += $"{ p.Id }|";
			}

			output = output.Substring(0, output.Length - 1);

			return output.Trim('|');
		}

		private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> entries)
		{
			string output = string.Empty;

			if (entries.Count == 0)
			{
				return "";
			}

			foreach (MatchupEntryModel e in entries)
			{
				output += $"{ e.Id }|";
			}

			output = output.Substring(0, output.Length - 1);

			return output.Trim('|');
		}
	}
}
