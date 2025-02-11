namespace WinFormsApp1
{
    partial class ExpensesCal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesCal));
            label1 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            label3 = new Label();
            textBox9 = new TextBox();
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button5 = new Button();
            button6 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(403, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 2;
            label1.Text = "Επέλεξε Όχημα";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(380, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
            comboBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(25, 79);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 16;
            label5.Text = "Έξοδα Οχήματος";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(928, 377);
            dataGridView1.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Location = new Point(12, 596);
            button2.Name = "button2";
            button2.Size = new Size(128, 43);
            button2.TabIndex = 19;
            button2.Text = "Επιστροφή";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.Location = new Point(146, 596);
            button3.Name = "button3";
            button3.Size = new Size(186, 43);
            button3.TabIndex = 20;
            button3.Text = "Εμφάνισε Οχήματα";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.Location = new Point(474, 596);
            button4.Name = "button4";
            button4.Size = new Size(138, 43);
            button4.TabIndex = 21;
            button4.Text = "Τροποποίησε";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(618, 596);
            button1.Name = "button1";
            button1.Size = new Size(138, 43);
            button1.TabIndex = 22;
            button1.Text = "Αποθήκευσε";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 23);
            textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(312, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 23);
            textBox4.TabIndex = 24;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "yyyy MM  dd";
            dateTimePicker3.Location = new Point(749, 105);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(199, 23);
            dateTimePicker3.TabIndex = 27;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CustomFormat = "yyyy MM  dd";
            dateTimePicker4.Location = new Point(25, 165);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(210, 23);
            dateTimePicker4.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GradientActiveCaption;
            label6.Location = new Point(219, 79);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 31;
            label6.Text = "ΚΤΕΟ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GradientActiveCaption;
            label7.Location = new Point(349, 79);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 32;
            label7.Text = "Οδηγός 1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.GradientActiveCaption;
            label10.Location = new Point(761, 79);
            label10.Name = "label10";
            label10.Size = new Size(153, 23);
            label10.TabIndex = 35;
            label10.Text = "Ημερομηνία ΚΤΕΟ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.GradientActiveCaption;
            label11.Location = new Point(40, 139);
            label11.Name = "label11";
            label11.Size = new Size(172, 23);
            label11.TabIndex = 36;
            label11.Text = "Ημερομηνία Ασφάλ.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(474, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 37;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(510, 79);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 38;
            label2.Text = "Οδηγός 2";
            label2.Click += label2_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(642, 105);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(101, 23);
            textBox7.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.GradientActiveCaption;
            label8.Location = new Point(659, 79);
            label8.Name = "label8";
            label8.Size = new Size(67, 23);
            label8.TabIndex = 44;
            label8.Text = "Ενοίκιο";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(554, 139);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 45;
            label3.Text = "Αναζήτηση";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(531, 165);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(136, 23);
            textBox9.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.GradientActiveCaption;
            label12.Location = new Point(749, 139);
            label12.Name = "label12";
            label12.Size = new Size(138, 23);
            label12.TabIndex = 47;
            label12.Text = "Επέλεξε Ημ.Από";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(716, 165);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 23);
            dateTimePicker1.TabIndex = 48;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(24, 30, 54);
            button5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 126, 249);
            button5.Location = new Point(338, 596);
            button5.Name = "button5";
            button5.Size = new Size(130, 43);
            button5.TabIndex = 51;
            button5.Text = "Αναζήτησε";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(24, 30, 54);
            button6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(0, 126, 249);
            button6.Location = new Point(762, 596);
            button6.Name = "button6";
            button6.Size = new Size(164, 43);
            button6.TabIndex = 52;
            button6.Text = "Εκτύπωσε";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy MM  dd";
            dateTimePicker2.Location = new Point(269, 165);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(222, 23);
            dateTimePicker2.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(269, 139);
            label4.Name = "label4";
            label4.Size = new Size(222, 23);
            label4.TabIndex = 54;
            label4.Text = "Ημερομηνία Καταχώρησης";
            // 
            // ExpensesCal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(952, 651);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label12);
            Controls.Add(textBox9);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ExpensesCal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpensesCal";
            Load += ExpensesCal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label11;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox7;
        private Label label8;
        private Label label3;
        private TextBox textBox9;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private Button button5;
        private Button button6;
        private DateTimePicker dateTimePicker2;
        private Label label4;
    }
}