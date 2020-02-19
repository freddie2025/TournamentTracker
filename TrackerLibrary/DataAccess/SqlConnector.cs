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
	}
}
