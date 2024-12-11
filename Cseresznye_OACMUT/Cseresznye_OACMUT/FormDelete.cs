using Cseresznye_OACMUT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cseresznye_OACMUT
{
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }
        FitnessDBContext context;
        public Workout torlendo;
        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Biztosan törölni szeretnéd?","Törlés",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                torlendo = new Workout();
                torlendo = (from x in context.Workouts where x.WorkoutId == ((int)comboBox2.SelectedValue) select x).FirstOrDefault();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult= DialogResult.Cancel;
            }
        }
        void Kereses()
        {
            var lista = (from x in context.Workouts where ((int)comboBox1.SelectedValue) == x.PersonId select x).ToList();
            workoutBindingSource.DataSource = lista;
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {
            context = new FitnessDBContext();
            var nevek = (from x in context.People select x).ToList();
            personBindingSource.DataSource = nevek;
            Kereses();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kereses();
        }
    }
}
