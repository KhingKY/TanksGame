using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using CMPE2800_Lab02;

namespace TankGameTest
{
	[TestClass]
	public class MechanicTest
	{
		[TestMethod]
		public void ChangeWeaponTest()
		{
			PlayerData playerData = new PlayerData(PlayerNumber.One);

			playerData.SwitchWeapon();
			Assert.AreEqual(GunType.Rocket, playerData.CurrentWeapon);

			playerData.SwitchWeapon();
			Assert.AreEqual(GunType.MachineGun, playerData.CurrentWeapon);
		}

		[TestMethod]
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
			Assert.AreEqual(3, playerData1.Lives);
		}

		[TestMethod]
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

		[TestMethod]
		public void HealTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			PlayerData playerData2 = new PlayerData(PlayerNumber.Two);

			playerData1.TakeDamage(GunType.Rocket, playerData2);
			Assert.AreEqual(75, playerData1.HP);

			playerData1.Heal();
			Assert.AreEqual(100, playerData1.HP);
		}

		[TestMethod]
		public void ShieldTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			PlayerData playerData2 = new PlayerData(PlayerNumber.Two);

			//Location of powerup
			Point spawnLocation = new Point();
			spawnLocation.X = 10;
			spawnLocation.Y = 9;

			//Get image of power up
			Bitmap _bitmap = new Bitmap(CMPE2800_Lab02.Properties.Resources.shield);

			PowerUp power1 = new PowerUp(spawnLocation, PowerUpType.Shield, _bitmap);
			Assert.AreEqual(PowerUpType.Shield, power1._powerUpType);
			Assert.AreEqual(false, playerData1.HasShield);

			playerData1.GetPowerUp(power1);
			Assert.AreEqual(true, playerData1.HasShield);
			Assert.AreEqual(100, playerData1.HP);

			playerData1.TakeDamage(GunType.Rocket, playerData2);
			Assert.AreEqual(false, playerData1.HasShield);
			Assert.AreEqual(100, playerData1.HP);
		}

		[TestMethod]
		public void SuperTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);

			//Location of powerup
			Point spawnLocation = new Point();
			spawnLocation.X = 10;
			spawnLocation.Y = 9;

			//Get image of power up
			Bitmap _bitmap = new Bitmap(CMPE2800_Lab02.Properties.Resources.super);

			PowerUp power1 = new PowerUp(spawnLocation, PowerUpType.Super, _bitmap);
			Assert.AreEqual(PowerUpType.Super, power1._powerUpType);
			Assert.AreEqual(false, playerData1.IsSuper);

			playerData1.GetPowerUp(power1);
			Assert.AreEqual(true, playerData1.IsSuper);

			//Try to break hard wall
			bool wall1 = playerData1.CanBreakWall(WallType.Hard);
			Assert.AreEqual(false, wall1);
			Assert.AreEqual(true, playerData1.IsSuper);

			//Break weak wall
			bool wall2 = playerData1.CanBreakWall(WallType.Weak);
			Assert.AreEqual(true, wall2);
			Assert.AreEqual(false, playerData1.IsSuper);

			bool wall3 = playerData1.CanBreakWall(WallType.Weak);
			Assert.AreEqual(false, wall3);
			Assert.AreEqual(false, playerData1.IsSuper);
		}

		[TestMethod]
		public void AddDamageTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			PlayerData playerData2 = new PlayerData(PlayerNumber.Two);

			//Location of powerup
			Point spawnLocation = new Point();
			spawnLocation.X = 10;
			spawnLocation.Y = 9;

			//Get image of power up
			Bitmap _bitmap = new Bitmap(CMPE2800_Lab02.Properties.Resources.damage);

			PowerUp power1 = new PowerUp(spawnLocation, PowerUpType.Damage, _bitmap);
			Assert.AreEqual(PowerUpType.Damage, power1._powerUpType);

			//Normal Situation without add damage
			playerData1.TakeDamage(GunType.Rocket, playerData2);
			Assert.AreEqual(75, playerData1.HP);

			playerData1.Heal();
			Assert.AreEqual(100, playerData1.HP);

			Assert.AreEqual(25, playerData1.RocketDmg);
			playerData1.GetPowerUp(power1);
			Assert.AreEqual(30, playerData1.RocketDmg);

			//After add damage
			playerData1.TakeDamage(GunType.Rocket, playerData2);
			Assert.AreEqual(70, playerData1.HP);
		}

		[TestMethod]
		public void MineTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);

			playerData1.GetMined();
			Assert.AreEqual(90, playerData1.HP);

			playerData1.GetMined();
			Assert.AreEqual(80, playerData1.HP);
		}

		[TestMethod]
		public void CollidedWithTankTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			PlayerData playerData2 = new PlayerData(PlayerNumber.Two);
			Assert.AreEqual(100, playerData1.HP);
			Assert.AreEqual(100, playerData2.HP);

			playerData1.CollidedWithTank(playerData2);
			Assert.AreEqual(99, playerData1.HP);
			Assert.AreEqual(99, playerData2.HP);

			playerData2.CollidedWithTank(playerData1);
			Assert.AreEqual(98, playerData1.HP);
			Assert.AreEqual(98, playerData2.HP);
		}
	}
}