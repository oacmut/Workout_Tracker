using Cseresznye_OACMUT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cseresznye_OACMUT
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }
        FitnessDBContext context;
        public Workout ujEdzes;
        private void button1_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren()&&IsValidated())
            {
                ujEdzes = new Workout();
                ujEdzes.PersonId = ((int)comboBox1.SelectedValue);
                ujEdzes.WorkoutName = textBox1.Text;
                ujEdzes.Date = DateTime.Parse(textBox2.Text);
                ujEdzes.DurationMinutes = int.Parse(textBox3.Text);
                ujEdzes.CaloriesBurned = int.Parse(textBox4.Text);
                this.DialogResult = DialogResult.OK;
            }

        }
        bool IsValidated()
        {
            if(errorProvider1.GetError(textBox1)==string.Empty&& errorProvider1.GetError(textBox2) == string.Empty && errorProvider1.GetError(textBox3) == string.Empty && errorProvider1.GetError(textBox4) == string.Empty)
            {
                return true;
            }
            return false;
        }
        private void FormAdd_Load(object sender, EventArgs e)
        {
            context = new FitnessDBContext();
            var nevek = (from x in context.People select x).ToList();
            personBindingSource.DataSource = nevek;
            button1.Enabled = false;
            Validal();
        }
        void Validal()
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty)
            {
                button1.Enabled = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Validal();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            string minta = @"[a-zA-Z]";
            if (!Regex.IsMatch(textBox1.Text, minta))
            {
                errorProvider1.SetError(textBox1, "Érvénytelen edzés!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            string minta = @"^\d{4}\.\d{2}\.\d{2}$";
            if (!Regex.IsMatch(textBox2.Text, minta))
            {
                errorProvider1.SetError(textBox2, "Érvénytelen dátum!");
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            string minta = @"^[0-9]+$";
            if (!Regex.IsMatch(textBox3.Text, minta))
            {
                errorProvider1.SetError(textBox3, "Érvénytelen hossz!");
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            string minta = @"^[0-9]+$";
            if (!Regex.IsMatch(textBox4.Text, minta))
            {
                errorProvider1.SetError(textBox4, "Érvénytelen kalória!");
            }
            else
            {
                errorProvider1.SetError(textBox4, "");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Validal();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Validal();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Validal();
        }
    }
}
