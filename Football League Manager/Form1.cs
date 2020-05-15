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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // load the contents of dat files
            League.LoadState();

            // set values to the dropdownlists
            foreach(var player in League.GetAllPlayers())
            {
                playerListbox.Items.Add(player.GetName());
            }

            foreach(var team in League.GetAllTeams())
            {
                teamListBox.Items.Add(team.GetName());
            }                   
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // remove whitespace from the text box fields, may cause issues
            string forename = forenameText.Text.Trim();
            string surname = surnameText.Text.Trim();

            if (string.IsNullOrEmpty(forename) || string.IsNullOrEmpty(surname))
            {
                Dialog.Show("Fields cannot be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool valid = false;

                Player player = new Player(forename, surname, result => {
                    valid = result;
                });

                if (valid)
                {
                    League.AddPlayerToList(player);

                    Dialog.Status(string.Format("Player {0} - {1} added", player.GetName(), player.GetCode()), statusLabelPlayer);
                    Dialog.Show(string.Format("Player {0} - {1} added", player.GetName(), player.GetCode()), "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    playerListbox.Items.Add(player.GetName());
                }
                else
                {
                    Dialog.Status("Player with that name already exists!", statusLabelPlayer);
                    Dialog.Show("Player with that name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void TeamSubmit_Click(object sender, EventArgs e)
        {
            // remove whitespace from the text box fields, may cause issues
            string teamName = teamNameBox.Text.Trim();
            string venue = venueTextBox.Text.Trim();

            bool valid = false;

            if (string.IsNullOrEmpty(teamName) || string.IsNullOrEmpty(venue))
            {
                Dialog.Show("Fields cannot be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Team team = new Team(teamName, venue, result => { valid = result; });

                if (!valid)
                {
                    Dialog.Status("Team with that name already exists!", statusLabelTeam);
                }
                else
                {
                    League.AddTeamToList(team);

                    Dialog.Status(string.Format("Team {0} - {1} added!", team.GetName(), team.GetCode()), statusLabelTeam);
                    Dialog.Show(string.Format("Team {0} - {1} added!", team.GetName(), team.GetCode()), "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    teamListBox.Items.Add(team.GetName());
                }
            }
        }

        private void PlayerListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removePlayerButton.Enabled = true;
        }

        private void TeamListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamRemoveButton.Enabled = true;
            teamManagerButton.Enabled = true;
        }

        private void RemovePlayerButton_Click(object sender, EventArgs e)
        {
            Player player = League.GetPlayerWithName(playerListbox.SelectedItem.ToString());

            if (player != null)
            {
                if (!player.IsOnLineUp())
                {
                    if (League.RemovePlayerFromList(player))
                    {
                        playerListbox.Items.Remove(playerListbox.SelectedItem);
                        removePlayerButton.Enabled = false;
                    }
                }
                else
                {
                    Dialog.Show(string.Format("Player {0} cannot be removed as they are expected to play a game", player.GetName()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void TeamRemoveButton_Click(object sender, EventArgs e)
        {
            Team team = League.GetTeamWithName(teamListBox.SelectedItem.ToString());

            if (team != null)
            {
                if (team.GetUpcomingGames().Count == 0)
                {
                    if (League.RemoveTeamFromList(team))
                    {
                        teamListBox.Items.Remove(teamListBox.SelectedItem);

                        teamRemoveButton.Enabled = false;
                        teamManagerButton.Enabled = false;
                    }
                }
                else
                {
                    Dialog.Show("Team is expected to play a game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void TeamManagerButton_Click(object sender, EventArgs e)
        {
            Team team = League.GetTeamWithName(teamListBox.SelectedItem.ToString());

            List<Player> playersInTeam = team.GetPlayers();
            List<string> playerNames = new List<string>();

            for (int i = 0; i < playersInTeam.Count; i++)
            {
                playerNames.Add(playersInTeam[i].GetName());
            }

            TeamManager teamManagerForm = new TeamManager(team.GetName(), team.GetCode(), team.GetVenue(), playerNames);

            teamManagerForm.Show();
        }

        private void AddToTeam_Click(object sender, EventArgs e)
        {
            List<string> teamNames = new List<string>();

            for (int i = 0; i < teamListBox.Items.Count; i++)
            {
                teamNames.Add(teamListBox.Items[i].ToString());
            }

            AddToTeam addToTeam = new AddToTeam(teamNames, false, new ListBox());
            addToTeam.Show();
        }

        private void CreateGameButton_Click(object sender, EventArgs e)
        {
            List<string> teamNames = new List<string>();

            for (int i = 0; i < teamListBox.Items.Count; i++)
            {
                teamNames.Add(teamListBox.Items[i].ToString());
            }

            GameCreation gameCreation = new GameCreation(teamNames);
            gameCreation.Show();
        }

        /// <summary>
        /// Save the state of the program before closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // store the teams into the dat file
            Data.SaveList("teams.dat", League.GetAllTeams());

            // store the players into the dat file
            Data.SaveList("players.dat", League.GetAllPlayers());

            // save the games into the dat file
            Data.SaveList("games.dat", League.GetAllGames());

            // store the current codes into the dat file
            Code.Save();
        }
    }
}
