namespace WinFormsApp1
{
    partial class Calculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculate));
            comboBox1 = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button4 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox9 = new TextBox();
            label12 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label13 = new Label();
            dateTimePicker4 = new DateTimePicker();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(54, 25);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 1;
            label1.Text = "Επέλεξε Ταξί";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Location = new Point(213, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(442, 51);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(212, 23);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(287, 25);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 5;
            label2.Text = "Από";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(520, 25);
            label3.Name = "label3";
            label3.Size = new Size(41, 23);
            label3.TabIndex = 6;
            label3.Text = "Έως";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(697, 25);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 7;
            label4.Text = "Ενοίκιο";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(675, 587);
            button1.Name = "button1";
            button1.Size = new Size(148, 45);
            button1.TabIndex = 8;
            button1.Text = "Αποθήκευσε";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Location = new Point(5, 587);
            button2.Name = "button2";
            button2.Size = new Size(142, 45);
            button2.TabIndex = 9;
            button2.Text = "Επιστροφή";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(850, 25);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 10;
            label5.Text = "Έξοδα";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(944, 352);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.Location = new Point(153, 587);
            button3.Name = "button3";
            button3.Size = new Size(207, 45);
            button3.TabIndex = 13;
            button3.Text = "Εμφάνισε Ταξί";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(675, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(818, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.Location = new Point(517, 587);
            button4.Name = "button4";
            button4.Size = new Size(154, 45);
            button4.TabIndex = 16;
            button4.Text = "Τροποποίησε";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(176, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(366, 132);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GradientActiveCaption;
            label6.Location = new Point(188, 106);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 20;
            label6.Text = "FreeNow";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GradientActiveCaption;
            label7.Location = new Point(391, 106);
            label7.Name = "label7";
            label7.Size = new Size(49, 23);
            label7.TabIndex = 21;
            label7.Text = "Uber";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(542, 132);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(711, 132);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.GradientActiveCaption;
            label9.Location = new Point(570, 106);
            label9.Name = "label9";
            label9.Size = new Size(49, 23);
            label9.TabIndex = 25;
            label9.Text = "ΦΠΑ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.GradientActiveCaption;
            label10.Location = new Point(727, 106);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 26;
            label10.Text = "Ένσημα";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.GradientActiveCaption;
            label11.Location = new Point(188, 163);
            label11.Name = "label11";
            label11.Size = new Size(96, 23);
            label11.TabIndex = 30;
            label11.Text = "Αναζήτηση";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(176, 186);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(127, 23);
            textBox9.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.GradientActiveCaption;
            label12.Location = new Point(373, 163);
            label12.Name = "label12";
            label12.Size = new Size(138, 23);
            label12.TabIndex = 33;
            label12.Text = "Επέλεξε Ημ.Από";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(342, 186);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(207, 23);
            dateTimePicker3.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.GradientActiveCaption;
            label13.Location = new Point(617, 163);
            label13.Name = "label13";
            label13.Size = new Size(136, 23);
            label13.TabIndex = 35;
            label13.Text = "Επέλεξε Ημ.Έως";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(586, 186);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(211, 23);
            dateTimePicker4.TabIndex = 36;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(24, 30, 54);
            button5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 126, 249);
            button5.Location = new Point(366, 587);
            button5.Name = "button5";
            button5.Size = new Size(145, 45);
            button5.TabIndex = 37;
            button5.Text = "Αναζήτησε";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(24, 30, 54);
            button6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(0, 126, 249);
            button6.Location = new Point(829, 586);
            button6.Name = "button6";
            button6.Size = new Size(120, 46);
            button6.TabIndex = 38;
            button6.Text = "Εκτύπωσε";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Calculate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(952, 651);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dateTimePicker4);
            Controls.Add(label13);
            Controls.Add(dateTimePicker3);
            Controls.Add(label12);
            Controls.Add(textBox9);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate";
            Load += Calculate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private DataGridView dataGridView1;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox9;
        private Label label12;
        private DateTimePicker dateTimePicker3;
        private Label label13;
        private DateTimePicker dateTimePicker4;
        private Button button5;
        private Button button6;
    }
}