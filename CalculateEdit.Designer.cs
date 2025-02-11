namespace WinFormsApp1
{
    partial class CalculateEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateEdit));
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(131, 45);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 2;
            label1.Text = "Επέλεξε Ταξί";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(467, 45);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 6;
            label2.Text = "Από";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy MM  dd";
            dateTimePicker1.Location = new Point(387, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(745, 45);
            label3.Name = "label3";
            label3.Size = new Size(41, 23);
            label3.TabIndex = 8;
            label3.Text = "Έως";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(660, 71);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(207, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(79, 120);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 10;
            label4.Text = "Ενοίκιο";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(250, 120);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 11;
            label5.Text = "Έξοδα";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(928, 389);
            dataGridView1.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Location = new Point(12, 595);
            button2.Name = "button2";
            button2.Size = new Size(134, 43);
            button2.TabIndex = 18;
            button2.Text = "Επιστροφή";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.Location = new Point(167, 595);
            button3.Name = "button3";
            button3.Size = new Size(246, 43);
            button3.TabIndex = 19;
            button3.Text = "Εμφάνισε Ταξί";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(445, 595);
            button1.Name = "button1";
            button1.Size = new Size(255, 44);
            button1.TabIndex = 22;
            button1.Text = "Ενημέρωση Ταξί";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.Location = new Point(716, 594);
            button4.Name = "button4";
            button4.Size = new Size(224, 44);
            button4.TabIndex = 23;
            button4.Text = "Διαγραφή Ταξί";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(387, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 23);
            textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(543, 146);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GradientActiveCaption;
            label6.Location = new Point(400, 120);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 27;
            label6.Text = "FreeNow";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GradientActiveCaption;
            label7.Location = new Point(563, 120);
            label7.Name = "label7";
            label7.Size = new Size(49, 23);
            label7.TabIndex = 28;
            label7.Text = "Uber";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(686, 146);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 30;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(814, 146);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.GradientActiveCaption;
            label9.Location = new Point(716, 120);
            label9.Name = "label9";
            label9.Size = new Size(49, 23);
            label9.TabIndex = 32;
            label9.Text = "ΦΠΑ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.GradientActiveCaption;
            label10.Location = new Point(831, 120);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 33;
            label10.Text = "Ένσημα";
            // 
            // CalculateEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(952, 651);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalculateEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalculateEdit";
            Load += CalculateEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label9;
        private Label label10;
    }
}