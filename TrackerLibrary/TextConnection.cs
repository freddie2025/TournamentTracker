namespace TrackerLibrary
{
	public class TextConnection : IDataConnection
	{
		// TODO: Wire up the CreatePrize for text files
		/// <summary>
		/// Saves a new prize to a text file
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
