namespace TrackerUI
{
	partial class CreateTournamentForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.headerLabel = new System.Windows.Forms.Label();
			this.tournamentNameValue = new System.Windows.Forms.TextBox();
			this.tournamentNameLabel = new System.Windows.Forms.Label();
			this.entryFeeValue = new System.Windows.Forms.TextBox();
			this.entryFeeLabel = new System.Windows.Forms.Label();
			this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
			this.selectTeamLabel = new System.Windows.Forms.Label();
			this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
			this.addTeamButton = new System.Windows.Forms.Button();
			this.createPrizeButton = new System.Windows.Forms.Button();
			this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
			this.tournamentTeamsLabel = new System.Windows.Forms.Label();
			this.deleteSelectedPlayersButton = new System.Windows.Forms.Button();
			this.deletedSelectedPrizesButton = new System.Windows.Forms.Button();
			this.prizesLabel = new System.Windows.Forms.Label();
			this.prizesListBox = new System.Windows.Forms.ListBox();
			this.createTournamentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(41, 40);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(640, 100);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "Create Tournament";
			// 
			// tournamentNameValue
			// 
			this.tournamentNameValue.Location = new System.Drawing.Point(53, 322);
			this.tournamentNameValue.Name = "tournamentNameValue";
			this.tournamentNameValue.Size = new System.Drawing.Size(628, 65);
			this.tournamentNameValue.TabIndex = 10;
			// 
			// tournamentNameLabel
			// 
			this.tournamentNameLabel.AutoSize = true;
			this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentNameLabel.Location = new System.Drawing.Point(41, 223);
			this.tournamentNameLabel.Name = "tournamentNameLabel";
			this.tournamentNameLabel.Size = new System.Drawing.Size(467, 71);
			this.tournamentNameLabel.TabIndex = 9;
			this.tournamentNameLabel.Text = "Tournament Name";
			// 
			// entryFeeValue
			// 
			this.entryFeeValue.Location = new System.Drawing.Point(298, 420);
			this.entryFeeValue.Name = "entryFeeValue";
			this.entryFeeValue.Size = new System.Drawing.Size(230, 65);
			this.entryFeeValue.TabIndex = 12;
			this.entryFeeValue.Text = "0";
			// 
			// entryFeeLabel
			// 
			this.entryFeeLabel.AutoSize = true;
			this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.entryFeeLabel.Location = new System.Drawing.Point(46, 414);
			this.entryFeeLabel.Name = "entryFeeLabel";
			this.entryFeeLabel.Size = new System.Drawing.Size(246, 71);
			this.entryFeeLabel.TabIndex = 11;
			this.entryFeeLabel.Text = "Entry Fee";
			// 
			// selectTeamDropDown
			// 
			this.selectTeamDropDown.FormattingEnabled = true;
			this.selectTeamDropDown.Location = new System.Drawing.Point(53, 614);
			this.selectTeamDropDown.Name = "selectTeamDropDown";
			this.selectTeamDropDown.Size = new System.Drawing.Size(628, 67);
			this.selectTeamDropDown.TabIndex = 14;
			// 
			// selectTeamLabel
			// 
			this.selectTeamLabel.AutoSize = true;
			this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.selectTeamLabel.Location = new System.Drawing.Point(46, 528);
			this.selectTeamLabel.Name = "selectTeamLabel";
			this.selectTeamLabel.Size = new System.Drawing.Size(308, 71);
			this.selectTeamLabel.TabIndex = 13;
			this.selectTeamLabel.Text = "Select Team";
			// 
			// createNewTeamLink
			// 
			this.createNewTeamLink.AutoSize = true;
			this.createNewTeamLink.Location = new System.Drawing.Point(436, 538);
			this.createNewTeamLink.Name = "createNewTeamLink";
			this.createNewTeamLink.Size = new System.Drawing.Size(245, 59);
			this.createNewTeamLink.TabIndex = 15;
			this.createNewTeamLink.TabStop = true;
			this.createNewTeamLink.Text = "Create New";
			// 
			// addTeamButton
			// 
			this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addTeamButton.Location = new System.Drawing.Point(53, 777);
			this.addTeamButton.Name = "addTeamButton";
			this.addTeamButton.Size = new System.Drawing.Size(628, 106);
			this.addTeamButton.TabIndex = 16;
			this.addTeamButton.Text = "Add Team";
			this.addTeamButton.UseVisualStyleBackColor = true;
			this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
			// 
			// createPrizeButton
			// 
			this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createPrizeButton.Location = new System.Drawing.Point(53, 901);
			this.createPrizeButton.Name = "createPrizeButton";
			this.createPrizeButton.Size = new System.Drawing.Size(628, 106);
			this.createPrizeButton.TabIndex = 17;
			this.createPrizeButton.Text = "Create Prize";
			this.createPrizeButton.UseVisualStyleBackColor = true;
			// 
			// tournamentTeamsListBox
			// 
			this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tournamentTeamsListBox.FormattingEnabled = true;
			this.tournamentTeamsListBox.ItemHeight = 59;
			this.tournamentTeamsListBox.Location = new System.Drawing.Point(841, 322);
			this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
			this.tournamentTeamsListBox.Size = new System.Drawing.Size(668, 297);
			this.tournamentTeamsListBox.TabIndex = 18;
			// 
			// tournamentTeamsLabel
			// 
			this.tournamentTeamsLabel.AutoSize = true;
			this.tournamentTeamsLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tournamentTeamsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentTeamsLabel.Location = new System.Drawing.Point(829, 223);
			this.tournamentTeamsLabel.Name = "tournamentTeamsLabel";
			this.tournamentTeamsLabel.Size = new System.Drawing.Size(369, 71);
			this.tournamentTeamsLabel.TabIndex = 19;
			this.tournamentTeamsLabel.Text = "Team / Players";
			// 
			// deleteSelectedPlayersButton
			// 
			this.deleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.deleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteSelectedPlayersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.deleteSelectedPlayersButton.Location = new System.Drawing.Point(1572, 399);
			this.deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
			this.deleteSelectedPlayersButton.Size = new System.Drawing.Size(257, 137);
			this.deleteSelectedPlayersButton.TabIndex = 20;
			this.deleteSelectedPlayersButton.Text = "Delete Selected";
			this.deleteSelectedPlayersButton.UseVisualStyleBackColor = true;
			// 
			// deletedSelectedPrizesButton
			// 
			this.deletedSelectedPrizesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.deletedSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.deletedSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.deletedSelectedPrizesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deletedSelectedPrizesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deletedSelectedPrizesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.deletedSelectedPrizesButton.Location = new System.Drawing.Point(1572, 831);
			this.deletedSelectedPrizesButton.Name = "deletedSelectedPrizesButton";
			this.deletedSelectedPrizesButton.Size = new System.Drawing.Size(257, 136);
			this.deletedSelectedPrizesButton.TabIndex = 23;
			this.deletedSelectedPrizesButton.Text = "Delete Selected";
			this.deletedSelectedPrizesButton.UseVisualStyleBackColor = true;
			// 
			// prizesLabel
			// 
			this.prizesLabel.AutoSize = true;
			this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.prizesLabel.Location = new System.Drawing.Point(829, 643);
			this.prizesLabel.Name = "prizesLabel";
			this.prizesLabel.Size = new System.Drawing.Size(165, 71);
			this.prizesLabel.TabIndex = 22;
			this.prizesLabel.Text = "Prizes";
			// 
			// prizesListBox
			// 
			this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.prizesListBox.FormattingEnabled = true;
			this.prizesListBox.ItemHeight = 59;
			this.prizesListBox.Location = new System.Drawing.Point(841, 742);
			this.prizesListBox.Name = "prizesListBox";
			this.prizesListBox.Size = new System.Drawing.Size(668, 297);
			this.prizesListBox.TabIndex = 21;
			// 
			// createTournamentButton
			// 
			this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTournamentButton.Location = new System.Drawing.Point(570, 1127);
			this.createTournamentButton.Name = "createTournamentButton";
			this.createTournamentButton.Size = new System.Drawing.Size(628, 106);
			this.createTournamentButton.TabIndex = 24;
			this.createTournamentButton.Text = "Create Tournament";
			this.createTournamentButton.UseVisualStyleBackColor = true;
			// 
			// CreateTournamentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1903, 1301);
			this.Controls.Add(this.createTournamentButton);
			this.Controls.Add(this.deletedSelectedPrizesButton);
			this.Controls.Add(this.prizesLabel);
			this.Controls.Add(this.prizesListBox);
			this.Controls.Add(this.deleteSelectedPlayersButton);
			this.Controls.Add(this.tournamentTeamsLabel);
			this.Controls.Add(this.tournamentTeamsListBox);
			this.Controls.Add(this.createPrizeButton);
			this.Controls.Add(this.addTeamButton);
			this.Controls.Add(this.createNewTeamLink);
			this.Controls.Add(this.selectTeamDropDown);
			this.Controls.Add(this.selectTeamLabel);
			this.Controls.Add(this.entryFeeValue);
			this.Controls.Add(this.entryFeeLabel);
			this.Controls.Add(this.tournamentNameValue);
			this.Controls.Add(this.tournamentNameLabel);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "CreateTournamentForm";
			this.Text = "Create Tournament";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.TextBox tournamentNameValue;
		private System.Windows.Forms.Label tournamentNameLabel;
		private System.Windows.Forms.TextBox entryFeeValue;
		private System.Windows.Forms.Label entryFeeLabel;
		private System.Windows.Forms.ComboBox selectTeamDropDown;
		private System.Windows.Forms.Label selectTeamLabel;
		private System.Windows.Forms.LinkLabel createNewTeamLink;
		private System.Windows.Forms.Button addTeamButton;
		private System.Windows.Forms.Button createPrizeButton;
		private System.Windows.Forms.ListBox tournamentTeamsListBox;
		private System.Windows.Forms.Label tournamentTeamsLabel;
		private System.Windows.Forms.Button deleteSelectedPlayersButton;
		private System.Windows.Forms.Button deletedSelectedPrizesButton;
		private System.Windows.Forms.Label prizesLabel;
		private System.Windows.Forms.ListBox prizesListBox;
		private System.Windows.Forms.Button createTournamentButton;
	}
}