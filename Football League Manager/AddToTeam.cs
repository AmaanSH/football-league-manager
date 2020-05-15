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
    public partial class AddToTeam : Form
    {
        public ListBox listBox;

        public AddToTeam(List<string> teams, bool selected, ListBox playerListBox)
        {
            InitializeComponent();

            // add teams to team dropdown
            for (int i = 0; i < teams.Count; i++)
            {
                teamDropdown.Items.Add(teams[i]);
            }

            // pre selects the team if adding player from the team manager
            if (selected)
            {
                teamDropdown.SelectedItem = teams[0];
                teamDropdown.Enabled = false;

                // once we're done here, need to update the listbox from Team Manager
                listBox = playerListBox;
            }
                          
            // only want players who are able to be signed to another team
            List<Player> players = League.GetUnsignedPlayers();

            for (var i = 0; i < players.Count; i++)
            {
                addPlayersList.Items.Add(players[i].GetName());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Team team = League.GetTeamWithName(teamDropdown.SelectedItem.ToString());

            foreach (var playerToAdd in addPlayersList.CheckedItems)
            {
                Player player = League.GetPlayerWithName(playerToAdd.ToString());

                if (player != null && team != null)
                {
                    team.AddPlayer(player);
                    League.UpdatePlayerInList(player);
                }
            }

            // save teams after updating
            Data.SaveList("teams.dat", League.GetAllTeams());
            Close();
        }

        private void AddPlayersList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int amount;

            if (e.NewValue == CheckState.Checked)
            {
                amount = addPlayersList.CheckedItems.Count + 1;
            }
            else
            {
                amount = addPlayersList.CheckedItems.Count - 1;
            }

            if (amount > 0)
                confirmButton.Enabled = true;
            else
                confirmButton.Enabled = false;
            
            amountOfPlayersText.Text = amount.ToString();
        }

        private void AddToTeam_FormClosed(object sender, FormClosedEventArgs e)
        {
            // if the team drop down is disabled, we're going back to Team Manager so refresh listbox
            if (!teamDropdown.Enabled)
            {
                foreach (var player in addPlayersList.CheckedItems)
                {
                    Player playerToAdd = League.GetPlayerWithName(player.ToString());

                    if (player != null)
                    {
                        listBox.Items.Add(playerToAdd.GetName());
                    }
                }

                // return the listbox variable back to empty
                listBox = null;
            }
        }
    }
}
