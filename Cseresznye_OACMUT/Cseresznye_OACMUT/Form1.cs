using Cseresznye_OACMUT.Models;

namespace Cseresznye_OACMUT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FitnessDBContext context;
        private void Form1_Load(object sender, EventArgs e)
        {
            Kereses();
        }
        void Kereses()
        {
            context = new FitnessDBContext();
            var lista = (from x in context.Workouts
                         where x.Person.Name.Contains(textBox1.Text) && x.WorkoutName.Contains(textBox2.Text)
                         select new Merged
                         {
                             PersonId = x.PersonId,
                             Name = x.Person.Name,
                             WorkoutId = x.WorkoutId,
                             WorkoutName = x.WorkoutName,
                             Date = x.Date,
                             DurationMinutes = x.DurationMinutes,
                             CaloriesBurned = x.CaloriesBurned
                         }).ToList();
            mergedBindingSource.DataSource = lista;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Kereses();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Kereses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd ujForm = new FormAdd();
            if (ujForm.ShowDialog() == DialogResult.OK)
            {
                context.Add(ujForm.ujEdzes);
                context.SaveChanges();
            }
            Kereses();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormDelete deleteForm = new FormDelete();
            if(deleteForm.ShowDialog() == DialogResult.OK)
            {
                context.Remove(deleteForm.torlendo);
                context.SaveChanges();
            }
            Kereses();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretnél lépni?", "Kilépés", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
    public class Merged
    {
        public int PersonId { get; set; }
        public string Name { get; set; } = null!;
        public int WorkoutId { get; set; }
        public string WorkoutName { get; set; } = null!;
        public DateTime Date { get; set; }
        public int? DurationMinutes { get; set; }
        public int? CaloriesBurned { get; set; }
    }
}