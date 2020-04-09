using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
	public class TextConnector : IDataConnection
	{
		/// <summary>
		/// Saves a new person to a text file
		/// </summary>
		/// <param name="model">The person information</param>
		/// <returns>The person information plus the unique identifier.</returns>
		public void CreatePerson(PersonModel model)
		{
			// Load the text file
			// Convert the text to a List<PersonModel>
			List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

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
			people.SaveToPeopleFile();
		}

		/// <summary>
		/// Saves a new prize to a text file
		/// </summary>
		/// <param name="model">The prize information</param>
		/// <returns>The prize information plus the unique identifier.</returns>
		public void CreatePrize(PrizeModel model)
		{
			// Load the text file
			// Convert the text to a List<PrizeModel>
			List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

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
			prizes.SaveToPrizeFile();
		}

		/// <summary>
		/// aves a new team to a text file
		/// </summary>
		/// <param name="model">The team information</param>
		/// <returns>The team information plus the unique identifier.</returns>
		public void CreateTeam(TeamModel model)
		{
			List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();

			// Find the ID
			int currentId = 1;

			if (teams.Count > 0)
			{
				currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
			}

			model.Id = currentId;

			teams.Add(model);

			teams.SaveToTeamFile();
		}

		/// <summary>
		/// Returns a list of all people from a text file
		/// </summary>
		/// <returns>List of person information</returns>
		public List<PersonModel> GetPerson_All()
		{
			return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
		}

		/// <summary>
		/// Returns a list of all teams from a text file
		/// </summary>
		/// <returns>List of team information</returns>
		public List<TeamModel> GetTeam_All()
		{
			return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
		}

		public void CreateTournament(TournamentModel model)
		{
			List<TournamentModel> tournaments = GlobalConfig.TournamentFile
				.FullFilePath()
				.LoadFile()
				.ConvertToTournamentModels();

			int currentId = 1;

			if (tournaments.Count > 0)
			{
				currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
			}

			model.Id = currentId;

			model.SaveRoundsToFile();

			tournaments.Add(model);

			tournaments.SaveToTournamentFile();

			TournamentLogic.UpdateTournamentResults(model);
		}

		public List<TournamentModel> GetTournament_All()
		{
			return GlobalConfig.TournamentFile
				.FullFilePath()
				.LoadFile()
				.ConvertToTournamentModels();
		}

		public void UpdateMatchup(MatchupModel model)
		{
			model.UpdateMatchupToFile();
		}

		public void CompleteTournament(TournamentModel model)
		{
			List<TournamentModel> tournaments = GlobalConfig.TournamentFile
				.FullFilePath()
				.LoadFile()
				.ConvertToTournamentModels();

			tournaments.Remove(model);

			tournaments.SaveToTournamentFile();

			TournamentLogic.UpdateTournamentResults(model);
		}
	}
}
