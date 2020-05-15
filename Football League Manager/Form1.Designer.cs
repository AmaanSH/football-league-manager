namespace Football_League_Manager
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.forenameText = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.playerListbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teamNameBox = new System.Windows.Forms.TextBox();
            this.teamSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.venueTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.createGameButton = new System.Windows.Forms.Button();
            this.teamManagerButton = new System.Windows.Forms.Button();
            this.teamRemoveButton = new System.Windows.Forms.Button();
            this.addToTeamButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.statusLabelPlayer = new System.Windows.Forms.Label();
            this.statusLabelTeam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forename";
            // 
            // forenameText
            // 
            this.forenameText.Location = new System.Drawing.Point(62, 15);
            this.forenameText.Name = "forenameText";
            this.forenameText.Size = new System.Drawing.Size(211, 20);
            this.forenameText.TabIndex = 1;
            this.toolTip1.SetToolTip(this.forenameText, "Forename for the player");
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(198, 71);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Add";
            this.toolTip1.SetToolTip(this.submit, "Add a new player with forename and surname provided");
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(62, 45);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(211, 20);
            this.surnameText.TabIndex = 3;
            this.toolTip1.SetToolTip(this.surnameText, "Surname for the player");
            // 
            // playerListbox
            // 
            this.playerListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playerListbox.FormattingEnabled = true;
            this.playerListbox.Location = new System.Drawing.Point(62, 139);
            this.playerListbox.Name = "playerListbox";
            this.playerListbox.Size = new System.Drawing.Size(211, 160);
            this.playerListbox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.playerListbox, "List of players");
            this.playerListbox.SelectedIndexChanged += new System.EventHandler(this.PlayerListbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Team";
            // 
            // teamNameBox
            // 
            this.teamNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameBox.Location = new System.Drawing.Point(329, 19);
            this.teamNameBox.Name = "teamNameBox";
            this.teamNameBox.Size = new System.Drawing.Size(306, 20);
            this.teamNameBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.teamNameBox, "The team\'s name");
            // 
            // teamSubmit
            // 
            this.teamSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamSubmit.Location = new System.Drawing.Point(560, 71);
            this.teamSubmit.Name = "teamSubmit";
            this.teamSubmit.Size = new System.Drawing.Size(75, 23);
            this.teamSubmit.TabIndex = 8;
            this.teamSubmit.Text = "Add";
            this.toolTip1.SetToolTip(this.teamSubmit, "Add a team to the program");
            this.teamSubmit.UseVisualStyleBackColor = true;
            this.teamSubmit.Click += new System.EventHandler(this.TeamSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Team";
            // 
            // teamListBox
            // 
            this.teamListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(329, 139);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(311, 160);
            this.teamListBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.teamListBox, "List of teams");
            this.teamListBox.SelectedIndexChanged += new System.EventHandler(this.TeamListBox_SelectedIndexChanged);
            // 
            // venueTextBox
            // 
            this.venueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.venueTextBox.Location = new System.Drawing.Point(329, 45);
            this.venueTextBox.Name = "venueTextBox";
            this.venueTextBox.Size = new System.Drawing.Size(306, 20);
            this.venueTextBox.TabIndex = 11;
            this.toolTip1.SetToolTip(this.venueTextBox, "The team\'s venue");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Venue";
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removePlayerButton.Enabled = false;
            this.removePlayerButton.Location = new System.Drawing.Point(214, 306);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(59, 23);
            this.removePlayerButton.TabIndex = 13;
            this.removePlayerButton.Text = "Remove";
            this.toolTip1.SetToolTip(this.removePlayerButton, "Removes the selected player");
            this.removePlayerButton.UseVisualStyleBackColor = true;
            this.removePlayerButton.Click += new System.EventHandler(this.RemovePlayerButton_Click);
            // 
            // createGameButton
            // 
            this.createGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createGameButton.Location = new System.Drawing.Point(10, 369);
            this.createGameButton.Name = "createGameButton";
            this.createGameButton.Size = new System.Drawing.Size(82, 23);
            this.createGameButton.TabIndex = 14;
            this.createGameButton.Text = " Create Game";
            this.toolTip1.SetToolTip(this.createGameButton, "Create a new game");
            this.createGameButton.UseVisualStyleBackColor = true;
            this.createGameButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // teamManagerButton
            // 
            this.teamManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.teamManagerButton.Enabled = false;
            this.teamManagerButton.Location = new System.Drawing.Point(469, 306);
            this.teamManagerButton.Name = "teamManagerButton";
            this.teamManagerButton.Size = new System.Drawing.Size(106, 23);
            this.teamManagerButton.TabIndex = 15;
            this.teamManagerButton.Text = "Team Manager";
            this.toolTip1.SetToolTip(this.teamManagerButton, "Manage the team selected.  Allows you to add new players, remove players, assign " +
        "player status, see upcoming games");
            this.teamManagerButton.UseVisualStyleBackColor = true;
            this.teamManagerButton.Click += new System.EventHandler(this.TeamManagerButton_Click);
            // 
            // teamRemoveButton
            // 
            this.teamRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.teamRemoveButton.Enabled = false;
            this.teamRemoveButton.Location = new System.Drawing.Point(581, 306);
            this.teamRemoveButton.Name = "teamRemoveButton";
            this.teamRemoveButton.Size = new System.Drawing.Size(59, 23);
            this.teamRemoveButton.TabIndex = 16;
            this.teamRemoveButton.Text = "Remove";
            this.toolTip1.SetToolTip(this.teamRemoveButton, "Remove the team selected");
            this.teamRemoveButton.UseVisualStyleBackColor = true;
            this.teamRemoveButton.Click += new System.EventHandler(this.TeamRemoveButton_Click);
            // 
            // addToTeamButton
            // 
            this.addToTeamButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addToTeamButton.Location = new System.Drawing.Point(98, 369);
            this.addToTeamButton.Name = "addToTeamButton";
            this.addToTeamButton.Size = new System.Drawing.Size(87, 23);
            this.addToTeamButton.TabIndex = 17;
            this.addToTeamButton.Text = "Sign Player(s)";
            this.toolTip1.SetToolTip(this.addToTeamButton, "Add a new player to a team");
            this.addToTeamButton.UseVisualStyleBackColor = true;
            this.addToTeamButton.Click += new System.EventHandler(this.AddToTeam_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Surname";
            // 
            // statusLabelPlayer
            // 
            this.statusLabelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelPlayer.Location = new System.Drawing.Point(59, 102);
            this.statusLabelPlayer.Name = "statusLabelPlayer";
            this.statusLabelPlayer.Size = new System.Drawing.Size(214, 34);
            this.statusLabelPlayer.TabIndex = 19;
            this.statusLabelPlayer.Text = "STATUS_LABEL";
            this.statusLabelPlayer.Visible = false;
            // 
            // statusLabelTeam
            // 
            this.statusLabelTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabelTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelTeam.Location = new System.Drawing.Point(326, 102);
            this.statusLabelTeam.Name = "statusLabelTeam";
            this.statusLabelTeam.Size = new System.Drawing.Size(314, 34);
            this.statusLabelTeam.TabIndex = 20;
            this.statusLabelTeam.Text = "STATUS_LABEL";
            this.statusLabelTeam.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(10, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(633, 2);
            this.label7.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(542, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "© Football Manager";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 405);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusLabelTeam);
            this.Controls.Add(this.statusLabelPlayer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addToTeamButton);
            this.Controls.Add(this.teamRemoveButton);
            this.Controls.Add(this.teamManagerButton);
            this.Controls.Add(this.createGameButton);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.venueTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teamListBox);
            this.Controls.Add(this.teamSubmit);
            this.Controls.Add(this.teamNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerListbox);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.forenameText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Football Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox forenameText;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.ListBox playerListbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teamNameBox;
        private System.Windows.Forms.Button teamSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.TextBox venueTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Button createGameButton;
        private System.Windows.Forms.Button teamManagerButton;
        private System.Windows.Forms.Button teamRemoveButton;
        private System.Windows.Forms.Button addToTeamButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label statusLabelPlayer;
        private System.Windows.Forms.Label statusLabelTeam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

