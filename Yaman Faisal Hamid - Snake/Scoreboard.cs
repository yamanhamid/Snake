using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaman_Faisal_Hamid___Snake
{
    public class Scoreboard
    {
        // Instance Variables
        /// <summary>
        /// The current score of the game
        /// </summary>
        private int _score;
        /// <summary>
        /// The current high score of the game
        /// </summary>
        private int _highScore;

        // Constructor
        public Scoreboard()
        {
            _score = 0;
            _highScore = 0;
        }

        // Properties
        /// <summary>
        /// The current score of the game
        /// </summary>
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        /// <summary>
        /// The current high score of the game
        /// </summary>
        public int HighScore
        {
            get { return _highScore; }
            set { _highScore = value; }
        }
    }
}
