namespace Cseresznye_OACMUT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            personIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workoutIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workoutNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            durationMinutesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caloriesBurnedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mergedBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mergedBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { personIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, workoutIdDataGridViewTextBoxColumn, workoutNameDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, durationMinutesDataGridViewTextBoxColumn, caloriesBurnedDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mergedBindingSource;
            dataGridView1.Location = new Point(21, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(747, 401);
            dataGridView1.TabIndex = 0;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // workoutIdDataGridViewTextBoxColumn
            // 
            workoutIdDataGridViewTextBoxColumn.DataPropertyName = "WorkoutId";
            workoutIdDataGridViewTextBoxColumn.HeaderText = "WorkoutId";
            workoutIdDataGridViewTextBoxColumn.Name = "workoutIdDataGridViewTextBoxColumn";
            // 
            // workoutNameDataGridViewTextBoxColumn
            // 
            workoutNameDataGridViewTextBoxColumn.DataPropertyName = "WorkoutName";
            workoutNameDataGridViewTextBoxColumn.HeaderText = "WorkoutName";
            workoutNameDataGridViewTextBoxColumn.Name = "workoutNameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // durationMinutesDataGridViewTextBoxColumn
            // 
            durationMinutesDataGridViewTextBoxColumn.DataPropertyName = "DurationMinutes";
            durationMinutesDataGridViewTextBoxColumn.HeaderText = "DurationMinutes";
            durationMinutesDataGridViewTextBoxColumn.Name = "durationMinutesDataGridViewTextBoxColumn";
            // 
            // caloriesBurnedDataGridViewTextBoxColumn
            // 
            caloriesBurnedDataGridViewTextBoxColumn.DataPropertyName = "CaloriesBurned";
            caloriesBurnedDataGridViewTextBoxColumn.HeaderText = "CaloriesBurned";
            caloriesBurnedDataGridViewTextBoxColumn.Name = "caloriesBurnedDataGridViewTextBoxColumn";
            // 
            // mergedBindingSource
            // 
            mergedBindingSource.DataSource = typeof(Merged);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(774, 63);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(774, 92);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Location = new Point(444, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 26);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 5;
            label1.Text = "Név";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(402, 26);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Edzés";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 499);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mergedBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workoutIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workoutNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durationMinutesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caloriesBurnedDataGridViewTextBoxColumn;
        private BindingSource mergedBindingSource;
        private Label label1;
        private Label label2;
    }
}