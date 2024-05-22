namespace LucaTimonAutogewicht
{
    public partial class Form1 : Form
    {
        Auto Auto1 = new Auto();
        Person person1 = new Person();

        List <Person> personen_liste = new List<Person>();
        
        public Form1()
        {
            InitializeComponent();

        }

        private void btneinsteigen_Click(object sender, EventArgs e)
        {
            
            Auto1.PersonEinsteigen(person1);
            txtgewichtausgabe.Text = Auto1.GetGesammtGewicht().ToString();
        }

        private void btnaussteigen_Click(object sender, EventArgs e)
        {

        }
    }
}
