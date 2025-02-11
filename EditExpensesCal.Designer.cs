namespace WinFormsApp1
{
    partial class EditExpensesCal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditExpensesCal));
            label1 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            label11 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(416, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 3;
            label1.Text = "Επέλεξε Όχημα";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(398, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(71, 72);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 17;
            label5.Text = "Έξοδα Οχήματος";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(71, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GradientActiveCaption;
            label6.Location = new Point(318, 72);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 32;
            label6.Text = "ΚΤΕΟ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(283, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 23);
            textBox3.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GradientActiveCaption;
            label7.Location = new Point(497, 72);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 34;
            label7.Text = "Οδηγός 1";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(464, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 23);
            textBox4.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(928, 377);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.GradientActiveCaption;
            label10.Location = new Point(253, 145);
            label10.Name = "label10";
            label10.Size = new Size(200, 23);
            label10.TabIndex = 41;
            label10.Text = "Ημερομηνία Ασφάλειας";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.GradientActiveCaption;
            label11.Location = new Point(497, 145);
            label11.Name = "label11";
            label11.Size = new Size(187, 23);
            label11.TabIndex = 42;
            label11.Text = "Ημερομηνία Τέλη Κυκ.";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "yyyy MM  dd";
            dateTimePicker3.Location = new Point(253, 171);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 43;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CustomFormat = "yyyy MM  dd";
            dateTimePicker4.Location = new Point(484, 171);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(200, 23);
            dateTimePicker4.TabIndex = 44;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Location = new Point(32, 599);
            button2.Name = "button2";
            button2.Size = new Size(137, 43);
            button2.TabIndex = 49;
            button2.Text = "Επιστροφή";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.Location = new Point(187, 600);
            button3.Name = "button3";
            button3.Size = new Size(218, 43);
            button3.TabIndex = 50;
            button3.Text = "Εμφάνισε Οχήματα";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(431, 600);
            button1.Name = "button1";
            button1.Size = new Size(225, 42);
            button1.TabIndex = 52;
            button1.Text = "Ενημέρωση Οχήματος";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(730, 72);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 53;
            label2.Text = "Οδηγός 2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(692, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 54;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.GradientActiveCaption;
            label8.Location = new Point(102, 145);
            label8.Name = "label8";
            label8.Size = new Size(67, 23);
            label8.TabIndex = 59;
            label8.Text = "Ενοίκιο";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(71, 171);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(147, 23);
            textBox7.TabIndex = 60;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy MM  dd";
            dateTimePicker2.Location = new Point(709, 171);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(222, 23);
            dateTimePicker2.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(709, 145);
            label4.Name = "label4";
            label4.Size = new Size(222, 23);
            label4.TabIndex = 62;
            label4.Text = "Ημερομηνία Καταχώρησης";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.Location = new Point(680, 599);
            button4.Name = "button4";
            button4.Size = new Size(225, 42);
            button4.TabIndex = 63;
            button4.Text = "Διαγραφή Οχήματος";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // EditExpensesCal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(952, 651);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditExpensesCal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditExpensesCal";
            Load += EditExpensesCal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Button button2;
        private Button button3;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label8;
        private TextBox textBox7;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Button button4;
    }
}