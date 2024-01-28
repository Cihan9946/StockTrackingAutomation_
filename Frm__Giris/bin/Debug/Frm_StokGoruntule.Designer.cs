
namespace Frm_Giris
{
    partial class Frm_StokGoruntule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StokGoruntule));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_filtre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbox_geri = new System.Windows.Forms.PictureBox();
            this.btn_kapat = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_geri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 519);
            this.dataGridView1.TabIndex = 2;
            // 
            // txt_filtre
            // 
            this.txt_filtre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_filtre.Location = new System.Drawing.Point(473, 103);
            this.txt_filtre.Name = "txt_filtre";
            this.txt_filtre.Size = new System.Drawing.Size(224, 28);
            this.txt_filtre.TabIndex = 0;
            this.txt_filtre.TextChanged += new System.EventHandler(this.txt_filtre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(340, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aranan Ürün :";
            // 
            // pbox_geri
            // 
            this.pbox_geri.BackColor = System.Drawing.Color.Black;
            this.pbox_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_geri.Image = global::Frm_Giris.Properties.Resources.geriTuruncu;
            this.pbox_geri.Location = new System.Drawing.Point(0, 2);
            this.pbox_geri.Name = "pbox_geri";
            this.pbox_geri.Size = new System.Drawing.Size(55, 55);
            this.pbox_geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_geri.TabIndex = 21;
            this.pbox_geri.TabStop = false;
            this.pbox_geri.Click += new System.EventHandler(this.pbox_geri_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Black;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.Image = global::Frm_Giris.Properties.Resources.kapatTuruncu;
            this.btn_kapat.Location = new System.Drawing.Point(973, 2);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(55, 55);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 18;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(104, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 172);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(703, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 172);
            this.panel2.TabIndex = 23;
            // 
            // Frm_StokGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Frm_Giris.Properties.Resources.stokgoruntukle;
            this.ClientSize = new System.Drawing.Size(1028, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbox_geri);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_filtre);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Frm_StokGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncel Stok";
            this.Load += new System.EventHandler(this.Frm_StokGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_geri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_filtre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_kapat;
        private System.Windows.Forms.PictureBox pbox_geri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}