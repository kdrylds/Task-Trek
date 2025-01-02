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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalendarApp
{
    public partial class TakvimForm : Form
    {
        private DataTable table;

        public TakvimForm(DataTable data)
        {
            InitializeComponent();
            table = data;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Width = 1250;

            // ListView sütunlarını ayarla
            listView1.Columns.Add("EtkinlikSorumlusu", 150);
            listView1.Columns.Add("EtkinlikAcıklaması", 250);
            listView1.Columns.Add("BaslangıcTarihi", 150);
            listView1.Columns.Add("BitisTarihi", 150);
            listView1.Width = 700;
            this.Resize += new EventHandler(Form3_Resize);


            // MonthCalendar'da bugünün tarihini seçili yap
            monthCalendar1.SetDate(DateTime.Now);

            // Bugün ile eşleşen etkinlikleri yükle
            UpdateListView(DateTime.Now);
        }

        private void UpdateListView(DateTime selectedDate)
        {
            listView1.Items.Clear(); // Mevcut öğeleri temizle

            foreach (DataRow row in table.Rows)
            {
                if (row["BaslangıcTarihi"] != null && row["BitisTarihi"] != null)
                {
                    DateTime baslangic = Convert.ToDateTime(row["BaslangıcTarihi"]);
                    DateTime bitis = Convert.ToDateTime(row["BitisTarihi"]);

                    if (selectedDate >= baslangic && selectedDate <= bitis)
                    {
                        ListViewItem item = new ListViewItem(row["EtkinlikSorumlusu"].ToString());
                        item.SubItems.Add(row["EtkinlikAcıklaması"].ToString());
                        item.SubItems.Add(baslangic.ToShortDateString());
                        item.SubItems.Add(bitis.ToShortDateString());
                        listView1.Items.Add(item);
                    }
                }
            }

            // Etkinliklerin renklerini güncelle
            UpdateItemColors();
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            UpdateListView(selectedDate);
        }
        //arka plan renklerini ayarlar
        private void UpdateItemColors()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[3].Text != null &&
                    DateTime.TryParse(item.SubItems[3].Text, out DateTime bitisTarihi))
                {
                    if (bitisTarihi < DateTime.Now)
                    {
                        item.BackColor = Color.FromArgb(250, 185, 185); // Arka plan kırmızı
                    }
                    else if (bitisTarihi >= DateTime.Now && bitisTarihi <= DateTime.Now.AddDays(2))
                    {
                        item.BackColor = Color.FromArgb(250, 243, 185); // Arka plan Sarı
                    }
                    else
                    {
                        item.BackColor = Color.FromArgb(135, 250, 175);  //yeşil arka plan
                    }
                }
            }
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            // Toplam pencere genişliğini hesapla ve kenar boşluklarını düş
            int listViewWidth = listView1.ClientSize.Width;

            // Sütun sayısını al
            int columnCount = listView1.Columns.Count;

            // Her sütunun eşit genişlikte olması için yeni genişlik
            int newColumnWidth = listViewWidth / columnCount;

            // Sütunların genişliğini ayarla
            for (int i = 0; i < columnCount; i++)
            {
                listView1.Columns[i].Width = newColumnWidth;
            }
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

