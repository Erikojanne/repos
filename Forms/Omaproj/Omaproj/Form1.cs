using System.Data;

namespace Omaproj_
{
    public partial class Form1 : Form
    {
        DataTable pankki = new DataTable();
        DataTable pankkiHenkilot = new DataTable();
        DataTable yhdista = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void PankkiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bisnes = pankki.Rows[PankkiCB.SelectedIndex]["PID"].ToString();
            Tilinro1LB.Text = pankki.Rows[PankkiCB.SelectedIndex]["PTilinro1"].ToString();
            Tilinro2LB.Text = pankki.Rows[PankkiCB.SelectedIndex]["PTilinro2"].ToString();
            Tilinro3LB.Text = pankki.Rows[PankkiCB.SelectedIndex]["PTilinro3"].ToString();
            

            yhdista = pankkiHenkilot.Select("PID =" + bisnes).CopyToDataTable();
            PhenkiloCB.DataSource = yhdista;
            PhenkiloCB.DisplayMember = "VNimi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taytaPankkiTaulukko();
            taytaPankkiHenkiloTaulukko();
            PankkiCB.DataSource = pankki;
            PankkiCB.DisplayMember = "PNimi";
        }
        private void taytaPankkiTaulukko()
        {
            pankki.Columns.Add("PID", typeof(int));
            pankki.Columns.Add("PNimi");
            pankki.Columns.Add("PTilinro1");
            pankki.Columns.Add("PTilinro2");
            pankki.Columns.Add("PTilinro3");

            pankki.Rows.Add(1, "Nordea", "Rahasto Tilinro: 111-222", "Sijoitus Tilinro: 00550");
            pankki.Rows.Add(2, "OP", "Tilinro 111-222", "Etutili: 182 4668 ");
            pankki.Rows.Add(3, "Aktia", "Tilinro 111-222");
            pankki.Rows.Add(4, "Hypo", "Tilinro 111-222");
        }
        private void taytaPankkiHenkiloTaulukko()
        {
            pankkiHenkilot.Columns.Add("PID", typeof(int));
            pankkiHenkilot.Columns.Add("VNimi");
            pankkiHenkilot.Columns.Add("VTitteli");
            pankkiHenkilot.Columns.Add("VSijainti");
            pankkiHenkilot.Columns.Add("VEmail");
            pankkiHenkilot.Columns.Add("VPuhelin");

            pankkiHenkilot.Rows.Add(1, "Arvo Rahasto", "Rahastonhoitaja", "Kamppi", "a.rahasto@nordea.fi", "Puh: 01234567");
            pankkiHenkilot.Rows.Add(1, "Petri Nolo", "Sijoitusneuvoja", "Kamppi", "p.nolo@nordea.fi", "Puh: 987654");
            pankkiHenkilot.Rows.Add(1, "Eila Info", "Yhteyshenkilö", "Kamppi", "e.info@nordea.fi", "Puh: 010 000");


            pankkiHenkilot.Rows.Add(2, "Osku Osaaja", "Asiakaspalvelija", "Helsinki", "o.osaajaja@op.fi", "Puh. 010 2435");
            pankkiHenkilot.Rows.Add(2, "Pirjo Ukkonen", "Pankkivirkailija", "Helsinki", "p.ukko@op.fi", "Puh: 48 6500");

            pankkiHenkilot.Rows.Add(3, "Ukko Auriainen", "Asiakaspalvelija", "Porvoo", "u.auriainen@aktia.fi", "Puh: 010 4514");
            pankkiHenkilot.Rows.Add(3, "Anne Leinonen", "Pankkivirkailija", "Porvoo", "anne.leinonen@aktia.fi", "Puh: 40 524 12");

            pankkiHenkilot.Rows.Add(4, "Iina Halme", "Pankkivirkailija", "Helsinki", "iina.halme@hypo.fi", "Puh: 50 336 97");
            pankkiHenkilot.Rows.Add(4, "Anna Mari", "Lainat", "Helsinki", "anna.mari@hypo.fi", "Puh: 40 174 23");
        }

        private void PhenkiloCB_TextChanged(object sender, EventArgs e)
        {
            TitteliLB.Text = yhdista.Rows[PhenkiloCB.SelectedIndex]["VTitteli"].ToString();
            SijaintiLB.Text = yhdista.Rows[PhenkiloCB.SelectedIndex]["VSijainti"].ToString();
            EmailLB.Text = yhdista.Rows[PhenkiloCB.SelectedIndex]["VEmail"].ToString();
            PuhelinLB.Text = yhdista.Rows[PhenkiloCB.SelectedIndex]["VPuhelin"].ToString();
        }

        private void PalkkaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, sahko, vesi, vakuutus, elintarvikkeet, harrastukset, palkka, saasto;
            laina = Convert.ToDouble(LainaTB.Text);
            sahko = Convert.ToDouble(SahkoTB.Text);
            vesi = Convert.ToDouble(VesiTB.Text);
            vakuutus = Convert.ToDouble(VakuutusTB.Text);
            elintarvikkeet = Convert.ToDouble(ElintarvikkeetTB.Text);
            harrastukset = Convert.ToDouble(HarrastuksetTB.Text);
            palkka = Convert.ToDouble(PalkkaCB.Text);
            saasto = (palkka) - (laina + sahko + vesi + vakuutus + elintarvikkeet + harrastukset);
            VastausLB.Text = "Säästö perus kuukausimenojen jälkeen: " + saasto;
            VastausLB.Visible = true;
        }
    }
}