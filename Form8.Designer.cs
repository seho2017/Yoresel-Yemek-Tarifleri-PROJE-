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
            KATEGORİLER = new ListBox();
            button1 = new Button();
            button2 = new Button();
            Fotoğraflar = new ListBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(-2, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1197, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // KATEGORİLER
            // 
            KATEGORİLER.BackColor = Color.Red;
            KATEGORİLER.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            KATEGORİLER.FormattingEnabled = true;
            KATEGORİLER.ItemHeight = 21;
            KATEGORİLER.Location = new Point(317, 187);
            KATEGORİLER.Name = "KATEGORİLER";
            KATEGORİLER.Size = new Size(208, 235);
            KATEGORİLER.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(-2, -4);
            button1.Name = "button1";
            button1.Size = new Size(46, 50);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(1143, -2);
            button2.Name = "button2";
            button2.Size = new Size(52, 48);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Fotoğraflar
            // 
            Fotoğraflar.BackColor = Color.Red;
            Fotoğraflar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Fotoğraflar.FormattingEnabled = true;
            Fotoğraflar.ItemHeight = 25;
            Fotoğraflar.Location = new Point(572, 187);
            Fotoğraflar.Name = "Fotoğraflar";
            Fotoğraflar.Size = new Size(227, 229);
            Fotoğraflar.TabIndex = 12;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Red;
            linkLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(600, 216);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(180, 21);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ana Yemek Fotoğrafları\r\n";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Red;
            linkLabel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(603, 258);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(144, 21);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Çorba Fotoğrafları";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Red;
            linkLabel3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(603, 295);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(129, 21);
            linkLabel3.TabIndex = 15;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Tatlı Fotoğrafları";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.Red;
            linkLabel4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(603, 340);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(147, 21);
            linkLabel4.TabIndex = 16;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "İçecek Fotoğrafları";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(317, 163);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 17;
            label1.Text = "KATEGORİLER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(572, 163);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 18;
            label2.Text = "FOTOĞRAFLAR";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1194, 586);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(Fotoğraflar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(KATEGORİLER);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ListBox KATEGORİLER;
        private Button button1;
        private Button button2;
        private ListBox Fotoğraflar;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private Label label1;
        private Label label2;
    }
}