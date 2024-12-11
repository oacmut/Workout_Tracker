namespace Cseresznye_OACMUT
{
    partial class FormAdd
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
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            personBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(124, 427);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(205, 427);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = personBindingSource;
            comboBox1.DisplayMember = "Name";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(75, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 2;
            comboBox1.ValueMember = "PersonId";
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Models.Person);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Validating += textBox3_Validating;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 23);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.Validating += textBox4_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 7;
            label1.Text = "Név";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 72);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Edzés";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 111);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "Dátum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 154);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "Hossz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 195);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 11;
            label5.Text = "Kalória";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 462);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormAdd";
            Text = "FormAdd";
            Load += FormAdd_Load;
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private BindingSource personBindingSource;
        private ErrorProvider errorProvider1;
    }
}