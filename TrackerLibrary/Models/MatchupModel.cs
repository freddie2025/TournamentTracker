using System.Collections.Generic;

namespace TrackerLibrary.Models
{
	/// <summary>
	/// Represents one match in the tournament.
	/// </summary>
	public class MatchupModel
	{
		/// <summary>
		/// The unique identifier for the match.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The set of teams that were involved in this match.
		/// </summary>
		public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

		/// <summary>
		/// The winner of the match.
		/// </summary>
		public TeamModel Winner { get; set; }

		/// <summary>
		/// Which round this match is part of.
		/// </summary>
		public int MatchupRound { get; set; }
	}
}
