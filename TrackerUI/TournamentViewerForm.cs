using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class TournamentViewerForm : Form
	{
		private TournamentModel tournament;
		BindingList<int> rounds = new BindingList<int>();
		BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

		public TournamentViewerForm(TournamentModel tournamentModel)
		{
			InitializeComponent();

			tournament = tournamentModel;

			WireUpLists();

			LoadFormData();

			LoadRounds();
		}

		private void LoadFormData()
		{
			tournamentName.Text = tournament.TournamnetName;
		}

		private void WireUpLists()
		{
			roundDropDown.DataSource = rounds;	
			matchupListBox.DataSource = selectedMatchups;
			matchupListBox.DisplayMember = "DisplayName";
		}

		private void LoadRounds()
		{
			rounds.Clear();

			rounds.Add(1);
			int currRound = 1;

			foreach (List<MatchupModel> matchups in tournament.Rounds)
			{
				if (matchups.First().MatchupRound > currRound)
				{
					currRound = matchups.First().MatchupRound;
					rounds.Add(currRound);
				}
			}

			LoadMatchups(1);
		}

		private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadMatchups((int)roundDropDown.SelectedItem);
		}

		private void LoadMatchups(int round)
		{
			foreach (List<MatchupModel> matchups in tournament.Rounds)
			{
				if (matchups.First().MatchupRound == round)
				{
					selectedMatchups.Clear();
					foreach (MatchupModel m in matchups)
					{
						selectedMatchups.Add(m);
					}
				}
			}

			LoadMatchup(selectedMatchups.First());
		}

		private void LoadMatchup(MatchupModel m)
		{
			for (int i = 0; i < m.Entries.Count; i++)
			{
				if (i == 0)
				{
					if (m.Entries[0].TeamCompeting != null)
					{
						teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
						teamOneScoreValue.Text = m.Entries[0].Score.ToString();

						teamTwoName.Text = "<bye>";
						teamTwoScoreValue.Text = "0";

					}
					else
					{ 
						teamOneName.Text = "Not Yet Set";
						teamOneScoreValue.Text = "";
					}
				}

				if (i == 1)
				{
					if (m.Entries[1].TeamCompeting != null)
					{
						teamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
						teamTwoScoreValue.Text = m.Entries[1].Score.ToString();

					}
					else
					{
						teamTwoName.Text = "Not Yet Set";
						teamTwoScoreValue.Text = "";
					}
				}
			}
		}

		private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
		}
	}
}
