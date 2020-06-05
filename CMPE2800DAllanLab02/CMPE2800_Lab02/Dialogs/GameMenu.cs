using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    
                    _gameinstruct.Close();
                    break;
                }

            }
            
        }
    }
}
