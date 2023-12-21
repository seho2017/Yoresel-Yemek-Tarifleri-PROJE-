namespace MASA_ÜSTÜ_YÖRESEL_YEMEKLER
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1146, -1);
            button1.Name = "button1";
            button1.Size = new Size(55, 45);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1204, 44);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(-3, 0);
            button2.Name = "button2";
            button2.Size = new Size(54, 44);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Blackadder ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(538, 99);
            label1.Name = "label1";
            label1.Size = new Size(133, 34);
            label1.TabIndex = 6;
            label1.Text = "Şehir Seçin";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Teal;
            pictureBox4.Location = new Point(-3, 83);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1204, 50);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Van", "Ağrı", "İstanbul", "Amasya", "Erzurum", "Adana", "Urfa", "Diyarbakır", "Gaziantep", "Mardin" });
            comboBox1.Location = new Point(423, 257);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(341, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(423, 286);
            button4.Name = "button4";
            button4.Size = new Size(341, 29);
            button4.TabIndex = 13;
            button4.Text = "Yöresel Yemeklerini Göster";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1202, 576);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        //private ComboBox comboBox1;
        private Label label1;
        private PictureBox pictureBox4;
        private ComboBox comboBox1;
        private Button button4;
    }
}