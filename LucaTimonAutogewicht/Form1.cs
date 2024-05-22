namespace LucaTimonAutogewicht
{
    public partial class Form1 : Form
    {
        Auto Auto1 = new Auto();

        public Form1()
        {
            InitializeComponent();
        }

        private void btneinsteigen_Click(object sender, EventArgs e)
        {
            txtgewichtausgabe.Text = Auto1.GetGesammtGewicht().ToString();
            txt_ausgabe_namen.Text = Auto1.GetAllePersonennamen().ToString();
        }

        private void btnaussteigen_Click(object sender, EventArgs e)
        {
            Auto1.PersonenlisteLeeren();
            txtgewichtausgabe.Text = Auto1.GetGesammtGewicht().ToString();
            txt_ausgabe_namen.Clear();
        }

        private void btn_gewicht_person_Click(object sender, EventArgs e)
        {
            //Nicht verwenden
        }

        private void Btn_name_person_Click(object sender, EventArgs e)//Speichern
        {
            Auto1.Personenliste(new Person(Txt_name.Text.ToString(),Convert.ToDouble(Txt_Gewicht_person.Text)));
        }
    }
}
