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
				lines.Add($"{ t.Id },{ t.TeamName },{ ConvertPeoplelistToString(t.TeamMembers) }");
			}

			File.WriteAllLines(fileName.FullFilePath(), lines);
		}

		private static string ConvertPeoplelistToString(List<PersonModel> people)
		{
			string output = string.Empty;

			foreach (PersonModel p in people)
			{
				output += $"{ p.Id }|";
			}

			return output.Trim('|');
		}
	}
}
