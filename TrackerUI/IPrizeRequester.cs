using TrackerLibrary.Models;

namespace TrackerUI
{
	public interface IPrizeRequester
	{
		void PrizeComplete(PrizeModel model);
	}
}
