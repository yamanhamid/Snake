using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaman_Faisal_Hamid___Snake
{
    /// <summary>
    /// Enum for the speed of the snake
    /// </summary>
    public enum Speed { EASY, MEDIUM, HARD }
    internal class Snake
    {
        // Instance Variables
        /// <summary>
        /// The x position of the snake
        /// </summary>
        public int _x;
        /// <summary>
        /// The y position of the snake
        /// </summary>
        public int _y;
        /// <summary>
        /// The width of the snake
        /// </summary>
        public static int Width { get; set; }
        /// <summary>
        /// The height of the snake
        /// </summary>
        public static int Height { get; set; }
        /// <summary>
        /// The direction of the snakes movement
        /// </summary>
        public static string direction;

        // Constructor
        /// <summary>
        /// Creates a new snake
        /// </summary>
        public Snake()
        {
            _x = 0;
            _y = 0;
            Width = 16;
            Height = 16;
            direction = "down";
        }

        // Public Methods
        /// <summary>
        /// Draws a new snake part
        /// </summary>
        public void Draw(Brush brush, Graphics paper, int x, int y, int width, int height)
        {
            paper.FillEllipse(brush, x, y, width, height);
        }

        // Properties
        /// <summary>
        /// The x position of the snake
        /// </summary>
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// The y position of the snake
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
