namespace TrackerUI
{
	partial class TournamentDashboardForm
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
			this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
			this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
			this.loadTournamentButton = new System.Windows.Forms.Button();
			this.createTournamentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(302, 47);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(778, 100);
			this.headerLabel.TabIndex = 13;
			this.headerLabel.Text = "Tournament Dashboard";
			// 
			// loadExistingTournamentDropDown
			// 
			this.loadExistingTournamentDropDown.FormattingEnabled = true;
			this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(235, 308);
			this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
			this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(920, 67);
			this.loadExistingTournamentDropDown.TabIndex = 20;
			// 
			// loadExistingTournamentLabel
			// 
			this.loadExistingTournamentLabel.AutoSize = true;
			this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.loadExistingTournamentLabel.Location = new System.Drawing.Point(375, 222);
			this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
			this.loadExistingTournamentLabel.Size = new System.Drawing.Size(633, 71);
			this.loadExistingTournamentLabel.TabIndex = 19;
			this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
			// 
			// loadTournamentButton
			// 
			this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.loadTournamentButton.Location = new System.Drawing.Point(387, 402);
			this.loadTournamentButton.Name = "loadTournamentButton";
			this.loadTournamentButton.Size = new System.Drawing.Size(628, 106);
			this.loadTournamentButton.TabIndex = 21;
			this.loadTournamentButton.Text = "Load Tournament";
			this.loadTournamentButton.UseVisualStyleBackColor = true;
			this.loadTournamentButton.Click += new System.EventHandler(this.loadTournamentButton_Click);
			// 
			// createTournamentButton
			// 
			this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTournamentButton.Location = new System.Drawing.Point(352, 567);
			this.createTournamentButton.Name = "createTournamentButton";
			this.createTournamentButton.Size = new System.Drawing.Size(679, 172);
			this.createTournamentButton.TabIndex = 26;
			this.createTournamentButton.Text = "Create Tournament";
			this.createTournamentButton.UseVisualStyleBackColor = true;
			this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
			// 
			// TournamentDashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1390, 806);
			this.Controls.Add(this.createTournamentButton);
			this.Controls.Add(this.loadTournamentButton);
			this.Controls.Add(this.loadExistingTournamentDropDown);
			this.Controls.Add(this.loadExistingTournamentLabel);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "TournamentDashboardForm";
			this.Text = "Tournament Dashboard";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
		private System.Windows.Forms.Label loadExistingTournamentLabel;
		private System.Windows.Forms.Button loadTournamentButton;
		private System.Windows.Forms.Button createTournamentButton;
	}
}