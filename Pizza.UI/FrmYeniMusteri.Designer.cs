namespace Pizza.UI
{
    partial class FrmYeniMusteri
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYeniTel = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYeniAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYeniAdres = new System.Windows.Forms.TextBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon No:";
            // 
            // txtYeniTel
            // 
            this.txtYeniTel.Location = new System.Drawing.Point(81, 51);
            this.txtYeniTel.Mask = "(999) 000-0000";
            this.txtYeniTel.Name = "txtYeniTel";
            this.txtYeniTel.Size = new System.Drawing.Size(148, 20);
            this.txtYeniTel.TabIndex = 1;
            this.txtYeniTel.TextChanged += new System.EventHandler(this.txtYeniTel_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim:";
            // 
            // txtYeniAd
            // 
            this.txtYeniAd.Location = new System.Drawing.Point(81, 75);
            this.txtYeniAd.Name = "txtYeniAd";
            this.txtYeniAd.Size = new System.Drawing.Size(148, 20);
            this.txtYeniAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres:";
            // 
            // txtYeniAdres
            // 
            this.txtYeniAdres.Location = new System.Drawing.Point(81, 101);
            this.txtYeniAdres.Multiline = true;
            this.txtYeniAdres.Name = "txtYeniAdres";
            this.txtYeniAdres.Size = new System.Drawing.Size(148, 106);
            this.txtYeniAdres.TabIndex = 5;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Enabled = false;
            this.btnMusteriEkle.Location = new System.Drawing.Point(81, 213);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(148, 33);
            this.btnMusteriEkle.TabIndex = 6;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(81, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yeni müşteri bilgilerini girin";
            // 
            // FrmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 308);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.txtYeniAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYeniAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYeniTel);
            this.Controls.Add(this.label1);
            this.Name = "FrmYeniMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtYeniTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYeniAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYeniAdres;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
    }
}