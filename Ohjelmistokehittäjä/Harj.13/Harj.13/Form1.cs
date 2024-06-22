namespace Harj._13
{
    public partial class SuosikkiForm : Form
    {
        public SuosikkiForm()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible= false;
            string[] pojat = File.ReadAllLines("C:/Users/janne/source/repos/Forms/SuosikkiNimi/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Users/janne/source/repos/Forms/SuosikkiNimi/tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1, laskurit = 1;
            foreach(string poju in pojat) 
            {
                if(nimi == poju) 
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2022";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string neiti in tytot)
            {
                if (nimi == neiti)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2022";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if(VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimeäsi ei löytynyt";
                VastausLB.Visible = true;
            }
        }
    }
}