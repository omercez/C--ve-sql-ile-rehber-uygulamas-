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
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source = Localhost\\SQLEXPRESS; Initial Catalog = Deneme; Integrated Security = True");
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            cnt.Open();
            if (textBox2.Text==textBox3.Text)
            {
               
                SqlCommand cmd = new SqlCommand("insert into users (kadi,sifre,guvenliksorusu,cevap) values (@kadi,@sifre,@soru,@cevap)",cnt);
                cmd.Parameters.AddWithValue("@kadi", textBox1.Text);
                cmd.Parameters.AddWithValue("@sifre", textBox2.Text);
                cmd.Parameters.AddWithValue("@soru",comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@cevap",textBox5.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Kayıt İşlemi Başarılı!");
                this.Hide();
                Giris gir = new Giris();
                gir.Show();
                cnt.Close();
            }
            else
            {
                MessageBox.Show("Şifreler Aynı Değildir!");
            }
        }

        private void Kayıt_Load(object sender, EventArgs e)
        {
            int rsayı = rnd.Next(1, 5);
            switch (rsayı)
            {
                case 1:

                    break;

                default:
                    break;
            }
        }
    }
}
