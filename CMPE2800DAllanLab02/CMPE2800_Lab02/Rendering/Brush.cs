using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace CMPE2800_Lab02
{
    class Brush : Shape
    {
        // Brush image
        private Bitmap _bm;

        // Brush Constructor
        public Brush(Point position) : base(position)
        {
        }

        /// <summary>
        /// Render brush.
        /// </summary>
        /// <param name="gr">
        /// The main graphics object of game
        /// </param>
        public override void Render(Graphics gr)
        {
        }

        /// <summary>
        /// Get the graphics path for use with hit detection
        /// </summary>
        /// <returns>
        /// the GraphicsPath of the ammo object
        /// </returns>
        public override GraphicsPath GetPath()
        {
        }
    }
}
