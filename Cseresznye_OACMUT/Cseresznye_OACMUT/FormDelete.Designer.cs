namespace Cseresznye_OACMUT
{
    partial class FormDelete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            personBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            workoutBindingSource = new BindingSource(components);
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workoutBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DataSource = personBindingSource;
            comboBox1.DisplayMember = "Name";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(75, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 23);
            comboBox1.TabIndex = 0;
            comboBox1.ValueMember = "PersonId";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Models.Person);
            // 
            // comboBox2
            // 
            comboBox2.DataSource = workoutBindingSource;
            comboBox2.DisplayMember = "WorkoutName";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(75, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(176, 23);
            comboBox2.TabIndex = 1;
            comboBox2.ValueMember = "WorkoutId";
            // 
            // workoutBindingSource
            // 
            workoutBindingSource.DataSource = typeof(Models.Workout);
            // 
            // comboBox3
            // 
            comboBox3.DataSource = workoutBindingSource;
            comboBox3.DisplayMember = "Date";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(75, 137);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(176, 23);
            comboBox3.TabIndex = 2;
            comboBox3.ValueMember = "WorkoutId";
            // 
            // comboBox4
            // 
            comboBox4.DataSource = workoutBindingSource;
            comboBox4.DisplayMember = "DurationMinutes";
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(75, 195);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(176, 23);
            comboBox4.TabIndex = 3;
            comboBox4.ValueMember = "WorkoutId";
            // 
            // comboBox5
            // 
            comboBox5.DataSource = workoutBindingSource;
            comboBox5.DisplayMember = "CaloriesBurned";
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(75, 251);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(176, 23);
            comboBox5.TabIndex = 4;
            comboBox5.ValueMember = "WorkoutId";
            // 
            // button1
            // 
            button1.Location = new Point(95, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(176, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 254);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 16;
            label5.Text = "Kalória";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 198);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "Hossz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 14;
            label3.Text = "Dátum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 13;
            label2.Text = "Edzés";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 12;
            label1.Text = "Név";
            // 
            // FormDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "FormDelete";
            Text = "FormDelete";
            Load += FormDelete_Load;
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)workoutBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private BindingSource personBindingSource;
        private BindingSource workoutBindingSource;
    }
}