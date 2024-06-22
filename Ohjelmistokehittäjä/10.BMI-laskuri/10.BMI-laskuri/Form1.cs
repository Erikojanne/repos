namespace _10.BMI_laskuri
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, painoindeksi;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            painoindeksi = Math.Round(paino / (pituus * pituus), 2);
            if(painoindeksi < 18.5)
            {
                VastausLB.Text = " painoindeksisi on: " + painoindeksi;
                VastausLB.ForeColor = Color.Black;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Green;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (painoindeksi < 25)
            {
                VastausLB.Text = "Painoindeksisi on: " + painoindeksi;
                VastausLB.ForeColor = Color.Black;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Blue;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (painoindeksi < 40)
            {
                VastausLB.Text = "Painoindeksisi on: " + painoindeksi;
                VastausLB.ForeColor = Color.Black;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.DarkRed;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Painoindeksisi on: " + painoindeksi;
                VastausLB.ForeColor = Color.Black;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
        }
    }
}