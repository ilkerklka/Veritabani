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

namespace veriTabani
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        void UrunGetir()
        {
            baglanti = new SqlConnection("server=.;Initial Catalog=SpotVeritabanı; Integrated Security=SSPI;");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM Deneme" , baglanti);
            DataTable tablo=new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        private void txt_fiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else 
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Girin" , "HATA!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Handled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunGetir();
        }

        private void txt_stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DialogResult sonuc;
            sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "ONAY", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (sonuc==DialogResult.Yes)
            {
                string sorgu = "DELETE FROM Deneme WHERE urunID=@urunID";
                komut = new SqlCommand(sorgu, baglanti);
                
                    if (baglanti == null)
                {
                   
                    MessageBox.Show("Silinecek Değer yok", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    komut.Parameters.AddWithValue("@urunID", Convert.ToInt32(txt_urun.Text));
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    UrunGetir();
                    MessageBox.Show("Kayıt silme işlemi başarılı", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Kayıt silme işlemi başarısız", "ONAY",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Deneme(urunAdi,stokAdet,Fiyat) VALUES(@urunAdi,@stokAdet,@Fiyat)";
            komut=new SqlCommand(sorgu , baglanti);
            komut.Parameters.AddWithValue("@urunAdi",txt_stok.Text);
            komut.Parameters.AddWithValue("@stokAdet" ,txt_fiyat.Text);
            komut.Parameters.AddWithValue("@Fiyat", txt_urunID.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            UrunGetir();
        }

        private void txt_urunID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_urunID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Girin", "HATA!!!" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void txt_stok_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_urun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Girin", "HATA!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE  Deneme SET urunAdi=@urunAdi , stokAdet=@stokAdet,Fiyat=@Fiyat WHERE urunID=@urunID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@urunID", Convert.ToInt32(txt_urun.Text));
            komut.Parameters.AddWithValue("@urunAdi", txt_stok.Text);
            komut.Parameters.AddWithValue("@stokAdet", txt_fiyat.Text);
            komut.Parameters.AddWithValue("@Fiyat", txt_urunID.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            UrunGetir();
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_urun.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_urunID.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_fiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_stok.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); 
        }
    }
}
