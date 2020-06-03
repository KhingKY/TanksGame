using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using CMPE2800_Lab02;

namespace TankGameTest
{
	[TestClass()]
	public class ShapeTest
	{
		[TestMethod()]
		public void IsWithinTileSizeTest()
		{
			PointF startP1 =new PointF(1,0);
			Color colour = Color.FromName("Blue");
			Tank tank = new Tank(startP1, colour, PlayerNumber.One);

			PointF startP2 = new PointF(1, 1);
			Color colour2 = Color.FromName("Red");
			Tank tank2 = new Tank(startP2, colour2, PlayerNumber.Two);

			Assert.IsTrue(tank.IsWithinTileSize(tank2));

		}

		[TestMethod()]
		public void IsIntersectingTest()
		{
			Image _beforeImage = Image.FromFile(@"..\..\..\..\..\CMPE2800DAllanLab02\CMPE2800_Lab02\Images\DirtTerrain.png");
			Bitmap _backgroundImage = new Bitmap(_beforeImage);
			Graphics gr = Graphics.FromImage(_backgroundImage);
			PointF startP1 = new PointF(1, 0);
			Color colour = Color.FromName("Blue");
			Tank tank = new Tank(startP1, colour, PlayerNumber.One);

			PointF startP2 = new PointF(1, 1);
			Color colour2 = Color.FromName("Red");
			Tank tank2 = new Tank(startP2, colour2, PlayerNumber.Two);

			Assert.IsTrue(tank.IsIntersecting(tank2, gr));

		}

		[TestMethod()]
		public void IsCollidingTest()
		{
			Image _beforeImage = Image.FromFile(@"..\..\..\..\..\CMPE2800DAllanLab02\CMPE2800_Lab02\Images\DirtTerrain.png");
			Bitmap _backgroundImage = new Bitmap(_beforeImage);
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
