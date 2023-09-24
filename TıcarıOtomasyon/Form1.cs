using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TıcarıOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunlerForm frmUrun =new Formlar.UrunlerForm();
            
            frmUrun.Show();
        }

        private void btnMusterıler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.musterıler frmmusterı = new Formlar.musterıler();
            frmmusterı.Show();
        }
    }
}
