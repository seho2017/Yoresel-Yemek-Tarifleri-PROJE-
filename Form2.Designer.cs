using System.Security.Cryptography;

namespace MASA_ÜSTÜ_YÖRESEL_YEMEKLER
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            pictureBox3 = new PictureBox();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(394, 135);
            label1.Name = "label1";
            label1.Size = new Size(381, 32);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı ve Şifrenizi Giriniz\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(403, 239);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(429, 312);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 0;
            label3.Text = "Şifre:";
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.Location = new Point(556, 224);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 38);
            textBox1.TabIndex = 1;
            textBox1.TabIndexChanged += TextBox_MouseEnter;
            textBox1.Enter += TextBox_MouseLeave;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 255, 192);
            textBox2.Location = new Point(556, 295);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(175, 38);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 192);
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(128, 64, 0);
            button2.Location = new Point(610, 404);
            button2.Name = "button2";
            button2.Size = new Size(122, 38);
            button2.TabIndex = 4;
            button2.Text = "KAYIT OL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(128, 64, 0);
            button1.Location = new Point(450, 404);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 5;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 255, 192);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(503, 224);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 255, 192);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(503, 295);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(429, 1);
            button3.Name = "button3";
            button3.Size = new Size(51, 43);
            button3.TabIndex = 8;
            button3.Text = " ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.MouseDownBackColor = Color.White;
            button4.FlatAppearance.MouseOverBackColor = Color.Blue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(503, 0);
            button4.Name = "button4";
            button4.Size = new Size(52, 47);
            button4.TabIndex = 9;
            button4.Text = " ";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatAppearance.MouseDownBackColor = Color.White;
            button5.FlatAppearance.MouseOverBackColor = Color.Blue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(582, 1);
            button5.Name = "button5";
            button5.Size = new Size(52, 42);
            button5.TabIndex = 10;
            button5.Text = " ";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatAppearance.MouseDownBackColor = Color.White;
            button6.FlatAppearance.MouseOverBackColor = Color.Blue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(664, -2);
            button6.Name = "button6";
            button6.Size = new Size(52, 49);
            button6.TabIndex = 11;
            button6.Text = " ";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatAppearance.MouseDownBackColor = Color.White;
            button7.FlatAppearance.MouseOverBackColor = Color.Blue;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(742, -3);
            button7.Name = "button7";
            button7.Size = new Size(57, 45);
            button7.TabIndex = 12;
            button7.Text = " ";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(192, 64, 0);
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Dock = DockStyle.Top;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1183, 48);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(1134, 1);
            button8.Name = "button8";
            button8.Size = new Size(49, 41);
            button8.TabIndex = 14;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(0, -1);
            button9.Name = "button9";
            button9.Size = new Size(39, 49);
            button9.TabIndex = 15;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1183, 577);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GİRİŞ SAYFASI";
            MouseDown += Form2_MouseDown;
            MouseMove += Form2_MouseMove;
            MouseUp += Form2_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public TextBox textBox1;
        public TextBox textBox2;
        public Button button2;
        public Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox3;
        private Button button8;
        private Button button9;
    }
}