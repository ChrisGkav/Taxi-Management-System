namespace WinFormsApp1
{
    partial class EditService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditService));
            button2 = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Location = new Point(109, 523);
            button2.Name = "button2";
            button2.Size = new Size(145, 43);
            button2.TabIndex = 50;
            button2.Text = "Επιστροφή";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(109, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(743, 345);
            dataGridView1.TabIndex = 53;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(73, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(73, 89);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 59;
            label2.Text = "Αριθμός Πινακίδας";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(297, 89);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 60;
            label3.Text = "Παρατηρήσεις";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(502, 89);
            label4.Name = "label4";
            label4.Size = new Size(126, 23);
            label4.TabIndex = 62;
            label4.Text = "Κόστος Service";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(488, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 23);
            textBox3.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(691, 89);
            label5.Name = "label5";
            label5.Size = new Size(170, 23);
            label5.TabIndex = 64;
            label5.Text = "Ημερομηνία Service";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(675, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 65;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(464, 523);
            button1.Name = "button1";
            button1.Size = new Size(197, 42);
            button1.TabIndex = 66;
            button1.Text = "Ενημέρωσε Όχημα";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.Location = new Point(267, 523);
            button3.Name = "button3";
            button3.Size = new Size(191, 42);
            button3.TabIndex = 67;
            button3.Text = "Εμφάνισε Service";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.Location = new Point(667, 523);
            button4.Name = "button4";
            button4.Size = new Size(185, 42);
            button4.TabIndex = 68;
            button4.Text = "Διέγραψε Όχημα";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // EditService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(952, 651);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditService";
            Load += EditService_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}