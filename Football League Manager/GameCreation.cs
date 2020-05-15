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
    public partial class GameCreation : Form
    {
        public GameCreation(List<string> teams)
        {
            InitializeComponent();

            for (int i = 0; i < teams.Count; i++)
            {
                homeDropdown.Items.Add(teams[i]);
                awayDropdown.Items.Add(teams[i]);
            }

            // custom date format
            gameDateTime.Format = DateTimePickerFormat.Custom;
            gameDateTime.CustomFormat = "dd-MM-y";
        }


        private void AssignToGame(ComboBox dropdown, ListBox lineupList, ComboBox target)
        {
            var currentlySelected = dropdown.SelectedItem.ToString();

            Team team = League.GetTeamWithName(currentlySelected);
            List<Player> players = team.GetPlayers();

            List<string> playerNames = new List<string>();

            for (int i = 0; i < players.Count; i++)
            {
                if (!players[i].IsInjured() && !players[i].IsOnLineUp())
                    playerNames.Add(players[i].GetName());
            }

            ((ListBox)lineupList).DataSource = playerNames;
            lineupList.Enabled = true;

            dropdown.Enabled = false;

            if (target == awayDropdown)
            {
                playerNames.Remove(currentlySelected);
                target.Items.Remove(currentlySelected);
                target.Enabled = true;
                venueTextbox.Text = team.GetVenue();
            }
        }

        private void HomeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssignToGame(homeDropdown, homeLineupList, awayDropdown);
        }

        private void AwayDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssignToGame(awayDropdown, awayLineupList, homeDropdown);
        }

        private void HomeLineupList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AwayLineupList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            bool success = false;

            if (homeDropdown.SelectedItem == null || awayDropdown.SelectedItem == null)
            {
                Dialog.Show("No team selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // create lineup array
            Player[] homeLineup = new Player[11];
            Player[] awayLineup = new Player[11];
            
            // getting teams that will be playing on the game
            Team home = League.GetTeamWithName(homeDropdown.SelectedItem.ToString());
            Team away = League.GetTeamWithName(awayDropdown.SelectedItem.ToString());

            // formatted date
            string date = gameDateTime.Value.ToString("ddmmy");

            if (homeLineupList.CheckedItems.Count < 11 || awayLineupList.CheckedItems.Count < 11)
            {
                Dialog.Show("Not enough players assigned to lineup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (homeLineupList.CheckedItems.Count > 11 || awayLineupList.CheckedItems.Count > 11)
            {
                Dialog.Show("Too many players assigned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                // adding selected players to the lineup
                AddToLineUp(homeLineupList, homeLineup);
                AddToLineUp(awayLineupList, awayLineup);

                // create the game object, passing in a callback to check if the game was created successfully
                Game game = new Game(home, away, homeLineup, awayLineup, home.GetVenue(), date, result => { success = result; });

                if (success)
                {
                    home.AssignToGame(game);
                    away.AssignToGame(game);

                    League.AddGameToList(game);

                    Dialog.Show(string.Format("Game with ID {0} created successfully. Date {1}. {2} v {3}", game.GetID(), game.GetDate(), game.GetHomeTeam(), game.GetAwayTeam()), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                    Close();
                }
                else
                {
                    Dialog.Show("There is already a game taking place on this date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }                   
        }

        private void AddToLineUp(CheckedListBox listbox, Player[] lineUp)
        {
            if (listbox.CheckedItems.Count == 11)
            {
                bool value = false;

                for (int i = 0; i < listbox.CheckedItems.Count; i++)
                {
                    Player player = League.GetPlayerFromTeam(listbox.SelectedItem.ToString());

                    if (player != null)
                        lineUp[i] = player;
                }

                LineUp lineup = new LineUp(lineUp, result =>
                {
                    value = result;
                });

                if (value)
                {
                    listbox.Enabled = false;
                }
                else
                {
                    Dialog.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HomeLineupList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CountCheck(homeLineupList, homeCount, e);
        }

        private void AwayLineupList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CountCheck(awayLineupList, awayCount, e);
        }

        private void CountCheck(CheckedListBox list, Label update, ItemCheckEventArgs e)
        {
            int count;

            if (e.NewValue == CheckState.Checked)
            {
                count = list.CheckedItems.Count + 1;
            }
            else
            {
                count = list.CheckedItems.Count - 1;
            }

            update.Text = count.ToString();
        }
    }
}
