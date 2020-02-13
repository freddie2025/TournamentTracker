namespace TrackerLibrary
{
	public class SqlConnector : IDataConnection
	{
		/// TODO: Make the CreatePrize method actually save to the database
		/// <summary>
		/// Saves a new prize to the database
		/// </summary>
		/// <param name="model">The prize information</param>
		/// <returns>The prize information plus the unique identifier.</returns>
		public PrizeModel CreatePrize(PrizeModel model)
		{
			model.Id = 1;

			return model;
		}
	}
}
