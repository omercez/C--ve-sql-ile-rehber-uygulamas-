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
    public partial class Ara : Form
    {
        public Ara()
        {
            InitializeComponent();
        }

        SqlConnection cnt = new SqlConnection("Data Source = Localhost\\SQLEXPRESS; Initial Catalog = Deneme; Integrated Security = True");
        private void Ara_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Arama ad soyad'a göre yapılmaktadır");
            SqlDataAdapter adp = new SqlDataAdapter("select * from rehber",cnt);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                SqlDataAdapter adp = new SqlDataAdapter("select ad,soyad from rehber", cnt);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlDataAdapter ara = new SqlDataAdapter("select * from rehber where ad like '%" + textBox1.Text + "%'", cnt);
                DataTable bul = new DataTable();
                ara.Fill(bul);
                dataGridView1.DataSource = bul;
            }
        }

        private void Ara_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menü menu = new Menü();
            menu.Show();
        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menü main = new Menü();
            main.Show();
        }
    }
}
