using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_League_Manager
{
    public partial class TeamManager : Form
    {
        public TeamManager(string teamName, string teamCode, string venue, List<string> players)
        {
            InitializeComponent();

            Team team = League.GetTeamWithName(teamName);
        
            if (team != null)
            {
                List<Game> upcomingGames = team.GetUpcomingGames();

                if (upcomingGames != null)
                {
                    for (int i = 0; i < upcomingGames.Count; i++)
                    {
                        //team.RemoveGame(upcomingGames[i]);
                        upcomingGameList.Items.Add(upcomingGames[i].GetID());
                    }
                }
            }

            teamNameBox.Text = teamName;
            teamCodeBox.Text = teamCode;
            venueTextBox.Text = venue;

            for (int i = 0; i < players.Count; i++)
            {
                teamPlayerBox.Items.Add(players[i]);
            }
        }

        private void TeamManager_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<string> team = new List<string>();

            team.Add(teamNameBox.Text);

            AddToTeam addToTeam = new AddToTeam(team, true, teamPlayerBox);

            addToTeam.Show();
        }

        public void RefreshPlayerList(object item)
        {
            teamPlayerBox.Items.Add(item);
        }

        private void TeamPlayerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamPlayerBox.SelectedItem != null)
            {
                Player player = League.GetPlayerFromTeam(teamPlayerBox.SelectedItem.ToString());

                if (player != null)
                {
                    playerNameLabel.Text = player.GetName();
                    playerCode.Text = player.GetCode();
                    onLineupCheck.Checked = player.IsOnLineUp();

                    if (player.IsInjured())
                    {
                        injuredRadioButton.Checked = true;
                        fitRadioButton.Checked = false;
                    }
                    else
                    {
                        injuredRadioButton.Checked = false;
                        fitRadioButton.Checked = true;
                    }

                    playerPanel.Visible = false;
                }
            }
        }

        private void UpdateStatus_Click(object sender, EventArgs e)
        {
            Player player = League.GetPlayerFromTeam(teamPlayerBox.SelectedItem.ToString());

            if (player != null)
            {
                if (injuredRadioButton.Checked)
                {
                    player.SetInjuredFlag(true);
                    Dialog.Status("Set status to Injured", statusUpdateLabel);
                    Dialog.Show(string.Format("Set status to Injured for player {0}", player.GetName()), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
                else
                {
                    player.SetInjuredFlag(false);
                    Dialog.Status("Set status to Fit", statusUpdateLabel);
                    Dialog.Show(string.Format("Set status to Fit for player {0}", player.GetName()), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Player player = League.GetPlayerFromTeam(teamPlayerBox.SelectedItem.ToString());

            if (player != null)
            {
                if (!player.IsOnLineUp())
                {
                    // remove from player listbox
                    teamPlayerBox.Items.Remove(teamPlayerBox.SelectedItem);

                    // remove player from the team players
                    League.RemovePlayerFromTeamList(player);

                    // unassign the player from the team
                    player.RemoveFromTeam();

                    // update player inside of the player list in League
                    League.UpdatePlayerInList(player);

                    playerPanel.Visible = true;
                }
                else
                {
                    Dialog.Show(string.Format("Player {0} cannot be removed as they are expected to play a game", player.GetName()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpcomingGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game game = League.GetGameWithID(upcomingGameList.SelectedItem.ToString());

            gameTitle.Text = game.GetHomeTeam() + " v " + game.GetAwayTeam();
            gameCodeText.Text = game.GetID();

            if (game.GetHomeTeam() == teamNameBox.Text)
            {
                Player[] playerList = game.GetHomeLineup();

                for (int i = 0; i < playerList.Length; i++)
                {
                    lineupList.Items.Add(playerList[i].GetName());
                }
            }
            else
            {
                Player[] playerList = game.GetAwayLineup();

                for (int i = 0; i < playerList.Length; i++)
                {
                    lineupList.Items.Add(playerList[i].GetName());
                }
            }

            dateTextBox.Text = game.GetDate();

            gamePanel.Hide();
        }

        private void TeamManager_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
