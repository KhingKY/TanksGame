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
            //creat the model. Positioning the image in the center of the tile
            _model = new GraphicsPath();
            _model.AddRectangle(new RectangleF(Position.X, Position.Y, Tilesize, Tilesize));

            //set the bitmap image to the Brush
            _bm = Properties.Resources.bush;
        }

        /// <summary>
        /// Render brush.
        /// </summary>
        /// <param name="gr">
        /// The main graphics object of game
        /// </param>
        public override void Render(Graphics gr)
        {
            // get the model's bounds
            RectangleF modRect = _model.GetBounds();

            //render an brush image
            gr.DrawImage(_bm, modRect.X, modRect.Y, modRect.Width, modRect.Height);
        }

        /// <summary>
        /// Get the graphics path for use with hit detection
        /// </summary>
        /// <returns>
        /// the GraphicsPath of the ammo object
        /// </returns>
        public override GraphicsPath GetPath()
        {
            return _model.Clone() as GraphicsPath;
        }
    }
}
