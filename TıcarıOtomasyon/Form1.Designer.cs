namespace TıcarıOtomasyon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menucontrolpanel = new DevExpress.XtraEditors.PanelControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnanasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusterıler = new DevExpress.XtraBars.BarButtonItem();
            this.btnFırmalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.btnGıder = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.btnFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menucontrolpanel)).BeginInit();
            this.menucontrolpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // menucontrolpanel
            // 
            this.menucontrolpanel.Controls.Add(this.ribbonControl1);
            this.menucontrolpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menucontrolpanel.Location = new System.Drawing.Point(0, 0);
            this.menucontrolpanel.Name = "menucontrolpanel";
            this.menucontrolpanel.Size = new System.Drawing.Size(794, 524);
            this.menucontrolpanel.TabIndex = 0;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnanasayfa,
            this.btnUrunler,
            this.btnStoklar,
            this.btnMusterıler,
            this.btnFırmalar,
            this.btnPersoneller,
            this.btnGıder,
            this.btnKasa,
            this.btnNotlar,
            this.btnBankalar,
            this.btnRehber,
            this.btnFaturalar,
            this.btnAyarlar,
            this.barButtonItem14});
            this.ribbonControl1.Location = new System.Drawing.Point(2, 2);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(790, 150);
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Caption = "ANA SAYFA";
            this.btnanasayfa.Id = 1;
            this.btnanasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnanasayfa.ImageOptions.Image")));
            this.btnanasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnanasayfa.ImageOptions.LargeImage")));
            this.btnanasayfa.Name = "btnanasayfa";
            // 
            // btnUrunler
            // 
            this.btnUrunler.Caption = "ÜRÜNLER";
            this.btnUrunler.Id = 2;
            this.btnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.Image")));
            this.btnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.LargeImage")));
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
            // 
            // btnStoklar
            // 
            this.btnStoklar.Caption = "STOKLAR";
            this.btnStoklar.Id = 3;
            this.btnStoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStoklar.ImageOptions.Image")));
            this.btnStoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStoklar.ImageOptions.LargeImage")));
            this.btnStoklar.Name = "btnStoklar";
            // 
            // btnMusterıler
            // 
            this.btnMusterıler.Caption = "MÜŞTERİLER";
            this.btnMusterıler.Id = 4;
            this.btnMusterıler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusterıler.ImageOptions.Image")));
            this.btnMusterıler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusterıler.ImageOptions.LargeImage")));
            this.btnMusterıler.Name = "btnMusterıler";
            this.btnMusterıler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusterıler_ItemClick);
            // 
            // btnFırmalar
            // 
            this.btnFırmalar.Caption = "FIRMALAR";
            this.btnFırmalar.Id = 5;
            this.btnFırmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFırmalar.ImageOptions.Image")));
            this.btnFırmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFırmalar.ImageOptions.LargeImage")));
            this.btnFırmalar.Name = "btnFırmalar";
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Caption = "PERSONELLER";
            this.btnPersoneller.Id = 6;
            this.btnPersoneller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersoneller.ImageOptions.Image")));
            this.btnPersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersoneller.ImageOptions.LargeImage")));
            this.btnPersoneller.Name = "btnPersoneller";
            // 
            // btnGıder
            // 
            this.btnGıder.Caption = "GİDERLER";
            this.btnGıder.Id = 7;
            this.btnGıder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGıder.ImageOptions.Image")));
            this.btnGıder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGıder.ImageOptions.LargeImage")));
            this.btnGıder.Name = "btnGıder";
            // 
            // btnKasa
            // 
            this.btnKasa.Caption = "KASA";
            this.btnKasa.Id = 8;
            this.btnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.Image")));
            this.btnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.LargeImage")));
            this.btnKasa.Name = "btnKasa";
            // 
            // btnNotlar
            // 
            this.btnNotlar.Caption = "NOTLAR";
            this.btnNotlar.Id = 9;
            this.btnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.Image")));
            this.btnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.LargeImage")));
            this.btnNotlar.Name = "btnNotlar";
            // 
            // btnBankalar
            // 
            this.btnBankalar.Caption = "BANKALAR";
            this.btnBankalar.Id = 10;
            this.btnBankalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBankalar.ImageOptions.Image")));
            this.btnBankalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBankalar.ImageOptions.LargeImage")));
            this.btnBankalar.Name = "btnBankalar";
            // 
            // btnRehber
            // 
            this.btnRehber.Caption = "REHBER";
            this.btnRehber.Id = 11;
            this.btnRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.Image")));
            this.btnRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.LargeImage")));
            this.btnRehber.Name = "btnRehber";
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.Caption = "FATURALAR";
            this.btnFaturalar.Id = 12;
            this.btnFaturalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturalar.ImageOptions.Image")));
            this.btnFaturalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFaturalar.ImageOptions.LargeImage")));
            this.btnFaturalar.Name = "btnFaturalar";
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Caption = "AYARLAR";
            this.btnAyarlar.Id = 13;
            this.btnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.Image")));
            this.btnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.LargeImage")));
            this.btnAyarlar.Name = "btnAyarlar";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "barButtonItem14";
            this.barButtonItem14.Id = 14;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TİCARİ OTOMASYON";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnanasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusterıler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFırmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGıder);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAyarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 524);
            this.Controls.Add(this.menucontrolpanel);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "-";
            ((System.ComponentModel.ISupportInitialize)(this.menucontrolpanel)).EndInit();
            this.menucontrolpanel.ResumeLayout(false);
            this.menucontrolpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl menucontrolpanel;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnanasayfa;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.BarButtonItem btnStoklar;
        private DevExpress.XtraBars.BarButtonItem btnMusterıler;
        private DevExpress.XtraBars.BarButtonItem btnFırmalar;
        private DevExpress.XtraBars.BarButtonItem btnPersoneller;
        private DevExpress.XtraBars.BarButtonItem btnGıder;
        private DevExpress.XtraBars.BarButtonItem btnKasa;
        private DevExpress.XtraBars.BarButtonItem btnNotlar;
        private DevExpress.XtraBars.BarButtonItem btnBankalar;
        private DevExpress.XtraBars.BarButtonItem btnRehber;
        private DevExpress.XtraBars.BarButtonItem btnFaturalar;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

