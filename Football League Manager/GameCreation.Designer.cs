namespace Football_League_Manager
{
    partial class GameCreation
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
            this.homeDropdown = new System.Windows.Forms.ComboBox();
            this.awayDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.homeLineupList = new System.Windows.Forms.CheckedListBox();
            this.awayLineupList = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.venueTextbox = new System.Windows.Forms.TextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.gameDateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.homeCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.awayCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // homeDropdown
            // 
            this.homeDropdown.FormattingEnabled = true;
            this.homeDropdown.Location = new System.Drawing.Point(56, 12);
            this.homeDropdown.Name = "homeDropdown";
            this.homeDropdown.Size = new System.Drawing.Size(195, 21);
            this.homeDropdown.TabIndex = 1;
            this.toolTip1.SetToolTip(this.homeDropdown, "Assign a Home team to the game");
            this.homeDropdown.SelectionChangeCommitted += new System.EventHandler(this.HomeDropdown_SelectedIndexChanged);
            // 
            // awayDropdown
            // 
            this.awayDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.awayDropdown.Enabled = false;
            this.awayDropdown.FormattingEnabled = true;
            this.awayDropdown.Location = new System.Drawing.Point(329, 12);
            this.awayDropdown.Name = "awayDropdown";
            this.awayDropdown.Size = new System.Drawing.Size(195, 21);
            this.awayDropdown.TabIndex = 3;
            this.toolTip1.SetToolTip(this.awayDropdown, "Assign an Away team to the game");
            this.awayDropdown.SelectionChangeCommitted += new System.EventHandler(this.AwayDropdown_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Home Lineup";
            // 
            // homeLineupList
            // 
            this.homeLineupList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.homeLineupList.FormattingEnabled = true;
            this.homeLineupList.Location = new System.Drawing.Point(15, 118);
            this.homeLineupList.Name = "homeLineupList";
            this.homeLineupList.Size = new System.Drawing.Size(264, 184);
            this.homeLineupList.TabIndex = 6;
            this.toolTip1.SetToolTip(this.homeLineupList, "Select the players you wish to place on the lineup, maximum 11 players");
            this.homeLineupList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.HomeLineupList_ItemCheck);
            this.homeLineupList.SelectedIndexChanged += new System.EventHandler(this.HomeLineupList_SelectedIndexChanged);
            // 
            // awayLineupList
            // 
            this.awayLineupList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.awayLineupList.FormattingEnabled = true;
            this.awayLineupList.Location = new System.Drawing.Point(305, 118);
            this.awayLineupList.Name = "awayLineupList";
            this.awayLineupList.Size = new System.Drawing.Size(264, 184);
            this.awayLineupList.TabIndex = 8;
            this.toolTip1.SetToolTip(this.awayLineupList, "Select the players you wish to place on the lineup, maximum 11 players");
            this.awayLineupList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AwayLineupList_ItemCheck);
            this.awayLineupList.SelectedIndexChanged += new System.EventHandler(this.AwayLineupList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Away Lineup";
            // 
            // venueTextbox
            // 
            this.venueTextbox.Enabled = false;
            this.venueTextbox.Location = new System.Drawing.Point(84, 56);
            this.venueTextbox.Name = "venueTextbox";
            this.venueTextbox.Size = new System.Drawing.Size(195, 20);
            this.venueTextbox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.venueTextbox, "The home team\'s venue, this is entered automatically");
            // 
            // startGameButton
            // 
            this.startGameButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startGameButton.Location = new System.Drawing.Point(227, 330);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(122, 23);
            this.startGameButton.TabIndex = 11;
            this.startGameButton.Text = "Create New Game";
            this.toolTip1.SetToolTip(this.startGameButton, "Create a new game with the given details");
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // gameDateTime
            // 
            this.gameDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameDateTime.Location = new System.Drawing.Point(305, 56);
            this.gameDateTime.Name = "gameDateTime";
            this.gameDateTime.Size = new System.Drawing.Size(195, 20);
            this.gameDateTime.TabIndex = 13;
            this.toolTip1.SetToolTip(this.gameDateTime, "The date of the match");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Venue";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date";
            // 
            // homeCount
            // 
            this.homeCount.AutoSize = true;
            this.homeCount.Location = new System.Drawing.Point(104, 305);
            this.homeCount.Name = "homeCount";
            this.homeCount.Size = new System.Drawing.Size(13, 13);
            this.homeCount.TabIndex = 17;
            this.homeCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selected Players:";
            // 
            // awayCount
            // 
            this.awayCount.AutoSize = true;
            this.awayCount.Location = new System.Drawing.Point(394, 305);
            this.awayCount.Name = "awayCount";
            this.awayCount.Size = new System.Drawing.Size(13, 13);
            this.awayCount.TabIndex = 19;
            this.awayCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Selected Players:";
            // 
            // GameCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 365);
            this.Controls.Add(this.awayCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.homeCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameDateTime);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.venueTextbox);
            this.Controls.Add(this.awayLineupList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.homeLineupList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.awayDropdown);
            this.Controls.Add(this.homeDropdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameCreation";
            this.Text = "GameCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox homeDropdown;
        private System.Windows.Forms.ComboBox awayDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox homeLineupList;
        private System.Windows.Forms.CheckedListBox awayLineupList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox venueTextbox;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.DateTimePicker gameDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label homeCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label awayCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}