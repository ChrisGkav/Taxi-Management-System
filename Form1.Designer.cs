namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(63, 134);
            button1.Name = "button1";
            button1.Padding = new Padding(22);
            button1.Size = new Size(175, 174);
            button1.TabIndex = 0;
            button1.Text = "Ταξί και Οδηγοί";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(285, 134);
            button2.Name = "button2";
            button2.Padding = new Padding(22);
            button2.Size = new Size(175, 174);
            button2.TabIndex = 1;
            button2.Text = "Υπολογισμός Εσόδων ";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(503, 134);
            button4.Name = "button4";
            button4.Padding = new Padding(22);
            button4.Size = new Size(175, 174);
            button4.TabIndex = 3;
            button4.Text = "Υπολογισμός Εξόδων Ταξί";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(24, 30, 54);
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 126, 249);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(503, 352);
            button5.Name = "button5";
            button5.Padding = new Padding(22);
            button5.Size = new Size(175, 174);
            button5.TabIndex = 4;
            button5.Text = "Έξοδος";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(721, 134);
            button3.Name = "button3";
            button3.Padding = new Padding(22);
            button3.Size = new Size(175, 174);
            button3.TabIndex = 5;
            button3.Text = "Λίστα  Αναμονής";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(24, 30, 54);
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(0, 126, 249);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(285, 352);
            button6.Name = "button6";
            button6.Padding = new Padding(22);
            button6.Size = new Size(175, 174);
            button6.TabIndex = 6;
            button6.Text = "Service";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(952, 651);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button3;
        private Button button6;
    }
}