using Microsoft.VisualBasic.Devices;
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
    public partial class Form7 : Form
    {

        private MySqlConnection connection; // MySQL bağlantısı
        private const string connectionString = "server=localhost;database=favori;uid=root;pwd=123456;";
        private MySqlConnection favoriConnection; // Bağlantı nesnesi düzeltildi
        private string favoriConnectionString = "server=localhost;database=favori;uid=root;pwd=123456;";
        public Form7()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            FillComboBox(); // ComboBox'ı favori yemek adları ile doldur
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Tarif = new Form1();
            Tarif.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYemekAdi = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedYemekAdi))
            {
                SetPictureBoxImage(selectedYemekAdi);
                GetYemekTarifi(selectedYemekAdi);
            }
        }
        private void FillComboBox()
        {
            try
            {
                connection.Open();
                string query = "SELECT YemekAdi FROM favori";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string yemekAdi = reader["YemekAdi"].ToString();
                        comboBox1.Items.Add(yemekAdi);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata: ");
            }
            finally
            {
                connection.Close();
            }
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
        private void GetYemekTarifi(string yemekAdi)
        {
            try
            {
                connection.Open();
                string query = $"SELECT tarif FROM favori WHERE YemekAdi = '{yemekAdi}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    richTextBox1.Text = result.ToString();
                }
                else
                {
                    richTextBox1.Text = "Yemek tarifi bulunamadı.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata: ");
            }
            finally
            {
                connection.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


            using (MySqlConnection favoriConnection = new MySqlConnection("server=localhost;database=favori;uid=root;pwd=123456;"))
            {
                if (comboBox1 != null)
                {
                    string yemekAdi = comboBox1.Text;

                    using (MySqlCommand cmdCheck = new MySqlCommand("SELECT COUNT(*) FROM favori WHERE YemekAdi = @YemekAdi", favoriConnection))
                    {
                        cmdCheck.Parameters.AddWithValue("@YemekAdi", yemekAdi);
                        favoriConnection.Open();
                        int existingCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            // Yemek adı favori tablosunda bulunuyorsa silme işlemi gerçekleştir
                            using (MySqlCommand cmdDelete = new MySqlCommand("DELETE FROM favori WHERE YemekAdi = @YemekAdi", favoriConnection))
                            {
                                cmdDelete.Parameters.AddWithValue("@YemekAdi", yemekAdi);
                                cmdDelete.ExecuteNonQuery();
                                MessageBox.Show("Yemek favorilerinizden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu yemek favorilerinizde bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void Form7_MouseDown(object sender, MouseEventArgs e)
        {
            //mouse hareketi icin;
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form7_MouseUp(object sender, MouseEventArgs e)
        {
            //mouse hareket
            move = false;
        }

        private void Form7_MouseMove(object sender, MouseEventArgs e)
        {
            // localasyonla ilgilenecek maouse hareketiyle hareket
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
    }
}
