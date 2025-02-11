namespace WinFormsApp1
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox8 = new TextBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(198, 62);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 0;
            label1.Text = "Αριθμός Πινακίδας";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(376, 62);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 1;
            label2.Text = "Μάρκα Ταξί";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(492, 62);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 2;
            label3.Text = "Μοντέλο Ταξί";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(625, 62);
            label4.Name = "label4";
            label4.Size = new Size(157, 23);
            label4.TabIndex = 3;
            label4.Text = "Όνομα Υπαλλήλου";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(785, 62);
            label5.Name = "label5";
            label5.Size = new Size(164, 23);
            label5.TabIndex = 4;
            label5.Text = "Επίθετο Υπαλλήλου";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GradientActiveCaption;
            label6.Location = new Point(61, 122);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 5;
            label6.Text = "Ηλικία";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GradientActiveCaption;
            label7.Location = new Point(182, 122);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 6;
            label7.Text = "ΑΦΜ";
            label7.Click += label7_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(376, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(103, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(492, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(625, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(157, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(800, 88);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(140, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(41, 148);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(162, 148);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(115, 23);
            textBox7.TabIndex = 13;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(451, 583);
            button1.Name = "button1";
            button1.Size = new Size(236, 47);
            button1.TabIndex = 14;
            button1.Text = "Ενημέρωση Υπαλλήλου";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Location = new Point(709, 583);
            button2.Name = "button2";
            button2.Size = new Size(231, 47);
            button2.TabIndex = 15;
            button2.Text = "Διαγραφή Υπαλλήλου";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.Location = new Point(19, 583);
            button3.Name = "button3";
            button3.Size = new Size(137, 47);
            button3.TabIndex = 16;
            button3.Text = "Επιστροφή";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(949, 388);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.Location = new Point(182, 583);
            button4.Name = "button4";
            button4.Size = new Size(245, 47);
            button4.TabIndex = 19;
            button4.Text = "Εμφάνισε Υπαλλήλους";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.GradientActiveCaption;
            label8.Location = new Point(329, 122);
            label8.Name = "label8";
            label8.Size = new Size(136, 23);
            label8.TabIndex = 21;
            label8.Text = "Έναρξη Βάρδιας";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.GradientActiveCaption;
            label9.Location = new Point(562, 122);
            label9.Name = "label9";
            label9.Size = new Size(125, 23);
            label9.TabIndex = 22;
            label9.Text = "Τέλος Βάρδιας";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(296, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(522, 148);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 24;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(749, 148);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(127, 23);
            textBox8.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.GradientActiveCaption;
            label10.Location = new Point(749, 122);
            label10.Name = "label10";
            label10.Size = new Size(127, 23);
            label10.TabIndex = 26;
            label10.Text = "Ώρες Εργασίας";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 55;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 56;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.GradientActiveCaption;
            label11.Location = new Point(19, 62);
            label11.Name = "label11";
            label11.Size = new Size(156, 23);
            label11.TabIndex = 57;
            label11.Text = "Επέλεξε Υπάλληλο";
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(952, 651);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label10);
            Controls.Add(textBox8);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditEmployee";
            Load += EditEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox8;
        private Label label10;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label11;
    }
}