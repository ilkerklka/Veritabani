namespace veriTabani
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_urun = new System.Windows.Forms.TextBox();
            this.lbl_urun = new System.Windows.Forms.Label();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_urunID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_urun
            // 
            this.txt_urun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_urun.Enabled = false;
            this.txt_urun.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_urun.Location = new System.Drawing.Point(118, 27);
            this.txt_urun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_urun.Multiline = true;
            this.txt_urun.Name = "txt_urun";
            this.txt_urun.Size = new System.Drawing.Size(206, 22);
            this.txt_urun.TabIndex = 0;
            this.txt_urun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_urun_KeyPress);
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_urun.Location = new System.Drawing.Point(21, 75);
            this.lbl_urun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(66, 24);
            this.lbl_urun.TabIndex = 1;
            this.lbl_urun.Text = "Ürün : ";
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stok.Location = new System.Drawing.Point(21, 120);
            this.lbl_stok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(56, 24);
            this.lbl_stok.TabIndex = 2;
            this.lbl_stok.Text = "Stok :";
            // 
            // txt_stok
            // 
            this.txt_stok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stok.Location = new System.Drawing.Point(118, 77);
            this.txt_stok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_stok.Multiline = true;
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(206, 22);
            this.txt_stok.TabIndex = 1;
            this.txt_stok.TextChanged += new System.EventHandler(this.txt_stok_TextChanged);
            this.txt_stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stok_KeyPress);
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fiyat.Location = new System.Drawing.Point(21, 159);
            this.lbl_fiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(59, 24);
            this.lbl_fiyat.TabIndex = 4;
            this.lbl_fiyat.Text = "Fiyat :";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fiyat.Location = new System.Drawing.Point(118, 119);
            this.txt_fiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_fiyat.Multiline = true;
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(206, 22);
            this.txt_fiyat.TabIndex = 2;
            this.txt_fiyat.TextChanged += new System.EventHandler(this.txt_fiyat_TextChanged);
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fiyat_KeyPress);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(483, 23);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(93, 32);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(483, 73);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(94, 32);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(483, 117);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(94, 32);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ID.Location = new System.Drawing.Point(20, 25);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(91, 24);
            this.lbl_ID.TabIndex = 10;
            this.lbl_ID.Text = "Ürün No :";
            // 
            // txt_urunID
            // 
            this.txt_urunID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_urunID.Location = new System.Drawing.Point(118, 159);
            this.txt_urunID.Multiline = true;
            this.txt_urunID.Name = "txt_urunID";
            this.txt_urunID.Size = new System.Drawing.Size(206, 24);
            this.txt_urunID.TabIndex = 3;
            this.txt_urunID.TextChanged += new System.EventHandler(this.txt_urunID_TextChanged);
            this.txt_urunID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_urunID_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(539, 208);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(620, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_urunID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.lbl_urun);
            this.Controls.Add(this.txt_urun);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spot Ürün Kontrol Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_urun;
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_urunID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

