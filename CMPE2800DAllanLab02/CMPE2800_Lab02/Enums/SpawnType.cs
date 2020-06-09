/********************************************************************
 * File: PlayerNumber.cs                                            *
 * Author: Dillon Allan and Jared Karpiak                           *
 * Description: Enum used to differentiate between                  *
 *              tank spawns and ammo drops.                         *
 ********************************************************************/

namespace CMPE2800_Lab02
{
    public enum SpawnType { Tank, Ammo, PowerUp, Mines, SlowFloor }
    
    //Enum used to differentiate between different power ups
    public enum PowerUpType { Shield, Super, Heal, Damage }
}
