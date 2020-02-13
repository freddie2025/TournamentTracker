using System.Collections.Generic;

namespace TrackerLibrary
{
	public static class GlobalConfig
	{
		public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

		public static void InitializeConnections(bool database, bool textFiles)
		{
			if (database)
			{
				// TODO: Set up the SQL connector properly
				SqlConnector sql = new SqlConnector();
				Connections.Add(sql);
			}

			if (textFiles)
			{
				// TODO: Create the Text Connection
				TextConnection text = new TextConnection();
				Connections.Add(text);
			}
		}
	}
}
