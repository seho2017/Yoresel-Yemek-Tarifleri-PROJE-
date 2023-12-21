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
        private Dictionary<string, List<string>> yemekTarifleri = new Dictionary<string, List<string>>();

        public Form3()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                // Şehir seçildiğinde yapılacak işlemler
                string secilenSehir = comboBox1.SelectedItem.ToString();
            }
            if (comboBox1.DataSource != null)
            {
                // ComboBox'ın veri kaynağı null değilse, işlemleri gerçekleştir
                // Şehir seçildiğinde yapılacak işlemler
                string secilenSehir = comboBox1.SelectedItem.ToString();
            }


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

        public void button4_Click(object sender, EventArgs e)
        {
            string selectedCity = comboBox1.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedCity))
            {
                Form8 form8 = new Form8(selectedCity, yemekTarifleri);
                form8.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir şehir seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}

