namespace TrackerLibrary
{
	public class MatchupEntryMode
	{
		/// <summary>
		/// Represents one team in the matchup.
		/// </summary>
		public TeamModel TeamCompeting { get; set; }

		/// <summary>
		/// Represents the score for this particular team.
		/// </summary>
		public double Score { get; set; }

		/// <summary>
		/// Represents the matchup that this team came 
		/// from as the winner.
		/// </summary>
		public MatchupModel ParentMatchup { get; set; }
	}
}
