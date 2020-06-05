using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE2800_Lab02.Dialogs
{
    public partial class GameHistoryTab : Form
    {
        public GameHistoryTab(List<string> content)
        {
            InitializeComponent();
            TextHistory.Font = new Font("Arial", 10, FontStyle.Bold);
            for (int i = 0; i < content.Count(); i++)
            {
                TextHistory.Text += content[i];
                TextHistory.Text += "\r\n";
            }
            
            
        }

        private void HistoryContents_TextChanged(object sender, EventArgs e )
        {
            
        }
    }
}
