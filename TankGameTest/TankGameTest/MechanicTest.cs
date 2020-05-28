using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CMPE2800_Lab02;

namespace TankGameTest
{
	[TestFixture()]
	class MechanicTest
	{
		[Test()]
		public void ChangeWeaponTest()
		{
			PlayerData playerData = new PlayerData(PlayerNumber.One);

			playerData.SwitchWeapon();
			Assert.AreEqual(playerData.CurrentWeapon, GunType.Rocket);

			playerData.SwitchWeapon();
			Assert.AreEqual(playerData.CurrentWeapon, GunType.MachineGun);
		}

		[Test()]
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

		[Test()]
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


	}

}
