using System.Collections.Generic;

namespace TrackerLibrary.Models
{
	public class TeamModel
	{
		public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
		public string TeamName { get; set; }
	}
}
