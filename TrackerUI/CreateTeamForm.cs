using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class CreateTeamForm : Form
	{
		public CreateTeamForm()
		{
			InitializeComponent();
		}

		private void createMemberButton_Click(object sender, EventArgs e)
		{
			if (ValidateForm())
			{
				PersonModel p = new PersonModel
				{
					FirstName = firstNameValue.Text,
					LastName = lastNameValue.Text,
					EmailAddress = emailValue.Text,
					CellPhoneNumber = cellphoneValue.Text
				};

				GlobalConfig.Connection.CreatePerson(p);

				firstNameValue.Text = string.Empty;
				lastNameValue.Text = string.Empty;
				emailValue.Text = string.Empty;
				cellphoneValue.Text = string.Empty;
			}
			else
			{ 
				MessageBox.Show("You need to fill in all of the fields.");
			}
		}

		private bool ValidateForm()
		{
			if (firstNameValue.Text.Length == 0)
			{
				return false;
			}

			if (lastNameValue.Text.Length == 0)
			{
				return false;
			}

			if (emailValue.Text.Length == 0)
			{
				return false;
			}

			if (cellphoneValue.Text.Length == 0)
			{
				return false;
			}

			return true;
		}
	}
}
