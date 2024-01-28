
namespace Frm_Giris
{
    partial class Frm_Acilis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Acilis));
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.BackColor = System.Drawing.Color.Black;
            this.btn_kullanici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kullanici.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullanici.ForeColor = System.Drawing.Color.White;
            this.btn_kullanici.Location = new System.Drawing.Point(40, 242);
            this.btn_kullanici.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(234, 68);
            this.btn_kullanici.TabIndex = 1;
            this.btn_kullanici.Text = "ÜYE GİRİŞ";
            this.btn_kullanici.UseVisualStyleBackColor = false;
            this.btn_kullanici.Click += new System.EventHandler(this.btn_kullanici_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.Black;
            this.btn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admin.ForeColor = System.Drawing.Color.White;
            this.btn_admin.Location = new System.Drawing.Point(344, 242);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(234, 68);
            this.btn_admin.TabIndex = 2;
            this.btn_admin.Text = "YÖNETİCİ GİRİŞ";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.Image = global::Frm_Giris.Properties.Resources.kapatTuruncu;
            this.btn_kapat.Location = new System.Drawing.Point(557, 2);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(42, 41);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 2;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(163, 331);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(288, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Frm_Acilis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Acilis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Acilis";
            this.Load += new System.EventHandler(this.Frm_Acilis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kullanici;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.PictureBox btn_kapat;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}