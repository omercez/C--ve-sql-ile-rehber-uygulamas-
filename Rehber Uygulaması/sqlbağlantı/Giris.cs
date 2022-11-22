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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source = Localhost\\SQLEXPRESS; Initial Catalog = Deneme; Integrated Security = True");
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Kayıt register = new Kayıt();
            register.Show(); 
        }
        public static int id;
        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from users",cnt);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (textBox1.Text==dt.Rows[i]["kadi"].ToString())
                {
                    if (textBox2.Text==dt.Rows[i]["sifre"].ToString())
                    {
                        id = Convert.ToInt16(dt.Rows[i]["id"]);
                        MessageBox.Show("Giriş Başarılı!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Hide();
                        ToolbarForm1 menu = new ToolbarForm1();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz Şifre!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz Kullanıcı Adı!","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
