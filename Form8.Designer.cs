namespace MASA_ÜSTÜ_YÖRESEL_YEMEKLER
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            YEMEKLER = new ListBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 128, 0);
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1234, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(380, 20);
            label1.Name = "label1";
            label1.Size = new Size(418, 30);
            label1.TabIndex = 0;
            label1.Text = "TARİF KATEGORİLERİ VE TÜM TARİFLER";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(-1, 0);
            button1.Name = "button1";
            button1.Size = new Size(63, 60);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(1170, -2);
            button2.Name = "button2";
            button2.Size = new Size(63, 60);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(224, 224, 224);
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.FromArgb(255, 128, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(554, 33);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(224, 224, 224);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.FromArgb(255, 128, 0);
            richTextBox1.Location = new Point(291, 162);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(469, 514);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(781, 162);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(435, 503);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(0, 63);
            label2.Name = "label2";
            label2.Size = new Size(158, 30);
            label2.TabIndex = 0;
            label2.Text = "KATEGORİ SEÇ";
            // 
            // YEMEKLER
            // 
            YEMEKLER.BackColor = Color.Gainsboro;
            YEMEKLER.BorderStyle = BorderStyle.None;
            YEMEKLER.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            YEMEKLER.ForeColor = Color.FromArgb(255, 128, 0);
            YEMEKLER.FormattingEnabled = true;
            YEMEKLER.ItemHeight = 32;
            YEMEKLER.Location = new Point(-1, 132);
            YEMEKLER.Name = "YEMEKLER";
            YEMEKLER.Size = new Size(268, 544);
            YEMEKLER.TabIndex = 0;
            YEMEKLER.SelectedIndexChanged += YEMEKLER_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(291, 129);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 0;
            label3.Text = "TARİF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(781, 132);
            label4.Name = "label4";
            label4.Size = new Size(144, 30);
            label4.TabIndex = 0;
            label4.Text = "GÖRÜNTÜSÜ";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1228, 667);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(YEMEKLER);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            Load += Form8_Load;
            MouseDown += Form8_MouseDown;
            MouseMove += Form8_MouseMove;
            MouseUp += Form8_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private ListBox YEMEKLER;
        private Label label3;
        private Label label4;
    }
}