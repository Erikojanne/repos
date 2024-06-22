using System.Data;

namespace Harj18
{
    public partial class AvainhenkilotForm : Form
    {
        DataTable pankki = new DataTable();
        DataTable pankkiHenkilot = new DataTable();
        DataTable yhteys = new DataTable();
        public AvainhenkilotForm()
        {
            InitializeComponent();
        }

        private void oppilaitosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string viite = pankki.Rows[oppilaitosCB.SelectedIndex]["PID"].ToString();
            OsoiteLB.Text = pankki.Rows[oppilaitosCB.SelectedIndex]["PTilinro1"].ToString();
            PostinumeroLB.Text = pankki.Rows[oppilaitosCB.SelectedIndex]["PTilinro2"].ToString();
            PostitoimipaikkaLB.Text = pankki.Rows[oppilaitosCB.SelectedIndex]["PPostitoimipaikka"].ToString();
            puhelinLB.Text = pankki.Rows[oppilaitosCB.SelectedIndex]["PPuhelin"].ToString();

            yhteys = pankkiHenkilot.Select("PID =" + viite).CopyToDataTable();
            vastuuhloCB.DataSource= yhteys;
            vastuuhloCB.DisplayMember = "VNimi";

        }

        private void AvainhenkilotForm_Load(object sender, EventArgs e)
        {
            taytaOppilaitosTaulukko();
            taytavastuuHenkilotTaulukko();
            oppilaitosCB.DataSource = pankki;
            oppilaitosCB.DisplayMember = "PNimi";
        }

        private void taytaOppilaitosTaulukko()
        {
            pankki.Columns.Add("PID", typeof(int));
            pankki.Columns.Add("PNimi");
            pankki.Columns.Add("PTilinro1");
            pankki.Columns.Add("PTilinro2");
            pankki.Columns.Add("PPostitoimipaikka");
            pankki.Columns.Add("PPuhelin");

            pankki.Rows.Add(1, "Nordea", "Rahasto Tilinro: 111-222", "Sijoitus Tilinro: 00550");
            pankki.Rows.Add(2, "OP", "Tilinro 111-222", "Etutili: 182 4668 ");
            pankki.Rows.Add(3, "Aktia", "Tilinro 111-222");
            pankki.Rows.Add(4, "Hypo", "Tilinro 111-222");
        }

        private void taytavastuuHenkilotTaulukko()
        {
            pankkiHenkilot.Columns.Add("PID", typeof(int));
            pankkiHenkilot.Columns.Add("VNimi");
            pankkiHenkilot.Columns.Add("VTitteli");
            pankkiHenkilot.Columns.Add("VOsasto");
            pankkiHenkilot.Columns.Add("VSahkoposti");
            pankkiHenkilot.Columns.Add("VPuhelin");

            pankkiHenkilot.Rows.Add(1, "Arvo Rahasto", "Rahastonhoitaja", "Kamppi", "sirpa.lindroos@nordea.fi", "Puh: 01234567");
            pankkiHenkilot.Rows.Add(1, "Petri Nolo", "Sijoitusneuvoja", "Kamppi", "p.nolo@nordea.fi", "Puh: 987654");
            pankkiHenkilot.Rows.Add(1, "Eila Info", "Yhteyshenkilö", "Kamppi", "e.info@nordea.fi", "Puh: 010 000");
            
            
            pankkiHenkilot.Rows.Add(2, "Osku Osaaja", "Asiakaspalvelija", "Helsinki", "o.osaajaja@op.fi", "Puh. 010 2435");
            pankkiHenkilot.Rows.Add(2, "Pirjo Ukkonen", "Pankkivirkailija", "Helsinki", "p.ukko@op.fi", "Puh: 48 6500");
            
            pankkiHenkilot.Rows.Add(3, "Ukko Auriainen", "Asiakaspalvelija", "Porvoo", "u.auriainen@aktia.fi", "Puh: 010 4514");
            pankkiHenkilot.Rows.Add(3, "Anne Leinonen", "Pankkivirkailija","Porvoo", "anne.leinonen@aktia.fi", "Puh: 40 524 12");
            
            pankkiHenkilot.Rows.Add(4, "Iina Halme", "Pankkivirkailija", "Helsinki", "iina.halme@hypo.fi", "Puh: 50 336 97");
            pankkiHenkilot.Rows.Add(4, "Anna Mari", "Lainat", "Helsinki", "anna.mari@hypo.fi", "Puh: 40 174 23");
            
        }

        private void vastuuhloCB_TextChanged(object sender, EventArgs e)
        {
            TitteliLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VTitteli"].ToString();
            OsastoLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VOsasto"].ToString();
            EmailLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VSahkoposti"].ToString();
            PuhLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VPuhelin"].ToString();
        }

        private void PalkkaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, sahko, vesi, vakuutus, elintarvikkeet, harrastukset, palkka, saasto;
            laina = Convert.ToDouble(LainaTB.Text);
            sahko = Convert.ToDouble(SahkoTB.Text);
            vesi = Convert.ToDouble(VesiTB.Text);
            vakuutus = Convert.ToDouble(VakuutusTB.Text);
            elintarvikkeet = Convert.ToDouble(ElintarvikeTB.Text);
            harrastukset = Convert.ToDouble(HarrastusTB.Text);
            palkka = Convert.ToDouble(PalkkaCB.Text);
            saasto = (palkka) - (laina + sahko + vesi + vakuutus + elintarvikkeet + harrastukset);
            VastausLB.Text = "Säästö perus kuukausimenojen jälkeen: " + saasto;
            VastausLB.Visible = true;

        }
    }
}