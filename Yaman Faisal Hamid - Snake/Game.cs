using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaman_Faisal_Hamid___Snake
{
    public partial class Game : Form
    {
        // Variables
        /// <summary>
        /// List for storing all the snake parts
        /// </summary>
        private List<Snake> _listSnake = new List<Snake>();
        /// <summary>
        /// List for storing the apples
        /// </summary>
        private List<Apple> _listApple = new List<Apple>();
        /// <summary>
        /// Creates a new apples
        /// </summary>
        private Apple _apple = new Apple();
        /// <summary>
        /// Creates a new snake
        /// </summary>
        private Snake _snake = new Snake();
        /// <summary>
        /// Creates a new player
        /// </summary>
        private Player _player = new Player();
        /// <summary>
        /// Creates a new scoreboard
        /// </summary>
        private Scoreboard _scoreboard = new Scoreboard();
        /// <summary>
        /// Max width for the form 
        /// </summary>
        int maxWidth;
        /// <summary>
        /// Max height for the form 
        /// </summary>
        int maxHeight;
        /// <summary>
        /// New random 
        /// </summary>
        Random rand = new Random();
        /// <summary>
        /// Bool for the directions
        /// </summary>
        bool left, right, down, up;

        // Constructor
        /// <summary>
        /// Creates and initialises the game and stores the values for the combo box
        /// </summary>
        public Game()
        {
            InitializeComponent();
            _comboBox.DataSource = Enum.GetValues(typeof(Speed));
        }

        // Event Handlers
        /// <summary>
        /// The event handler for painting the snake and apple on the picture box
        /// </summary>
        private void PictureBoxPaint(object sender, PaintEventArgs e)
        {
            // Creates new graphics paper on the picture box
            Graphics paper = e.Graphics;

            // Creates new brushes for the snake and apple
            Brush snakeColour;
            Brush appleColour = Brushes.Red;

            // For the whole list of snake parts 
            for (int i = 0; i < _listSnake.Count; i++)
            {
                // If index is 0 make brush colour black otherwise make it green
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }

                // Calls the snakes Draw() method and draws the snake parts 
                _snake.Draw(snakeColour, paper, _listSnake[i].X * Snake.Width, _listSnake[i].Y * Snake.Height, Snake.Width, Snake.Height);
            }

            // Calls the apple Draw() method and draws the apple
            _apple.Draw(appleColour, paper, _apple.X * Snake.Width, _apple.Y * Snake.Height, Snake.Width, Snake.Height);
        }

        /// <summary>
        /// The event handler for the key press from the user
        /// </summary>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            // Registers if keys W, A, S, D are pressed and ensures they dont conflict and then makes their respective boolean true
            if (e.KeyCode == Keys.A && Snake.direction != "right")
            {
                left = true;
            }
            if (e.KeyCode == Keys.D && Snake.direction != "left")
            {
                right = true;
            }
            if (e.KeyCode == Keys.W && Snake.direction != "down")
            {
                up = true;
            }
            if (e.KeyCode == Keys.S && Snake.direction != "up")
            {
                down = true;
            }
        }

        /// <summary>
        /// The event handler for when the key is released by the user
        /// </summary>
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // Registers if keys W, A, S, D are released and then makes their respective boolean false
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            if (e.KeyCode == Keys.W)
            {
                up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down = false;
            }
        }

        /// <summary>
        /// Tick event handler of the animation timer
        /// </summary>
        private void GameTimerTick(object sender, EventArgs e)
        {
            // Setting the direction from the boolean of each direction
            if (left)
            {
                Snake.direction = "left";
            }
            if (right)
            {
                Snake.direction = "right";
            }
            if (down)
            {
                Snake.direction = "down";
            }
            if (up)
            {
                Snake.direction = "up";
            }

            // Setting the speed. The user selects a speed from the combo box and the interval for the game timer decreases or increases
            if (_comboBox.Text == "EASY")
            {
                _gameTimer.Interval = 100;
            }
            else if (_comboBox.Text == "MEDIUM")
            {
                _gameTimer.Interval = 50;
            }
            else if (_comboBox.Text == "HARD")
            {
                _gameTimer.Interval = 10;
            }

            // For the snake list
            for (int i = _listSnake.Count - 1; i >= 0; i--)
            {
                // If index is 0
                if (i == 0)
                {
                    // Switch statemen tests the code to seewhat direction is selected and then moves the head of the snake
                    switch (Snake.direction)
                    {
                        case "left":
                            _listSnake[i].X--;
                            break;
                        case "right":
                            _listSnake[i].X++;
                            break;
                        case "down":
                            _listSnake[i].Y++;
                            break;
                        case "up":
                            _listSnake[i].Y--;
                            break;
                    }

                    // If the head of the snake collides with an apple then a point is added to score
                    if (_listSnake[i].X == _apple.X && _listSnake[i].Y == _apple.Y)
                    {
                        Score();
                    }

                    // If the head of the snake collides with the boundaries of the picture box then the player loses
                    if (_listSnake[0].X < 0 || _listSnake[0].Y < 0 || _listSnake[0].X > 580 || _listSnake[0].Y > 680)
                    {
                        Lose();
                    }

                    // If the head of the snake collides with the body parts of the snake then the player loses
                    for (int j = 1; j < _listSnake.Count; j++)
                    {
                        if (_listSnake[i].X == _listSnake[j].X && _listSnake[i].Y == _listSnake[j].Y)
                        {
                            Lose();
                        }
                    }
                }
                else
                {
                    // The body parts follow the head of the snake
                    _listSnake[i].X = _listSnake[i - 1].X;
                    _listSnake[i].Y = _listSnake[i - 1].Y;
                }
            }

            // Resets the pictureBox making the paint event trigger
            _pictureBox.Invalidate();
        }

        /// <summary>
        /// Event handler for clicking the start button
        /// </summary>
        private void ButtonStartClick(object sender, EventArgs e)
        {
            // Calls the Start() method
            Start();
        }

        /// <summary>
        /// Event handler for clicking the reset button
        /// </summary>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            // Calls the start method 
            Start();
            
            // Changes the label of the high score
            _labelHighScore.Text = "High Score: " + _player.PlayerName + " " + _scoreboard.HighScore;

            // Sets the score to 0 and changes its label
            _scoreboard.Score = 0;
            _labelScore.Text = "Score: " + _player.PlayerName + " 0";
        }

        /// <summary>
        /// Event handler for clicking the pause button
        /// </summary>
        private void ButtonPauseClick(object sender, EventArgs e)
        {
            // Stops the game timer
            _gameTimer.Stop();
        }

        /// <summary>
        /// Event handler for clicking the resume button
        /// </summary>
        private void ButtonResumeClick(object sender, EventArgs e)
        {
            // Starts the game timer
            _gameTimer.Start();
        }
        
        // Private Methods
        /// <summary>
        /// This method starts the game
        /// </summary>
        private void Start()
        {
            // Disables the Start button
            _buttonStart.Enabled = false;

            // Sets the max width and height
            maxWidth = _pictureBox.Width / Snake.Width - 1;
            maxHeight = _pictureBox.Height / Snake.Height - 1;

            // The text entered into the textbox becomes the player name
            _player.PlayerName = _textBoxPlayerName.Text;

            // Clears the snake and apple list
            _listSnake.Clear();
            _listApple.Clear();

            // Creates a new head and adds it to the snake list
            Snake head = new Snake { X = 10, Y = 5 };
            _listSnake.Add(head); // adding the head part of the snake to the list

            // Creates 5 new body parts and adds it to the snake list
            for (int i = 0; i < 5; i++)
            {
                Snake body = new Snake();
                _listSnake.Add(body);
            }

            // Creates an apple in a random position on the picturebox
            _apple = new Apple { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            _listApple.Add(_apple);

            // Starts the timer
            _gameTimer.Start();
        }

        /// <summary>
        /// This method keeps the score
        /// </summary>
        private void Score()
        {
            // Increases score by one and updates the label
            _scoreboard.Score += 1;
            _labelScore.Text = "Score: " + _player.PlayerName + " " + _scoreboard.Score;

            // Adds a new snake part at the end of the snake
            Snake body = new Snake { X = _listSnake[_listSnake.Count - 1].X, Y = _listSnake[_listSnake.Count - 1].Y };
            _listSnake.Add(body);

            // Creates a new apple and adds it to the list
            _apple = new Apple { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            _listApple.Add(_apple);

            // Sets the direction
            if (Snake.direction == "left")
            {
                Snake.direction = "right";
            }
            if (Snake.direction == "right")
            {
                Snake.direction = "left";
            }
            if (Snake.direction == "up")
            {
                Snake.direction = "down";
            }
            if (Snake.direction == "down")
            {
                Snake.direction = "up";
            }
        }

        /// <summary>
        /// This method is for when the user loses
        /// </summary>
        private void Lose()
        {
            // Stops the gametimer and displays message
            _gameTimer.Stop();
            MessageBox.Show("You lose :(");

            // If the score is greater than the high score then change the highscore
            if (_scoreboard.Score > _scoreboard.HighScore)
            {
                _scoreboard.HighScore = _scoreboard.Score;
                _labelHighScore.Text = "High Score: " + _player.PlayerName + " " + _scoreboard.HighScore;
            }

            // Resest the score and label
            _scoreboard.Score = 0;
            _labelScore.Text = "Score: " + _player.PlayerName + " 0";

            // Clears the snake list and calls the Start() method
            _listSnake.Clear();
            Start();
        }
    }
}
