namespace THA_W4_Ros_Diana
{
    partial class Form1
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
            this.labelSoccerTeamList = new System.Windows.Forms.Label();
            this.labelAddingTeam = new System.Windows.Forms.Label();
            this.labelAddingPlayers = new System.Windows.Forms.Label();
            this.labelChooseCountry = new System.Windows.Forms.Label();
            this.labelChooseTeam = new System.Windows.Forms.Label();
            this.comboBox_Choose_Country = new System.Windows.Forms.ComboBox();
            this.comboBox_Choose_Team = new System.Windows.Forms.ComboBox();
            this.ListBoxSoccerTeamList = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelTeamCountry = new System.Windows.Forms.Label();
            this.labelTeamCity = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.textBoxTeamCountry = new System.Windows.Forms.TextBox();
            this.textBoxTeamCity = new System.Windows.Forms.TextBox();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelPlayerNumber = new System.Windows.Forms.Label();
            this.labelPlayerPosition = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.textBoxPlayerNumber = new System.Windows.Forms.TextBox();
            this.comboBoxPlayerPostion = new System.Windows.Forms.ComboBox();
            this.buttonPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSoccerTeamList
            // 
            this.labelSoccerTeamList.AutoSize = true;
            this.labelSoccerTeamList.Location = new System.Drawing.Point(15, 54);
            this.labelSoccerTeamList.Name = "labelSoccerTeamList";
            this.labelSoccerTeamList.Size = new System.Drawing.Size(132, 20);
            this.labelSoccerTeamList.TabIndex = 0;
            this.labelSoccerTeamList.Text = "Soccer Team List";
            // 
            // labelAddingTeam
            // 
            this.labelAddingTeam.AutoSize = true;
            this.labelAddingTeam.Location = new System.Drawing.Point(385, 54);
            this.labelAddingTeam.Name = "labelAddingTeam";
            this.labelAddingTeam.Size = new System.Drawing.Size(103, 20);
            this.labelAddingTeam.TabIndex = 1;
            this.labelAddingTeam.Text = "Adding Team";
            // 
            // labelAddingPlayers
            // 
            this.labelAddingPlayers.AutoSize = true;
            this.labelAddingPlayers.Location = new System.Drawing.Point(755, 54);
            this.labelAddingPlayers.Name = "labelAddingPlayers";
            this.labelAddingPlayers.Size = new System.Drawing.Size(114, 20);
            this.labelAddingPlayers.TabIndex = 2;
            this.labelAddingPlayers.Text = "Adding Players";
            // 
            // labelChooseCountry
            // 
            this.labelChooseCountry.AutoSize = true;
            this.labelChooseCountry.Location = new System.Drawing.Point(15, 111);
            this.labelChooseCountry.Name = "labelChooseCountry";
            this.labelChooseCountry.Size = new System.Drawing.Size(123, 20);
            this.labelChooseCountry.TabIndex = 3;
            this.labelChooseCountry.Text = "Choose Country";
            // 
            // labelChooseTeam
            // 
            this.labelChooseTeam.AutoSize = true;
            this.labelChooseTeam.Location = new System.Drawing.Point(15, 168);
            this.labelChooseTeam.Name = "labelChooseTeam";
            this.labelChooseTeam.Size = new System.Drawing.Size(108, 20);
            this.labelChooseTeam.TabIndex = 4;
            this.labelChooseTeam.Text = "Choose Team";
            // 
            // comboBox_Choose_Country
            // 
            this.comboBox_Choose_Country.FormattingEnabled = true;
            this.comboBox_Choose_Country.Location = new System.Drawing.Point(169, 111);
            this.comboBox_Choose_Country.Name = "comboBox_Choose_Country";
            this.comboBox_Choose_Country.Size = new System.Drawing.Size(161, 28);
            this.comboBox_Choose_Country.TabIndex = 5;
            this.comboBox_Choose_Country.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Choose_Country_SelectionChangeCommitted);
            // 
            // comboBox_Choose_Team
            // 
            this.comboBox_Choose_Team.FormattingEnabled = true;
            this.comboBox_Choose_Team.Location = new System.Drawing.Point(169, 160);
            this.comboBox_Choose_Team.Name = "comboBox_Choose_Team";
            this.comboBox_Choose_Team.Size = new System.Drawing.Size(161, 28);
            this.comboBox_Choose_Team.TabIndex = 6;
            this.comboBox_Choose_Team.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Choose_Team_SelectionChangeCommitted);
            // 
            // ListBoxSoccerTeamList
            // 
            this.ListBoxSoccerTeamList.FormattingEnabled = true;
            this.ListBoxSoccerTeamList.ItemHeight = 20;
            this.ListBoxSoccerTeamList.Location = new System.Drawing.Point(35, 225);
            this.ListBoxSoccerTeamList.Name = "ListBoxSoccerTeamList";
            this.ListBoxSoccerTeamList.Size = new System.Drawing.Size(260, 144);
            this.ListBoxSoccerTeamList.TabIndex = 7;
            this.ListBoxSoccerTeamList.SelectedIndexChanged += new System.EventHandler(this.ListBoxSoccerTeamList_SelectedIndexChanged);
            this.ListBoxSoccerTeamList.SelectedValueChanged += new System.EventHandler(this.ListBoxSoccerTeamList_SelectedValueChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(35, 384);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(103, 35);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(385, 114);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(99, 20);
            this.labelTeamName.TabIndex = 9;
            this.labelTeamName.Text = "Team Name:";
            // 
            // labelTeamCountry
            // 
            this.labelTeamCountry.AutoSize = true;
            this.labelTeamCountry.Location = new System.Drawing.Point(385, 168);
            this.labelTeamCountry.Name = "labelTeamCountry";
            this.labelTeamCountry.Size = new System.Drawing.Size(112, 20);
            this.labelTeamCountry.TabIndex = 10;
            this.labelTeamCountry.Text = "Team Country:";
            // 
            // labelTeamCity
            // 
            this.labelTeamCity.AutoSize = true;
            this.labelTeamCity.Location = new System.Drawing.Point(385, 225);
            this.labelTeamCity.Name = "labelTeamCity";
            this.labelTeamCity.Size = new System.Drawing.Size(83, 20);
            this.labelTeamCity.TabIndex = 11;
            this.labelTeamCity.Text = "Team City:";
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(517, 113);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(169, 26);
            this.textBoxTeamName.TabIndex = 12;
            // 
            // textBoxTeamCountry
            // 
            this.textBoxTeamCountry.Location = new System.Drawing.Point(517, 168);
            this.textBoxTeamCountry.Name = "textBoxTeamCountry";
            this.textBoxTeamCountry.Size = new System.Drawing.Size(169, 26);
            this.textBoxTeamCountry.TabIndex = 13;
            // 
            // textBoxTeamCity
            // 
            this.textBoxTeamCity.Location = new System.Drawing.Point(517, 219);
            this.textBoxTeamCity.Name = "textBoxTeamCity";
            this.textBoxTeamCity.Size = new System.Drawing.Size(169, 26);
            this.textBoxTeamCity.TabIndex = 14;
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(517, 269);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(75, 31);
            this.buttonAddTeam.TabIndex = 15;
            this.buttonAddTeam.Text = "Add";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(755, 116);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(102, 20);
            this.labelPlayerName.TabIndex = 16;
            this.labelPlayerName.Text = "Player Name:";
            // 
            // labelPlayerNumber
            // 
            this.labelPlayerNumber.AutoSize = true;
            this.labelPlayerNumber.Location = new System.Drawing.Point(755, 174);
            this.labelPlayerNumber.Name = "labelPlayerNumber";
            this.labelPlayerNumber.Size = new System.Drawing.Size(116, 20);
            this.labelPlayerNumber.TabIndex = 17;
            this.labelPlayerNumber.Text = "Player Number:";
            // 
            // labelPlayerPosition
            // 
            this.labelPlayerPosition.AutoSize = true;
            this.labelPlayerPosition.Location = new System.Drawing.Point(755, 225);
            this.labelPlayerPosition.Name = "labelPlayerPosition";
            this.labelPlayerPosition.Size = new System.Drawing.Size(116, 20);
            this.labelPlayerPosition.TabIndex = 18;
            this.labelPlayerPosition.Text = "Player Position:";
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(896, 110);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(152, 26);
            this.textBoxPlayerName.TabIndex = 19;
            // 
            // textBoxPlayerNumber
            // 
            this.textBoxPlayerNumber.Location = new System.Drawing.Point(896, 171);
            this.textBoxPlayerNumber.Name = "textBoxPlayerNumber";
            this.textBoxPlayerNumber.Size = new System.Drawing.Size(152, 26);
            this.textBoxPlayerNumber.TabIndex = 20;
            // 
            // comboBoxPlayerPostion
            // 
            this.comboBoxPlayerPostion.FormattingEnabled = true;
            this.comboBoxPlayerPostion.Items.AddRange(new object[] {
            "GK ",
            "DF",
            "FW",
            "MF"});
            this.comboBoxPlayerPostion.Location = new System.Drawing.Point(896, 219);
            this.comboBoxPlayerPostion.Name = "comboBoxPlayerPostion";
            this.comboBoxPlayerPostion.Size = new System.Drawing.Size(152, 28);
            this.comboBoxPlayerPostion.TabIndex = 21;
            // 
            // buttonPlayers
            // 
            this.buttonPlayers.Location = new System.Drawing.Point(896, 269);
            this.buttonPlayers.Name = "buttonPlayers";
            this.buttonPlayers.Size = new System.Drawing.Size(75, 31);
            this.buttonPlayers.TabIndex = 22;
            this.buttonPlayers.Text = "Add";
            this.buttonPlayers.UseVisualStyleBackColor = true;
            this.buttonPlayers.Click += new System.EventHandler(this.buttonPlayers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.buttonPlayers);
            this.Controls.Add(this.comboBoxPlayerPostion);
            this.Controls.Add(this.textBoxPlayerNumber);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelPlayerPosition);
            this.Controls.Add(this.labelPlayerNumber);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.textBoxTeamCity);
            this.Controls.Add(this.textBoxTeamCountry);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.labelTeamCity);
            this.Controls.Add(this.labelTeamCountry);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.ListBoxSoccerTeamList);
            this.Controls.Add(this.comboBox_Choose_Team);
            this.Controls.Add(this.comboBox_Choose_Country);
            this.Controls.Add(this.labelChooseTeam);
            this.Controls.Add(this.labelChooseCountry);
            this.Controls.Add(this.labelAddingPlayers);
            this.Controls.Add(this.labelAddingTeam);
            this.Controls.Add(this.labelSoccerTeamList);
            this.Name = "Form1";
            this.Text = "Football";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoccerTeamList;
        private System.Windows.Forms.Label labelAddingTeam;
        private System.Windows.Forms.Label labelAddingPlayers;
        private System.Windows.Forms.Label labelChooseCountry;
        private System.Windows.Forms.Label labelChooseTeam;
        private System.Windows.Forms.ComboBox comboBox_Choose_Country;
        private System.Windows.Forms.ComboBox comboBox_Choose_Team;
        private System.Windows.Forms.ListBox ListBoxSoccerTeamList;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelTeamCountry;
        private System.Windows.Forms.Label labelTeamCity;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.TextBox textBoxTeamCountry;
        private System.Windows.Forms.TextBox textBoxTeamCity;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelPlayerNumber;
        private System.Windows.Forms.Label labelPlayerPosition;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.TextBox textBoxPlayerNumber;
        private System.Windows.Forms.ComboBox comboBoxPlayerPostion;
        private System.Windows.Forms.Button buttonPlayers;
    }
}

