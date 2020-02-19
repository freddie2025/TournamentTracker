using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class CreateTournamentForm : Form
	{
		List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
		List<TeamModel> selectedTeams = new List<TeamModel>();
		List<PrizeModel> selectedPrizes = new List<PrizeModel>();

		public CreateTournamentForm()
		{
			InitializeComponent();

			WireUpLists();
		}

		private void WireUpLists()
		{
			selectTeamDropDown.DataSource = null;
			selectTeamDropDown.DataSource = availableTeams;
			selectTeamDropDown.DisplayMember = "TeamName";

			tournamentTeamsListBox.DataSource = null;
			tournamentTeamsListBox.DataSource = selectedTeams;
			tournamentTeamsListBox.DisplayMember = "TeamName";

			prizesListBox.DataSource = null;
			prizesListBox.DataSource = selectedPrizes;
			prizesListBox.DisplayMember = "PlaceName";
		}

		private void addTeamButton_Click(object sender, System.EventArgs e)
		{
			TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

			if (t != null)
			{
				availableTeams.Remove(t);
				selectedTeams.Add(t);

				WireUpLists();
			}
		}
	}
}
