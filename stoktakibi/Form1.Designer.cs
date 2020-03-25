namespace stoktakini
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbalurun = new System.Windows.Forms.ComboBox();
            this.msktxttel = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtsatfiyat = new System.Windows.Forms.TextBox();
            this.txturunalfiyat = new System.Windows.Forms.TextBox();
            this.txturunkod = new System.Windows.Forms.TextBox();
            this.cmburunad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txturunadet = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txturunadet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbalurun);
            this.groupBox1.Controls.Add(this.msktxttel);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ürün Detay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbalurun
            // 
            this.cmbalurun.FormattingEnabled = true;
            this.cmbalurun.Items.AddRange(new object[] {
            "Bilgisayar",
            "Telefon",
            "Laptop",
            "Televizyon",
            "Ps4"});
            this.cmbalurun.Location = new System.Drawing.Point(158, 172);
            this.cmbalurun.Name = "cmbalurun";
            this.cmbalurun.Size = new System.Drawing.Size(143, 32);
            this.cmbalurun.TabIndex = 7;
            // 
            // msktxttel
            // 
            this.msktxttel.Location = new System.Drawing.Point(158, 130);
            this.msktxttel.Mask = "(999) 000-0000";
            this.msktxttel.Name = "msktxttel";
            this.msktxttel.Size = new System.Drawing.Size(143, 30);
            this.msktxttel.TabIndex = 6;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(158, 88);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(143, 30);
            this.txtsoyad.TabIndex = 5;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(158, 44);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(143, 30);
            this.txtad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alınacak Ürün:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtstok);
            this.groupBox2.Controls.Add(this.txtsatfiyat);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txturunalfiyat);
            this.groupBox2.Controls.Add(this.txturunkod);
            this.groupBox2.Controls.Add(this.cmburunad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(392, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 348);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Bilgileri";
            // 
            // txtstok
            // 
            this.txtstok.Enabled = false;
            this.txtstok.Location = new System.Drawing.Point(191, 218);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(161, 30);
            this.txtstok.TabIndex = 12;
            // 
            // txtsatfiyat
            // 
            this.txtsatfiyat.Enabled = false;
            this.txtsatfiyat.Location = new System.Drawing.Point(191, 169);
            this.txtsatfiyat.Name = "txtsatfiyat";
            this.txtsatfiyat.Size = new System.Drawing.Size(161, 30);
            this.txtsatfiyat.TabIndex = 11;
            // 
            // txturunalfiyat
            // 
            this.txturunalfiyat.Enabled = false;
            this.txturunalfiyat.Location = new System.Drawing.Point(191, 124);
            this.txturunalfiyat.Name = "txturunalfiyat";
            this.txturunalfiyat.Size = new System.Drawing.Size(161, 30);
            this.txturunalfiyat.TabIndex = 10;
            // 
            // txturunkod
            // 
            this.txturunkod.Enabled = false;
            this.txturunkod.Location = new System.Drawing.Point(191, 43);
            this.txturunkod.Name = "txturunkod";
            this.txturunkod.Size = new System.Drawing.Size(161, 30);
            this.txturunkod.TabIndex = 9;
            // 
            // cmburunad
            // 
            this.cmburunad.FormattingEnabled = true;
            this.cmburunad.Items.AddRange(new object[] {
            "Bilgisayar",
            "Telefon",
            "Laptop",
            "Televizyon",
            "Ps4"});
            this.cmburunad.Location = new System.Drawing.Point(191, 80);
            this.cmburunad.Name = "cmburunad";
            this.cmburunad.Size = new System.Drawing.Size(161, 32);
            this.cmburunad.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ürün Satış Fiyatı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ürün Stok Miktari:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ürün Alış Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ürün Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Kodu:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(811, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 340);
            this.listBox1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 48);
            this.label10.TabIndex = 8;
            this.label10.Text = "Alınacak Ürün\r\nAdeti:";
            // 
            // txturunadet
            // 
            this.txturunadet.Location = new System.Drawing.Point(158, 225);
            this.txturunadet.Name = "txturunadet";
            this.txturunadet.Size = new System.Drawing.Size(143, 30);
            this.txturunadet.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(209, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 50);
            this.button4.TabIndex = 11;
            this.button4.Text = "Çıkış";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1206, 492);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Stok Takibi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbalurun;
        private System.Windows.Forms.MaskedTextBox msktxttel;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtsatfiyat;
        private System.Windows.Forms.TextBox txturunalfiyat;
        private System.Windows.Forms.TextBox txturunkod;
        private System.Windows.Forms.ComboBox cmburunad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txturunadet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

