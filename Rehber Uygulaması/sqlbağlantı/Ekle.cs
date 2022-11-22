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
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection("Data Source = Localhost\\SQLEXPRESS; Initial Catalog = Deneme; Integrated Security = True");
        List<string> isimler = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter bul = new SqlDataAdapter("select * from rehber where ad='" + textBox1.Text + "' or soyad='" + textBox2.Text + "' and numara='" + textBox3.Text + "' or adres='" + richTextBox1.Text + "' and email='" + textBox4.Text + "'",sql);
            DataTable sonuc = new DataTable();
            bul.Fill(sonuc);
            if (sonuc.Rows.Count==1)
            {
                MessageBox.Show("Zaten böyle bir kayıt var!");
            }
            else
            {
                if (textBox3.TextLength < 11)
                {
                    MessageBox.Show("Numaranız 11 karakterden oluşmalıdır!");
                }
                else
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Adınızı Giriniz!");
                    }
                    else
                    {
                        if (textBox2.Text == "")
                        {
                            MessageBox.Show("Soyadınızı Giriniz!");
                        }
                        else
                        {
                            if (textBox3.Text == "")
                            {
                                MessageBox.Show("Numaranızı Giriniz!");
                            }
                            else
                            {
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Adresinizi Giriniz!");
                                }
                                else
                                {
                                    if (textBox4.Text == "")
                                    {
                                        MessageBox.Show("E-Mailinizi Giriniz!");
                                    }
                                    else
                                    {
                                        sql.Open();
                                        SqlCommand cmd = new SqlCommand("insert into rehber (id,ad,soyad,numara,adres,email) values (@id,@ad,@soyad,@numara,@adres,@email)");
                                        cmd.Parameters.AddWithValue("@id",Giris.id);
                                        cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                                        cmd.Parameters.AddWithValue("@soyad", textBox2.Text);
                                        cmd.Parameters.AddWithValue("@numara", textBox3.Text);
                                        cmd.Parameters.AddWithValue("@adres", richTextBox1.Text);
                                        cmd.Parameters.AddWithValue("@email", textBox4.Text);
                                        cmd.Connection = sql;
                                        cmd.ExecuteNonQuery();
                                        sql.Close();
                                        MessageBox.Show("Başarıyla Eklendi");
                                        this.Hide();
                                        kisilercs kisi = new kisilercs();
                                        kisi.Show();
                                    }
                                }
                            }
                        }
                    }

                }
            }
            }
           
            

        private void Ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menü giris = new Menü();
            giris.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            kisilercs kisi = new kisilercs();
            kisi.Show();
        }
       
    }
}
