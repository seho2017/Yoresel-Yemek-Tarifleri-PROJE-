using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;

namespace MASA_ÜSTÜ_YÖRESEL_YEMEKLER
{
    public partial class Form2 : Form
    {
        MySqlConnection baglanti;
        public Form2()
        {
            InitializeComponent();


            // TextBox olaylarına bağlıyken kullanılacak olan olayları tanımlayın
            textBox1.MouseEnter += TextBox_MouseEnter;
            textBox1.MouseLeave += TextBox_MouseLeave;

            textBox2.MouseEnter += TextBox_MouseEnter;
            textBox2.MouseLeave += TextBox_MouseLeave;


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
            textBox.BackColor = Color.LightGoldenrodYellow;
        }
        private void button1_Click(object sender, EventArgs e)
        {//Giriş
            MySqlConnection baglan = new MySqlConnection("server='localhost';" + "Database='masa_üstü';" + "Uid='root';" + "Pwd='123456';");
            string sql = $"select * from masa_üstü where kullanici_adi='{textBox1.Text.Trim()}' and sifre = '{textBox2.Text.Trim()}'";
            MySqlCommand komut = new MySqlCommand(sql, baglan);
            baglan.Open();
            MySqlDataReader oku = komut.ExecuteReader();
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (oku.Read())
            {
                Form6 tarif = new Form6();
                tarif.Show();
                this.Hide();
                // Giriş yapıldıktan sonra TextBox'ları temizle
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 kayıt = new Form4();
            kayıt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 Tarif = new Form5();
            Tarif.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form5 Tarif = new Form5();
            Tarif.Show();
            this.Hide();

        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            //mouse hareketi icin;
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;

        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            // localasyonla ilgilenecek maouse hareketiyle hareket
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }

        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            //mouse hareket
            move = false;
        }
    }
}










