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

		public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
		{
			//Id, Team Name, list of IDs separated by pipe
			//3, Fred's Team, 1|3|5
			List<TeamModel> output = new List<TeamModel>();
			List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

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

		public static List<TournamentModel> ConvertToTournamentModels(
			this List<string> lines, 
			string teamFileName, 
			string peopleFileName,
			string prizeFileName)
		{
			// Id = 0
			// TournamentName = 1
			// EntryFee = 2
			// EnteredTeams = 3
			// Prizes = 4
			// Rounds = 5
			//Id, TournamentName, EntryFee, (Id|Id|Id - Entered Teams), (Id|Id|Id - Prizes), (Rounds - Id^Id^Id^|Id^Id^Id|Id^Id^Id)
			List<TournamentModel> output = new List<TournamentModel>();
			List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
			List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();

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

				string[] prizeIds = cols[4].Split('|');

				foreach (string Id in prizeIds)
				{
					tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(Id)).First());
				}

				// TODO - Capture Rounds information

				output.Add(tm);
			}

			return output;
		}

		public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
		{
			List<string> lines = new List<string>();

			foreach (PersonModel p in models)
			{
				lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellPhoneNumber }");
			}

			File.WriteAllLines(fileName.FullFilePath(), lines);
		}

		public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
		{
			List<string> lines = new List<string>();

			foreach (PrizeModel p in models)
			{
				lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
			}

			File.WriteAllLines(fileName.FullFilePath(), lines);
		}

		public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
		{
			List<string> lines = new List<string>();

			foreach (TeamModel t in models)
			{
				lines.Add($"{ t.Id },{ t.TeamName },{ ConvertPeopleListToString(t.TeamMembers) }");
			}

			File.WriteAllLines(fileName.FullFilePath(), lines);
		}

		public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
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
				lines.Add($@"{ tm.Id },
					{ tm.TournamnetName },
					{ tm.EntryFee },
					{ ConvertTeamListToString(tm.EnteredTeams) },
					{ ConvertPrizeListToString(tm.Prizes) },
					{ ConvertRoundListToString(tm.Rounds) }");
			}

			File.WriteAllLines(fileName.FullFilePath(), lines);
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
	}
}
