using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASA_ÜSTÜ_YÖRESEL_YEMEKLER
{
    public partial class Form8 : Form
    {
        private MySqlConnection baglanti;
        private const string connectionString = "server=localhost;database=yemektarifleri;uid=root;pwd=123456;";
        private MySqlConnection favoriConnection;
        private string favoriConnectionString = "server=localhost;database=favori;uid=root;pwd=123456;";
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            baglanti = new MySqlConnection(connectionString);
            KategorileriComboBoxaGetir();
        }
        private void KategorileriComboBoxaGetir()
        {

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            string sorgu = "SELECT DISTINCT Kategori FROM yemektarifleri";
            MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Kategori"].ToString());
                }
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenKategori = comboBox1.SelectedItem.ToString();
            YemekleriListeyeGetir(secilenKategori);

        }
        private void SetPictureBoxImage(string yemekAdi)
        {
            try
            {
                // Yemek adına uygun fotoğraf dosya yolu oluştur
                string imagePath = $"C:\\Users\\biris\\Desktop\\Yemek_fotoğrafları\\{yemekAdi}.jpg"; // Bu yolu kendi projenize göre güncelleyin.

                // Fotoğraf var mı kontrol et
                if (System.IO.File.Exists(imagePath))
                {
                    // Fotoğrafı PictureBox kontrolüne at
                    pictureBox2.Image = Image.FromFile(imagePath);

                }
                else
                {

                    pictureBox2.Image = null; // PictureBox'ı temizle
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata: ");
            }
        }
        private void YemekleriListeyeGetir(string kategori)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = $"SELECT YemekAdi FROM yemektarifleri WHERE Kategori = '{kategori}'";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);

                YEMEKLER.Items.Clear();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        YEMEKLER.Items.Add(reader["YemekAdi"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata: ");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void YEMEKLER_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenYemek = YEMEKLER.SelectedItem.ToString();
            TarifiGoster(secilenYemek);
            SetPictureBoxImage(secilenYemek);
        }
        private void TarifiGoster(string yemekAdi)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = $"SELECT Tarif FROM yemektarifleri WHERE YemekAdi = '{yemekAdi}'";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        richTextBox1.Text = reader["Tarif"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata: ");
            }
            finally
            {
                baglanti.Close();
            }
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void Form8_MouseDown(object sender, MouseEventArgs e)
        {
            //mouse hareketi icin;
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form8_MouseUp(object sender, MouseEventArgs e)
        {
            //mouse hareket
            move = false;

        }

        private void Form8_MouseMove(object sender, MouseEventArgs e)
        {
            // localasyonla ilgilenecek maouse hareketiyle hareket
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}