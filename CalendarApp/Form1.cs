using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CalendarApp
{
    public partial class ScanGraphyMainForm : Form
    {

        DataTable table = new DataTable("table");
        public ScanGraphyMainForm()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-UNK7A4M;Initial Catalog = son; Integrated Security = True; Encrypt=False;";
        SqlConnection connect = new SqlConnection(constring);

        private void Form1_Load(object sender, EventArgs e)
        {


            // Veritabanından verileri al ve tabloyu güncelle
            LoadEventsFromDatabase();

            // DataGridView ayarları
            dataGridView1.DataSource = table;

            /* table.Columns.Add("Etkinlik Sorumlusu", typeof(string));
            table.Columns.Add("Etkinlik İçeriği", typeof(string));
            table.Columns.Add("Başlangıç Tarihi", typeof(DateTime));
            table.Columns.Add("Bitiş Tarihi", typeof(DateTime)); */
        }

        private void LoadEventsFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT EtkinlikSorumlusu, EtkinlikAcıklaması, BaslangıcTarihi, BitisTarihi FROM Events";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    table.Clear(); // Her yüklemeden önce tablonun içeriğini temizleyin
                    dataAdapter.Fill(table); // Verileri al ve tabloya ekle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message);
                }
            }
        }

       

        private void HighlightExpiredRows()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // "Bitiş Tarihi" sütununun değeri null değilse kontrol et
                if (row.Cells["BitisTarihi"].Value != null &&
                    DateTime.TryParse(row.Cells["BitisTarihi"].Value.ToString(), out DateTime bitisTarihi))
                {
                    // Eğer bitiş tarihi bugünden küçükse
                    if (bitisTarihi < DateTime.Now)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(250, 185, 185); // Arka plan kırmızı
                    }
                    else if (bitisTarihi >= DateTime.Now && bitisTarihi <= DateTime.Now.AddDays(2))//2 gün kalan görevler
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(250, 243, 185); // Arka plan Sarı

                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(135, 250, 175); // Yeşil  arka plan 
                    }
                }
            }
        }




        /* private void EtkinlikSilButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow theRowView in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(theRowView);
                }
            }
            else
                MessageBox.Show("Lütfen bir etkinlik seçin", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } */


        private void DeleteEventFromDatabase(string etkinlikSorumlusu, DateTime baslangicTarihi)
        {
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();

                    // Silme işlemi için SQL komutu
                    string query = "DELETE FROM Events WHERE EtkinlikSorumlusu = @UserName AND BaslangıcTarihi = @EventStartingDate";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserName", etkinlikSorumlusu);
                    command.Parameters.AddWithValue("@EventStartingDate", baslangicTarihi);

                    // Komut çalıştır ve silme işlemini uygula
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı silme işleminde hata: " + ex.Message);
                }
            }
        }

        //SqlConnection con = new SqlConnection();  DATABASE İÇİN SİLME
        //con.ConnectionString = "Data Source=CANSU-PC\\SQLEXPRESS;Database=.\databaseadı;Integrated Security=SSPI;"; 
        //      con.Open(); 
        //      SqlCommand sorguCalistir = new SqlCommand("Delete from tabloadı where kolonadı +" + textBox1.Text + "", con);
        //sorguCalistir.ExecuteNonQuery();

        //    Databaseac();
        //    komut.CommandType = CommandType.Text; 
        //          komut.CommandText =  Delete from tabloadı where kolunadı adı;
        //    int kontrol = (int)komut.ExecuteNonQuery(); 
        //          if (kontrol > 0) 
        //          { 
        //              MessageBox.Show("kayıt silindi"); 
        //          }

        //DatabaseKapat();
        //btnac.PerformClick();



        private void TakvimdeGosterButton_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount > 0)
            {
                TakvimForm form3 = new TakvimForm(table); // 'table' adlı DataTable'ı Form3'e gönder
                form3.ShowDialog();
            }
            else
                MessageBox.Show("Takvimde herhangi bir etkinlik bulunmamaktadır", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            EtkinlikEklemeForm form2 = new EtkinlikEklemeForm();
            if (form2.ShowDialog() == DialogResult.OK) // Form2 "EKLE"bbutonu ile kapatılmışsa
            {
                // Form2'deki gelen bilgileri  ekle
                table.Rows.Add(
                    form2.TextBox1Value,
                    form2.TextBox2Value,
                    form2.DateTime1Value,
                    form2.DateTime2Value
                );

                //Her eklemede rengi kontrol et
                HighlightExpiredRows();
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow theRowView in dataGridView1.SelectedRows)
                {
                    // DataGridView'den kaydın verilerini al
                    string etkinlikSorumlusu = theRowView.Cells["EtkinlikSorumlusu"].Value.ToString();
                    DateTime baslangicTarihi = Convert.ToDateTime(theRowView.Cells["BaslangıcTarihi"].Value);

                    // Veritabanından kaydı silmek için SQL sorgusu
                    DeleteEventFromDatabase(etkinlikSorumlusu, baslangicTarihi);

                    // DataGridView'den satırı sil
                    dataGridView1.Rows.Remove(theRowView);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir etkinlik seçin", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EtkinlikDuzenleButton_Click_1(object sender, EventArgs e)
        {


            DuzenleForm form4 = new DuzenleForm();

            if (dataGridView1.SelectedRows.Count != 0) // Form2 "EKLE" butonu ile kapatılmışsa
            {

                if (form4.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataGridViewRow theRowView in dataGridView1.SelectedRows)
                    {
                        int selectedIndex = dataGridView1.SelectedRows[0].Index;
                        string existingValue1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        string existingValue2 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        string existingValue3 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        string existingValue4 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                        // Geri dönen veriyi güncelle
                        dataGridView1.Rows[selectedIndex].Cells[0].Value = form4.UpdatedValue1;
                        dataGridView1.Rows[selectedIndex].Cells[1].Value = form4.UpdatedValue2;
                        dataGridView1.Rows[selectedIndex].Cells[2].Value = form4.UpdatedValue3;
                        dataGridView1.Rows[selectedIndex].Cells[3].Value = form4.UpdatedValue4;

                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen bir etkinlik seçin", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Her eklemede rengi kontrol et
            HighlightExpiredRows();
        }

        private void bunifuDataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            HighlightExpiredRows();

        }

        private void bunifuDataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HighlightExpiredRows();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}