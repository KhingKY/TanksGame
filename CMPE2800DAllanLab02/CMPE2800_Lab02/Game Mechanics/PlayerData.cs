/************************************************************************
 * File: PlayerData.cs                                                  *
 * Author: Dillon Allan and Jared Karpiak                               *
 * Description: Class used for tracking player information,             *
 *              including health, lives remaining, and reload status.   *
 ***********************************************************************/
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace CMPE2800_Lab02
{
    class PlayerData
    {
        #region Members
        public static Stopwatch _time = new Stopwatch();
        // get-only player number
        public PlayerNumber Player { get; }

        // player score 
        public int Score { get; private set; }

        // score this much to win the game
        public const int ScoreToWin = 3;

        // players lose a life when HP < 1
        public int Lives { get; private set; }
        const int LivesMax = 3;

        // players lose HP when they take damage
        public int HP { get; private set; }
        const int HPMax = 100;

        // players gain sheild when they collected it but lost shield when they take damage, no damage is taken
        public bool HasShield { get; private set; }

        // players is in super mode and can knockdown low wall
        public bool IsSuper { get; private set; }

        // the number of wall that has been break
        public int NumBreak { get; private set; }
        const int MaxNumBreak = 1;

        // ammo for the heavy weapon (rockets, in this case)
        public int HeavyAmmo { get; private set; }

        // Max number of heavy ammo rounds a player gets
        const int HeavyAmmoMax = 5;

        // used for generating the appropriate gunfire objects
        public GunType CurrentWeapon { get; private set; }

        // list of weapons to choose from
        static readonly List<GunType> Guns = new List<GunType>() { GunType.MachineGun, GunType.Rocket };

        // reload times (ms) for each gun type
        public const int MachineGunReload = 200;
        public const int RocketReload = 1000;

        // damage values for gun types
        public int MachineGunDmg { get; private set; }
        public int RocketDmg { get; private set; }

        // stopwatch to time tank gunfire reloads
        Stopwatch ReloadTimer = new Stopwatch();

        // death flag
        public bool IsAlive { get; private set; }

        // player victory flag (raised when a player reaches 3 pts)
        public static bool PlayerVictory { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Instance constructor for new PlayerData objects.
        /// </summary>
        /// <param name="player">
        /// Player number in the game.
        /// </param>
        public PlayerData(PlayerNumber player)
        {
            // player is alive at first
            IsAlive = true;

            // user specifies player number
            Player = player;

            // players have four lives
            Lives = LivesMax;

            // players have 100HP per life
            HP = HPMax;

            // players start with 5 rounds of heavy ammunition
            HeavyAmmo = HeavyAmmoMax;

            // machinegun is the starting weapon by default
            CurrentWeapon = GunType.MachineGun;

            // player do not have shield
            HasShield = false;

            // player is not in super mode
            IsSuper = false;
            NumBreak = 0;

            // Initialize gun damage
            MachineGunDmg = 5;
            RocketDmg = 25;
        }

        /// <summary>
        /// Checks reload timer's elapsed milliseconds against
        /// the current weapon's reload time.
        /// </summary>
        /// <returns>
        /// Returns false if still reloading, and true if reloading is done.
        /// </returns>
        public bool CheckReload()
        {
            // return true if not reloading
            if (!ReloadTimer.IsRunning)
                return true;

            // currently reloading -- get the reload time for 
            // the currently selected weapon
            int reloadTime = 0;

            switch (CurrentWeapon)
            {
                case GunType.MachineGun:
                    reloadTime = MachineGunReload;
                    break;
                case GunType.Rocket:
                    reloadTime = RocketReload;
                    break;
            }

            // if not done reloading yet, return false
            if (ReloadTimer.ElapsedMilliseconds < reloadTime)
                return false;

            // if heavy weapon equipped and out of ammo, return false
            if (CurrentWeapon == GunType.Rocket && HeavyAmmo < 1)
                return false;

            // done reloading, so reset the timer and return true
            ReloadTimer.Reset();
            return true;
        }


        /// <summary>
        /// Decrement HP when collided with another tank
        /// </summary>
        /// <param name="aOther">Another player's data.</param>
        public void CollidedWithTank(PlayerData aOther)
        {
            if (HP > 1 && aOther.HP > 1)
            {
                HP--;
                aOther.HP--;
            }
        }

        /// <summary>
        /// Check if super mode is available to break wall
        /// </summary>
        /// <param name="wallType">The type of wall.</param>
        public bool CanBreakWall(WallType wallType)
        {
            if (IsSuper == true && wallType == WallType.Weak)
            {
                NumBreak++;
                if (NumBreak == MaxNumBreak)
                {
                    NumBreak = 0;
                    IsSuper = false;            
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Resets the reload timer.
        /// </summary>
        public void StartReloading()
        {
            ReloadTimer.Restart();

            // if heavy weapon used, expend one Heavy Ammo
            if (CurrentWeapon == GunType.Rocket)
                HeavyAmmo--;
        }

        /// <summary>
        /// Gets the next weapon from the player's list of guns.
        /// </summary>
        public void SwitchWeapon()
        {
            // wrap around if at the end of the list
            if (CurrentWeapon == Guns[Guns.Count - 1])
            {
                CurrentWeapon = Guns[0];
                return;
            }

            // set current weapon to the next weapon in the list
            CurrentWeapon = Guns[Guns.IndexOf(CurrentWeapon + 1)];
        }

        /// <summary>
        /// Processes new damage to invoking player.
        /// </summary>
        /// <param name="gunfire">Type of weapon that inflicted damage.</param>
        /// <param name="shooter">The player who shot the weapon.</param>
        /// <returns></returns>
        public void TakeDamage(GunType gunfire, PlayerData shooter)
        {
            // player takes damage according to guntype
            if (HasShield)
            {
                HasShield = false;
            }
            else { 
                switch (gunfire)
                {
                    case GunType.MachineGun:
                        HP -= shooter.MachineGunDmg;
                        break;
                    case GunType.Rocket:
                        HP -= shooter.RocketDmg;
                        break;
                }
            }

            // if HP is below 0, lose a life
            if (HP <= 0)
            {
                Lives--;

                // reset HP
                HP = HPMax;

                // the shooter gets a point
                shooter.Score++;

                // trigger respawn flag
                IsAlive = false;
            }

            // if shooter reaches 3 points, trigger victory condition
            if (shooter.Score >= ScoreToWin)
            {
                PlayerVictory = true;
            }
        }

        public bool GetPlayerVictory()
        {
            return PlayerVictory;
        }

        public void SetPlayerVictory()
        {
            PlayerVictory = true;
        }

        public void Heal()
        {
            HP += 30;
            if (HP > 100)
            {
                HP = 100;
            }
        }

        /// <summary>
        /// Tank obtain power up based on the powerup type
        /// </summary>
        public void GetPowerUp(PowerUp powerUp)
        {
            switch (powerUp._powerUpType)
            {
                case PowerUpType.Shield:
                    HasShield = true;
                    break;
                case PowerUpType.Super:
                    IsSuper = true;
                    break;
                case PowerUpType.Heal:
                    Heal();
                    break;
                case PowerUpType.Damage:
                    MachineGunDmg += 5;
                    RocketDmg += 5;
                    break;
            }
        }
        
        
        public void GetMined()
        {
            HP -= 10;
        }

        /// <summary>
        /// Sets Heavy Ammo count to the max value.
        /// </summary>
        public void GetMaxAmmo()
        {
            HeavyAmmo = HeavyAmmoMax;
        }

        /// <summary>
        /// Sets HP to max, and raises life flag.
        /// </summary>
        public void Respawn()
        {
            // reset HP
            HP = HPMax;

            // reset life flag
            IsAlive = true;
        }
        #endregion
    }
}
