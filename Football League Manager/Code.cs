using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League_Manager
{
    [Serializable]
    static class Code
    {
        private static int _playerCodeInt = 0;
        private static int _teamCodeInt = 0;

        /// <summary>
        /// Assign player with a unique player code
        /// </summary>
        /// <param name="surname"></param>
        public static string SetPlayerCode(string surname)
        {
            string threeLetters;

            if (surname.Length < 3)
                threeLetters = surname.ToUpper();

            else
                threeLetters = surname.Substring(0, 3).ToUpper();

            string codeString = _playerCodeInt.ToString();
            string code = threeLetters + codeString.PadLeft(4, '0');

            _playerCodeInt += 1;

            return code;
        }

        /// <summary>
        /// Assign a team with a unique code
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        public static string SetTeamCode(string team)
        {
            string threeLetters;

            if (team.Length < 3)
                threeLetters = team;
            else
                threeLetters = team.Substring(0, 3).ToUpper();

            string codeString = _teamCodeInt.ToString();
            string code = codeString.PadLeft(3, '0') + threeLetters;

            _teamCodeInt += 1;

            Save();

            return code;
        }

        public static List<int> GetCodes()
        {
            List<int> codeList = new List<int>();

            codeList.Add(_playerCodeInt);
            codeList.Add(_teamCodeInt);

            return codeList;

        }

        /// <summary>
        /// Set the code values from a previous state
        /// </summary>
        /// <param name="playerCode">player code int to load</param>
        /// <param name="teamCode">team code int to load</param>
        public static void SetCodeValues(List<int> codes)
        {
            _playerCodeInt = codes[0];
            _teamCodeInt = codes[1];
        }

        /// <summary>
        /// Save the current stored IDs
        /// </summary>
        public static void Save()
        {
            List<int> intList = new List<int>();

            intList.Add(_playerCodeInt);
            intList.Add(_teamCodeInt);

            Data.SaveList("code.dat", intList);
        }
    }
}
