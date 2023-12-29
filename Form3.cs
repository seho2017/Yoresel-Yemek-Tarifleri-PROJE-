﻿using MySql.Data.MySqlClient;
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
    public partial class Form3 : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;database=yemektarifleri;uid=root;pwd=123456;";


        public Form3()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            FillCitiesComboBox();

        }
        private void FillCitiesComboBox()
        {
            try
            {
                connection.Open();
                string query = "SELECT DISTINCT Sehir FROM yemektarifleri";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxSehir.Items.Add(reader["Sehir"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void FillCategoriesComboBox(string sehir)
        {
            try
            {
                connection.Open();
                string query = $"SELECT DISTINCT Kategori FROM yemektarifleri WHERE Sehir = '{sehir}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                comboBoxKategoriler.Items.Clear();
                while (reader.Read())
                {
                    comboBoxKategoriler.Items.Add(reader["Kategori"].ToString());
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
        private void FillMealsComboBox(string sehir, string kategori)
        {
            try
            {
                connection.Open();
                string query = $"SELECT yemekAdi FROM yemektarifleri WHERE Sehir = '{sehir}' AND Kategori = '{kategori}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                comboBoxYemekler.Items.Clear();
                while (reader.Read())
                {
                    comboBoxYemekler.Items.Add(reader["yemekAdi"].ToString());
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
        private void GetYemekTarifi(string sehir, string kategori, string yemekAdi)
        {
            try
            {
                connection.Open();
                string query = $"SELECT Tarif FROM yemektarifleri WHERE Sehir = '{sehir}' AND Kategori = '{kategori}' AND YemekAdi = '{yemekAdi}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    richTextBoxTarif.Text = result.ToString();
                }
                else
                {
                    richTextBoxTarif.Text = "Yemek tarifi bulunamadı.";
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
        bool move;
        int mouse_x;
        int mouse_y;

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            //mouse hareketi icin;
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            //mouse hareket
            move = false;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            // localasyonla ilgilenecek maouse hareketiyle hareket
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Tarif = new Form2();
            Tarif.Show();
            this.Hide();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sehir = comboBoxSehir.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(sehir))
            {
                FillCategoriesComboBox(sehir);
            }
        }

        private void comboBoxKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sehir = comboBoxSehir.SelectedItem?.ToString();
            string kategori = comboBoxKategoriler.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(sehir) && !string.IsNullOrEmpty(kategori))
            {
                FillMealsComboBox(sehir, kategori);
            }

        }

        private void comboBoxYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sehir = comboBoxSehir.SelectedItem?.ToString();
            string kategori = comboBoxKategoriler.SelectedItem?.ToString();
            string yemekAdi = comboBoxYemekler.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(yemekAdi) && !string.IsNullOrEmpty(sehir) && !string.IsNullOrEmpty(kategori) && !string.IsNullOrEmpty(yemekAdi))
            {
                SetPictureBoxImage(yemekAdi);
                GetYemekTarifi(sehir, kategori, yemekAdi);
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
                    label6.Visible = false;
                }
                else
                {
                    label6.Visible = true;
                    pictureBox2.Image = null; // PictureBox'ı temizle
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata: ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string sehir = comboBoxSehir.SelectedItem?.ToString();
            string kategori = comboBoxKategoriler.SelectedItem?.ToString();
            string yemekAdi = comboBoxYemekler.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(sehir) || string.IsNullOrEmpty(kategori) || string.IsNullOrEmpty(yemekAdi))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            else
            {
                richTextBoxTarif.Clear();
            }

            GetYemekTarifi(sehir, kategori, yemekAdi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBoxTarif.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sehir = comboBoxSehir.SelectedItem?.ToString();
            string kategori = comboBoxKategoriler.SelectedItem?.ToString();
            string yemekAdi = comboBoxYemekler.SelectedItem?.ToString();
            string tarif = richTextBoxTarif.Text;
            if (!string.IsNullOrEmpty(sehir) && !string.IsNullOrEmpty(kategori) && !string.IsNullOrEmpty(yemekAdi))
            {
                try
                {
                    connection.Open();
                    string insertQuery = $"INSERT INTO Favoriler ( Sehir, Kategori, YemekAdi, Tarif) " +
                                        $"VALUES ( '{sehir}', '{kategori}', '{yemekAdi}', '{tarif}')";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Yemek favorilere eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Favori eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("bir hata oluştu" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

