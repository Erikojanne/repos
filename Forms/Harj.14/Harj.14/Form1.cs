namespace Harj._14
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
            
        }

        private void TalennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText("C:/Users/janne/source/repos/Forms/Harj.14/paivakirja.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:/Users/janne/source/repos/Forms/Harj.14/paivakirja.txt");
            text.WriteLine(teksti);
            text.Close();
            Application.Exit();
        }
    }
}