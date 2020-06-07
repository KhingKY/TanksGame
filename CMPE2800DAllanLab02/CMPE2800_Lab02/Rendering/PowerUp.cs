/****************************************************************************
 * File: PowerUp.cs                                                            *
 * Author: Elwin Chan, Alvin Sim, Chan Kwang Yung and Thon Pun Liang                                  *
 * Description: Used for creating power up drops for tanks for collect in-game. *
 ****************************************************************************/
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace CMPE2800_Lab02
{
    class PowerUp : Shape
    {
        // the stopwatch for counting the time between power up spawns
        public static Stopwatch _stopwatch;

        //power up image
        private Bitmap _bm;

        private PowerUpType _type;

        //public property to determine the power up type
        public PowerUpType PowerUpType { get; set; }

        //public property to determine if a power up object is either showing or has a stopwatch started
        public bool IsAlive { get; set; }

        //PowerUp Constructor
        public PowerUp(Point sp, PowerUpType lPowerUpType, Bitmap lBitmap) : base(sp)
        {
            //create the new stopwatch object
            _stopwatch = new Stopwatch();

            //creat the model. Positioning the image in the center of the tile
            _model = new GraphicsPath();
            _model.AddRectangle(new RectangleF(Position.X + Tilesize / 4, Position.Y + Tilesize / 4,
                Tilesize / 2, Tilesize / 2));

            _type = lPowerUpType;
            //set the bitmap image based on power up type
            _bm = lBitmap;

            //all power up object start with a stopped stopwatch not showing.
            IsAlive = false;
        }
        /// <summary>
        /// Get the graphics path for use with hit detection
        /// </summary>
        /// <returns>
        /// the GraphicsPath of the power up object
        /// </returns>
        public override GraphicsPath GetPath()
        {
            return _model.Clone() as GraphicsPath;
        }
        /// <summary>
        /// Render the PowerUp drop. It needs to be a quarter of the size of tile and 
        /// placed in the center of the tile
        /// </summary>
        /// <param name="gr">
        /// The main graphics object of game
        /// </param>
        public override void Render(Graphics gr)
        {
            // get the model's bounds
            RectangleF modRect = _model.GetBounds();

            //render an ammo icon
            gr.DrawImage(_bm, modRect.X, modRect.Y, modRect.Width, modRect.Height);
        }
    }
}
