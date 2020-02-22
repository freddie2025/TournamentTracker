using System;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class CreatePrizeForm : Form
	{
		IPrizeRequester callingForm;
		public CreatePrizeForm(IPrizeRequester caller)
		{
			InitializeComponent();

			callingForm = caller;
		}

		private void createPrizeButton_Click(object sender, EventArgs e)
		{
			if (ValidateForm())
			{
				PrizeModel model = new PrizeModel(
					placeNameValue.Text,
					placeNumberValue.Text,
					prizeAmountValue.Text,
					prizePercentageValue.Text);

				GlobalConfig.Connection.CreatePrize(model);

				callingForm.PrizeComplete(model);

				this.Close();

				//placeNameValue.Text = String.Empty;
				//placeNumberValue.Text = String.Empty;
				//prizeAmountValue.Text = "0";
				//prizePercentageValue.Text = "0";
			}
			else
			{
				MessageBox.Show("This form has invalid information. Please check it and try again.");
			}
		}

		private bool ValidateForm()
		{
			bool output = true;
			bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out int placeNumber);

			if (placeNumberValidNumber == false)
			{
				output = false;
			}

			if (placeNumber < 1)
			{
				output = false;
			}

			if (placeNameValue.Text.Length == 0)
			{
				output = false;
			}

			bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out decimal prizeAmount);
			bool prizePercentageValid = int.TryParse(prizePercentageValue.Text, out int prizePercentage);

			if (prizeAmountValid == false || prizePercentageValid == false)
			{
				output = false;
			}

			if (prizeAmount <= 0 && prizePercentage <= 0)
			{
				output = false;
			}

			if (prizePercentage < 0 || prizePercentage > 100)
			{
				output = false;
			}

			return output;
		}
	}
}
