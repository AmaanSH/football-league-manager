using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League_Manager
{
    [Serializable]
    class Game
    {
        private Player[] _homeLineUp;
        private Player[] _awayLineUp;
        private Team _homeTeam;
        private Team _awayTeam;
        private string _venue;
        private string _date;
        private string _gameID;

        public Game(Team home, Team away, Player[] homeLineUp, Player[] awayLineUp, string venue, string date, Action<bool> callback)
        {
            List<Game> homeTeamGames = home.GetUpcomingGames();
            List<Game> awayTeamGames = away.GetUpcomingGames();

            if (homeTeamGames.Count > 0 && awayTeamGames.Count > 0)
            {
                if (homeTeamGames.Find(x => x._date == date) != null || awayTeamGames.Find(x => x._date == date) != null)
                {
                    callback(false);
                }
            }
            else
            {
                _homeLineUp = homeLineUp;
                _awayLineUp = awayLineUp;

                _homeTeam = home;
                _awayTeam = away;

                _venue = venue;
                _date = date;

                _gameID = GenerateGameID(home, away, date);

                callback(true);
            }
        }

        /// <summary>
        /// Getter for game ID
        /// </summary>
        /// <returns>Specified game's ID</returns>
        public string GetID()
        {
            return _gameID;
        }

        /// <summary>
        /// Getter for home team for the current game
        /// </summary>
        /// <returns></returns>
        public string GetHomeTeam()
        {
            return _homeTeam.GetName();
        }

        /// <summary>
        /// Getter for away team for the current game
        /// </summary>
        /// <returns></returns>
        public string GetAwayTeam()
        {
            return _awayTeam.GetName();
        }

        /// <summary>
        /// Getter for venue for the current game
        /// </summary>
        /// <returns></returns>
        public string GetVenue()
        {
            return _venue;
        }

        /// <summary>
        /// Getter for the date for current game
        /// </summary>
        /// <returns></returns>
        public string GetDate()
        {
            return _date;
        }

        /// <summary>
        /// Getter for the home team's line up
        /// </summary>
        /// <returns></returns>
        public Player[] GetHomeLineup()
        {
            return _homeLineUp;
        }

        /// <summary>
        /// Getter for the away team's line up
        /// </summary>
        /// <returns></returns>
        public Player[] GetAwayLineup()
        {
            return _awayLineUp;
        }

        /// <summary>
        /// Generate a unique ID for the game
        /// </summary>
        /// <param name="homeTeam">The home team</param>
        /// <param name="awayTeam">The away team</param>
        /// <param name="date">Date the match will occur</param>
        /// <returns>generated ID</returns>
        private string GenerateGameID(Team homeTeam, Team awayTeam, string date)
        {
            string homeCode = homeTeam.GetCode();
            string awayCode = awayTeam.GetCode();

            return homeCode + "v" + awayCode + date;
        }
    }
}
