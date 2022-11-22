namespace sqlbağlantı
{
    partial class Menü
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcbx_sil = new System.Windows.Forms.PictureBox();
            this.pcbx_kisiler = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_sil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_kisiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yyToolStripMenuItem
            // 
            this.yyToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed;
            this.yyToolStripMenuItem.Name = "yyToolStripMenuItem";
            this.yyToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.yyToolStripMenuItem.Text = "ÇIKIŞ";
            this.yyToolStripMenuItem.Click += new System.EventHandler(this.yyToolStripMenuItem_Click);
            // 
            // pcbx_sil
            // 
            this.pcbx_sil.Image = global::sqlbağlantı.Properties.Resources._3;
            this.pcbx_sil.Location = new System.Drawing.Point(189, 53);
            this.pcbx_sil.Name = "pcbx_sil";
            this.pcbx_sil.Size = new System.Drawing.Size(134, 137);
            this.pcbx_sil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbx_sil.TabIndex = 2;
            this.pcbx_sil.TabStop = false;
            this.pcbx_sil.Click += new System.EventHandler(this.pcbx_sil_Click);
            // 
            // pcbx_kisiler
            // 
            this.pcbx_kisiler.Image = global::sqlbağlantı.Properties.Resources.Ekran_Alıntısı;
            this.pcbx_kisiler.Location = new System.Drawing.Point(38, 53);
            this.pcbx_kisiler.Name = "pcbx_kisiler";
            this.pcbx_kisiler.Size = new System.Drawing.Size(134, 137);
            this.pcbx_kisiler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbx_kisiler.TabIndex = 0;
            this.pcbx_kisiler.TabStop = false;
            this.pcbx_kisiler.Click += new System.EventHandler(this.pcbx_kisiler_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sqlbağlantı.Properties.Resources._8;
            this.pictureBox1.Location = new System.Drawing.Point(342, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 285);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbx_sil);
            this.Controls.Add(this.pcbx_kisiler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Menü_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_sil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_kisiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbx_kisiler;
        private System.Windows.Forms.PictureBox pcbx_sil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yyToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}