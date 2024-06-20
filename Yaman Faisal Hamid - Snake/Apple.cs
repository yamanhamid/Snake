using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaman_Faisal_Hamid___Snake
{
    class Apple
    {
        // Instance Variables
        /// <summary>
        /// The x position of the apple
        /// </summary>
        public int _x;
        /// <summary>
        /// The y position of the apple
        /// </summary>
        public int _y;

        // Constructor
        /// <summary>
        /// Creates a new apple
        /// </summary>
        public Apple()
        {
            _x = 0;
            _y = 0;
        }

        // Public Methods
        /// <summary>
        /// Creates a new apple
        /// </summary>
        public void Draw(Brush brush, Graphics paper, int x, int y, int width, int height)
        {
            paper.FillEllipse(brush, x, y, width, height);
        }

        // Properties
        /// <summary>
        /// The x position of the apple
        /// </summary>
        public int X
        { 
            get { return _x; }
            set {  _x = value; } 
        } 

        /// <summary>
        /// The y position of the apple
        /// </summary>
        public int Y
        { 
            get { return _y; } 
            set { _y = value; } 
        }
    }
}
