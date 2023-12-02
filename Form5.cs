using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASA_ÜSTÜ_YÖRESEL_YEMEKLER
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            // PictureBox'ın kenarlarını ovalleştirmek için OvalleştirPictureBox metodunu çağırın
            OvalleştirPictureBox(pictureBox1);
        }

        private void OvalleştirPictureBox(PictureBox pictureBox)
        {
            // Yeni bir GraphicsPath oluşturun
            GraphicsPath path = new GraphicsPath();

            // Elips çizerek GraphicsPath'e ekleyin
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

            // PictureBox'ın Region özelliğini oluşturulan GraphicsPath ile ayarlayın
            pictureBox.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Tarif = new Form2();
            Tarif.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }
    }
}
