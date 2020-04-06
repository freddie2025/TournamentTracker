using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
	public static class GlobalConfig
	{
		public const string PrizesFile = "PrizeModel.csv";
		public const string PeopleFile = "PersonModel.csv";
		public const string TeamFile = "TeamModel.csv";
		public const string TournamentFile = "TournamentModel.csv";
		public const string MatchupFile = "MatchupModel.csv";
		public const string MatchupEntryFile = "MatchupEntryModel.csv";

		public static IDataConnection Connection { get; private set; }

		public static void InitializeConnection(DatabaseType db)
		{
			switch (db)
			{
				case DatabaseType.Sql:				
					SqlConnector sql = new SqlConnector();
					Connection = sql;
					break;
				case DatabaseType.TextFile:
					TextConnector text = new TextConnector();
					Connection = text;
					break;
				default:
					break;
			}
		}

		public static string CnnString(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}

		public static string AppKeyLookup(string key)
		{
			return ConfigurationManager.AppSettings[key];
		}
	}
}
