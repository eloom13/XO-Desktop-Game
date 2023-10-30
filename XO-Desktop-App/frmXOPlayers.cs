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
    public partial class frmXOPlayers : Form
    {
        public frmXOPlayers()
        {
            InitializeComponent();
        }

        public string Igrac1 { get; set; }
        public string Igrac2 { get; set; }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Igrac1 = txtIgrac1.Text;
            Igrac2 = txtIgrac2.Text;

            if (Igrac1 != "" && Igrac2 != "")
            {
                frmXOGame frm = new frmXOGame(Igrac1, Igrac2);
                frm.ShowDialog();
                this.Hide();
            }
        }

        public static implicit operator frmXOPlayers(frmXOGame v)
        {
            throw new NotImplementedException();
        }
    }
}
