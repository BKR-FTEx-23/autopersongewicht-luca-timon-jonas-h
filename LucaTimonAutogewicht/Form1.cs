namespace LucaTimonAutogewicht
{
    public partial class Form1 : Form
    {
        Auto mein_Auto = new Auto();

        public Form1()
        {
            InitializeComponent();
        }

        private void btneinsteigen_Click(object sender, EventArgs e)
        {
            //txtgewichtausgabe.Text = mein_Auto.GetGesammtGewicht().ToString();
            txtgewichtausgabe.Text = mein_Auto.GesammtGewicht.ToString();       //mit Property
            txt_ausgabe_namen.Text = mein_Auto.GetAllePersonennamen().ToString();
        }

        private void btnaussteigen_Click(object sender, EventArgs e)
        {
            mein_Auto.Aussteigen();
            txtgewichtausgabe.Text = mein_Auto.GesammtGewicht.ToString();
            txt_ausgabe_namen.Clear();
        }

        private void Btn_name_person_Click(object sender, EventArgs e) //Speichern
        {
            mein_Auto.Einsteigen(new Person(Txt_name.Text.ToString(),Convert.ToDouble(Txt_Gewicht_person.Text)));
            Txt_name.Clear();
            Txt_Gewicht_person.Clear();
        }
    }
}
