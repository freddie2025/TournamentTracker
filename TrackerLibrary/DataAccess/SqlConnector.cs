using Dapper;
using System.Data;
using System.Data.SqlClient;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
	public class SqlConnector : IDataConnection
	{
		/// <summary>
		/// Saves a new prize to the database
		/// </summary>
		/// <param name="model">The prize information</param>
		/// <returns>The prize information plus the unique identifier.</returns>
		public PrizeModel CreatePrize(PrizeModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournament")))
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
	}
}
