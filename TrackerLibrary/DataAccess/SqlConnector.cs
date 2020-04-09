using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
	public class SqlConnector : IDataConnection
	{
		private const string db = "Tournament";

		/// <summary>
		/// Saves a new person to the database
		/// </summary>
		/// <param name="model">The person information</param>
		/// <returns>The person information plus the unique identifier.</returns>
		public void CreatePerson(PersonModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				var p = new DynamicParameters();
				p.Add("@FirstName", model.FirstName);
				p.Add("@LastName", model.LastName);
				p.Add("@EmailAddress", model.EmailAddress);
				p.Add("@CellPhoneNumber", model.CellPhoneNumber);
				p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("[dbo].[spPeople_Insert]", p, commandType: CommandType.StoredProcedure);

				model.Id = p.Get<int>("@Id");
			}
		}

		/// <summary>
		/// Saves a new prize to the database
		/// </summary>
		/// <param name="model">The prize information</param>
		/// <returns>The prize information plus the unique identifier.</returns>
		public void CreatePrize(PrizeModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				var p = new DynamicParameters();
				p.Add("@PlaceNumber", model.PlaceNumber);
				p.Add("@PlaceName", model.PlaceName);
				p.Add("@PrizeAmount", model.PrizeAmount);
				p.Add("@PrizePercentage", model.PrizePercentage);
				p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("[dbo].[spPrizes_Insert]", p, commandType: CommandType.StoredProcedure);

				model.Id = p.Get<int>("@Id");
			}
		}

		/// <summary>
		/// Saves a new team to the database
		/// </summary>
		/// <param name="model">The team information<</param>
		/// <returns>The team information plus the unique identifier.</returns>
		public void CreateTeam(TeamModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				var p = new DynamicParameters();
				p.Add("@TeamName", model.TeamName);
				p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("[dbo].[spTeams_Insert]", p, commandType: CommandType.StoredProcedure);

				model.Id = p.Get<int>("@Id");

				foreach (PersonModel tm in model.TeamMembers)
				{
					p = new DynamicParameters();
					p.Add("@TeamId", model.Id);
					p.Add("@PersonId", tm.Id);

					connection.Execute("[dbo].[spTeamMembers_Insert]", p, commandType: CommandType.StoredProcedure);
				}
			}
		}

		public void CreateTournament(TournamentModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				SaveTournament(connection, model);

				SaveTournamentPrizes(connection, model);

				SaveTournamentEntries(connection, model);

				SaveTournamentRounds(connection, model);

				TournamentLogic.UpdateTournamentResults(model);
			}
		}

		private void SaveTournament(IDbConnection connection, TournamentModel model)
		{
			var p = new DynamicParameters();
			p.Add("@TournamentName", model.TournamnetName);
			p.Add("@EntryFee", model.EntryFee);
			p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

			connection.Execute("[dbo].[spTournaments_Insert]", p, commandType: CommandType.StoredProcedure);

			model.Id = p.Get<int>("@Id");
		}

		private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
		{
			foreach (PrizeModel pz in model.Prizes)
			{
				var p = new DynamicParameters();
				p.Add("@TournamentId", model.Id);
				p.Add("@PrizeId", pz.Id);
				p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("[dbo].[spTournamentPrizes_Insert]", p, commandType: CommandType.StoredProcedure);
			}
		}

		private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
		{
			foreach (TeamModel tm in model.EnteredTeams)
			{
				var p = new DynamicParameters();
				p.Add("@TournamentId", model.Id);
				p.Add("@TeamId", tm.Id);
				p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("[dbo].[spTournamentEntries_Insert]", p, commandType: CommandType.StoredProcedure);
			}
		}

		private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
		{
			foreach (List<MatchupModel> round in model.Rounds)
			{
				foreach (MatchupModel matchup in round)
				{
					var p = new DynamicParameters();
					p.Add("@TournamentId", model.Id);
					p.Add("@MatchupRound", matchup.MatchupRound);
					p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

					connection.Execute("[dbo].[spMatchups_Insert]", p, commandType: CommandType.StoredProcedure);

					matchup.Id = p.Get<int>("@Id");

					foreach (MatchupEntryModel entry in matchup.Entries)
					{
						p = new DynamicParameters();

						p.Add("@MatchupId", matchup.Id);
						
						if (entry.ParentMatchup == null)
						{
							p.Add("@ParentMatchupId", null);
						}
						else
						{
							p.Add("@ParentMatchupId", entry.ParentMatchup.Id);
						}

						if (entry.TeamCompeting == null)
						{
							p.Add("@TeamCompetingId", null);
						}
						else
						{ 
							p.Add("@TeamCompetingId", entry.TeamCompeting.Id);
						}

						p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

						connection.Execute("[dbo].[spMatchupEntries_Insert]", p, commandType: CommandType.StoredProcedure);
					}
				}
			}
		}

		/// <summary>
		/// Returns a list of all people from the database
		/// </summary>
		/// <returns>List of person information</returns>
		public List<PersonModel> GetPerson_All()
		{
			List<PersonModel> output;

			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				output = connection.Query<PersonModel>("[dbo].[spPeople_GetAll]", new { }, commandType: CommandType.StoredProcedure).ToList();
			}

			return output;
		}

		/// <summary>
		/// Returns a list of all teams from the database
		/// </summary>
		/// <returns>List of teams information</returns>
		public List<TeamModel> GetTeam_All()
		{
			List<TeamModel> output;

			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				output = connection.Query<TeamModel>("[dbo].[spTeams_GetAll]", new { }, commandType: CommandType.StoredProcedure).ToList();

				foreach (TeamModel team in output)
				{
					var p = new DynamicParameters();
					p.Add("@TeamId", team.Id);

					team.TeamMembers = connection.Query<PersonModel>("[dbo].[spTeamMembers_GetByTeam]", p, commandType: CommandType.StoredProcedure).ToList();
				}
			}

			return output;
		}

		public List<TournamentModel> GetTournament_All()
		{
			List<TournamentModel> output;
			var p = new DynamicParameters();

			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				output = connection.Query<TournamentModel>("[dbo].[spTournaments_GetAll]", commandType: CommandType.StoredProcedure).ToList();

				foreach (TournamentModel t in output)
				{
					// Populate Prizes
					p = new DynamicParameters();
					p.Add("@TournamentId", t.Id);

					t.Prizes = connection.Query<PrizeModel>("[dbo].[spPrizes_GetByTournament]", p, commandType: CommandType.StoredProcedure).ToList();

					// Populate Teams
					p = new DynamicParameters();
					p.Add("@TournamentId", t.Id);

					t.EnteredTeams = connection.Query<TeamModel>("[dbo].[spTeam_getByTournament]", p, commandType: CommandType.StoredProcedure).ToList();

					foreach (TeamModel team in t.EnteredTeams)
					{
						p = new DynamicParameters();
						p.Add("@TeamId", team.Id);

						team.TeamMembers = connection.Query<PersonModel>("[dbo].[spTeamMembers_GetByTeam]", p, commandType: CommandType.StoredProcedure).ToList();
					}

					p = new DynamicParameters();
					p.Add("@TournamentId", t.Id);

					// Populate Rounds
					List<MatchupModel> matchups = connection.Query<MatchupModel>("[dbo].[spMatchups_GetByTournament]", p, commandType: CommandType.StoredProcedure).ToList();

					foreach (MatchupModel m in matchups)
					{
						p = new DynamicParameters();
						p.Add("@MatchupId", m.Id);

						// Populate Rounds
						m.Entries = connection.Query<MatchupEntryModel>("[dbo].[spMatchupEntries_GetByMatchup]", p, commandType: CommandType.StoredProcedure).ToList();

						// Populate each entry (2 models)
						// Populate each matchup (1 model)
						List<TeamModel> allTeams = GetTeam_All();

						if (m.WinnerId > 0)
						{
							m.Winner = allTeams.Where(x => x.Id == m.WinnerId).First();
						}

						foreach (var me in m.Entries)
						{
							if (me.TeamCompetingId > 0)
							{
								me.TeamCompeting = allTeams.Where(x => x.Id == me.TeamCompetingId).First();
							}

							if (me.ParentMatchupId > 0)
							{
								me.ParentMatchup = matchups.Where(x => x.Id == me.ParentMatchupId).First();
							}
						}
					}

					// List<List<MatchupModel>>
					List<MatchupModel> currRow = new List<MatchupModel>();
					int currRound = 1;

					foreach (MatchupModel m in matchups)
					{
						if (m.MatchupRound > currRound)
						{
							t.Rounds.Add(currRow);
							currRow = new List<MatchupModel>();
							currRound += 1;
						}

						currRow.Add(m);
					}

					t.Rounds.Add(currRow);
				}
			}

			return output;
		}

		public void UpdateMatchup(MatchupModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				var p = new DynamicParameters();
				
				if (model.Winner != null)
				{	
					p.Add("@Id", model.Id);
					p.Add("@WinnerId", model.Winner.Id);

					connection.Execute("[dbo].[spMatchups_Update]", p, commandType: CommandType.StoredProcedure);
				}

				foreach (MatchupEntryModel me in model.Entries)
				{
					if (me.TeamCompeting != null)
					{
						p = new DynamicParameters();
						p.Add("@Id", me.Id);
						p.Add("@TeamCompetingId", me.TeamCompeting.Id);
						p.Add("@Score", me.Score);

						connection.Execute("[dbo].[spMatchupEntries_Update]", p, commandType: CommandType.StoredProcedure);
					}
				}
			}
		}

		public void CompleteTournament(TournamentModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				var p = new DynamicParameters();
				p.Add("@Id", model.Id);

				connection.Execute("[dbo].[spTournaments_Complete]", p, commandType: CommandType.StoredProcedure);
			}
		}
	}
}
