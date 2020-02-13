using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
	public interface IDataConnection
	{
		PrizeModel CreatePrize(PrizeModel model);
	}
}
