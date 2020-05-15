using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League_Manager
{
    class LineUp
    {
        public int currentlySelected = 0;
        private Player[] _lineup;

        public LineUp(Player[] players, Action<bool> callback)
        {
            if (players.Length < 11)
            {
                callback(false);
            }
            else
            {
                // making new array with 11 slots
                _lineup = new Player[11];

                for (var i = 0; i < players.Length; i++)
                {
                    _lineup[i] = players[i];
                }

                callback(true);
            }
        }
    }
}
