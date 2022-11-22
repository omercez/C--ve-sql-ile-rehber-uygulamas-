using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace sqlbağlantı
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source = Localhost\\SQLEXPRESS; Initial Catalog = Deneme; Integrated Security = True");
       
        public static int id;
        

        private void btn_giris_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from users", cnt);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (textBox1.Text == dt.Rows[i]["kadi"].ToString())
                {
                    if (textBox2.Text == dt.Rows[i]["sifre"].ToString())
                    {
                        id = Convert.ToInt16(dt.Rows[i]["id"]);
                        MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Menü menu = new Menü();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz Şifre!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz Kullanıcı Adı!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Kayıt register = new Kayıt();
            register.Show();
        }
    }
}