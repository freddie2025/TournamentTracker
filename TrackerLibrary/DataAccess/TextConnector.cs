using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
	public class TextConnector : IDataConnection
	{
		private const string PrizesFile = "PrizeModel.csv";
		private const string PeopleFile = "PersonModel.csv";
		private const string TeamFile = "TeamModel.csv";

		/// <summary>
		/// Saves a new person to a text file
		/// </summary>
		/// <param name="model">The person information</param>
		/// <returns>The person information plus the unique identifier.</returns>
		public PersonModel CreatePerson(PersonModel model)
		{
			// Load the text file
			// Convert the text to a List<PersonModel>
			List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

			int currentId = 1;

			if (people.Count > 0)
			{
				currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
			}

			model.Id = currentId;

			// Add the new record with the new ID
			people.Add(model);

			// Convert the people to List<string>
			// Save the list<string> to the text file
			people.SaveToPeopleFile(PeopleFile);

			return model;
		}

		/// <summary>
		/// Saves a new prize to a text file
		/// </summary>
		/// <param name="model">The prize information</param>
		/// <returns>The prize information plus the unique identifier.</returns>
		public PrizeModel CreatePrize(PrizeModel model)
		{
			// Load the text file
			// Convert the text to a List<PrizeModel>
			List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

			// Find the ID
			int currentId = 1;

			if (prizes.Count > 0)
			{
				currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
			}
			
			model.Id = currentId;

			// Add the new record with the new ID
			prizes.Add(model);

			// Convert the prizes to List<string>
			// Save the list<string> to the text file
			prizes.SaveToPrizeFile(PrizesFile);

			return model;
		}

		/// <summary>
		/// aves a new team to a text file
		/// </summary>
		/// <param name="model">The team information</param>
		/// <returns>The team information plus the unique identifier.</returns>
		public TeamModel CreateTeam(TeamModel model)
		{
			List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

			// Find the ID
			int currentId = 1;

			if (teams.Count > 0)
			{
				currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
			}

			model.Id = currentId;

			teams.Add(model);

			teams.SaveToTeamFile(TeamFile);

			return model;
		}

		/// <summary>
		/// Returns a list of all people from a text file
		/// </summary>
		/// <returns>List of person information</returns>
		public List<PersonModel> GetPerson_All()
		{
			return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
		}
	}
}
