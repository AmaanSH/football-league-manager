using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League_Manager
{
    [Serializable]
    class Team
    {
        private List<Player> _players;
        private string _teamName;
        private string _venue;
        private string _teamCode;
        private List<Game> _upcomingGames;
        //private string _upcomingGameID;
        //private string _dateOfUpcomingGame;

        #region Constructor
        public Team(string teamName, string venue, Action<bool> callback)
        {
            if (!League.DoesTeamExist(teamName))
            {
                // assign teamname and venue properties
                _teamName = teamName;
                _venue = venue;

                // create empty players list
                _players = new List<Player>();

                _upcomingGames = new List<Game>();

                _teamCode = Code.SetTeamCode(teamName);

                callback(true);
            }
            else
            {
                callback(false);
            }
        }

        #endregion

        #region Getters

        public List<Player> GetPlayers()
        {
            return _players;
        }

        public string GetName()
        {
            return _teamName;
        }

        public string GetCode()
        {
            return _teamCode;
        }

        public List<Game> GetUpcomingGames()
        {
            return _upcomingGames;
        }

        public string GetVenue()
        {
            return _venue;
        }

        #endregion

        #region Setters

        public void AssignToGame(Game game)
        {
            _upcomingGames.Add(game);
            
            if (game.GetHomeTeam() == _teamName)
            {
                Player[] HomeCompetingPlayers = game.GetHomeLineup();

                for (var i = 0; i < HomeCompetingPlayers.Length; i++)
                {
                    Player playerToSetLineUp = _players.Find(x => x.GetName() == HomeCompetingPlayers[i].GetName());
                    playerToSetLineUp.SetLineUpStatus(true);
                }
            }
            else
            {
                Player[] awayCompetingPlayers = game.GetAwayLineup();

                for (var i = 0; i < awayCompetingPlayers.Length; i++)
                {
                    Player playerToSetLineUp = _players.Find(x => x.GetName() == awayCompetingPlayers[i].GetName());
                    playerToSetLineUp.SetLineUpStatus(true);
                }
            }
        }

        public void RemoveGame(Game game)
        {
            _upcomingGames.Remove(game);
        }

        public bool AddPlayer(Player player)
        {
            if (!player.GetSignedStatus())
            {
                // assign team to the player object
                player.AssignToTeam(_teamName);

                // add player to the players list
                _players.Add(player);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemovePlayer(Player player)
        {

            Player p = _players.Find(x => x.GetName() == player.GetName());

            if (p != null)
            {
                // remove player from the players list inside of the team
                _players.Remove(p);

                // unassign the team in the player object
                player.RemoveFromTeam();

                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
