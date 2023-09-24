using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TıcarıOtomasyon.Properties;

namespace TıcarıOtomasyon.Formlar
{
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
        }
        sqlBaglantı bgl =new sqlBaglantı();

        void listele()
        {
            DataTable dt =new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * From URUNLER",
                bgl.baglanti());
            da.Fill(dt);
            urunlerGrıde.DataSource = dt;
        }

        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //VERİLERİ KAYDETME
            SqlCommand komut = new SqlCommand("insert into URUNLER" +
                "(URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYATI,DETAY) values" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", adText.Text);
            komut.Parameters.AddWithValue("@p2",markaText.Text);
            komut.Parameters.AddWithValue("@p3",modelText.Text);
            komut.Parameters.AddWithValue("@p4",yılTextBox.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(adetNumeric.Value.ToString()));
            komut.Parameters.AddWithValue("@p6",decimal.Parse(alısfıyatıText.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(satısfıyatText.Text));
            komut.Parameters.AddWithValue("@p8", detayRıchBox.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil =new SqlCommand("Delete From URUNLER WHERE ID=@p1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", ıdText.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürününüz Başarılı Bir Şekide Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void urunlerGrıdevıew_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                //ÜRÜNLERİ TEXT BOXA ÇEKMEK İÇİN 
                DataRow dr = urunlerGrıdevıew.GetDataRow(urunlerGrıdevıew.FocusedRowHandle);
                ıdText.Text = dr["ID"].ToString();
                adText.Text = dr["URUNAD"].ToString();
                markaText.Text = dr["MARKA"].ToString();
                modelText.Text = dr["MODEL"].ToString();
                yılTextBox.Text = dr["YIL"].ToString();
                adetNumeric.Value = decimal.Parse(dr["ADET"].ToString());
                alısfıyatıText.Text = dr["ALISFIYAT"].ToString();
                satısfıyatText.Text = dr["SATISFIYATI"].ToString();
                detayRıchBox.Text = dr["DETAY"].ToString();
                ıdText.Properties.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void temizle()
        {
            ıdText.Text = "";
            adText.Text = "";
            markaText.Text = ""; 
            modelText.Text = "";
            yılTextBox.Text = "";
            //adetNumeric.Value = decimal.Parse("");
            alısfıyatıText.Text = "";
            satısfıyatText.Text = "";
            detayRıchBox.Text = "";

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //yeni kayıt oluşturma
            temizle();
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update URUNLER set " +
                    "URUNAD=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATISFIYATI=@P7,DETAY=@P8 where ID=@P9", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", adText.Text);
                komut.Parameters.AddWithValue("@P2", markaText.Text);
                komut.Parameters.AddWithValue("@P3", modelText.Text);
                komut.Parameters.AddWithValue("@P4", yılTextBox.Text);
                komut.Parameters.AddWithValue("@P5", int.Parse(adetNumeric.Value.ToString()));
                komut.Parameters.AddWithValue("@P6", decimal.Parse(alısfıyatıText.Text));
                komut.Parameters.AddWithValue("@P7", decimal.Parse(satısfıyatText.Text));
                komut.Parameters.AddWithValue("@P8", detayRıchBox.Text);
                komut.Parameters.AddWithValue("@P9", ıdText.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürününüz Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
