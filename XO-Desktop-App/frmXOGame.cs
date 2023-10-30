using Guna.UI2.WinForms;

namespace XO_Desktop_App
{
    public partial class frmXOGame : Form
    {
        public int Brojac { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Igrac1 { get; set; }
        public string Igrac2 { get; set; }

        public frmXOGame(string igrac1, string igrac2)
        {
            InitializeComponent();

            Igrac1 = igrac1;
            Igrac2 = igrac2;
        }

        private void DugmicOdabran(object sender)
        {
            if (sender is Guna2Button)
            {
                var button = sender as Guna2Button;

                if (button.Text == "")
                {
                    button.Text = (Brojac % 2 == 0) ? "X" : "O";

                    if (KrajIgre())
                        PostaviStatusDugmica(new StatusDugmica() { Enabled = false });

                    Brojac++;
                    PrikaziNarednogIgraca();
                }
            }
        }

        private void PrikaziNarednogIgraca()
        {
            lblNaredniIgrac.Text = (Brojac % 2 == 0) ? Igrac1 : Igrac2;
        }

        private void PostaviStatusDugmica(StatusDugmica status)
        {
            foreach (var kontrola in this.Controls)
            {
                if (kontrola is Guna2Button)
                {
                    var button = kontrola as Guna2Button;

                    if (button != btnNovaIgra && button != btnExit && button != btnReset && button != lblPlayer1 && button != lblPlayer2)
                    {
                        button.Enabled = status.Enabled;

                        if (status.ResetText)
                            button.Text = "";

                        //if (status.ResetColor)
                        //    button.FillColor = Color.Red;
                    }
                }
            }
        }

        private bool KrajIgre()
        {
            return ProvjeriRedove() || ProvjeriKolone() || ProvjeriDijagonale();
        }

        private bool ProvjeriDijagonale()
        {
            return ProvjeriPobjedu(button1, button5, button9) ||
                   ProvjeriPobjedu(button3, button5, button7);
        }

        private bool ProvjeriKolone()
        {
            return ProvjeriPobjedu(button1, button4, button7) ||
                   ProvjeriPobjedu(button2, button5, button8) ||
                   ProvjeriPobjedu(button3, button6, button9);
        }

        private bool ProvjeriRedove()
        {
            return ProvjeriPobjedu(button1, button2, button3) ||
                   ProvjeriPobjedu(button4, button5, button6) ||
                   ProvjeriPobjedu(button7, button8, button9);
        }

        private bool ProvjeriPobjedu(Guna2Button Button1, Guna2Button Button2, Guna2Button Button3)
        {
            var pobjeda = Button1.Text != "" && Button1.Text == Button2.Text && Button2.Text == Button3.Text;

            if (pobjeda)
            {
                Button1.DisabledState.FillColor = Button2.DisabledState.FillColor = Button3.DisabledState.FillColor = Color.Red;
                Button1.DisabledState.ForeColor = Button2.DisabledState.ForeColor = Button3.DisabledState.ForeColor = Color.White;

                if (Brojac % 2 == 0)
                    Score1++;
                else
                    Score2++;

                lblPlayerScore1.Text = Score1.ToString();
                lblPlayerScore2.Text = Score2.ToString();
            }

            return pobjeda;
        }


        private void PokreniNovuIgru()
        {
            Brojac = 0;
            Score1 = 0;
            Score2 = 0;

            lblPlayer1.Text = Igrac1.ToString();
            lblPlayer2.Text = Igrac2.ToString();

            PrikaziNarednogIgraca();
        }

        public partial class StatusDugmica
        {
            public bool Enabled { get; set; }
            public bool ResetText { get; set; }
            public bool ResetColor { get; set; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokreniNovuIgru();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DugmicOdabran(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DugmicOdabran(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DugmicOdabran(sender);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DugmicOdabran(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DugmicOdabran(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DugmicOdabran(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DugmicOdabran(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DugmicOdabran(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DugmicOdabran(sender);
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            //PostaviStatusDugmica(true, true, true);
            PostaviStatusDugmica(new StatusDugmica() { Enabled = true, ResetColor = true, ResetText = true });

            PokreniNovuIgru();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmXOPlayers frm = new frmXOPlayers();
            this.Hide();
            frm.ShowDialog();

            Brojac = 0;
            Score1 = 0;
            Score2 = 0;
        }
    }
}