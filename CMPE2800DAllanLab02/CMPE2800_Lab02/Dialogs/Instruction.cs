using System;
using System.Windows.Forms;

namespace CMPE2800_Lab02
{
    public partial class Instruction : Form
    {
        #region Methods
        /// <summary>
        /// Instance constructor. Centres form to screen.
        /// </summary>
        public Instruction()
        {
            InitializeComponent();

            // center form to screen
            StartPosition = FormStartPosition.CenterScreen;

            DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Click event triggers application exit event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnContinue_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        #endregion

    }
}
