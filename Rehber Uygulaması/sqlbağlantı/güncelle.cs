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
    public partial class güncelle : Form
    {
        public güncelle()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source = Localhost\\SQLEXPRESS; Initial Catalog = Deneme; Integrated Security = True");
        SqlDataAdapter adp;
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter bul = new SqlDataAdapter("select * from rehber where ad='" + textBox1.Text + "' or soyad='" + textBox2.Text + "' and numara='" + textBox3.Text + "' or adres='" + richTextBox1.Text + "' and email='" + textBox4.Text + "'", cnt);
            DataTable sonuc = new DataTable();
            bul.Fill(sonuc);
           
                cnt.Open();
                SqlCommand cmd = new SqlCommand("update rehber set ad='" + textBox1.Text + "',soyad='" + textBox2.Text + "' ,numara='" + textBox3.Text + "' ,adres='" + richTextBox1.Text + "' ,email='" + textBox4.Text + "' where ad='" + kisilercs.ad + "'");
                cmd.Connection = cnt;
                cmd.ExecuteNonQuery();
                cnt.Close();
                MessageBox.Show("Başarıyla Güncellendi!");
                this.Hide();
                bilgi bilgi = new bilgi();
                bilgi.Show();
            
           
        }

      

        private void güncelle_Load(object sender, EventArgs e)
        {

           
            textBox1.Text = bilgi.ad;
            textBox2.Text = bilgi.soyad;
            textBox3.Text = bilgi.numara;
            textBox4.Text = bilgi.mail;
            richTextBox1.Text = bilgi.adres;

        }

        private void güncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            bilgi bilgi = new bilgi();
            bilgi.Show();
        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            bilgi bilgi = new bilgi();
            bilgi.Show();
        }
    }
}
