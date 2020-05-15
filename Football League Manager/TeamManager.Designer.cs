namespace Football_League_Manager
{
    partial class TeamManager
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.teamNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teamCodeBox = new System.Windows.Forms.TextBox();
            this.venueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teamPlayerBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.playerCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.onLineupCheck = new System.Windows.Forms.CheckBox();
            this.updateStatus = new System.Windows.Forms.Button();
            this.injuredRadioButton = new System.Windows.Forms.RadioButton();
            this.fitRadioButton = new System.Windows.Forms.RadioButton();
            this.statusUpdateLabel = new System.Windows.Forms.Label();
            this.upcomingGameList = new System.Windows.Forms.ListBox();
            this.gameTitle = new System.Windows.Forms.Label();
            this.gameCodeText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lineupList = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name";
            // 
            // teamNameBox
            // 
            this.teamNameBox.Enabled = false;
            this.teamNameBox.Location = new System.Drawing.Point(83, 10);
            this.teamNameBox.Name = "teamNameBox";
            this.teamNameBox.Size = new System.Drawing.Size(246, 20);
            this.teamNameBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.teamNameBox, "The team\'s name");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team Code";
            // 
            // teamCodeBox
            // 
            this.teamCodeBox.Enabled = false;
            this.teamCodeBox.Location = new System.Drawing.Point(83, 45);
            this.teamCodeBox.Name = "teamCodeBox";
            this.teamCodeBox.Size = new System.Drawing.Size(246, 20);
            this.teamCodeBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.teamCodeBox, "The team\'s unique code");
            // 
            // venueTextBox
            // 
            this.venueTextBox.Enabled = false;
            this.venueTextBox.Location = new System.Drawing.Point(83, 80);
            this.venueTextBox.Name = "venueTextBox";
            this.venueTextBox.Size = new System.Drawing.Size(246, 20);
            this.venueTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.venueTextBox, "Team\'s home venue");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Venue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Players";
            // 
            // teamPlayerBox
            // 
            this.teamPlayerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.teamPlayerBox.FormattingEnabled = true;
            this.teamPlayerBox.Location = new System.Drawing.Point(16, 235);
            this.teamPlayerBox.Name = "teamPlayerBox";
            this.teamPlayerBox.Size = new System.Drawing.Size(313, 251);
            this.teamPlayerBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.teamPlayerBox, "The list of players, select one for more details");
            this.teamPlayerBox.SelectedIndexChanged += new System.EventHandler(this.TeamPlayerBox_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(458, 411);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(127, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove From Team";
            this.toolTip1.SetToolTip(this.removeButton, "Removes the selected player from the team");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(227, 506);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add Players...";
            this.toolTip1.SetToolTip(this.addButton, "Add a new player to the team");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Upcoming Games";
            // 
            // playerCode
            // 
            this.playerCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerCode.Enabled = false;
            this.playerCode.Location = new System.Drawing.Point(412, 276);
            this.playerCode.Name = "playerCode";
            this.playerCode.Size = new System.Drawing.Size(488, 20);
            this.playerCode.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Code";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(365, 247);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(97, 13);
            this.playerNameLabel.TabIndex = 14;
            this.playerNameLabel.Text = "PLAYER_NAME";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lineup";
            // 
            // onLineupCheck
            // 
            this.onLineupCheck.AutoSize = true;
            this.onLineupCheck.Enabled = false;
            this.onLineupCheck.Location = new System.Drawing.Point(412, 309);
            this.onLineupCheck.Name = "onLineupCheck";
            this.onLineupCheck.Size = new System.Drawing.Size(15, 14);
            this.onLineupCheck.TabIndex = 19;
            this.onLineupCheck.UseVisualStyleBackColor = true;
            // 
            // updateStatus
            // 
            this.updateStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateStatus.Location = new System.Drawing.Point(388, 411);
            this.updateStatus.Name = "updateStatus";
            this.updateStatus.Size = new System.Drawing.Size(64, 23);
            this.updateStatus.TabIndex = 20;
            this.updateStatus.Text = "Update";
            this.toolTip1.SetToolTip(this.updateStatus, "Updates the selected players injury status");
            this.updateStatus.UseVisualStyleBackColor = true;
            this.updateStatus.Click += new System.EventHandler(this.UpdateStatus_Click);
            // 
            // injuredRadioButton
            // 
            this.injuredRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.injuredRadioButton.AutoSize = true;
            this.injuredRadioButton.Location = new System.Drawing.Point(412, 337);
            this.injuredRadioButton.Name = "injuredRadioButton";
            this.injuredRadioButton.Size = new System.Drawing.Size(57, 17);
            this.injuredRadioButton.TabIndex = 21;
            this.injuredRadioButton.TabStop = true;
            this.injuredRadioButton.Text = "Injured";
            this.injuredRadioButton.UseVisualStyleBackColor = true;
            // 
            // fitRadioButton
            // 
            this.fitRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fitRadioButton.AutoSize = true;
            this.fitRadioButton.Location = new System.Drawing.Point(412, 360);
            this.fitRadioButton.Name = "fitRadioButton";
            this.fitRadioButton.Size = new System.Drawing.Size(36, 17);
            this.fitRadioButton.TabIndex = 22;
            this.fitRadioButton.TabStop = true;
            this.fitRadioButton.Text = "Fit";
            this.fitRadioButton.UseVisualStyleBackColor = true;
            // 
            // statusUpdateLabel
            // 
            this.statusUpdateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusUpdateLabel.Location = new System.Drawing.Point(365, 452);
            this.statusUpdateLabel.Name = "statusUpdateLabel";
            this.statusUpdateLabel.Size = new System.Drawing.Size(535, 34);
            this.statusUpdateLabel.TabIndex = 23;
            this.statusUpdateLabel.Text = "STATUS_LABEL";
            this.statusUpdateLabel.Visible = false;
            // 
            // upcomingGameList
            // 
            this.upcomingGameList.FormattingEnabled = true;
            this.upcomingGameList.Location = new System.Drawing.Point(15, 134);
            this.upcomingGameList.Name = "upcomingGameList";
            this.upcomingGameList.Size = new System.Drawing.Size(313, 69);
            this.upcomingGameList.TabIndex = 24;
            this.toolTip1.SetToolTip(this.upcomingGameList, "A list of upcoming games, select one for more details");
            this.upcomingGameList.SelectedIndexChanged += new System.EventHandler(this.UpcomingGameList_SelectedIndexChanged);
            // 
            // gameTitle
            // 
            this.gameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(365, 13);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(65, 13);
            this.gameTitle.TabIndex = 25;
            this.gameTitle.Text = "GAME_VS";
            // 
            // gameCodeText
            // 
            this.gameCodeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameCodeText.Enabled = false;
            this.gameCodeText.Location = new System.Drawing.Point(412, 41);
            this.gameCodeText.Name = "gameCodeText";
            this.gameCodeText.Size = new System.Drawing.Size(488, 20);
            this.gameCodeText.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Code";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Lineup";
            // 
            // lineupList
            // 
            this.lineupList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineupList.FormattingEnabled = true;
            this.lineupList.Location = new System.Drawing.Point(412, 83);
            this.lineupList.Name = "lineupList";
            this.lineupList.Size = new System.Drawing.Size(488, 82);
            this.lineupList.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(365, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Date";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTextBox.Enabled = false;
            this.dateTextBox.Location = new System.Drawing.Point(412, 171);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(488, 20);
            this.dateTextBox.TabIndex = 31;
            // 
            // playerPanel
            // 
            this.playerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerPanel.Location = new System.Drawing.Point(355, 213);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(555, 322);
            this.playerPanel.TabIndex = 32;
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePanel.Location = new System.Drawing.Point(355, 8);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(555, 195);
            this.gamePanel.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(347, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(2, 523);
            this.label13.TabIndex = 34;
            // 
            // TeamManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 541);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lineupList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gameCodeText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.upcomingGameList);
            this.Controls.Add(this.statusUpdateLabel);
            this.Controls.Add(this.fitRadioButton);
            this.Controls.Add(this.injuredRadioButton);
            this.Controls.Add(this.updateStatus);
            this.Controls.Add(this.onLineupCheck);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.playerCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.teamPlayerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.venueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teamCodeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teamNameBox);
            this.Controls.Add(this.label1);
            this.Name = "TeamManager";
            this.Text = "TeamManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeamManager_FormClosed);
            this.Load += new System.EventHandler(this.TeamManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teamNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teamCodeBox;
        private System.Windows.Forms.TextBox venueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox teamPlayerBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox playerCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox onLineupCheck;
        private System.Windows.Forms.Button updateStatus;
        private System.Windows.Forms.RadioButton injuredRadioButton;
        private System.Windows.Forms.RadioButton fitRadioButton;
        private System.Windows.Forms.Label statusUpdateLabel;
        private System.Windows.Forms.ListBox upcomingGameList;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.TextBox gameCodeText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lineupList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}