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

namespace sqlbağlantı
{
    public partial class bilgi : Form
    {
        public bilgi()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source = Localhost\\SQLEXPRESS; Initial Catalog = Deneme; Integrated Security = True");
        public static string ad;
        public static string soyad;
        public static string numara;
        public static string mail;
        public static string adres;

        private void bilgi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from rehber where ad='"+kisilercs.ad.ToString()+"'",cnt);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            label1.Text="Adı= "+dt.Rows[0]["ad"].ToString();
            label2.Text ="Soyadı= "+dt.Rows[0]["soyad"].ToString();
            label3.Text ="Tel No= "+dt.Rows[0]["numara"].ToString();
            label4.Text ="E-Mail= "+dt.Rows[0]["email"].ToString();
            label5.Text ="Adresi= "+dt.Rows[0]["adres"].ToString();

            ad= dt.Rows[0]["ad"].ToString();
            soyad= dt.Rows[0]["soyad"].ToString();
            numara= dt.Rows[0]["numara"].ToString();
            mail= dt.Rows[0]["email"].ToString();
            adres= dt.Rows[0]["adres"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            güncelle günc = new güncelle();
            günc.Show();
        }

        private void sdgsdgdrgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            kisilercs kisiler = new kisilercs();
            kisiler.Show();
        }
    }
}
