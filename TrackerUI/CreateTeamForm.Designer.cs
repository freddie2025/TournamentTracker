namespace TrackerUI
{
	partial class CreateTeamForm
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
			this.teamNameValue = new System.Windows.Forms.TextBox();
			this.teamNameLabel = new System.Windows.Forms.Label();
			this.headerLabel = new System.Windows.Forms.Label();
			this.addMemberButton = new System.Windows.Forms.Button();
			this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
			this.selectTeamMemberLabel = new System.Windows.Forms.Label();
			this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
			this.createMemberButton = new System.Windows.Forms.Button();
			this.cellphoneValue = new System.Windows.Forms.TextBox();
			this.cellphoneLabel = new System.Windows.Forms.Label();
			this.emailValue = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.lastNameValue = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.firstNameValue = new System.Windows.Forms.TextBox();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.teamMembersListBox = new System.Windows.Forms.ListBox();
			this.removeSelectedMemberButton = new System.Windows.Forms.Button();
			this.createTeamButton = new System.Windows.Forms.Button();
			this.addNewMemberGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// teamNameValue
			// 
			this.teamNameValue.Location = new System.Drawing.Point(28, 147);
			this.teamNameValue.Margin = new System.Windows.Forms.Padding(2);
			this.teamNameValue.Name = "teamNameValue";
			this.teamNameValue.Size = new System.Drawing.Size(464, 36);
			this.teamNameValue.TabIndex = 13;
			// 
			// teamNameLabel
			// 
			this.teamNameLabel.AutoSize = true;
			this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamNameLabel.Location = new System.Drawing.Point(22, 98);
			this.teamNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.teamNameLabel.Name = "teamNameLabel";
			this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
			this.teamNameLabel.TabIndex = 12;
			this.teamNameLabel.Text = "Team Name";
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(20, 26);
			this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(218, 51);
			this.headerLabel.TabIndex = 11;
			this.headerLabel.Text = "Create Team";
			// 
			// addMemberButton
			// 
			this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addMemberButton.Location = new System.Drawing.Point(102, 308);
			this.addMemberButton.Margin = new System.Windows.Forms.Padding(2);
			this.addMemberButton.Name = "addMemberButton";
			this.addMemberButton.Size = new System.Drawing.Size(314, 53);
			this.addMemberButton.TabIndex = 19;
			this.addMemberButton.Text = "Add Member";
			this.addMemberButton.UseVisualStyleBackColor = true;
			this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
			// 
			// selectTeamMemberDropDown
			// 
			this.selectTeamMemberDropDown.FormattingEnabled = true;
			this.selectTeamMemberDropDown.Location = new System.Drawing.Point(30, 238);
			this.selectTeamMemberDropDown.Margin = new System.Windows.Forms.Padding(2);
			this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
			this.selectTeamMemberDropDown.Size = new System.Drawing.Size(462, 38);
			this.selectTeamMemberDropDown.TabIndex = 18;
			// 
			// selectTeamMemberLabel
			// 
			this.selectTeamMemberLabel.AutoSize = true;
			this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.selectTeamMemberLabel.Location = new System.Drawing.Point(27, 196);
			this.selectTeamMemberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
			this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
			this.selectTeamMemberLabel.TabIndex = 17;
			this.selectTeamMemberLabel.Text = "Select Team Member";
			// 
			// addNewMemberGroupBox
			// 
			this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
			this.addNewMemberGroupBox.Controls.Add(this.cellphoneValue);
			this.addNewMemberGroupBox.Controls.Add(this.cellphoneLabel);
			this.addNewMemberGroupBox.Controls.Add(this.emailValue);
			this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
			this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
			this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
			this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
			this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
			this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addNewMemberGroupBox.Location = new System.Drawing.Point(28, 396);
			this.addNewMemberGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
			this.addNewMemberGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.addNewMemberGroupBox.Size = new System.Drawing.Size(499, 342);
			this.addNewMemberGroupBox.TabIndex = 20;
			this.addNewMemberGroupBox.TabStop = false;
			this.addNewMemberGroupBox.Text = "Add New Member";
			// 
			// createMemberButton
			// 
			this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createMemberButton.Location = new System.Drawing.Point(162, 273);
			this.createMemberButton.Margin = new System.Windows.Forms.Padding(2);
			this.createMemberButton.Name = "createMemberButton";
			this.createMemberButton.Size = new System.Drawing.Size(301, 53);
			this.createMemberButton.TabIndex = 21;
			this.createMemberButton.Text = "Create Member";
			this.createMemberButton.UseVisualStyleBackColor = true;
			this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
			// 
			// cellphoneValue
			// 
			this.cellphoneValue.Location = new System.Drawing.Point(162, 216);
			this.cellphoneValue.Margin = new System.Windows.Forms.Padding(2);
			this.cellphoneValue.Name = "cellphoneValue";
			this.cellphoneValue.Size = new System.Drawing.Size(303, 43);
			this.cellphoneValue.TabIndex = 16;
			// 
			// cellphoneLabel
			// 
			this.cellphoneLabel.AutoSize = true;
			this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.cellphoneLabel.Location = new System.Drawing.Point(17, 213);
			this.cellphoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.cellphoneLabel.Name = "cellphoneLabel";
			this.cellphoneLabel.Size = new System.Drawing.Size(138, 37);
			this.cellphoneLabel.TabIndex = 15;
			this.cellphoneLabel.Text = "Cellphone";
			// 
			// emailValue
			// 
			this.emailValue.Location = new System.Drawing.Point(162, 162);
			this.emailValue.Margin = new System.Windows.Forms.Padding(2);
			this.emailValue.Name = "emailValue";
			this.emailValue.Size = new System.Drawing.Size(303, 43);
			this.emailValue.TabIndex = 14;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.emailLabel.Location = new System.Drawing.Point(17, 160);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(82, 37);
			this.emailLabel.TabIndex = 13;
			this.emailLabel.Text = "Email";
			// 
			// lastNameValue
			// 
			this.lastNameValue.Location = new System.Drawing.Point(162, 109);
			this.lastNameValue.Margin = new System.Windows.Forms.Padding(2);
			this.lastNameValue.Name = "lastNameValue";
			this.lastNameValue.Size = new System.Drawing.Size(303, 43);
			this.lastNameValue.TabIndex = 12;
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.lastNameLabel.Location = new System.Drawing.Point(17, 106);
			this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
			this.lastNameLabel.TabIndex = 11;
			this.lastNameLabel.Text = "Last Name";
			// 
			// firstNameValue
			// 
			this.firstNameValue.Location = new System.Drawing.Point(162, 57);
			this.firstNameValue.Margin = new System.Windows.Forms.Padding(2);
			this.firstNameValue.Name = "firstNameValue";
			this.firstNameValue.Size = new System.Drawing.Size(303, 43);
			this.firstNameValue.TabIndex = 10;
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.firstNameLabel.Location = new System.Drawing.Point(17, 54);
			this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
			this.firstNameLabel.TabIndex = 9;
			this.firstNameLabel.Text = "First Name";
			// 
			// teamMembersListBox
			// 
			this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.teamMembersListBox.FormattingEnabled = true;
			this.teamMembersListBox.ItemHeight = 30;
			this.teamMembersListBox.Location = new System.Drawing.Point(575, 147);
			this.teamMembersListBox.Margin = new System.Windows.Forms.Padding(2);
			this.teamMembersListBox.Name = "teamMembersListBox";
			this.teamMembersListBox.Size = new System.Drawing.Size(335, 542);
			this.teamMembersListBox.TabIndex = 21;
			// 
			// removeSelectedMemberButton
			// 
			this.removeSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.removeSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.removeSelectedMemberButton.Location = new System.Drawing.Point(936, 410);
			this.removeSelectedMemberButton.Margin = new System.Windows.Forms.Padding(2);
			this.removeSelectedMemberButton.Name = "removeSelectedMemberButton";
			this.removeSelectedMemberButton.Size = new System.Drawing.Size(128, 88);
			this.removeSelectedMemberButton.TabIndex = 24;
			this.removeSelectedMemberButton.Text = "Remove Selected";
			this.removeSelectedMemberButton.UseVisualStyleBackColor = true;
			this.removeSelectedMemberButton.Click += new System.EventHandler(this.removeSelectedMemberButton_Click);
			// 
			// createTeamButton
			// 
			this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTeamButton.Location = new System.Drawing.Point(358, 787);
			this.createTeamButton.Margin = new System.Windows.Forms.Padding(2);
			this.createTeamButton.Name = "createTeamButton";
			this.createTeamButton.Size = new System.Drawing.Size(314, 53);
			this.createTeamButton.TabIndex = 25;
			this.createTeamButton.Text = "Create Team";
			this.createTeamButton.UseVisualStyleBackColor = true;
			// 
			// CreateTeamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1100, 877);
			this.Controls.Add(this.createTeamButton);
			this.Controls.Add(this.removeSelectedMemberButton);
			this.Controls.Add(this.teamMembersListBox);
			this.Controls.Add(this.addNewMemberGroupBox);
			this.Controls.Add(this.addMemberButton);
			this.Controls.Add(this.selectTeamMemberDropDown);
			this.Controls.Add(this.selectTeamMemberLabel);
			this.Controls.Add(this.teamNameValue);
			this.Controls.Add(this.teamNameLabel);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "CreateTeamForm";
			this.Text = "Create Team";
			this.addNewMemberGroupBox.ResumeLayout(false);
			this.addNewMemberGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox teamNameValue;
		private System.Windows.Forms.Label teamNameLabel;
		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Button addMemberButton;
		private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
		private System.Windows.Forms.Label selectTeamMemberLabel;
		private System.Windows.Forms.GroupBox addNewMemberGroupBox;
		private System.Windows.Forms.TextBox lastNameValue;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.TextBox firstNameValue;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.TextBox cellphoneValue;
		private System.Windows.Forms.Label cellphoneLabel;
		private System.Windows.Forms.TextBox emailValue;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Button createMemberButton;
		private System.Windows.Forms.ListBox teamMembersListBox;
		private System.Windows.Forms.Button removeSelectedMemberButton;
		private System.Windows.Forms.Button createTeamButton;
	}
}