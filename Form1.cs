using System.Drawing.Drawing2D;

namespace MASA_ÜSTÜ_YÖRESEL_YEMEKLER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // PictureBox'ın kenarlarını ovalleştirmek için OvalleştirPictureBox metodunu çağırın
            OvalleştirPictureBox(pictureBox2);
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
            Form5 Tarif = new Form5();
            Tarif.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}