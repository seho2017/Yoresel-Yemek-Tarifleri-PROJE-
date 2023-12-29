namespace MASA_ÜSTÜ_YÖRESEL_YEMEKLER
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(0, -2);
            button1.Name = "button1";
            button1.Size = new Size(41, 50);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1195, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(1142, -2);
            button2.Name = "button2";
            button2.Size = new Size(53, 50);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(1, 146);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 3;
            label1.Text = "Şehir Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(0, 52);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 4;
            label2.Text = "Yemek Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(3, 310);
            label6.Name = "label6";
            label6.Size = new Size(94, 30);
            label6.TabIndex = 8;
            label6.Text = "Tarifi Yaz";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 85);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1195, 50);
            textBox1.TabIndex = 9;
            textBox1.MouseEnter += textBox1_MouseEnter;
            textBox1.MouseLeave += textBox1_MouseLeave;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(0, 357);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(1195, 182);
            textBox6.TabIndex = 14;
            textBox6.MouseEnter += textBox6_MouseEnter;
            textBox6.MouseLeave += textBox6_MouseLeave;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button3.Location = new Point(1, 535);
            button3.Name = "button3";
            button3.Size = new Size(1195, 45);
            button3.TabIndex = 15;
            button3.Text = "TASLAĞI KAYDET";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(1, 236);
            label3.Name = "label3";
            label3.Size = new Size(143, 30);
            label3.TabIndex = 16;
            label3.Text = "kategori Seçin";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ANA YEMEKLER", "ÇORBALAR", "TATLILAR", "KAHVALTILIKLAR" });
            comboBox1.Location = new Point(0, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(1194, 23);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 184);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1194, 49);
            textBox2.TabIndex = 18;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1192, 583);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(textBox6);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            MouseDown += Form6_MouseDown;
            MouseMove += Form6_MouseMove;
            MouseUp += Form6_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox6;
        private Button button3;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox2;
    }
}