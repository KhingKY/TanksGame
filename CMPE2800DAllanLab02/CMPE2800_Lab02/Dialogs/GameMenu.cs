using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using System.IO;
using Microsoft.Xna.Framework;
>>>>>>> 389c60681377be3f99ffefbcbea0cec74cf1ed5a

namespace CMPE2800_Lab02.Dialogs
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            DialogResult = DialogResult.None;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void InstructionsButton_Click(object sender, EventArgs e)
        {
            Instruction _gameinstruct = new Instruction();
            _gameinstruct.ShowDialog();
            while (true)
            {
                if (_gameinstruct.DialogResult == DialogResult.Cancel)
                {
<<<<<<< HEAD
                    
=======
>>>>>>> 389c60681377be3f99ffefbcbea0cec74cf1ed5a
                    _gameinstruct.Close();
                    break;
                }

            }
            
        }
<<<<<<< HEAD
=======

        private void HistoryButton_Click(object sender, EventArgs e)
        {

            string gamehistorypath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\\..\\GameHistory.txt");
            var lines = File.ReadAllLines(gamehistorypath);

            List<string> fields = lines.ToList();

            GameHistoryTab _gamehistory = new GameHistoryTab(fields);
            _gamehistory.ShowDialog();

        }
>>>>>>> 389c60681377be3f99ffefbcbea0cec74cf1ed5a
    }
}
