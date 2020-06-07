using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.IO;
using CMPE2800_Lab02;

namespace TankGameTest
{
	[TestClass()]
	public class MechanicTest
	{
		[TestMethod()]
		public void ChangeWeaponTest()
		{
			PlayerData playerData = new PlayerData(PlayerNumber.One);

			playerData.SwitchWeapon();
			Assert.AreEqual(GunType.Rocket, playerData.CurrentWeapon);

			playerData.SwitchWeapon();
			Assert.AreEqual(GunType.MachineGun, playerData.CurrentWeapon);
		}

		[TestMethod()]
		public void TakeDamageTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			PlayerData playerData2 = new PlayerData(PlayerNumber.Two);

			playerData1.TakeDamage(GunType.MachineGun, playerData2);
			Assert.AreEqual(95, playerData1.HP);

			playerData1.TakeDamage(GunType.Rocket, playerData2);
			Assert.AreEqual(70, playerData1.HP);

			playerData1.Respawn();
			Assert.AreEqual(100, playerData1.HP);
			Assert.AreEqual(4, playerData1.Lives);
		}

		[TestMethod()]
		public void ReloadAmmoTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			playerData1.SwitchWeapon();

			playerData1.StartReloading();
			Assert.AreEqual(4, playerData1.HeavyAmmo);

			playerData1.StartReloading();
			Assert.AreEqual(3, playerData1.HeavyAmmo);

			playerData1.GetMaxAmmo();
			Assert.AreEqual(5, playerData1.HeavyAmmo);

		}

		[TestMethod()]
		public void HealTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			PlayerData playerData2 = new PlayerData(PlayerNumber.Two);

			playerData1.TakeDamage(GunType.Rocket, playerData2);
			Assert.AreEqual(75, playerData1.HP);

			playerData1.Heal();
			Assert.AreEqual(100, playerData1.HP);
		}

		[TestMethod()]
		public void ShieldTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			PlayerData playerData2 = new PlayerData(PlayerNumber.Two);

			//Location of powerup
			Point spawnLocation = new Point();
			spawnLocation.X = 10;
			spawnLocation.Y = 9;

			//Get image of power up
			string _CurrentDir = Directory.GetCurrentDirectory();
			string _newDir = _CurrentDir;
			string _fileName = "";

			while (Path.GetFileName(_newDir) != "TanksGame") 
			{
				_newDir = Path.GetFullPath(Path.Combine(_newDir, ".."));
			}
			_fileName = _newDir + @"/CMPE2800DAllanLab02/CMPE2800_Lab02/Images/shield.png";

			Image _beforeImage = Image.FromFile(_fileName);
			Bitmap _bitmap = new Bitmap(_beforeImage);

			PowerUp power1 = new PowerUp(spawnLocation, PowerUpType.Shield, _bitmap);
			
			Assert.AreEqual(false, playerData1.HasShield);

			playerData1.GetPowerUp(power1);
			Assert.AreEqual(true, playerData1.HasShield);
			Assert.AreEqual(100, playerData1.HP);

			playerData1.TakeDamage(GunType.Rocket, playerData2);
			Assert.AreEqual(false, playerData1.HasShield);
			Assert.AreEqual(100, playerData1.HP);
		}

		[TestMethod()]
		public void SuperTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);

			//Initaite wall

			//Location of powerup
			Point spawnLocation = new Point();
			spawnLocation.X = 10;
			spawnLocation.Y = 9;

			//Get image of power up
			string _CurrentDir = Directory.GetCurrentDirectory();
			string _newDir = _CurrentDir;
			string _fileName = "";

			while (Path.GetFileName(_newDir) != "TanksGame")
			{
				_newDir = Path.GetFullPath(Path.Combine(_newDir, ".."));
			}
			_fileName = _newDir + @"/CMPE2800DAllanLab02/CMPE2800_Lab02/Images/shield.png";

			Image _beforeImage = Image.FromFile(_fileName);
			Bitmap _bitmap = new Bitmap(_beforeImage);

			PowerUp power1 = new PowerUp(spawnLocation, PowerUpType.Super, _bitmap);

			Assert.AreEqual(false, playerData1.IsSuper);

			playerData1.GetPowerUp(power1);
			Assert.AreEqual(true, playerData1.IsSuper);

			//checks if after breaking 3 wall the super mode is still on
			bool wall1 = playerData1.CanBreakWall(WallType.Weak);
			Assert.AreEqual(true, wall1);
			Assert.AreEqual(true, playerData1.IsSuper);

			bool wall2 = playerData1.CanBreakWall(WallType.Weak);
			Assert.AreEqual(true, wall2);
			Assert.AreEqual(true, playerData1.IsSuper);

			bool wall3 = playerData1.CanBreakWall(WallType.Weak);
			Assert.AreEqual(true, wall3);
			Assert.AreEqual(true, playerData1.IsSuper);

			//Try to break hard wall
			bool wall4 = playerData1.CanBreakWall(WallType.Hard);
			Assert.AreEqual(wall4, false);
			Assert.AreEqual(true, playerData1.IsSuper);

			bool wall5 = playerData1.CanBreakWall(WallType.Weak);
			Assert.AreEqual(wall5, false);
			Assert.AreEqual(false, playerData1.IsSuper);
		}

		[TestMethod()]
		public void AddDamageTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			PlayerData playerData2 = new PlayerData(PlayerNumber.Two);

			//Location of powerup
			Point spawnLocation = new Point();
			spawnLocation.X = 10;
			spawnLocation.Y = 9;

			//Get image of power up
			string _CurrentDir = Directory.GetCurrentDirectory();
			string _newDir = _CurrentDir;
			string _fileName = "";

			while (Path.GetFileName(_newDir) != "TanksGame")
			{
				_newDir = Path.GetFullPath(Path.Combine(_newDir, ".."));
			}
			_fileName = _newDir + @"/CMPE2800DAllanLab02/CMPE2800_Lab02/Images/shield.png";

			Image _beforeImage = Image.FromFile(_fileName);
			Bitmap _bitmap = new Bitmap(_beforeImage);

			PowerUp power1 = new PowerUp(spawnLocation, PowerUpType.Damage, _bitmap);

			//Normal Situation without add damage
			playerData1.TakeDamage(GunType.Rocket, playerData2);
			Assert.AreEqual(75, playerData1.HP);

			playerData1.Heal();
			Assert.AreEqual(100, playerData1.HP);

			Assert.AreEqual(25, playerData1.RocketDmg);
			playerData1.GetPowerUp(power1);
			Assert.AreEqual(PowerUpType.Damage, power1.PowerUpType);
			Assert.AreEqual(30, playerData1.RocketDmg);

			//After add damage
			playerData1.TakeDamage(GunType.Rocket, playerData2);
			Assert.AreEqual(70, playerData1.HP);
		}
	}
}
