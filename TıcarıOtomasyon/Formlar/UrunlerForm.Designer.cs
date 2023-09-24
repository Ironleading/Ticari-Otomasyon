namespace TıcarıOtomasyon.Formlar
{
    partial class UrunlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunlerForm));
            this.verıtabanıkısmı = new DevExpress.XtraEditors.PanelControl();
            this.urunlerGrıde = new DevExpress.XtraGrid.GridControl();
            this.urunlerGrıdevıew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sagtaraf = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.guncellebtn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.detayRıchBox = new System.Windows.Forms.RichTextBox();
            this.adetNumeric = new System.Windows.Forms.NumericUpDown();
            this.detayLabel = new DevExpress.XtraEditors.LabelControl();
            this.satısfıyatText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.adetLabel = new DevExpress.XtraEditors.LabelControl();
            this.alısfıyatıText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.modelText = new DevExpress.XtraEditors.TextEdit();
            this.modelLabel = new DevExpress.XtraEditors.LabelControl();
            this.yılLabel = new DevExpress.XtraEditors.LabelControl();
            this.adText = new DevExpress.XtraEditors.TextEdit();
            this.adLabel = new DevExpress.XtraEditors.LabelControl();
            this.markaText = new DevExpress.XtraEditors.TextEdit();
            this.markaLabel = new DevExpress.XtraEditors.LabelControl();
            this.yılTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ıdText = new DevExpress.XtraEditors.TextEdit();
            this.IdLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.verıtabanıkısmı)).BeginInit();
            this.verıtabanıkısmı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerGrıde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerGrıdevıew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagtaraf)).BeginInit();
            this.sagtaraf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adetNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satısfıyatText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alısfıyatıText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıdText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // verıtabanıkısmı
            // 
            this.verıtabanıkısmı.Controls.Add(this.urunlerGrıde);
            this.verıtabanıkısmı.Dock = System.Windows.Forms.DockStyle.Left;
            this.verıtabanıkısmı.Location = new System.Drawing.Point(0, 0);
            this.verıtabanıkısmı.Name = "verıtabanıkısmı";
            this.verıtabanıkısmı.Size = new System.Drawing.Size(595, 387);
            this.verıtabanıkısmı.TabIndex = 0;
            // 
            // urunlerGrıde
            // 
            this.urunlerGrıde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunlerGrıde.Location = new System.Drawing.Point(2, 2);
            this.urunlerGrıde.MainView = this.urunlerGrıdevıew;
            this.urunlerGrıde.Name = "urunlerGrıde";
            this.urunlerGrıde.Size = new System.Drawing.Size(591, 383);
            this.urunlerGrıde.TabIndex = 0;
            this.urunlerGrıde.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.urunlerGrıdevıew});
            // 
            // urunlerGrıdevıew
            // 
            this.urunlerGrıdevıew.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.AD,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.urunlerGrıdevıew.GridControl = this.urunlerGrıde;
            this.urunlerGrıdevıew.Name = "urunlerGrıdevıew";
            this.urunlerGrıdevıew.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.urunlerGrıdevıew_FocusedRowChanged);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // AD
            // 
            this.AD.Caption = "AD";
            this.AD.FieldName = "URUNAD";
            this.AD.Name = "AD";
            this.AD.Visible = true;
            this.AD.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MARKA";
            this.gridColumn2.FieldName = "MARKA";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "MODEL";
            this.gridColumn3.FieldName = "MODEL";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "YIL";
            this.gridColumn4.FieldName = "YIL";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ADET";
            this.gridColumn5.FieldName = "ADET";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "ALIŞ FİYATI";
            this.gridColumn6.FieldName = "ALISFIYAT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "SATIŞ FİYAT";
            this.gridColumn7.FieldName = "SATISFIYATI";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "ÜRÜN DETAYI";
            this.gridColumn8.FieldName = "DETAY";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            // 
            // sagtaraf
            // 
            this.sagtaraf.Controls.Add(this.simpleButton4);
            this.sagtaraf.Controls.Add(this.guncellebtn);
            this.sagtaraf.Controls.Add(this.simpleButton2);
            this.sagtaraf.Controls.Add(this.simpleButton1);
            this.sagtaraf.Controls.Add(this.detayRıchBox);
            this.sagtaraf.Controls.Add(this.adetNumeric);
            this.sagtaraf.Controls.Add(this.detayLabel);
            this.sagtaraf.Controls.Add(this.satısfıyatText);
            this.sagtaraf.Controls.Add(this.labelControl1);
            this.sagtaraf.Controls.Add(this.adetLabel);
            this.sagtaraf.Controls.Add(this.alısfıyatıText);
            this.sagtaraf.Controls.Add(this.labelControl6);
            this.sagtaraf.Controls.Add(this.modelText);
            this.sagtaraf.Controls.Add(this.modelLabel);
            this.sagtaraf.Controls.Add(this.yılLabel);
            this.sagtaraf.Controls.Add(this.adText);
            this.sagtaraf.Controls.Add(this.adLabel);
            this.sagtaraf.Controls.Add(this.markaText);
            this.sagtaraf.Controls.Add(this.markaLabel);
            this.sagtaraf.Controls.Add(this.yılTextBox);
            this.sagtaraf.Controls.Add(this.ıdText);
            this.sagtaraf.Controls.Add(this.IdLabel);
            this.sagtaraf.Dock = System.Windows.Forms.DockStyle.Right;
            this.sagtaraf.Location = new System.Drawing.Point(599, 0);
            this.sagtaraf.Name = "sagtaraf";
            this.sagtaraf.Size = new System.Drawing.Size(235, 387);
            this.sagtaraf.TabIndex = 1;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(148, 349);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 23;
            this.simpleButton4.Text = "Yeni";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.guncellebtn.Location = new System.Drawing.Point(19, 349);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(75, 23);
            this.guncellebtn.TabIndex = 22;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(148, 320);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 21;
            this.simpleButton2.Text = "Sil";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(19, 320);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // detayRıchBox
            // 
            this.detayRıchBox.Location = new System.Drawing.Point(79, 252);
            this.detayRıchBox.Name = "detayRıchBox";
            this.detayRıchBox.Size = new System.Drawing.Size(130, 62);
            this.detayRıchBox.TabIndex = 19;
            this.detayRıchBox.Text = "";
            // 
            // adetNumeric
            // 
            this.adetNumeric.Location = new System.Drawing.Point(78, 164);
            this.adetNumeric.Name = "adetNumeric";
            this.adetNumeric.Size = new System.Drawing.Size(131, 21);
            this.adetNumeric.TabIndex = 18;
            // 
            // detayLabel
            // 
            this.detayLabel.Location = new System.Drawing.Point(39, 251);
            this.detayLabel.Name = "detayLabel";
            this.detayLabel.Size = new System.Drawing.Size(33, 13);
            this.detayLabel.TabIndex = 16;
            this.detayLabel.Text = "Detay:";
            // 
            // satısfıyatText
            // 
            this.satısfıyatText.Location = new System.Drawing.Point(78, 219);
            this.satısfıyatText.Name = "satısfıyatText";
            this.satısfıyatText.Size = new System.Drawing.Size(131, 20);
            this.satısfıyatText.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 221);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Satış Fiyat:";
            // 
            // adetLabel
            // 
            this.adetLabel.Location = new System.Drawing.Point(45, 166);
            this.adetLabel.Name = "adetLabel";
            this.adetLabel.Size = new System.Drawing.Size(27, 13);
            this.adetLabel.TabIndex = 13;
            this.adetLabel.Text = "Adet:";
            // 
            // alısfıyatıText
            // 
            this.alısfıyatıText.Location = new System.Drawing.Point(78, 190);
            this.alısfıyatıText.Name = "alısfıyatıText";
            this.alısfıyatıText.Size = new System.Drawing.Size(131, 20);
            this.alısfıyatıText.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(25, 192);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Alış Fiyat:";
            // 
            // modelText
            // 
            this.modelText.Location = new System.Drawing.Point(78, 111);
            this.modelText.Name = "modelText";
            this.modelText.Size = new System.Drawing.Size(131, 20);
            this.modelText.TabIndex = 10;
            // 
            // modelLabel
            // 
            this.modelLabel.Location = new System.Drawing.Point(40, 117);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(32, 13);
            this.modelLabel.TabIndex = 9;
            this.modelLabel.Text = "Model:";
            // 
            // yılLabel
            // 
            this.yılLabel.Location = new System.Drawing.Point(58, 145);
            this.yılLabel.Name = "yılLabel";
            this.yılLabel.Size = new System.Drawing.Size(14, 13);
            this.yılLabel.TabIndex = 7;
            this.yılLabel.Text = "Yıl:";
            // 
            // adText
            // 
            this.adText.Location = new System.Drawing.Point(78, 59);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(131, 20);
            this.adText.TabIndex = 6;
            // 
            // adLabel
            // 
            this.adLabel.Location = new System.Drawing.Point(55, 62);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(17, 13);
            this.adLabel.TabIndex = 5;
            this.adLabel.Text = "Ad:";
            // 
            // markaText
            // 
            this.markaText.Location = new System.Drawing.Point(78, 85);
            this.markaText.Name = "markaText";
            this.markaText.Size = new System.Drawing.Size(131, 20);
            this.markaText.TabIndex = 4;
            // 
            // markaLabel
            // 
            this.markaLabel.Location = new System.Drawing.Point(39, 87);
            this.markaLabel.Name = "markaLabel";
            this.markaLabel.Size = new System.Drawing.Size(33, 13);
            this.markaLabel.TabIndex = 3;
            this.markaLabel.Text = "Marka:";
            // 
            // yılTextBox
            // 
            this.yılTextBox.Location = new System.Drawing.Point(78, 137);
            this.yılTextBox.Mask = "0000";
            this.yılTextBox.Name = "yılTextBox";
            this.yılTextBox.Size = new System.Drawing.Size(131, 21);
            this.yılTextBox.TabIndex = 2;
            this.yılTextBox.ValidatingType = typeof(int);
            // 
            // ıdText
            // 
            this.ıdText.Location = new System.Drawing.Point(78, 33);
            this.ıdText.Name = "ıdText";
            this.ıdText.Size = new System.Drawing.Size(131, 20);
            this.ıdText.TabIndex = 1;
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(57, 36);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(15, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 387);
            this.Controls.Add(this.sagtaraf);
            this.Controls.Add(this.verıtabanıkısmı);
            this.Name = "UrunlerForm";
            this.Text = "UrunlerForm";
            this.Load += new System.EventHandler(this.UrunlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verıtabanıkısmı)).EndInit();
            this.verıtabanıkısmı.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerGrıde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerGrıdevıew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagtaraf)).EndInit();
            this.sagtaraf.ResumeLayout(false);
            this.sagtaraf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adetNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satısfıyatText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alısfıyatıText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıdText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl verıtabanıkısmı;
        private DevExpress.XtraEditors.PanelControl sagtaraf;
        private DevExpress.XtraGrid.GridControl urunlerGrıde;
        private DevExpress.XtraGrid.Views.Grid.GridView urunlerGrıdevıew;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton guncellebtn;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox detayRıchBox;
        private System.Windows.Forms.NumericUpDown adetNumeric;
        private DevExpress.XtraEditors.LabelControl detayLabel;
        private DevExpress.XtraEditors.TextEdit satısfıyatText;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl adetLabel;
        private DevExpress.XtraEditors.TextEdit alısfıyatıText;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit modelText;
        private DevExpress.XtraEditors.LabelControl modelLabel;
        private DevExpress.XtraEditors.LabelControl yılLabel;
        private DevExpress.XtraEditors.TextEdit adText;
        private DevExpress.XtraEditors.LabelControl adLabel;
        private DevExpress.XtraEditors.TextEdit markaText;
        private DevExpress.XtraEditors.LabelControl markaLabel;
        private System.Windows.Forms.MaskedTextBox yılTextBox;
        private DevExpress.XtraEditors.TextEdit ıdText;
        private DevExpress.XtraEditors.LabelControl IdLabel;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn AD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}