using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Desktop_App
{
    public partial class frmStartGame : Form
    {
        public frmStartGame()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            frmXOPlayers frm = new frmXOPlayers();
            Hide();
            frm.Show();
        }
    }
}
