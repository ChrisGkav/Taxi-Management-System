namespace WinFormsApp1
{
    partial class StandByEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandByEdit));
            label1 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker4 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            dateTimePicker5 = new DateTimePicker();
            label7 = new Label();
            dateTimePicker6 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker7 = new DateTimePicker();
            label9 = new Label();
            dateTimePicker8 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(408, 23);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 6;
            label1.Text = "Επέλεξε Υπάλληλο";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(378, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 23);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(582, 82);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 31;
            label4.Text = "Covid Έναρξη";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(528, 108);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(789, 82);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 33;
            label5.Text = "Covid Παύση";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(740, 108);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(200, 23);
            dateTimePicker4.TabIndex = 34;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(928, 355);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.Location = new Point(12, 586);
            button3.Name = "button3";
            button3.Size = new Size(128, 47);
            button3.TabIndex = 41;
            button3.Text = "Επιστροφή";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.Location = new Point(157, 586);
            button4.Name = "button4";
            button4.Size = new Size(222, 47);
            button4.TabIndex = 42;
            button4.Text = "Εμφάνισε Υπαλλήλους";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(430, 586);
            button1.Name = "button1";
            button1.Size = new Size(252, 47);
            button1.TabIndex = 43;
            button1.Text = "Ενημέρωση Υπαλλήλου";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Location = new Point(702, 586);
            button2.Name = "button2";
            button2.Size = new Size(238, 47);
            button2.TabIndex = 44;
            button2.Text = "Διαγραφή Δεδομένων";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GradientActiveCaption;
            label6.Location = new Point(251, 150);
            label6.Name = "label6";
            label6.Size = new Size(167, 23);
            label6.TabIndex = 45;
            label6.Text = "Αναρρωτική Έναρξη";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new Point(237, 176);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(200, 23);
            dateTimePicker5.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GradientActiveCaption;
            label7.Location = new Point(552, 150);
            label7.Name = "label7";
            label7.Size = new Size(156, 23);
            label7.TabIndex = 47;
            label7.Text = "Αναρρωτική Τέλος";
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Location = new Point(528, 176);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(200, 23);
            dateTimePicker6.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.GradientActiveCaption;
            label8.Location = new Point(69, 82);
            label8.Name = "label8";
            label8.Size = new Size(117, 23);
            label8.TabIndex = 49;
            label8.Text = "Άδεια Έναρξη";
            // 
            // dateTimePicker7
            // 
            dateTimePicker7.Location = new Point(31, 108);
            dateTimePicker7.Name = "dateTimePicker7";
            dateTimePicker7.Size = new Size(200, 23);
            dateTimePicker7.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.GradientActiveCaption;
            label9.Location = new Point(288, 82);
            label9.Name = "label9";
            label9.Size = new Size(106, 23);
            label9.TabIndex = 51;
            label9.Text = "Άδεια Τέλος";
            label9.Click += label9_Click;
            // 
            // dateTimePicker8
            // 
            dateTimePicker8.Location = new Point(237, 108);
            dateTimePicker8.Name = "dateTimePicker8";
            dateTimePicker8.Size = new Size(200, 23);
            dateTimePicker8.TabIndex = 52;
            // 
            // StandByEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(952, 651);
            Controls.Add(dateTimePicker8);
            Controls.Add(label9);
            Controls.Add(dateTimePicker7);
            Controls.Add(label8);
            Controls.Add(dateTimePicker6);
            Controls.Add(label7);
            Controls.Add(dateTimePicker5);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker4);
            Controls.Add(label5);
            Controls.Add(dateTimePicker3);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StandByEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StandByEdit";
            Load += StandByEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePicker3;
        private Label label5;
        private DateTimePicker dateTimePicker4;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button1;
        private Button button2;
        private Label label6;
        private DateTimePicker dateTimePicker5;
        private Label label7;
        private DateTimePicker dateTimePicker6;
        private Label label8;
        private DateTimePicker dateTimePicker7;
        private Label label9;
        private DateTimePicker dateTimePicker8;
    }
}