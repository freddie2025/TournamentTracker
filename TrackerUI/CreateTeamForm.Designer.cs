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
			this.cellphoneTextBox = new System.Windows.Forms.TextBox();
			this.cellphoneLabel = new System.Windows.Forms.Label();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.firstNameValue = new System.Windows.Forms.TextBox();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.teamMembersListBox = new System.Windows.Forms.ListBox();
			this.deletedSelectedMemberButton = new System.Windows.Forms.Button();
			this.createTeamButton = new System.Windows.Forms.Button();
			this.addNewMemberGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// teamNameValue
			// 
			this.teamNameValue.Location = new System.Drawing.Point(56, 294);
			this.teamNameValue.Name = "teamNameValue";
			this.teamNameValue.Size = new System.Drawing.Size(925, 65);
			this.teamNameValue.TabIndex = 13;
			// 
			// teamNameLabel
			// 
			this.teamNameLabel.AutoSize = true;
			this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamNameLabel.Location = new System.Drawing.Point(44, 195);
			this.teamNameLabel.Name = "teamNameLabel";
			this.teamNameLabel.Size = new System.Drawing.Size(310, 71);
			this.teamNameLabel.TabIndex = 12;
			this.teamNameLabel.Text = "Team Name";
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(39, 51);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(431, 100);
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
			this.addMemberButton.Location = new System.Drawing.Point(204, 617);
			this.addMemberButton.Name = "addMemberButton";
			this.addMemberButton.Size = new System.Drawing.Size(628, 106);
			this.addMemberButton.TabIndex = 19;
			this.addMemberButton.Text = "Add Member";
			this.addMemberButton.UseVisualStyleBackColor = true;
			// 
			// selectTeamMemberDropDown
			// 
			this.selectTeamMemberDropDown.FormattingEnabled = true;
			this.selectTeamMemberDropDown.Location = new System.Drawing.Point(61, 477);
			this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
			this.selectTeamMemberDropDown.Size = new System.Drawing.Size(920, 67);
			this.selectTeamMemberDropDown.TabIndex = 18;
			// 
			// selectTeamMemberLabel
			// 
			this.selectTeamMemberLabel.AutoSize = true;
			this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.selectTeamMemberLabel.Location = new System.Drawing.Point(54, 391);
			this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
			this.selectTeamMemberLabel.Size = new System.Drawing.Size(522, 71);
			this.selectTeamMemberLabel.TabIndex = 17;
			this.selectTeamMemberLabel.Text = "Select Team Member";
			// 
			// addNewMemberGroupBox
			// 
			this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
			this.addNewMemberGroupBox.Controls.Add(this.cellphoneTextBox);
			this.addNewMemberGroupBox.Controls.Add(this.cellphoneLabel);
			this.addNewMemberGroupBox.Controls.Add(this.emailTextBox);
			this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
			this.addNewMemberGroupBox.Controls.Add(this.lastNameTextBox);
			this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
			this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
			this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
			this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addNewMemberGroupBox.Location = new System.Drawing.Point(56, 792);
			this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
			this.addNewMemberGroupBox.Size = new System.Drawing.Size(998, 683);
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
			this.createMemberButton.Location = new System.Drawing.Point(323, 546);
			this.createMemberButton.Name = "createMemberButton";
			this.createMemberButton.Size = new System.Drawing.Size(602, 106);
			this.createMemberButton.TabIndex = 21;
			this.createMemberButton.Text = "Create Member";
			this.createMemberButton.UseVisualStyleBackColor = true;
			// 
			// cellphoneTextBox
			// 
			this.cellphoneTextBox.Location = new System.Drawing.Point(323, 432);
			this.cellphoneTextBox.Name = "cellphoneTextBox";
			this.cellphoneTextBox.Size = new System.Drawing.Size(602, 78);
			this.cellphoneTextBox.TabIndex = 16;
			// 
			// cellphoneLabel
			// 
			this.cellphoneLabel.AutoSize = true;
			this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.cellphoneLabel.Location = new System.Drawing.Point(34, 426);
			this.cellphoneLabel.Name = "cellphoneLabel";
			this.cellphoneLabel.Size = new System.Drawing.Size(267, 71);
			this.cellphoneLabel.TabIndex = 15;
			this.cellphoneLabel.Text = "Cellphone";
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(323, 325);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(602, 78);
			this.emailTextBox.TabIndex = 14;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.emailLabel.Location = new System.Drawing.Point(34, 319);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(156, 71);
			this.emailLabel.TabIndex = 13;
			this.emailLabel.Text = "Email";
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(323, 218);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(602, 78);
			this.lastNameTextBox.TabIndex = 12;
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.lastNameLabel.Location = new System.Drawing.Point(34, 212);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(278, 71);
			this.lastNameLabel.TabIndex = 11;
			this.lastNameLabel.Text = "Last Name";
			// 
			// firstNameValue
			// 
			this.firstNameValue.Location = new System.Drawing.Point(323, 114);
			this.firstNameValue.Name = "firstNameValue";
			this.firstNameValue.Size = new System.Drawing.Size(602, 78);
			this.firstNameValue.TabIndex = 10;
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.firstNameLabel.Location = new System.Drawing.Point(34, 108);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(283, 71);
			this.firstNameLabel.TabIndex = 9;
			this.firstNameLabel.Text = "First Name";
			// 
			// teamMembersListBox
			// 
			this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.teamMembersListBox.FormattingEnabled = true;
			this.teamMembersListBox.ItemHeight = 59;
			this.teamMembersListBox.Location = new System.Drawing.Point(1150, 294);
			this.teamMembersListBox.Name = "teamMembersListBox";
			this.teamMembersListBox.Size = new System.Drawing.Size(668, 1182);
			this.teamMembersListBox.TabIndex = 21;
			// 
			// deletedSelectedMemberButton
			// 
			this.deletedSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.deletedSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.deletedSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.deletedSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deletedSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deletedSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.deletedSelectedMemberButton.Location = new System.Drawing.Point(1873, 820);
			this.deletedSelectedMemberButton.Name = "deletedSelectedMemberButton";
			this.deletedSelectedMemberButton.Size = new System.Drawing.Size(257, 136);
			this.deletedSelectedMemberButton.TabIndex = 24;
			this.deletedSelectedMemberButton.Text = "Delete Selected";
			this.deletedSelectedMemberButton.UseVisualStyleBackColor = true;
			// 
			// createTeamButton
			// 
			this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(202)))));
			this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTeamButton.Location = new System.Drawing.Point(717, 1574);
			this.createTeamButton.Name = "createTeamButton";
			this.createTeamButton.Size = new System.Drawing.Size(628, 106);
			this.createTeamButton.TabIndex = 25;
			this.createTeamButton.Text = "Create Team";
			this.createTeamButton.UseVisualStyleBackColor = true;
			// 
			// CreateTeamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(2176, 1764);
			this.Controls.Add(this.createTeamButton);
			this.Controls.Add(this.deletedSelectedMemberButton);
			this.Controls.Add(this.teamMembersListBox);
			this.Controls.Add(this.addNewMemberGroupBox);
			this.Controls.Add(this.addMemberButton);
			this.Controls.Add(this.selectTeamMemberDropDown);
			this.Controls.Add(this.selectTeamMemberLabel);
			this.Controls.Add(this.teamNameValue);
			this.Controls.Add(this.teamNameLabel);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
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
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.TextBox firstNameValue;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.TextBox cellphoneTextBox;
		private System.Windows.Forms.Label cellphoneLabel;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Button createMemberButton;
		private System.Windows.Forms.ListBox teamMembersListBox;
		private System.Windows.Forms.Button deletedSelectedMemberButton;
		private System.Windows.Forms.Button createTeamButton;
	}
}