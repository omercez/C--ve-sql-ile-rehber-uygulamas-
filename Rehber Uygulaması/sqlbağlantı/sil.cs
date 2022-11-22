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
    public partial class sil : Form
    {
        public sil()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source = Localhost\\SQLEXPRESS; Initial Catalog = Deneme; Integrated Security = True");

        private void sil_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from rehber",cnt);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
			{
			  comboBox1.Items.Add(dt.Rows[i]["ad"].ToString());
			}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnt.Open();
            if (comboBox1.SelectedItem.ToString()==null)
            {
                MessageBox.Show("Lütfen Bir Kişi Seçiniz!");
            }
            else
            {
                SqlCommand silcmd = new SqlCommand("delete from rehber where ad='" + comboBox1.SelectedItem.ToString() + "'");
                silcmd.Connection = cnt;
                silcmd.ExecuteNonQuery();
                cnt.Close();
                MessageBox.Show("Başarıyla Silindi!");
                comboBox1.Items.Clear();
                SqlDataAdapter adp = new SqlDataAdapter("select * from rehber", cnt);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i]["ad"].ToString());
                }
                this.Hide();
                Menü giris = new Menü();
                giris.Show();
            }
           
        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menü giris = new Menü();
            giris.Show();
        }

        private void sil_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menü giris = new Menü();
            giris.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
