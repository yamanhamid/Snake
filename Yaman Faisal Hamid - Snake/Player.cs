using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaman_Faisal_Hamid___Snake
{
    public class Player
    {
        // Instance Variables
        /// <summary>
        /// The players name
        /// </summary>
        private string _playerName;
        /// <summary>
        /// The players score
        /// </summary>
        private int _playerScore;

        // Constructor
        public Player()
        {
            _playerName = "";
        }

        // Properties
        /// <summary>
        /// The players name
        /// </summary>
        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        /// <summary>
        /// The players score
        /// </summary>
        public int PlayerScore
        {
            get { return _playerScore; }
            set { _playerScore = value; }
        }
    }
}
