namespace Ajastin
{
    public partial class TimerForm : Form
    {
        private int kokonaisaika;
        public TimerForm()
        {
            InitializeComponent();
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false; // Alussa poistetaan Stop-button käytöstä
            for(int i = 0; i < 60; i++)
            {
                MinuutitCB.Items.Add(i.ToString()); // Lisätään minuutteihin 0-99
                SekunnitCB.Items.Add(i.ToString()); // Lisätään sekunteihin 0-99
            }
            MinuutitCB.SelectedIndex = 0; // Määritetään ,että oletus on 0 
            SekunnitCB.SelectedIndex = 10;// Määritetään ,että oletus on 10
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false; // Poistetaan Start painike käytösta
            StopBT.Enabled = true; // Otetaan Stop painike käyttöön
            // Lasketaan kokonaisaika sekuntteina
            int minuutit = int.Parse(MinuutitCB.SelectedItem.ToString()); // Haetaan valitut minuutit
            int sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString()); // Haetaan valitut sekunnit
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;

        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true; // Otetaan Start painike käyttöön
            StopBT.Enabled = false;  //   Poistetaan stop painike käytösta
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                AikaLB.Text = minuutit + ":" + sekunnit;
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui! ");

            }
        }
    }
}