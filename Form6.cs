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

        }


    }
}







