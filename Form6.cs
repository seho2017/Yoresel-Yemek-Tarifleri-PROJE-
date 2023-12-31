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
    public partial class Form6 : Form
    {
        private string connectionString = "server='localhost';" + "Database='Yemektarifleri';" + "Uid='root';" + "Pwd='123456';";
        public Form6()
        {
            InitializeComponent();

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
        bool move;
        int mouse_x;
        int mouse_y;
        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            //mouse hareketi icin;
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {

            // localasyonla ilgilenecek maouse hareketiyle hareket
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Form6_MouseUp(object sender, MouseEventArgs e)
        {
            //mouse hareket
            move = false;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerinden çıkınca orijinal rengini geri al
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = SystemColors.Window;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerine gelince rengi değiştir
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightBlue;
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerine gelince rengi değiştir
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightBlue;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerinden çıkınca orijinal rengini geri al
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = SystemColors.Window;
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerine gelince rengi değiştir
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightBlue;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerinden çıkınca orijinal rengini geri al
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = SystemColors.Window;
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerine gelince rengi değiştir
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightBlue;
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerinden çıkınca orijinal rengini geri al
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = SystemColors.Window;
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerine gelince rengi değiştir
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightBlue;
        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerinden çıkınca orijinal rengini geri al
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = SystemColors.Window;
        }

        private void textBox6_MouseEnter(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerine gelince rengi değiştir
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightBlue;
        }

        private void textBox6_MouseLeave(object sender, EventArgs e)
        {
            // Fare TextBox'ın üzerinden çıkınca orijinal rengini geri al
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = SystemColors.Window;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Formdaki değerleri al
            string yemekAdi = textBox1.Text;
            string sehir = textBox2.Text;
            string kategori = comboBox1.SelectedItem?.ToString();
            string tarif = textBox6.Text;

            // Tüm alanların doldurulup doldurulmadığını kontrol et
            if (string.IsNullOrEmpty(yemekAdi) || string.IsNullOrEmpty(sehir) || string.IsNullOrEmpty(kategori) || string.IsNullOrEmpty(tarif))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yemek tarifini veritabanına ekleyen metot
            EkleYemekTarifi(yemekAdi, sehir, kategori, tarif);
        }
        private void EkleYemekTarifi(string yemekAdi, string sehir, string kategori, string tarif)
        {
            string query = "INSERT INTO yemektarifleri (YemekAdi, Sehir, Kategori, Tarif) VALUES (@yemekAdi, @sehir, @kategori, @tarif)";

            using MySqlConnection connection = new MySqlConnection(connectionString);
            using MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@yemekAdi", yemekAdi);
            command.Parameters.AddWithValue("@sehir", sehir);
            command.Parameters.AddWithValue("@kategori", kategori);
            command.Parameters.AddWithValue("@tarif", tarif);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Yemek tarifi başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show($"Yemek tarifi eklenirken bir hata oluştu:");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}









