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

namespace TıcarıOtomasyon.Formlar
{
    public partial class musterıler : Form
    {
        public musterıler()
        {
            InitializeComponent();
        }
        sqlBaglantı bgl = new sqlBaglantı();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da =new SqlDataAdapter("Select * from MUSTERILER",bgl.baglanti());
            da.Fill(dt);
            musterıgrıde.DataSource = dt;
        }

        private void musterıler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into MUSTERILER" +
                "(AD ,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRESI)" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",adRow.)
        }
    }
}
