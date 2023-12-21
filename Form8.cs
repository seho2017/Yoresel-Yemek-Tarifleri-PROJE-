using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MASA_ÜSTÜ_YÖRESEL_YEMEKLER
{
    public partial class Form8 : Form
    {

        private Dictionary<string, List<string>> yemekTarifleri;
        private string selectedCity;


        public Form8(string sehir, Dictionary<string, List<string>> tarifler)
        {
            InitializeComponent();
            selectedCity = sehir;
            yemekTarifleri = tarifler;
            GosterKategoriler();
            string connectionString = "server='localhost';" + "Database='Yemektarifleri';" + "Uid='root';" + "Pwd='123456';";
            using MySqlConnection connection = new MySqlConnection(connectionString);
            string kategori = "Ana Yemekler"; // İstediğiniz kategori
            string query = $"SELECT Tarif FROM Yemektarifleri WHERE Sehir = '{selectedCity}' AND Kategori = '{kategori}'";

            using MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();

            using MySqlDataReader reader = command.ExecuteReader();

            List<string> yemekListesi = new List<string>();
            while (reader.Read())
            {
                string tarif = reader.GetString("tarif");
                yemekListesi.Add(tarif);
            }

            connection.Close();
        }
        private void GosterKategoriler()
        {// Ana yemekleri, çorbaları, tatlıları ve içecekleri ayır
            List<string> anaYemekler = AyirTarif("Ana Yemekler:");
            List<string> corbalar = AyirTarif("Çorbalar:");
            List<string> tatlilar = AyirTarif("Tatlılar:");
            List<string> icecekler = AyirTarif("İçecekler:");

            // Kategorileri linkler halinde ListBox'a ekleme
            KATEGORİLER.Items.Add($"Ana Yemekler ({anaYemekler.Count})");
            KATEGORİLER.Items.Add($"Çorbalar ({corbalar.Count})");
            KATEGORİLER.Items.Add($"Tatlılar ({tatlilar.Count})");
            KATEGORİLER.Items.Add($"İçecekler ({icecekler.Count})");

            int itemCount = KATEGORİLER.Items.Count;
            int padding = 15; // İstediğiniz boşluk miktarını belirleyin

            // Üste ve alta boşluk ekle
            KATEGORİLER.Items.Insert(0, " ");
            KATEGORİLER.Items.Add("");
            // ListBox öğelerini ortalama ve aralarına boşluk eklemek için aşağıdaki kodu kullanabilirsiniz
            foreach (var item in KATEGORİLER.Items)
            {
                // ListBox öğelerini ortalama ve boşluk ekleyerek güncelle

                string formattedItem = item.ToString().PadLeft(padding + item.ToString().Length / 2);
                KATEGORİLER.Items[KATEGORİLER.Items.IndexOf(item)] = formattedItem;
            }

            // Kategoriler arasına boşluk ekleyin
            for (int i = 2; i < itemCount * 2 - 1; i += 2)
            {
                KATEGORİLER.Items.Insert(i, "");
            }

            // Kategorileri düzenle
            for (int i = 2; i < itemCount * 2 - 1; i += 2)
            {
                string itemText = KATEGORİLER.Items[i].ToString();
                string formattedItem = itemText.PadLeft(padding + itemText.Length / 2);
                KATEGORİLER.Items[i] = formattedItem;
            }


        }
        private List<string> AyirTarif(string kategori)
        {
            List<string> yemekListesi = new List<string>();

            // Şehre ait yemek tarifini al
            if (yemekTarifleri.ContainsKey(selectedCity))
            {
                if (yemekTarifleri.ContainsKey(selectedCity))
                {
                    List<string> tarifListesi = yemekTarifleri[selectedCity];

                    // Listeyi birleştirerek bir string elde et
                    string tarif = string.Join(Environment.NewLine, tarifListesi);

                    // Daha sonra tarifi kullanabilirsiniz
                    // ...


                    int kategoriIndex = tarif.IndexOf(kategori);
                    if (kategoriIndex != -1)
                    {
                        // Kategori başlangıcını bul
                        int baslangicIndex = kategoriIndex + kategori.Length;

                        // Kategori sonunu bul (bir sonraki kategori veya tarifin sonu)
                        int sonIndex = tarif.Length;

                        int siralanacakIndex = tarif.IndexOf("Çorbalar:", baslangicIndex);

                        if (siralanacakIndex != -1)
                        {
                            sonIndex = siralanacakIndex;
                        }

                        // Kategori aralığını al ve satırlara ayır
                        string kategoriAraligi = tarif.Substring(baslangicIndex, sonIndex - baslangicIndex);
                        string[] yemekler = kategoriAraligi.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                        // Liste içindeki boşlukları temizle
                        foreach (var yemek in yemekler)
                        {
                            yemekListesi.Add(yemek.Trim());
                        }

                    }

                }


            }
            return yemekListesi;
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
    }
}