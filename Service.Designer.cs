namespace WinFormsApp1
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            button2 = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button4 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            label11 = new Label();
            label12 = new Label();
            textBox9 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Location = new Point(2, 545);
            button2.Name = "button2";
            button2.Size = new Size(136, 47);
            button2.TabIndex = 50;
            button2.Text = "Επιστροφή";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(96, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(743, 361);
            dataGridView1.TabIndex = 51;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(73, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 52;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 55;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(463, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 23);
            textBox3.TabIndex = 56;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(83, 32);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 58;
            label2.Text = "Αριθμός Πινακίδας";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(288, 32);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 59;
            label3.Text = "Παρατηρήσεις";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(475, 32);
            label4.Name = "label4";
            label4.Size = new Size(126, 23);
            label4.TabIndex = 60;
            label4.Text = "Κόστος Service";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(654, 32);
            label5.Name = "label5";
            label5.Size = new Size(170, 23);
            label5.TabIndex = 61;
            label5.Text = "Ημερομηνία Service";
            label5.Click += label5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.Location = new Point(144, 545);
            button4.Name = "button4";
            button4.Size = new Size(207, 47);
            button4.TabIndex = 62;
            button4.Text = "Εμφάνισε Service";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(531, 545);
            button1.Name = "button1";
            button1.Size = new Size(208, 47);
            button1.TabIndex = 63;
            button1.Text = "Ενημέρωσε Όχημα";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(639, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 64;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.Location = new Point(745, 545);
            button3.Name = "button3";
            button3.Size = new Size(205, 47);
            button3.TabIndex = 65;
            button3.Text = "Τροποποίησε Service";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.GradientActiveCaption;
            label11.Location = new Point(288, 100);
            label11.Name = "label11";
            label11.Size = new Size(96, 23);
            label11.TabIndex = 66;
            label11.Text = "Αναζήτηση";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.GradientActiveCaption;
            label12.Location = new Point(544, 100);
            label12.Name = "label12";
            label12.Size = new Size(138, 23);
            label12.TabIndex = 67;
            label12.Text = "Επέλεξε Ημ.Από";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(266, 122);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(145, 23);
            textBox9.TabIndex = 69;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(509, 122);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(210, 23);
            dateTimePicker2.TabIndex = 70;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(24, 30, 54);
            button5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 126, 249);
            button5.Location = new Point(357, 546);
            button5.Name = "button5";
            button5.Size = new Size(168, 46);
            button5.TabIndex = 72;
            button5.Text = "Αναζήτησε";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(24, 30, 54);
            button6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(0, 126, 249);
            button6.Location = new Point(403, 598);
            button6.Name = "button6";
            button6.Size = new Size(174, 46);
            button6.TabIndex = 73;
            button6.Text = "Εκτύπωσε";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Service
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(952, 651);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox9);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Service";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service";
            Load += Service_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button4;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Label label11;
        private Label label12;
        private TextBox textBox9;
        private DateTimePicker dateTimePicker2;
        private Button button5;
        private Button button6;
    }
}