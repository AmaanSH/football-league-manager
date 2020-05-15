namespace Football_League_Manager
{
    partial class AddToTeam
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
            this.teamDropdown = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addPlayersList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountOfPlayersText = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team";
            // 
            // teamDropdown
            // 
            this.teamDropdown.FormattingEnabled = true;
            this.teamDropdown.Location = new System.Drawing.Point(55, 12);
            this.teamDropdown.Name = "teamDropdown";
            this.teamDropdown.Size = new System.Drawing.Size(255, 21);
            this.teamDropdown.TabIndex = 1;
            this.toolTip1.SetToolTip(this.teamDropdown, "A dropdown list containing all available teams");
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(235, 296);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.toolTip1.SetToolTip(this.confirmButton, "Adds the players selected to the team");
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player";
            // 
            // addPlayersList
            // 
            this.addPlayersList.FormattingEnabled = true;
            this.addPlayersList.Location = new System.Drawing.Point(16, 80);
            this.addPlayersList.Name = "addPlayersList";
            this.addPlayersList.Size = new System.Drawing.Size(294, 184);
            this.addPlayersList.TabIndex = 4;
            this.toolTip1.SetToolTip(this.addPlayersList, "Select players you wish to add to the team");
            this.addPlayersList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AddPlayersList_ItemCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selected Players:";
            // 
            // amountOfPlayersText
            // 
            this.amountOfPlayersText.AutoSize = true;
            this.amountOfPlayersText.Location = new System.Drawing.Point(105, 279);
            this.amountOfPlayersText.Name = "amountOfPlayersText";
            this.amountOfPlayersText.Size = new System.Drawing.Size(13, 13);
            this.amountOfPlayersText.TabIndex = 6;
            this.amountOfPlayersText.Text = "0";
            // 
            // AddToTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 331);
            this.Controls.Add(this.amountOfPlayersText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addPlayersList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.teamDropdown);
            this.Controls.Add(this.label1);
            this.Name = "AddToTeam";
            this.Text = "AddToTeam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddToTeam_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teamDropdown;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox addPlayersList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label amountOfPlayersText;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}