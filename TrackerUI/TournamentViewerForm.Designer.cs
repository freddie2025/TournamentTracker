namespace TrackerUI
{
	partial class TournamentViewerForm
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
			this.tournamentName = new System.Windows.Forms.Label();
			this.roundLabel = new System.Windows.Forms.Label();
			this.roundDropDown = new System.Windows.Forms.ComboBox();
			this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
			this.matchupListBox = new System.Windows.Forms.ListBox();
			this.teamOneName = new System.Windows.Forms.Label();
			this.teamOneScoreLabel = new System.Windows.Forms.Label();
			this.teamOneScoreValue = new System.Windows.Forms.TextBox();
			this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
			this.teamTwoScoreLabel = new System.Windows.Forms.Label();
			this.teamTwoName = new System.Windows.Forms.Label();
			this.versusLabel = new System.Windows.Forms.Label();
			this.scoreButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(51, 51);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(431, 100);
			this.headerLabel.TabIndex = 0;
			this.headerLabel.Text = "Tournament:";
			// 
			// tournamentName
			// 
			this.tournamentName.AutoSize = true;
			this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentName.Location = new System.Drawing.Point(488, 51);
			this.tournamentName.Name = "tournamentName";
			this.tournamentName.Size = new System.Drawing.Size(300, 100);
			this.tournamentName.TabIndex = 1;
			this.tournamentName.Text = "<none>";
			// 
			// roundLabel
			// 
			this.roundLabel.AutoSize = true;
			this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.roundLabel.Location = new System.Drawing.Point(56, 201);
			this.roundLabel.Name = "roundLabel";
			this.roundLabel.Size = new System.Drawing.Size(182, 71);
			this.roundLabel.TabIndex = 2;
			this.roundLabel.Text = "Round";
			// 
			// roundDropDown
			// 
			this.roundDropDown.FormattingEnabled = true;
			this.roundDropDown.Location = new System.Drawing.Point(244, 205);
			this.roundDropDown.Name = "roundDropDown";
			this.roundDropDown.Size = new System.Drawing.Size(403, 67);
			this.roundDropDown.TabIndex = 3;
			this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
			// 
			// unplayedOnlyCheckbox
			// 
			this.unplayedOnlyCheckbox.AutoSize = true;
			this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(244, 289);
			this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
			this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(403, 75);
			this.unplayedOnlyCheckbox.TabIndex = 4;
			this.unplayedOnlyCheckbox.Text = "Unplayed Only";
			this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
			this.unplayedOnlyCheckbox.CheckedChanged += new System.EventHandler(this.unplayedOnlyCheckbox_CheckedChanged);
			// 
			// matchupListBox
			// 
			this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.matchupListBox.FormattingEnabled = true;
			this.matchupListBox.ItemHeight = 59;
			this.matchupListBox.Location = new System.Drawing.Point(68, 392);
			this.matchupListBox.Name = "matchupListBox";
			this.matchupListBox.Size = new System.Drawing.Size(587, 533);
			this.matchupListBox.TabIndex = 5;
			this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
			// 
			// teamOneName
			// 
			this.teamOneName.AutoSize = true;
			this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamOneName.Location = new System.Drawing.Point(754, 392);
			this.teamOneName.Name = "teamOneName";
			this.teamOneName.Size = new System.Drawing.Size(325, 71);
			this.teamOneName.TabIndex = 6;
			this.teamOneName.Text = "<team one>";
			// 
			// teamOneScoreLabel
			// 
			this.teamOneScoreLabel.AutoSize = true;
			this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamOneScoreLabel.Location = new System.Drawing.Point(754, 486);
			this.teamOneScoreLabel.Name = "teamOneScoreLabel";
			this.teamOneScoreLabel.Size = new System.Drawing.Size(159, 71);
			this.teamOneScoreLabel.TabIndex = 7;
			this.teamOneScoreLabel.Text = "Score";
			// 
			// teamOneScoreValue
			// 
			this.teamOneScoreValue.Location = new System.Drawing.Point(955, 492);
			this.teamOneScoreValue.Name = "teamOneScoreValue";
			this.teamOneScoreValue.Size = new System.Drawing.Size(361, 65);
			this.teamOneScoreValue.TabIndex = 8;
			// 
			// teamTwoScoreValue
			// 
			this.teamTwoScoreValue.Location = new System.Drawing.Point(955, 849);
			this.teamTwoScoreValue.Name = "teamTwoScoreValue";
			this.teamTwoScoreValue.Size = new System.Drawing.Size(361, 65);
			this.teamTwoScoreValue.TabIndex = 11;
			// 
			// teamTwoScoreLabel
			// 
			this.teamTwoScoreLabel.AutoSize = true;
			this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamTwoScoreLabel.Location = new System.Drawing.Point(754, 843);
			this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
			this.teamTwoScoreLabel.Size = new System.Drawing.Size(159, 71);
			this.teamTwoScoreLabel.TabIndex = 10;
			this.teamTwoScoreLabel.Text = "Score";
			// 
			// teamTwoName
			// 
			this.teamTwoName.AutoSize = true;
			this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamTwoName.Location = new System.Drawing.Point(754, 749);
			this.teamTwoName.Name = "teamTwoName";
			this.teamTwoName.Size = new System.Drawing.Size(323, 71);
			this.teamTwoName.TabIndex = 9;
			this.teamTwoName.Text = "<team two>";
			// 
			// versusLabel
			// 
			this.versusLabel.AutoSize = true;
			this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.versusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.versusLabel.Location = new System.Drawing.Point(943, 631);
			this.versusLabel.Name = "versusLabel";
			this.versusLabel.Size = new System.Drawing.Size(133, 71);
			this.versusLabel.TabIndex = 12;
			this.versusLabel.Text = "-VS-";
			// 
			// scoreButton
			// 
			this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.scoreButton.Location = new System.Drawing.Point(1317, 617);
			this.scoreButton.Name = "scoreButton";
			this.scoreButton.Size = new System.Drawing.Size(242, 106);
			this.scoreButton.TabIndex = 13;
			this.scoreButton.Text = "Score";
			this.scoreButton.UseVisualStyleBackColor = true;
			this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
			// 
			// TournamentViewerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1612, 1082);
			this.Controls.Add(this.scoreButton);
			this.Controls.Add(this.versusLabel);
			this.Controls.Add(this.teamTwoScoreValue);
			this.Controls.Add(this.teamTwoScoreLabel);
			this.Controls.Add(this.teamTwoName);
			this.Controls.Add(this.teamOneScoreValue);
			this.Controls.Add(this.teamOneScoreLabel);
			this.Controls.Add(this.teamOneName);
			this.Controls.Add(this.matchupListBox);
			this.Controls.Add(this.unplayedOnlyCheckbox);
			this.Controls.Add(this.roundDropDown);
			this.Controls.Add(this.roundLabel);
			this.Controls.Add(this.tournamentName);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "TournamentViewerForm";
			this.Text = "Tournament Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Label tournamentName;
		private System.Windows.Forms.Label roundLabel;
		private System.Windows.Forms.ComboBox roundDropDown;
		private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
		private System.Windows.Forms.ListBox matchupListBox;
		private System.Windows.Forms.Label teamOneName;
		private System.Windows.Forms.Label teamOneScoreLabel;
		private System.Windows.Forms.TextBox teamOneScoreValue;
		private System.Windows.Forms.TextBox teamTwoScoreValue;
		private System.Windows.Forms.Label teamTwoScoreLabel;
		private System.Windows.Forms.Label teamTwoName;
		private System.Windows.Forms.Label versusLabel;
		private System.Windows.Forms.Button scoreButton;
	}
}

