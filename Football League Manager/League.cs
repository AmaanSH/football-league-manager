using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_League_Manager
{
    [Serializable]
    static class League
    {
        private static List<Team> _teams = new List<Team>();
        private static List<Player> _players = new List<Player>();
        private static List<Game> _games = new List<Game>();

        #region Getters

        /// <summary>
        /// Return a list of teams
        /// </summary>
        /// <returns>List of teams</returns>
        public static List<Team> GetAllTeams()
        {
            return _teams;
        }

        /// <summary>
        /// Get team from given team name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>null or team</returns>
        public static Team GetTeamWithName(string name)
        {
            Team result = _teams.Find(x => x.GetName() == name);
            return result;
        }

        /// <summary>
        /// Return a list of players
        /// </summary>
        /// <returns>List of players</returns>
        public static List<Player> GetAllPlayers()
        {
            return _players;
        }

        /// <summary>
        /// Returns a list of all the unsigned players
        /// </summary>
        /// <returns>A list of players</returns>
        public static List<Player> GetUnsignedPlayers()
        {
            List<Player> result = _players.FindAll(x => x.GetSignedStatus() == false);
            return result;
        }

        /// <summary>
        /// Gets a player from a team with the name given
        /// </summary>
        /// <param name="name"></param>
        /// <returns>player or null</returns>
        public static Player GetPlayerFromTeam(string name)
        {
            // find the player and get what team they're on
            Player player = _players.Find(x => x.GetName() == name);
            string currentTeam = player.GetTeamSignedTo();

            // find the team in question
            Team team = GetTeamWithName(currentTeam);

            // find the player object for that team
            List<Player> players = team.GetPlayers();
           
            return players.Find(x => x.GetName() == name);
        }

        /// <summary>
        /// Get the player object from the name given
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Player GetPlayerWithName(string name)
        {
            return _players.Find(x => x.GetName() == name);
        }

        /// <summary>
        /// Gets player with name given
        /// </summary>
        /// <param name="name"></param>
        /// <returns>player or null</returns>
        /*public static Player GetPlayerWithName(string name)
        {
           return _players.Find(x => x.GetName() == name);
        }*/

        /// <summary>
        /// Returns a list of games
        /// </summary>
        /// <returns>List of games</returns>
        public static List<Game> GetAllGames()
        {
            return _games;
        }

        /// <summary>
        /// Get a game with given ID
        /// </summary>
        /// <param name="gameId">The ID to look for</param>
        /// <returns></returns>
        public static Game GetGameWithID(string gameId)
        {
            return _games.Find(x => x.GetID() == gameId);
        }

        /// <summary>
        /// Checks to see if a player exists
        /// </summary>
        /// <param name="playerName">Player's name</param>
        /// <returns></returns>
        public static bool DoesPlayerExist(string playerName)
        {
            Player result = _players.Find(x => x.GetName() == playerName);

            if (result != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Checks to see if a team already exists
        /// </summary>
        /// <param name="teamName">The name of the team to check</param>
        /// <returns></returns>
        public static bool DoesTeamExist(string teamName)
        {
            Team result = _teams.Find(x => x.GetName() == teamName);

            if (result != null)
                return true;
            else
                return false;
        }

        #endregion

        #region Setters

        /// <summary>
        /// Load the previous state of the program
        /// </summary>
       public static void LoadState()
        {
            // find all .dat files in the applications root directory
            DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath);

            foreach (var file in directoryInfo.GetFiles("*.dat"))
            {
                switch(file.Name)
                {
                    case "players.dat":
                        List<Player> dummy = new List<Player>();
                        _players = Data.LoadList(file.FullName, dummy);
                        break;
                    case "teams.dat":
                        List<Team> teamDummyList = new List<Team>();
                        _teams = Data.LoadList(file.FullName, teamDummyList);
                        break;
                    case "games.dat":
                        List<Game> gameDummyList = new List<Game>();
                        _games = Data.LoadList(file.FullName, gameDummyList);
                        break;
                    case "code.dat":
                        List<int> codeDummyList = new List<int>();
                        Code.SetCodeValues(Data.LoadList(file.FullName, codeDummyList));
                        break;
                }
            }
        }

        /// <summary>
        /// Remove the passed in player from the player List on team
        /// </summary>
        /// <param name="player">player to remove</param>
        public static void RemovePlayerFromTeamList(Player player)
        {
            // find the player and get what team they're on
            Team team = GetTeamWithName(player.GetTeamSignedTo());

            // find the player object for that team
            List<Player> players = team.GetPlayers();

            // remove from the list
            players.Remove(player);
        }

        /// <summary>
        /// Add a team to the list
        /// </summary>
        /// <param name="team">The team object</param>
        /// <returns>bool value to show success</returns>
        public static bool AddTeamToList(Team team)
        {
            if (_teams.Contains(team))
                return false;
            else
            {
                _teams.Add(team);
                Data.SaveList("teams.dat", _teams);
                return true;
            }
        }

        /// <summary>
        /// Add player to the players list
        /// </summary>
        /// <param name="player"> the player you want to add</param>
        /// <returns>bool value to show success</returns>
        public static bool AddPlayerToList(Player player)
        {
            if (_players.Contains(player))
            {
                return false;
            }
            else
            {
                _players.Add(player);
                Data.SaveList("players.dat", _players);
                return true;
            }
        }

        /// <summary>
        /// Update the player in the players list
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool UpdatePlayerInList(Player player)
        {
            if (_players.Contains(player))
            {
                Player playerToUpdate = _players.Find(x => x.GetName() == player.GetName());

                _players.Remove(playerToUpdate);
                _players.Add(player);

                Data.SaveList("players.dat", _players);

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Add game to the list of games
        /// </summary>
        /// <param name="game">the game to add</param>
        /// <returns>bool value to show success</returns>
        public static bool AddGameToList(Game game)
        {
            if (_games.Contains(game))
            {
                return false;
            }
            else
            {
                _games.Add(game);
                Data.SaveList("games.dat", _games);
                return true;
            }
        }

        /// <summary>
        /// Remove a team from the teams list
        /// </summary>
        /// <param name="team">The team object to remove</param>
        /// <returns></returns>
        public static bool RemoveTeamFromList(Team team)
        {
            if (_teams.Contains(team))
            {
                // was anyone on this team? if so, mark them as free agent
                List<Player> result = _players.FindAll(x => x.GetTeamSignedTo() == team.GetName());

                if (result != null)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        result[i].RemoveFromTeam();
                    }
                }
                
                _teams.Remove(team);
                Data.SaveList("teams.dat", _teams);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Remove a player from the player list
        /// </summary>
        /// <param name="player">player to look for</param>
        /// <returns></returns>
        public static bool RemovePlayerFromList(Player player)
        {
            if (_players.Contains(player))
            {
                Team team = _teams.Find(x => x.GetName() == player.GetTeamSignedTo());

                // unassign player from team before removing
                if (team != null)
                {
                    team.RemovePlayer(player);
                }

                _players.Remove(player);
                Data.SaveList("players.dat", _players);

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Save all the changes to the program before quitting
        /// </summary>
        public static void SaveAndExit()
        {
            // store the teams into the dat file
            Data.SaveList("teams.dat", GetAllTeams());

            // store the players into the dat file
            Data.SaveList("players.dat", GetAllPlayers());

            // save the games into the dat file
            Data.SaveList("games.dat", GetAllGames());

            // store the current codes into the dat file
            Data.SaveList("code.dat", Code.GetCodes());
        }

        #endregion
    }
}
