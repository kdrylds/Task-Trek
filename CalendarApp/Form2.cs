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
    public partial class EtkinlikEklemeForm : Form
    {
        public string TextBox1Value { get; private set; }
        public string TextBox2Value { get; private set; }
        public DateTime DateTime1Value { get; private set; }
        public DateTime DateTime2Value { get; private set; }

        public EtkinlikEklemeForm()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-UNK7A4M;Initial Catalog = son; Integrated Security = True; Encrypt=False;";
            SqlConnection connect = new SqlConnection(constring);


        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            // TextBox ve DateTimePicker'daki bilgileri al
            TextBox1Value = EkleESorumlusuTextBox.Text;
            TextBox2Value = EkleEIcerigiTextBox.Text;
            DateTime1Value = EkleDateTimePicker1.Value;
            DateTime2Value = EkleDateTimePicker2.Value;

            if (connect.State == ConnectionState.Closed)
                connect.Open();

            string kayit = ("Insert into Events (EtkinlikSorumlusu,EtkinllikAcıklaması,BaslangıcTarihi,BitisTarihi) values (@pUserName,@pEventDescription,@pEventStartingDate,@pEventEndDate)");
            SqlCommand komut = new SqlCommand(kayit, connect);
            komut.Parameters.AddWithValue("@pUserName", EkleESorumlusuTextBox.Text);
            komut.Parameters.AddWithValue("@pEventDescription", EkleEIcerigiTextBox.Text);
            komut.Parameters.AddWithValue("@pEventStartingDate", EkleDateTimePicker1.Value);
            komut.Parameters.AddWithValue("@pEventEndDate", EkleDateTimePicker2.Value);
            komut.ExecuteNonQuery();

            connect.Close();


            // isimsiz etkinlik ve sorumlusu olmauyan etkinlik eklenemez
            if (string.IsNullOrWhiteSpace(TextBox1Value) || string.IsNullOrWhiteSpace(TextBox2Value))
            {
                MessageBox.Show("Lütfen Etkinlik Sorumlusu ve Etkinlik İçeriği alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //başlangıç tarihi bitiş tarihinden sonra olan etkinlikler eklenemez
            if (DateTime1Value > DateTime2Value)
            {
                MessageBox.Show("Başlangıç Tarihi Bitiş Tarihinden sonra olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // İşlem başarılı
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EkleIptalButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EkleESorumlusuTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
