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
    public partial class kisilercs : Form
    {
        public kisilercs()
        {
            InitializeComponent();
        }
        public static string ad;
        SqlConnection cnt = new SqlConnection("Data Source = Localhost\\SQLEXPRESS; Initial Catalog = Deneme; Integrated Security = True");
        private void kisilercs_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select ad,soyad from rehber",cnt);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Kişilerin Üzerine Tıklayarak Bilgilerini Görebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ad = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            this.Hide();
            bilgi bilgi = new bilgi();
            bilgi.Show();
        }

        private void kisilercs_FormClosed(object sender, FormClosedEventArgs e)
        {
               this.Hide();
            Menü giris = new Menü();
            giris.Show();
        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menü giris = new Menü();
            giris.Show();
        }

       

        private void kİŞİEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ekle ekle = new Ekle();
            ekle.Show();
        }
    }
}
