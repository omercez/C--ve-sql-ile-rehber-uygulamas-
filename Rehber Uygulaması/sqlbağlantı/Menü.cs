using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlbağlantı
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void pcbx_kisiler_Click(object sender, EventArgs e)
        {
            this.Hide();
            kisilercs kisiler = new kisilercs();
            kisiler.Show();
        }

       

        private void pcbx_sil_Click(object sender, EventArgs e)
        {
            this.Hide();
            sil sil = new sil();
            sil.Show();
        }

        private void pcbx_güncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            güncelle günc = new güncelle();
            günc.Show();
        }

        private void yyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris gir = new Giris();
            gir.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ara search = new Ara();
            search.Show();
        }

        private void Menü_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(pcbx_kisiler, "Kişileri Gösterir");
            Aciklama.IsBalloon = true;
            Aciklama.ToolTipIcon = ToolTipIcon.Info;
            Aciklama.ToolTipTitle = "Bilgi";

            Aciklama.SetToolTip(pcbx_sil, "İstediğiniz Kişiyi Siler");
            Aciklama.IsBalloon = true;
            Aciklama.ToolTipIcon = ToolTipIcon.Info;
            Aciklama.ToolTipTitle = "Bilgi";

            Aciklama.SetToolTip(pictureBox1, "Aramak İstediğiniz Kişileri Bulur");
            Aciklama.IsBalloon = true;
            Aciklama.ToolTipIcon = ToolTipIcon.Info;
            Aciklama.ToolTipTitle = "Bilgi";
        }
    }
}
