/************************************************************************
 * File: GameUI.cs                                                      *
 * Author: Dillon Allan and Jared Karpiak                               *
 * Description: Form used to display game data including player score,  *
 *              HP, lives, heavy ammo, and current weapon.              *
 ***********************************************************************/
using System.Windows.Forms;
using System.Drawing;
using System;

namespace CMPE2800_Lab02
{
    public partial class GameUI : Form
    {
        #region Members
        // delegate for updating the UI stats
        public delegate void delVoidUIStats(int HP1, int HP2, int Lives1, int Lives2,
            int HAmmo1, int HAmmo2, int Score1, int Score2, bool isPaused);

        // delegate for toggling weapon icon background color
        public delegate void delVoidSwitchWeapon(PlayerNumber player, GunType gun);

        // desired UI Height in pixels
        private const int _iUIHeightPx = 154;
        Timer timer = new Timer();
        int count_down = 180;
        #endregion

        #region Methods
        /// <summary>
        /// Instance constructor. Sets height to fit about four lines of size 14 text.
        /// </summary>
        public GameUI()
        {
            InitializeComponent();
            Height = _iUIHeightPx;
        }

        /// <summary>
        /// Updates Game UI using current player data.
        /// </summary>
        /// <param name="HP1">Player 1 HP.</param>
        /// <param name="HP2">Player 2 HP.</param>
        /// <param name="Lives1">Player 1 lives.</param>
        /// <param name="Lives2">Player 2 lives.</param>
        /// <param name="HAmmo1">Player 1 heavy ammo.</param>
        /// <param name="HAmmo2">Player 2 heavy ammo.</param>
        /// <param name="Score1">Player 1 score.</param>
        /// <param name="Score2">Player 2 score.</param>
        public void CBUpdateUI(int HP1, int HP2, int Lives1, int Lives2, 
            int HAmmo1, int HAmmo2, int Score1, int Score2, bool isPaused)
        {
            // set UI values
            _labHP1.Text = $"{HP1}/100";
            _labHP2.Text = $"{HP2}/100";
            _labLives1.Text = $"{Lives1}";
            _labLives2.Text = $"{Lives2}";
            _labHAmmo1.Text = $"{HAmmo1}";
            _labHAmmo2.Text = $"{HAmmo2}";
            _labScoreDisplay.Text = $"{Score1} | {Score2}";
            progressBar1.Value = HP1;
            progressBar2.Value = HP2;

            // if set HP, life, and HAmmo fonts red if quantities are below 50%
            _labHP1.ForeColor = HP1 < 50 ? Color.Red : Color.Black;
            _labHP2.ForeColor = HP2 < 50 ? Color.Red : Color.Black;
            _labHAmmo1.ForeColor = HAmmo1 < 3 ? Color.Red : Color.Black;
            _labHAmmo2.ForeColor = HAmmo2 < 3 ? Color.Red : Color.Black;
            _labLives1.ForeColor = Lives1 < 2 ? Color.DarkRed : Color.White;
            _labLives2.ForeColor = Lives2 < 2 ? Color.DarkRed : Color.White;

            // set titlebar text to indicate if the game is paused
            if (isPaused)
            {
                Text = "PAUSED";
            }
            else
            {
                Text = "First to 3 points wins!";
            }
        }

        /// <summary>
        /// Callback function for indicating a weapon switch, 
        /// setting the current weapon icon background color
        /// to the "ActiveControl" color.
        /// </summary>
        /// <param name="player">Player number.</param>
        /// <param name="switchToGun">Newly equipped weapon.</param>
        public void CBSwitchWeapon(PlayerNumber player, GunType switchToGun)
        {
            PictureBox oldPBx = null;
            PictureBox newPBx = null;

            // set old and new PictureBox locals
            switch (player)
            {
                case PlayerNumber.One:
                    switch (switchToGun)
                    {
                        case GunType.MachineGun:
                            oldPBx = _pbxRocket1;
                            newPBx = _pbxMG1;
                            break;
                        case GunType.Rocket:
                            oldPBx = _pbxMG1;
                            newPBx = _pbxRocket1;
                            break;
                    }
                    break;

                case PlayerNumber.Two:
                    switch (switchToGun)
                    {
                        case GunType.MachineGun:
                            oldPBx = _pbxRocket2;
                            newPBx = _pbxMG2;
                            break;
                        case GunType.Rocket:
                            oldPBx = _pbxMG2;
                            newPBx = _pbxRocket2;
                            break;
                    }
                    break;
            }

            // reset oldPBx color, and set newPBx color
            oldPBx.BackColor = SystemColors.Control;
            newPBx.BackColor = SystemColors.ActiveCaption;
        }
        #endregion
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            count_down--;
            //get current time
            int mm = TimeSpan.FromMinutes(count_down).Hours;
            int ss = TimeSpan.FromMinutes(count_down).Minutes;

            //time
            string time = "";

            //padding leading zero

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            if (count_down == 0)
            {
                count_down++;
                time = "00:00";
            }

            //update label
            label2.Text = time;


        }
    }
}
