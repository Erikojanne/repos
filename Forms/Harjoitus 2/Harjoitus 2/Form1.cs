namespace Harjoitus_2
{
    public partial class Label1 : Form
    {
        public Label1()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            TulostusLB.Text = teksti;
            //TulostusLB.Text = ViestiTB.Text;
            TulostusLB.Visible = true;
        }
    }
}