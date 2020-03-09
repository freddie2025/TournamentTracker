using Dapper;
using System;
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
		public PersonModel CreatePerson(PersonModel model)
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

				return model;
			}
		}

		/// <summary>
		/// Saves a new prize to the database
		/// </summary>
		/// <param name="model">The prize information</param>
		/// <returns>The prize information plus the unique identifier.</returns>
		public PrizeModel CreatePrize(PrizeModel model)
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

				return model;
			}
		}

		/// <summary>
		/// Saves a new team to the database
		/// </summary>
		/// <param name="model">The team information<</param>
		/// <returns>The team information plus the unique identifier.</returns>
		public TeamModel CreateTeam(TeamModel model)
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

				return model;
			}
		}

		public void CreateTournament(TournamentModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				SaveTournament(connection, model);

				SaveTournamentPrizes(connection, model);

				SaveTournamentEntries(connection, model);
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
	}
}
