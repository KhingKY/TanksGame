using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CMPE2800_Lab02
{
	[TestFixture()]
	class MechanicTest
	{
		[Test()]
		public void IsWithinTileSizeTest()
		{
			PointF startP1 = new PointF(1, 0);
			Color colour = Color.FromName("Blue");
			Tank tank = new Tank(startP1, colour, PlayerNumber.One);

			PointF startP2 = new PointF(1, 1);
			Color colour2 = Color.FromName("Red");
			Tank tank2 = new Tank(startP2, colour2, PlayerNumber.Two);

			Assert.IsTrue(tank.IsWithinTileSize(tank2));

		}

		[Test()]
		public void IsIntersectingTest()
		{
			Bitmap _backgroundImage = new Bitmap(Properties.Resources.DirtTerrain);
			Graphics gr = Graphics.FromImage(_backgroundImage);
			PointF startP1 = new PointF(1, 0);
			Color colour = Color.FromName("Blue");
			Tank tank = new Tank(startP1, colour, PlayerNumber.One);

			PointF startP2 = new PointF(1, 1);
			Color colour2 = Color.FromName("Red");
			Tank tank2 = new Tank(startP2, colour2, PlayerNumber.Two);

			Assert.IsTrue(tank.IsIntersecting(tank2, gr));

		}

		[Test()]
		public void IsCollidingTest()
		{
			Bitmap _backgroundImage = new Bitmap(Properties.Resources.DirtTerrain);
			Graphics gr = Graphics.FromImage(_backgroundImage);
			PointF startP1 = new PointF(1, 0);
			Color colour = Color.FromName("Blue");
			Tank tank = new Tank(startP1, colour, PlayerNumber.One);

			PointF startP2 = new PointF(1, 1);
			Color colour2 = Color.FromName("Red");
			Tank tank2 = new Tank(startP2, colour2, PlayerNumber.Two);

			Assert.IsTrue(tank.IsColliding(tank2, gr));

		}


	}

}
