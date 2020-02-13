using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
	public class TextConnector : IDataConnection
	{
		private const string PrizesFile = "PrizeModel.csv";

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
	}
}
