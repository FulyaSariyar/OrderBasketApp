namespace SiparisOrnek
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
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.nFeight = new System.Windows.Forms.NumericUpDown();
            this.txtShipRagion = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.txtShipPostalCode = new System.Windows.Forms.TextBox();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.txtShipAdress = new System.Windows.Forms.TextBox();
            this.dtpRequredDate = new System.Windows.Forms.DateTimePicker();
            this.cbmShippers = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.btnArtir = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstCart = new System.Windows.Forms.ListView();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.lblKargo = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblUlke = new System.Windows.Forms.Label();
            this.lblPosta = new System.Windows.Forms.Label();
            this.lblGonderen = new System.Windows.Forms.Label();
            this.lblBolge = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nFeight)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(562, 350);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(206, 23);
            this.cmbCustomer.TabIndex = 38;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(457, 418);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(206, 23);
            this.btnOnayla.TabIndex = 37;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // nFeight
            // 
            this.nFeight.DecimalPlaces = 2;
            this.nFeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nFeight.Location = new System.Drawing.Point(457, 386);
            this.nFeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nFeight.Name = "nFeight";
            this.nFeight.Size = new System.Drawing.Size(100, 26);
            this.nFeight.TabIndex = 36;
            
            // 
            // txtShipRagion
            // 
            this.txtShipRagion.Location = new System.Drawing.Point(562, 263);
            this.txtShipRagion.Name = "txtShipRagion";
            this.txtShipRagion.Size = new System.Drawing.Size(206, 23);
            this.txtShipRagion.TabIndex = 35;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(562, 321);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(206, 23);
            this.txtShipName.TabIndex = 34;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(562, 205);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(206, 23);
            this.txtShipCity.TabIndex = 33;
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.Location = new System.Drawing.Point(562, 292);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(206, 23);
            this.txtShipPostalCode.TabIndex = 32;
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(562, 234);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(206, 23);
            this.txtShipCountry.TabIndex = 31;
            // 
            // txtShipAdress
            // 
            this.txtShipAdress.Location = new System.Drawing.Point(562, 176);
            this.txtShipAdress.Name = "txtShipAdress";
            this.txtShipAdress.Size = new System.Drawing.Size(206, 23);
            this.txtShipAdress.TabIndex = 30;
            // 
            // dtpRequredDate
            // 
            this.dtpRequredDate.Location = new System.Drawing.Point(562, 147);
            this.dtpRequredDate.Name = "dtpRequredDate";
            this.dtpRequredDate.Size = new System.Drawing.Size(206, 23);
            this.dtpRequredDate.TabIndex = 29;
            // 
            // cbmShippers
            // 
            this.cbmShippers.FormattingEnabled = true;
            this.cbmShippers.Location = new System.Drawing.Point(562, 118);
            this.cbmShippers.Name = "cbmShippers";
            this.cbmShippers.Size = new System.Drawing.Size(206, 23);
            this.cbmShippers.TabIndex = 28;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(562, 89);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(206, 23);
            this.cmbEmployee.TabIndex = 27;
            // 
            // btnArtir
            // 
            this.btnArtir.Location = new System.Drawing.Point(335, 418);
            this.btnArtir.Name = "btnArtir";
            this.btnArtir.Size = new System.Drawing.Size(73, 23);
            this.btnArtir.TabIndex = 26;
            this.btnArtir.Text = "Artır";
            this.btnArtir.UseVisualStyleBackColor = true;
            this.btnArtir.Click += new System.EventHandler(this.btnArtir_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(250, 418);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(73, 23);
            this.btnAzalt.TabIndex = 25;
            this.btnAzalt.Text = "Azalt";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(72, 418);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(158, 23);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.Location = new System.Drawing.Point(250, 54);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(111, 19);
            this.lblToplam.TabIndex = 23;
            this.lblToplam.Text = "Toplam : 0.00 ₺";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(72, 54);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(158, 23);
            this.txtAra.TabIndex = 22;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstCart
            // 
            this.lstCart.Location = new System.Drawing.Point(250, 89);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(158, 323);
            this.lstCart.TabIndex = 21;
            this.lstCart.UseCompatibleStateImageBehavior = false;
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 15;
            this.lstProducts.Location = new System.Drawing.Point(72, 93);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(158, 319);
            this.lstProducts.TabIndex = 20;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(76, 29);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(25, 15);
            this.lblAra.TabIndex = 39;
            this.lblAra.Text = "Ara";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(457, 89);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(94, 15);
            this.lblPersonel.TabIndex = 40;
            this.lblPersonel.Text = "Personel Seçiniz:";
            // 
            // lblKargo
            // 
            this.lblKargo.AutoSize = true;
            this.lblKargo.Location = new System.Drawing.Point(420, 118);
            this.lblKargo.Name = "lblKargo";
            this.lblKargo.Size = new System.Drawing.Size(131, 15);
            this.lblKargo.TabIndex = 41;
            this.lblKargo.Text = "Kargo Firmasını Seçiniz:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(474, 147);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(77, 15);
            this.lblTarih.TabIndex = 42;
            this.lblTarih.Text = "Tarihi Seçiniz:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(511, 176);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(40, 15);
            this.lblAdres.TabIndex = 43;
            this.lblAdres.Text = "Adres:";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(515, 205);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(36, 15);
            this.lblSehir.TabIndex = 44;
            this.lblSehir.Text = "Şehir:";
            // 
            // lblUlke
            // 
            this.lblUlke.AutoSize = true;
            this.lblUlke.Location = new System.Drawing.Point(523, 237);
            this.lblUlke.Name = "lblUlke";
            this.lblUlke.Size = new System.Drawing.Size(33, 15);
            this.lblUlke.TabIndex = 45;
            this.lblUlke.Text = "Ülke:";
            // 
            // lblPosta
            // 
            this.lblPosta.AutoSize = true;
            this.lblPosta.Location = new System.Drawing.Point(486, 295);
            this.lblPosta.Name = "lblPosta";
            this.lblPosta.Size = new System.Drawing.Size(70, 15);
            this.lblPosta.TabIndex = 46;
            this.lblPosta.Text = "Posta Kodu:";
            // 
            // lblGonderen
            // 
            this.lblGonderen.AutoSize = true;
            this.lblGonderen.Location = new System.Drawing.Point(474, 321);
            this.lblGonderen.Name = "lblGonderen";
            this.lblGonderen.Size = new System.Drawing.Size(83, 15);
            this.lblGonderen.TabIndex = 47;
            this.lblGonderen.Text = "Gönderen Adı:";
            // 
            // lblBolge
            // 
            this.lblBolge.AutoSize = true;
            this.lblBolge.Location = new System.Drawing.Point(516, 262);
            this.lblBolge.Name = "lblBolge";
            this.lblBolge.Size = new System.Drawing.Size(40, 15);
            this.lblBolge.TabIndex = 48;
            this.lblBolge.Text = "Bölge:";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(468, 352);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(89, 15);
            this.lblMusteri.TabIndex = 49;
            this.lblMusteri.Text = "Müşteri Seçiniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 450);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.lblBolge);
            this.Controls.Add(this.lblGonderen);
            this.Controls.Add(this.lblPosta);
            this.Controls.Add(this.lblUlke);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblKargo);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.nFeight);
            this.Controls.Add(this.txtShipRagion);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.txtShipCity);
            this.Controls.Add(this.txtShipPostalCode);
            this.Controls.Add(this.txtShipCountry);
            this.Controls.Add(this.txtShipAdress);
            this.Controls.Add(this.dtpRequredDate);
            this.Controls.Add(this.cbmShippers);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.btnArtir);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lstProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbCustomer;
        private Button btnOnayla;
        private NumericUpDown nFeight;
        private TextBox txtShipRagion;
        private TextBox txtShipName;
        private TextBox txtShipCity;
        private TextBox txtShipPostalCode;
        private TextBox txtShipCountry;
        private TextBox txtShipAdress;
        private DateTimePicker dtpRequredDate;
        private ComboBox cbmShippers;
        private ComboBox cmbEmployee;
        private Button btnArtir;
        private Button btnAzalt;
        private Button btnEkle;
        private Label lblToplam;
        private TextBox txtAra;
        private ListView lstCart;
        private ListBox lstProducts;
        private Label lblAra;
        private Label lblPersonel;
        private Label lblKargo;
        private Label lblTarih;
        private Label lblAdres;
        private Label lblSehir;
        private Label lblUlke;
        private Label lblPosta;
        private Label lblGonderen;
        private Label lblBolge;
        private Label lblMusteri;
    }
}