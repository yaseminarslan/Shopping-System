
namespace odev_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFiyat1 = new System.Windows.Forms.Label();
            this.lblAdet1 = new System.Windows.Forms.Label();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnSepetiTemizle = new System.Windows.Forms.Button();
            this.lblBaslik1 = new System.Windows.Forms.Label();
            this.lblBaslik2 = new System.Windows.Forms.Label();
            this.lblSepetAdet = new System.Windows.Forms.Label();
            this.lblSepetUrun = new System.Windows.Forms.Label();
            this.lblSepetKdvliFiyat = new System.Windows.Forms.Label();
            this.lstBoxAdet = new System.Windows.Forms.ListBox();
            this.lstBoxUrun = new System.Windows.Forms.ListBox();
            this.lstBoxKDVFiyat = new System.Windows.Forms.ListBox();
            this.lbltxtToplam = new System.Windows.Forms.Label();
            this.lblStok1 = new System.Windows.Forms.Label();
            this.txtStok1 = new System.Windows.Forms.Label();
            this.txtFiyat1 = new System.Windows.Forms.Label();
            this.txtAdet1 = new System.Windows.Forms.NumericUpDown();
            this.txtKDVToplam = new System.Windows.Forms.Label();
            this.txtAdet2 = new System.Windows.Forms.NumericUpDown();
            this.txtFiyat2 = new System.Windows.Forms.Label();
            this.txtStok2 = new System.Windows.Forms.Label();
            this.lblAdet2 = new System.Windows.Forms.Label();
            this.lblStok2 = new System.Windows.Forms.Label();
            this.lblFiyat2 = new System.Windows.Forms.Label();
            this.txtAdet4 = new System.Windows.Forms.NumericUpDown();
            this.txtFiyat4 = new System.Windows.Forms.Label();
            this.txtStok4 = new System.Windows.Forms.Label();
            this.lblAdet4 = new System.Windows.Forms.Label();
            this.lblStok4 = new System.Windows.Forms.Label();
            this.lblFiyat4 = new System.Windows.Forms.Label();
            this.txtAdet3 = new System.Windows.Forms.NumericUpDown();
            this.txtFiyat3 = new System.Windows.Forms.Label();
            this.txtStok3 = new System.Windows.Forms.Label();
            this.lblAdet3 = new System.Windows.Forms.Label();
            this.lblStok3 = new System.Windows.Forms.Label();
            this.lblFiyat3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiyat1
            // 
            this.lblFiyat1.AutoSize = true;
            this.lblFiyat1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiyat1.Location = new System.Drawing.Point(43, 158);
            this.lblFiyat1.Name = "lblFiyat1";
            this.lblFiyat1.Size = new System.Drawing.Size(50, 21);
            this.lblFiyat1.TabIndex = 0;
            this.lblFiyat1.Text = "Fiyat :";
            // 
            // lblAdet1
            // 
            this.lblAdet1.AutoSize = true;
            this.lblAdet1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdet1.Location = new System.Drawing.Point(44, 219);
            this.lblAdet1.Name = "lblAdet1";
            this.lblAdet1.Size = new System.Drawing.Size(49, 21);
            this.lblAdet1.TabIndex = 2;
            this.lblAdet1.Text = "Adet :";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSepeteEkle.Location = new System.Drawing.Point(44, 492);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(175, 32);
            this.btnSepeteEkle.TabIndex = 16;
            this.btnSepeteEkle.Text = "Ürünleri Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnSepetiTemizle
            // 
            this.btnSepetiTemizle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSepetiTemizle.Location = new System.Drawing.Point(295, 492);
            this.btnSepetiTemizle.Name = "btnSepetiTemizle";
            this.btnSepetiTemizle.Size = new System.Drawing.Size(126, 32);
            this.btnSepetiTemizle.TabIndex = 17;
            this.btnSepetiTemizle.Text = "Sepeti Temizle";
            this.btnSepetiTemizle.UseVisualStyleBackColor = true;
            this.btnSepetiTemizle.Click += new System.EventHandler(this.btnSepetiTemizle_Click);
            // 
            // lblBaslik1
            // 
            this.lblBaslik1.AutoSize = true;
            this.lblBaslik1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik1.Location = new System.Drawing.Point(46, 15);
            this.lblBaslik1.Name = "lblBaslik1";
            this.lblBaslik1.Size = new System.Drawing.Size(223, 21);
            this.lblBaslik1.TabIndex = 18;
            this.lblBaslik1.Text = "Ürünlere ait KDV\'siz Fiyatlar";
            // 
            // lblBaslik2
            // 
            this.lblBaslik2.AutoSize = true;
            this.lblBaslik2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik2.Location = new System.Drawing.Point(503, 20);
            this.lblBaslik2.Name = "lblBaslik2";
            this.lblBaslik2.Size = new System.Drawing.Size(105, 21);
            this.lblBaslik2.TabIndex = 19;
            this.lblBaslik2.Text = "Sipariş Özeti";
            // 
            // lblSepetAdet
            // 
            this.lblSepetAdet.AutoSize = true;
            this.lblSepetAdet.Location = new System.Drawing.Point(508, 68);
            this.lblSepetAdet.Name = "lblSepetAdet";
            this.lblSepetAdet.Size = new System.Drawing.Size(32, 15);
            this.lblSepetAdet.TabIndex = 20;
            this.lblSepetAdet.Text = "Adet";
            // 
            // lblSepetUrun
            // 
            this.lblSepetUrun.AutoSize = true;
            this.lblSepetUrun.Location = new System.Drawing.Point(602, 68);
            this.lblSepetUrun.Name = "lblSepetUrun";
            this.lblSepetUrun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSepetUrun.Size = new System.Drawing.Size(33, 15);
            this.lblSepetUrun.TabIndex = 21;
            this.lblSepetUrun.Text = "Ürün";
            // 
            // lblSepetKdvliFiyat
            // 
            this.lblSepetKdvliFiyat.AutoSize = true;
            this.lblSepetKdvliFiyat.Location = new System.Drawing.Point(700, 68);
            this.lblSepetKdvliFiyat.Name = "lblSepetKdvliFiyat";
            this.lblSepetKdvliFiyat.Size = new System.Drawing.Size(66, 15);
            this.lblSepetKdvliFiyat.TabIndex = 22;
            this.lblSepetKdvliFiyat.Text = "KDV\'li Fiyat";
            // 
            // lstBoxAdet
            // 
            this.lstBoxAdet.FormattingEnabled = true;
            this.lstBoxAdet.ItemHeight = 15;
            this.lstBoxAdet.Items.AddRange(new object[] {
            " "});
            this.lstBoxAdet.Location = new System.Drawing.Point(503, 99);
            this.lstBoxAdet.Name = "lstBoxAdet";
            this.lstBoxAdet.Size = new System.Drawing.Size(47, 169);
            this.lstBoxAdet.TabIndex = 23;
            // 
            // lstBoxUrun
            // 
            this.lstBoxUrun.FormattingEnabled = true;
            this.lstBoxUrun.ItemHeight = 15;
            this.lstBoxUrun.Location = new System.Drawing.Point(556, 99);
            this.lstBoxUrun.Name = "lstBoxUrun";
            this.lstBoxUrun.Size = new System.Drawing.Size(130, 169);
            this.lstBoxUrun.TabIndex = 24;
            // 
            // lstBoxKDVFiyat
            // 
            this.lstBoxKDVFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxKDVFiyat.FormattingEnabled = true;
            this.lstBoxKDVFiyat.ItemHeight = 15;
            this.lstBoxKDVFiyat.Location = new System.Drawing.Point(692, 99);
            this.lstBoxKDVFiyat.Name = "lstBoxKDVFiyat";
            this.lstBoxKDVFiyat.Size = new System.Drawing.Size(91, 169);
            this.lstBoxKDVFiyat.TabIndex = 25;
            // 
            // lbltxtToplam
            // 
            this.lbltxtToplam.AutoSize = true;
            this.lbltxtToplam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxtToplam.Location = new System.Drawing.Point(474, 455);
            this.lbltxtToplam.Name = "lbltxtToplam";
            this.lbltxtToplam.Size = new System.Drawing.Size(150, 21);
            this.lbltxtToplam.TabIndex = 26;
            this.lbltxtToplam.Text = "KDV\'li Toplam Fiyat :";
            // 
            // lblStok1
            // 
            this.lblStok1.AutoSize = true;
            this.lblStok1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStok1.Location = new System.Drawing.Point(46, 188);
            this.lblStok1.Name = "lblStok1";
            this.lblStok1.Size = new System.Drawing.Size(47, 21);
            this.lblStok1.TabIndex = 1;
            this.lblStok1.Text = "Stok :";
            // 
            // txtStok1
            // 
            this.txtStok1.AutoSize = true;
            this.txtStok1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStok1.Location = new System.Drawing.Point(104, 188);
            this.txtStok1.Name = "txtStok1";
            this.txtStok1.Size = new System.Drawing.Size(19, 21);
            this.txtStok1.TabIndex = 28;
            this.txtStok1.Text = "0";
            // 
            // txtFiyat1
            // 
            this.txtFiyat1.AutoSize = true;
            this.txtFiyat1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiyat1.Location = new System.Drawing.Point(104, 158);
            this.txtFiyat1.Name = "txtFiyat1";
            this.txtFiyat1.Size = new System.Drawing.Size(19, 21);
            this.txtFiyat1.TabIndex = 29;
            this.txtFiyat1.Text = "0";
            // 
            // txtAdet1
            // 
            this.txtAdet1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdet1.Location = new System.Drawing.Point(104, 217);
            this.txtAdet1.Name = "txtAdet1";
            this.txtAdet1.Size = new System.Drawing.Size(63, 29);
            this.txtAdet1.TabIndex = 30;
            this.txtAdet1.ValueChanged += new System.EventHandler(this.txtAdet1_ValueChanged);
            // 
            // txtKDVToplam
            // 
            this.txtKDVToplam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtKDVToplam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKDVToplam.Location = new System.Drawing.Point(630, 455);
            this.txtKDVToplam.Name = "txtKDVToplam";
            this.txtKDVToplam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKDVToplam.Size = new System.Drawing.Size(153, 21);
            this.txtKDVToplam.TabIndex = 31;
            this.txtKDVToplam.Text = "0 TL";
            this.txtKDVToplam.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAdet2
            // 
            this.txtAdet2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdet2.Location = new System.Drawing.Point(328, 217);
            this.txtAdet2.Name = "txtAdet2";
            this.txtAdet2.Size = new System.Drawing.Size(63, 29);
            this.txtAdet2.TabIndex = 37;
            this.txtAdet2.ValueChanged += new System.EventHandler(this.txtAdet2_ValueChanged);
            // 
            // txtFiyat2
            // 
            this.txtFiyat2.AutoSize = true;
            this.txtFiyat2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiyat2.Location = new System.Drawing.Point(328, 158);
            this.txtFiyat2.Name = "txtFiyat2";
            this.txtFiyat2.Size = new System.Drawing.Size(19, 21);
            this.txtFiyat2.TabIndex = 36;
            this.txtFiyat2.Text = "0";
            // 
            // txtStok2
            // 
            this.txtStok2.AutoSize = true;
            this.txtStok2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStok2.Location = new System.Drawing.Point(328, 188);
            this.txtStok2.Name = "txtStok2";
            this.txtStok2.Size = new System.Drawing.Size(19, 21);
            this.txtStok2.TabIndex = 35;
            this.txtStok2.Text = "0";
            // 
            // lblAdet2
            // 
            this.lblAdet2.AutoSize = true;
            this.lblAdet2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdet2.Location = new System.Drawing.Point(268, 219);
            this.lblAdet2.Name = "lblAdet2";
            this.lblAdet2.Size = new System.Drawing.Size(49, 21);
            this.lblAdet2.TabIndex = 34;
            this.lblAdet2.Text = "Adet :";
            // 
            // lblStok2
            // 
            this.lblStok2.AutoSize = true;
            this.lblStok2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStok2.Location = new System.Drawing.Point(270, 188);
            this.lblStok2.Name = "lblStok2";
            this.lblStok2.Size = new System.Drawing.Size(47, 21);
            this.lblStok2.TabIndex = 33;
            this.lblStok2.Text = "Stok :";
            // 
            // lblFiyat2
            // 
            this.lblFiyat2.AutoSize = true;
            this.lblFiyat2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiyat2.Location = new System.Drawing.Point(267, 158);
            this.lblFiyat2.Name = "lblFiyat2";
            this.lblFiyat2.Size = new System.Drawing.Size(50, 21);
            this.lblFiyat2.TabIndex = 32;
            this.lblFiyat2.Text = "Fiyat :";
            // 
            // txtAdet4
            // 
            this.txtAdet4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdet4.Location = new System.Drawing.Point(329, 447);
            this.txtAdet4.Name = "txtAdet4";
            this.txtAdet4.Size = new System.Drawing.Size(63, 29);
            this.txtAdet4.TabIndex = 43;
            this.txtAdet4.ValueChanged += new System.EventHandler(this.txtAdet4_ValueChanged);
            // 
            // txtFiyat4
            // 
            this.txtFiyat4.AutoSize = true;
            this.txtFiyat4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiyat4.Location = new System.Drawing.Point(329, 388);
            this.txtFiyat4.Name = "txtFiyat4";
            this.txtFiyat4.Size = new System.Drawing.Size(19, 21);
            this.txtFiyat4.TabIndex = 42;
            this.txtFiyat4.Text = "0";
            // 
            // txtStok4
            // 
            this.txtStok4.AutoSize = true;
            this.txtStok4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStok4.Location = new System.Drawing.Point(329, 418);
            this.txtStok4.Name = "txtStok4";
            this.txtStok4.Size = new System.Drawing.Size(19, 21);
            this.txtStok4.TabIndex = 41;
            this.txtStok4.Text = "0";
            // 
            // lblAdet4
            // 
            this.lblAdet4.AutoSize = true;
            this.lblAdet4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdet4.Location = new System.Drawing.Point(269, 449);
            this.lblAdet4.Name = "lblAdet4";
            this.lblAdet4.Size = new System.Drawing.Size(49, 21);
            this.lblAdet4.TabIndex = 40;
            this.lblAdet4.Text = "Adet :";
            // 
            // lblStok4
            // 
            this.lblStok4.AutoSize = true;
            this.lblStok4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStok4.Location = new System.Drawing.Point(271, 418);
            this.lblStok4.Name = "lblStok4";
            this.lblStok4.Size = new System.Drawing.Size(47, 21);
            this.lblStok4.TabIndex = 39;
            this.lblStok4.Text = "Stok :";
            // 
            // lblFiyat4
            // 
            this.lblFiyat4.AutoSize = true;
            this.lblFiyat4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiyat4.Location = new System.Drawing.Point(268, 388);
            this.lblFiyat4.Name = "lblFiyat4";
            this.lblFiyat4.Size = new System.Drawing.Size(50, 21);
            this.lblFiyat4.TabIndex = 38;
            this.lblFiyat4.Text = "Fiyat :";
            // 
            // txtAdet3
            // 
            this.txtAdet3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdet3.Location = new System.Drawing.Point(106, 447);
            this.txtAdet3.Name = "txtAdet3";
            this.txtAdet3.Size = new System.Drawing.Size(63, 29);
            this.txtAdet3.TabIndex = 49;
            this.txtAdet3.ValueChanged += new System.EventHandler(this.txtAdet3_ValueChanged);
            // 
            // txtFiyat3
            // 
            this.txtFiyat3.AutoSize = true;
            this.txtFiyat3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiyat3.Location = new System.Drawing.Point(106, 388);
            this.txtFiyat3.Name = "txtFiyat3";
            this.txtFiyat3.Size = new System.Drawing.Size(19, 21);
            this.txtFiyat3.TabIndex = 48;
            this.txtFiyat3.Text = "0";
            // 
            // txtStok3
            // 
            this.txtStok3.AutoSize = true;
            this.txtStok3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStok3.Location = new System.Drawing.Point(106, 418);
            this.txtStok3.Name = "txtStok3";
            this.txtStok3.Size = new System.Drawing.Size(19, 21);
            this.txtStok3.TabIndex = 47;
            this.txtStok3.Text = "0";
            // 
            // lblAdet3
            // 
            this.lblAdet3.AutoSize = true;
            this.lblAdet3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdet3.Location = new System.Drawing.Point(46, 449);
            this.lblAdet3.Name = "lblAdet3";
            this.lblAdet3.Size = new System.Drawing.Size(49, 21);
            this.lblAdet3.TabIndex = 46;
            this.lblAdet3.Text = "Adet :";
            // 
            // lblStok3
            // 
            this.lblStok3.AutoSize = true;
            this.lblStok3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStok3.Location = new System.Drawing.Point(48, 418);
            this.lblStok3.Name = "lblStok3";
            this.lblStok3.Size = new System.Drawing.Size(47, 21);
            this.lblStok3.TabIndex = 45;
            this.lblStok3.Text = "Stok :";
            // 
            // lblFiyat3
            // 
            this.lblFiyat3.AutoSize = true;
            this.lblFiyat3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiyat3.Location = new System.Drawing.Point(45, 388);
            this.lblFiyat3.Name = "lblFiyat3";
            this.lblFiyat3.Size = new System.Drawing.Size(50, 21);
            this.lblFiyat3.TabIndex = 44;
            this.lblFiyat3.Text = "Fiyat :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::odev_2.Properties.Resources.buz;
            this.pictureBox1.Location = new System.Drawing.Point(46, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::odev_2.Properties.Resources.tv;
            this.pictureBox2.Location = new System.Drawing.Point(264, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::odev_2.Properties.Resources.tel;
            this.pictureBox3.Location = new System.Drawing.Point(46, 278);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::odev_2.Properties.Resources.laptop;
            this.pictureBox4.Location = new System.Drawing.Point(264, 278);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(157, 107);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(829, 558);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAdet3);
            this.Controls.Add(this.txtFiyat3);
            this.Controls.Add(this.txtStok3);
            this.Controls.Add(this.lblAdet3);
            this.Controls.Add(this.lblStok3);
            this.Controls.Add(this.lblFiyat3);
            this.Controls.Add(this.txtAdet4);
            this.Controls.Add(this.txtFiyat4);
            this.Controls.Add(this.txtStok4);
            this.Controls.Add(this.lblAdet4);
            this.Controls.Add(this.lblStok4);
            this.Controls.Add(this.lblFiyat4);
            this.Controls.Add(this.txtAdet2);
            this.Controls.Add(this.txtFiyat2);
            this.Controls.Add(this.txtStok2);
            this.Controls.Add(this.lblAdet2);
            this.Controls.Add(this.lblStok2);
            this.Controls.Add(this.lblFiyat2);
            this.Controls.Add(this.txtKDVToplam);
            this.Controls.Add(this.txtAdet1);
            this.Controls.Add(this.txtFiyat1);
            this.Controls.Add(this.txtStok1);
            this.Controls.Add(this.lbltxtToplam);
            this.Controls.Add(this.lstBoxKDVFiyat);
            this.Controls.Add(this.lstBoxUrun);
            this.Controls.Add(this.lstBoxAdet);
            this.Controls.Add(this.lblSepetKdvliFiyat);
            this.Controls.Add(this.lblSepetUrun);
            this.Controls.Add(this.lblSepetAdet);
            this.Controls.Add(this.lblBaslik2);
            this.Controls.Add(this.lblBaslik1);
            this.Controls.Add(this.btnSepetiTemizle);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.lblAdet1);
            this.Controls.Add(this.lblStok1);
            this.Controls.Add(this.lblFiyat1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiyat1;
        private System.Windows.Forms.Label lblAdet1;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button btnSepetiTemizle;
        private System.Windows.Forms.Label lblBaslik1;
        private System.Windows.Forms.Label lblBaslik2;
        private System.Windows.Forms.Label lblSepetAdet;
        private System.Windows.Forms.Label lblSepetUrun;
        private System.Windows.Forms.Label lblSepetKdvliFiyat;
        private System.Windows.Forms.ListBox lstBoxAdet;
        private System.Windows.Forms.ListBox lstBoxUrun;
        private System.Windows.Forms.ListBox lstBoxKDVFiyat;
        private System.Windows.Forms.Label lbltxtToplam;
        private System.Windows.Forms.Label lblStok1;
        private System.Windows.Forms.Label txtStok1;
        private System.Windows.Forms.Label txtFiyat1;
        private System.Windows.Forms.NumericUpDown txtAdet1;
        private System.Windows.Forms.Label txtKDVToplam;
        private System.Windows.Forms.NumericUpDown txtAdet2;
        private System.Windows.Forms.Label txtFiyat2;
        private System.Windows.Forms.Label txtStok2;
        private System.Windows.Forms.Label lblAdet2;
        private System.Windows.Forms.Label lblStok2;
        private System.Windows.Forms.Label lblFiyat2;
        private System.Windows.Forms.NumericUpDown txtAdet4;
        private System.Windows.Forms.Label txtFiyat4;
        private System.Windows.Forms.Label txtStok4;
        private System.Windows.Forms.Label lblAdet4;
        private System.Windows.Forms.Label lblStok4;
        private System.Windows.Forms.Label lblFiyat4;
        private System.Windows.Forms.NumericUpDown txtAdet3;
        private System.Windows.Forms.Label txtFiyat3;
        private System.Windows.Forms.Label txtStok3;
        private System.Windows.Forms.Label lblAdet3;
        private System.Windows.Forms.Label lblStok3;
        private System.Windows.Forms.Label lblFiyat3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

