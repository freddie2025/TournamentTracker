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
			this.removeSelectedPlayersButton = new System.Windows.Forms.Button();
			this.removeSelectedPrizesButton = new System.Windows.Forms.Button();
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
			this.headerLabel.Location = new System.Drawing.Point(20, 20);
			this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(323, 51);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "Create Tournament";
			// 
			// tournamentNameValue
			// 
			this.tournamentNameValue.Location = new System.Drawing.Point(26, 161);
			this.tournamentNameValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tournamentNameValue.Name = "tournamentNameValue";
			this.tournamentNameValue.Size = new System.Drawing.Size(316, 36);
			this.tournamentNameValue.TabIndex = 10;
			// 
			// tournamentNameLabel
			// 
			this.tournamentNameLabel.AutoSize = true;
			this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentNameLabel.Location = new System.Drawing.Point(20, 112);
			this.tournamentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.tournamentNameLabel.Name = "tournamentNameLabel";
			this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
			this.tournamentNameLabel.TabIndex = 9;
			this.tournamentNameLabel.Text = "Tournament Name";
			// 
			// entryFeeValue
			// 
			this.entryFeeValue.Location = new System.Drawing.Point(149, 210);
			this.entryFeeValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.entryFeeValue.Name = "entryFeeValue";
			this.entryFeeValue.Size = new System.Drawing.Size(117, 36);
			this.entryFeeValue.TabIndex = 12;
			this.entryFeeValue.Text = "0";
			// 
			// entryFeeLabel
			// 
			this.entryFeeLabel.AutoSize = true;
			this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.entryFeeLabel.Location = new System.Drawing.Point(23, 207);
			this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.entryFeeLabel.Name = "entryFeeLabel";
			this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
			this.entryFeeLabel.TabIndex = 11;
			this.entryFeeLabel.Text = "Entry Fee";
			// 
			// selectTeamDropDown
			// 
			this.selectTeamDropDown.FormattingEnabled = true;
			this.selectTeamDropDown.Location = new System.Drawing.Point(26, 307);
			this.selectTeamDropDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.selectTeamDropDown.Name = "selectTeamDropDown";
			this.selectTeamDropDown.Size = new System.Drawing.Size(316, 38);
			this.selectTeamDropDown.TabIndex = 14;
			// 
			// selectTeamLabel
			// 
			this.selectTeamLabel.AutoSize = true;
			this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.selectTeamLabel.Location = new System.Drawing.Point(23, 264);
			this.selectTeamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.selectTeamLabel.Name = "selectTeamLabel";
			this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
			this.selectTeamLabel.TabIndex = 13;
			this.selectTeamLabel.Text = "Select Team";
			// 
			// createNewTeamLink
			// 
			this.createNewTeamLink.AutoSize = true;
			this.createNewTeamLink.Location = new System.Drawing.Point(218, 269);
			this.createNewTeamLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.createNewTeamLink.Name = "createNewTeamLink";
			this.createNewTeamLink.Size = new System.Drawing.Size(127, 30);
			this.createNewTeamLink.TabIndex = 15;
			this.createNewTeamLink.TabStop = true;
			this.createNewTeamLink.Text = "Create New";
			this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
			// 
			// addTeamButton
			// 
			this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addTeamButton.Location = new System.Drawing.Point(26, 388);
			this.addTeamButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.addTeamButton.Name = "addTeamButton";
			this.addTeamButton.Size = new System.Drawing.Size(314, 53);
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
			this.createPrizeButton.Location = new System.Drawing.Point(26, 450);
			this.createPrizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.createPrizeButton.Name = "createPrizeButton";
			this.createPrizeButton.Size = new System.Drawing.Size(314, 53);
			this.createPrizeButton.TabIndex = 17;
			this.createPrizeButton.Text = "Create Prize";
			this.createPrizeButton.UseVisualStyleBackColor = true;
			this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
			// 
			// tournamentTeamsListBox
			// 
			this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tournamentTeamsListBox.FormattingEnabled = true;
			this.tournamentTeamsListBox.ItemHeight = 30;
			this.tournamentTeamsListBox.Location = new System.Drawing.Point(420, 161);
			this.tournamentTeamsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
			this.tournamentTeamsListBox.Size = new System.Drawing.Size(335, 122);
			this.tournamentTeamsListBox.TabIndex = 18;
			// 
			// tournamentTeamsLabel
			// 
			this.tournamentTeamsLabel.AutoSize = true;
			this.tournamentTeamsLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tournamentTeamsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentTeamsLabel.Location = new System.Drawing.Point(414, 112);
			this.tournamentTeamsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.tournamentTeamsLabel.Name = "tournamentTeamsLabel";
			this.tournamentTeamsLabel.Size = new System.Drawing.Size(187, 37);
			this.tournamentTeamsLabel.TabIndex = 19;
			this.tournamentTeamsLabel.Text = "Team / Players";
			// 
			// removeSelectedPlayersButton
			// 
			this.removeSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.removeSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.removeSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.removeSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeSelectedPlayersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.removeSelectedPlayersButton.Location = new System.Drawing.Point(786, 189);
			this.removeSelectedPlayersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.removeSelectedPlayersButton.Name = "removeSelectedPlayersButton";
			this.removeSelectedPlayersButton.Size = new System.Drawing.Size(128, 77);
			this.removeSelectedPlayersButton.TabIndex = 20;
			this.removeSelectedPlayersButton.Text = "Remove Selected";
			this.removeSelectedPlayersButton.UseVisualStyleBackColor = true;
			this.removeSelectedPlayersButton.Click += new System.EventHandler(this.removeSelectedPlayersButton_Click);
			// 
			// removeSelectedPrizesButton
			// 
			this.removeSelectedPrizesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.removeSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.removeSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.removeSelectedPrizesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeSelectedPrizesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeSelectedPrizesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.removeSelectedPrizesButton.Location = new System.Drawing.Point(786, 388);
			this.removeSelectedPrizesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.removeSelectedPrizesButton.Name = "removeSelectedPrizesButton";
			this.removeSelectedPrizesButton.Size = new System.Drawing.Size(128, 77);
			this.removeSelectedPrizesButton.TabIndex = 23;
			this.removeSelectedPrizesButton.Text = "Remove Selected";
			this.removeSelectedPrizesButton.UseVisualStyleBackColor = true;
			this.removeSelectedPrizesButton.Click += new System.EventHandler(this.removeSelectedPrizesButton_Click);
			// 
			// prizesLabel
			// 
			this.prizesLabel.AutoSize = true;
			this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.prizesLabel.Location = new System.Drawing.Point(414, 322);
			this.prizesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.prizesLabel.Name = "prizesLabel";
			this.prizesLabel.Size = new System.Drawing.Size(85, 37);
			this.prizesLabel.TabIndex = 22;
			this.prizesLabel.Text = "Prizes";
			// 
			// prizesListBox
			// 
			this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.prizesListBox.FormattingEnabled = true;
			this.prizesListBox.ItemHeight = 30;
			this.prizesListBox.Location = new System.Drawing.Point(420, 371);
			this.prizesListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.prizesListBox.Name = "prizesListBox";
			this.prizesListBox.Size = new System.Drawing.Size(335, 122);
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
			this.createTournamentButton.Location = new System.Drawing.Point(285, 564);
			this.createTournamentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.createTournamentButton.Name = "createTournamentButton";
			this.createTournamentButton.Size = new System.Drawing.Size(314, 53);
			this.createTournamentButton.TabIndex = 24;
			this.createTournamentButton.Text = "Create Tournament";
			this.createTournamentButton.UseVisualStyleBackColor = true;
			this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
			// 
			// CreateTournamentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(952, 665);
			this.Controls.Add(this.createTournamentButton);
			this.Controls.Add(this.removeSelectedPrizesButton);
			this.Controls.Add(this.prizesLabel);
			this.Controls.Add(this.prizesListBox);
			this.Controls.Add(this.removeSelectedPlayersButton);
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
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
		private System.Windows.Forms.Button removeSelectedPlayersButton;
		private System.Windows.Forms.Button removeSelectedPrizesButton;
		private System.Windows.Forms.Label prizesLabel;
		private System.Windows.Forms.ListBox prizesListBox;
		private System.Windows.Forms.Button createTournamentButton;
	}
}