using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League_Manager
{
    [Serializable]
    class Player
    {
        private string _forename;
        private string _surname;
        private string _playerCode;
        private string _teamName;
        private bool _isOnLineUp;
        private bool _isSigned;
        private bool _isInjured;

        #region Constructor

        /// <summary>
        /// Constructor for Player class
        /// </summary>
        /// <param name="forename">Player's forename</param>
        /// <param name="surname">Player's surname</param>
        public Player(string forename, string surname, Action<bool> callback)
        {
            if (!League.DoesPlayerExist(forename + " " + surname))
            {
                // assign forename and surname to player
                _forename = forename;
                _surname = surname;

                // setting default values
                _isOnLineUp = false;
                _isSigned = false;
                _teamName = "";
                _isInjured = false;

                _playerCode = Code.SetPlayerCode(surname);

                callback(true);
            }
            else
            {
                callback(false);
            }

        }

        #endregion

        #region Getters

        /// <summary>
        /// Getter for player's name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return _forename + " " + _surname;
        }

        /// <summary>
        /// Getter for player's code
        /// </summary>
        /// <returns>player code</returns>
        public string GetCode()
        {
            return _playerCode;
        }

        /// <summary>
        /// Getter for player's team
        /// </summary>
        /// <returns>the name of the team player is signed too</returns>
        public string GetTeamSignedTo()
        {
            return _teamName;
        }

        /// <summary>
        /// Getter for current player's team sign status
        /// </summary>
        /// <returns>true/false for isSigned</returns>
        public bool GetSignedStatus()
        {
            return _isSigned;
        }

        /// <summary>
        /// Getter to check if player is already included on a line up
        /// </summary>
        /// <returns>true/false for isOnLineUp</returns>
        public bool IsOnLineUp()
        {
            return _isOnLineUp;
        }

        /// <summary>
        /// Getter for player's injured status
        /// </summary>
        /// <returns>true/false for isInjured</returns>
        public bool IsInjured()
        {
            return _isInjured;
        }
        #endregion

        #region Setters

        /// <summary>
        /// Assign player to specified team
        /// </summary>
        /// <param name="teamName"></param>
        public void AssignToTeam(string teamName)
        {
            _teamName = teamName;
            _isSigned = true;
        }

        /// <summary>
        /// Remove specified player from a team
        /// </summary>
        public void RemoveFromTeam()
        {
            _teamName = "";
            _isSigned = false;
        }

        /// <summary>
        /// Change player's line up status
        /// </summary>
        /// <param name="status"></param>
        public void SetLineUpStatus(bool status)
        {
            _isOnLineUp = status;
        }

        /// <summary>
        /// Change player's injury status
        /// </summary>
        /// <param name="status">true/false</param>
        public void SetInjuredFlag(bool status)
        {
            _isInjured = status;
        }

        #endregion
    }
}
