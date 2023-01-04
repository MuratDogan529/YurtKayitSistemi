namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxOgrAd = new System.Windows.Forms.TextBox();
            this.txtBoxOgrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskdBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.mskdBoxOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskdBoxDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOgrenciBolumu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskdBoxVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rchTxtBoxAdres = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxOgrAd
            // 
            this.txtBoxOgrAd.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxOgrAd.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxOgrAd.Location = new System.Drawing.Point(173, 34);
            this.txtBoxOgrAd.Name = "txtBoxOgrAd";
            this.txtBoxOgrAd.Size = new System.Drawing.Size(287, 28);
            this.txtBoxOgrAd.TabIndex = 1;
            // 
            // txtBoxOgrSoyad
            // 
            this.txtBoxOgrSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxOgrSoyad.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxOgrSoyad.Location = new System.Drawing.Point(173, 68);
            this.txtBoxOgrSoyad.Name = "txtBoxOgrSoyad";
            this.txtBoxOgrSoyad.Size = new System.Drawing.Size(287, 28);
            this.txtBoxOgrSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(128, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // mskdBoxTC
            // 
            this.mskdBoxTC.BackColor = System.Drawing.SystemColors.Info;
            this.mskdBoxTC.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdBoxTC.Location = new System.Drawing.Point(173, 102);
            this.mskdBoxTC.Mask = "00000000000";
            this.mskdBoxTC.Name = "mskdBoxTC";
            this.mskdBoxTC.Size = new System.Drawing.Size(287, 28);
            this.mskdBoxTC.TabIndex = 5;
            this.mskdBoxTC.ValidatingType = typeof(int);
            // 
            // mskdBoxOgrTelefon
            // 
            this.mskdBoxOgrTelefon.BackColor = System.Drawing.SystemColors.Info;
            this.mskdBoxOgrTelefon.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdBoxOgrTelefon.Location = new System.Drawing.Point(173, 133);
            this.mskdBoxOgrTelefon.Mask = "(999) 000-0000";
            this.mskdBoxOgrTelefon.Name = "mskdBoxOgrTelefon";
            this.mskdBoxOgrTelefon.Size = new System.Drawing.Size(287, 28);
            this.mskdBoxOgrTelefon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(90, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // mskdBoxDogumTarihi
            // 
            this.mskdBoxDogumTarihi.BackColor = System.Drawing.SystemColors.Info;
            this.mskdBoxDogumTarihi.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdBoxDogumTarihi.Location = new System.Drawing.Point(173, 161);
            this.mskdBoxDogumTarihi.Mask = "00/00/0000";
            this.mskdBoxDogumTarihi.Name = "mskdBoxDogumTarihi";
            this.mskdBoxDogumTarihi.Size = new System.Drawing.Size(287, 28);
            this.mskdBoxDogumTarihi.TabIndex = 9;
            this.mskdBoxDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(40, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci Bölümü:";
            // 
            // cmbOgrenciBolumu
            // 
            this.cmbOgrenciBolumu.BackColor = System.Drawing.SystemColors.Info;
            this.cmbOgrenciBolumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenciBolumu.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgrenciBolumu.FormattingEnabled = true;
            this.cmbOgrenciBolumu.Location = new System.Drawing.Point(173, 194);
            this.cmbOgrenciBolumu.Name = "cmbOgrenciBolumu";
            this.cmbOgrenciBolumu.Size = new System.Drawing.Size(287, 29);
            this.cmbOgrenciBolumu.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(113, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mail:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxMail.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMail.Location = new System.Drawing.Point(173, 264);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(287, 28);
            this.txtBoxMail.TabIndex = 13;
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.BackColor = System.Drawing.SystemColors.Info;
            this.cmbOdaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdaNo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(172, 229);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(287, 29);
            this.cmbOdaNo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(89, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oda No:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtBoxVeliAdSoyad
            // 
            this.txtBoxVeliAdSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxVeliAdSoyad.Location = new System.Drawing.Point(173, 312);
            this.txtBoxVeliAdSoyad.Name = "txtBoxVeliAdSoyad";
            this.txtBoxVeliAdSoyad.Size = new System.Drawing.Size(287, 28);
            this.txtBoxVeliAdSoyad.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(42, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Veli Ad Soyad:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // mskdBoxVeliTelefon
            // 
            this.mskdBoxVeliTelefon.BackColor = System.Drawing.SystemColors.Info;
            this.mskdBoxVeliTelefon.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdBoxVeliTelefon.Location = new System.Drawing.Point(173, 346);
            this.mskdBoxVeliTelefon.Mask = "(999) 000-0000";
            this.mskdBoxVeliTelefon.Name = "mskdBoxVeliTelefon";
            this.mskdBoxVeliTelefon.Size = new System.Drawing.Size(287, 28);
            this.mskdBoxVeliTelefon.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(55, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Veli Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(104, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Adres:";
            // 
            // rchTxtBoxAdres
            // 
            this.rchTxtBoxAdres.BackColor = System.Drawing.SystemColors.Info;
            this.rchTxtBoxAdres.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchTxtBoxAdres.Location = new System.Drawing.Point(173, 383);
            this.rchTxtBoxAdres.Name = "rchTxtBoxAdres";
            this.rchTxtBoxAdres.Size = new System.Drawing.Size(286, 114);
            this.rchTxtBoxAdres.TabIndex = 21;
            this.rchTxtBoxAdres.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(331, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 22;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(482, 570);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rchTxtBoxAdres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskdBoxVeliTelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxVeliAdSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbOgrenciBolumu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskdBoxDogumTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskdBoxOgrTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskdBoxTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxOgrSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxOgrAd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxOgrAd;
        private System.Windows.Forms.TextBox txtBoxOgrSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskdBoxTC;
        private System.Windows.Forms.MaskedTextBox mskdBoxOgrTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskdBoxDogumTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOgrenciBolumu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxVeliAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskdBoxVeliTelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchTxtBoxAdres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
    }
}

