using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CalendarApp
{
    public partial class giris_ekrani : Form
    {
        public giris_ekrani()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı için connection string (örnek)
        string conString = "Data Source=DESKTOP-UNK7A4M;Initial Catalog = son; Integrated Security = True; Encrypt=False;";

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullanıcı_adı_textBox1.Text.Trim();
            string sifre = sifre_textBox2.Text.Trim();

            // Veritabanı bağlantısı ve sorgu
            using (SqlConnection connect = new SqlConnection(conString))
            {
                try
                {
                    //connection.Open();
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    // Kullanıcı adı ve şifreyi kontrol eden SQL sorgusu
                    string query = "SELECT COUNT(*) FROM Kullanıcılar WHERE KullanıcıAdı = @pKullanıcıAdı AND Sifre = @pSifre";

                    SqlCommand cmd = new SqlCommand(query, connect);

                    // Parametreleri ekleyelim
                    cmd.Parameters.AddWithValue("@pKullanıcıAdı", kullanıcı_adı_textBox1.Text);
                    cmd.Parameters.AddWithValue("@pSifre", sifre_textBox2.Text);

                    // Sorgu çalıştırılıyor
                    int result = (int)cmd.ExecuteScalar();

                    // Eğer kullanıcı adı ve şifre doğruysa
                    if (result > 0)
                    {
                        // Giriş başarılı, ana formu aç
                        MessageBox.Show("Giriş başarılı!");
                        ScanGraphyMainForm form = new ScanGraphyMainForm();
                        this.Hide(); // Giriş ekranını gizle
                        form.ShowDialog(); // Ana formu göster
                        this.Close(); // Giriş formunu kapat
                    }
                    else
                    {
                        // Hatalı kullanıcı adı veya şifre
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    // Hata durumunda bir mesaj göster
                    MessageBox.Show("Veritabanı bağlantısı hatalı. Hata: " + ex.Message);
                }

            }
        }

        private void giris_ekrani_Load(object sender, EventArgs e)
        {

        }
    }
}
