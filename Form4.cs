using MySql.Data.MySqlClient;
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
    public partial class Form4 : Form
    {


        public Form4()
        {
            InitializeComponent();

            // TextBox olaylarına bağlıyken kullanılacak olan olayları tanımlayın
            textBox1.MouseEnter += TextBox_MouseEnter;
            textBox1.MouseLeave += TextBox_MouseLeave;

            textBox2.MouseEnter += TextBox_MouseEnter;
            textBox2.MouseLeave += TextBox_MouseLeave;

            textBox3.MouseEnter += TextBox_MouseEnter;
            textBox3.MouseLeave += TextBox_MouseLeave;
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

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerine gelince rengi değiştir
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightBlue;
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerinden çıkınca orijinal rengini geri al
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = SystemColors.Window;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection(
           $"server='localhost';" +
           $"Database='masa_üstü';" +
           $"Uid='root';" +
           $"Pwd='123456';");

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Alanlar boş geçilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "INSERT INTO masa_üstü (kullanici_adi, sifre, sifre_tekrar) VALUES (@kullanici_adi, @sifre, @sifre_tekrar)";
                MySqlCommand komut = new MySqlCommand(sql, baglan);
                komut.Parameters.AddWithValue("@kullanici_adi", textBox1.Text);
                komut.Parameters.AddWithValue("@sifre", textBox2.Text);
                komut.Parameters.AddWithValue("@sifre_tekrar", textBox3.Text);

                baglan.Open();
                komut.ExecuteNonQuery();
                baglan.Close(); // Bağlantıyı kapatma
                MessageBox.Show("Kaydınız Başarıyla Oluşmuştur");
                Form2 Tarif = new Form2();
                Tarif.Show();
                this.Hide();



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Tarif = new Form2();
            Tarif.Show();
            this.Hide();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            //mouse hareketi icin;
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            //mouse hareket
            move = false;
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {

            // localasyonla ilgilenecek maouse hareketiyle hareket
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}