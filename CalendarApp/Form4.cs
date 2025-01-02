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
    public partial class DuzenleForm : Form
    {
        public string UpdatedValue1 { get; private set; }
        public string UpdatedValue2 { get; private set; }
        public DateTime UpdatedValue3 { get; private set; }
        public DateTime UpdatedValue4 { get; private set; }


        public DuzenleForm()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-UNK7A4M;Initial Catalog = son; Integrated Security = True; Encrypt=False;";
        SqlConnection connect = new SqlConnection(constring);

        private void DuzenleButton_Click(object sender, EventArgs e)
        {

            // Form alanlarından değerleri al
            UpdatedValue1 = DuzenleESTextBox.Text;
            UpdatedValue2 = DuzenleEITextBox.Text;
            UpdatedValue3 = DuzenleDateTimePicker1.Value;
            UpdatedValue4 = DuzenleDateTimePicker2.Value;

            // Alanların doğruluğunu kontrol et
            if (string.IsNullOrWhiteSpace(UpdatedValue1) || string.IsNullOrWhiteSpace(UpdatedValue2))
            {
                MessageBox.Show("Lütfen Etkinlik Sorumlusu ve Etkinlik İçeriği alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UpdatedValue3 > UpdatedValue4)
            {
                MessageBox.Show("Başlangıç Tarihi Bitiş Tarihinden sonra olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Veritabanı bağlantısını aç
            if (connect.State == ConnectionState.Closed)
                connect.Open();

            try
            {
                // Mevcut kaydı benzersiz alanlarla güncelle
                string updateQuery = @"
            UPDATE Events 
            SET EtkinlikAcıklaması = @pEventDescription, 
                BaslangıcTarihi = @pEventStartingDate, 
                BitisTarihi = @pEventEndDate 
            WHERE EtkinlikSorumlusu = @pUserName ";

                SqlCommand komut = new SqlCommand(updateQuery, connect);
                komut.Parameters.AddWithValue("@pUserName", DuzenleESTextBox.Text);
                komut.Parameters.AddWithValue("@pEventDescription", DuzenleEITextBox.Text);
                komut.Parameters.AddWithValue("@pEventStartingDate", DuzenleDateTimePicker1.Value);
                komut.Parameters.AddWithValue("@pEventEndDate", DuzenleDateTimePicker2.Value);

                // Orijinal başlangıç tarihi (düzenleme öncesi tarih)
                komut.Parameters.AddWithValue("@originalStartingDate", DuzenleDateTimePicker1.Value);

                int affectedRows = komut.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Kayıt başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme yapılacak kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close(); // Bağlantıyı kapat
            }
        }

        private void IptalButton_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
