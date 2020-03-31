using System.Collections.Generic;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
	public interface IDataConnection
	{
		PrizeModel CreatePrize(PrizeModel model);
		PersonModel CreatePerson(PersonModel model);
		List<PersonModel> GetPerson_All();
		TeamModel CreateTeam(TeamModel model);
		void CreateTournament(TournamentModel model);
		void UpdateMatchup(MatchupModel model);
		List<TeamModel> GetTeam_All();
		List<TournamentModel> GetTournament_All();
	}
}
