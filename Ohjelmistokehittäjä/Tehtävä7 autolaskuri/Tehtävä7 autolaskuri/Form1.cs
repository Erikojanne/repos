namespace Tehtävä7_autolaskuri
{
    public partial class AutolaskuriForm : Form
    {
        public AutolaskuriForm()
        {
            InitializeComponent();
        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutusTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutKulutTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            energia = Convert.ToDouble(BensaTB.Text);
            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + muut + energia) / (kilometrit / 12);
            VastausLB.Text = " Kustannukset kilometriä kohden ovat: " + kustannukset;
            VastausLB.Visible = true;
        }
    }
}