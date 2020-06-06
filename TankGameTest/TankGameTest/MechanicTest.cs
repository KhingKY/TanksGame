using Microsoft.VisualStudio.TestTools.UnitTesting;
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
			Assert.AreEqual(playerData.CurrentWeapon, GunType.Rocket);

			playerData.SwitchWeapon();
			Assert.AreEqual(playerData.CurrentWeapon, GunType.MachineGun);
		}

		[TestMethod()]
		public void TakeDamageTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			PlayerData playerData2 = new PlayerData(PlayerNumber.Two);

			playerData1.TakeDamage(GunType.MachineGun, playerData2);
			Assert.AreEqual(playerData1.HP, 95);

			playerData1.TakeDamage(GunType.Rocket, playerData2);
			Assert.AreEqual(playerData1.HP, 70);

			playerData1.Respawn();
			Assert.AreEqual(playerData1.HP, 100);
			Assert.AreEqual(playerData1.Lives, 4);
		}

		[TestMethod()]
		public void ReloadAmmoTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			playerData1.SwitchWeapon();

			playerData1.StartReloading();
			Assert.AreEqual(playerData1.HeavyAmmo, 4);

			playerData1.StartReloading();
			Assert.AreEqual(playerData1.HeavyAmmo, 3);

			playerData1.GetMaxAmmo();
			Assert.AreEqual(playerData1.HeavyAmmo, 5);

		}

		[TestMethod()]
		public void HealTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);
			PlayerData playerData2 = new PlayerData(PlayerNumber.Two);

			playerData1.TakeDamage(GunType.Rocket, playerData2);
			Assert.AreEqual(playerData1.HP, 75);

			playerData1.Heal();
			Assert.AreEqual(playerData1.HP, 100);
		}

		[TestMethod()]
		public void MineTest()
		{
			PlayerData playerData1 = new PlayerData(PlayerNumber.One);

			playerData1.GetMined();
			Assert.AreEqual(playerData1.HP, 90);

			playerData1.GetMined();
			Assert.AreEqual(playerData1.HP, 80);
		}
	}
}
