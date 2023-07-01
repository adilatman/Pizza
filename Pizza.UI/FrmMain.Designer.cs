namespace Pizza.UI
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lstMusteri = new System.Windows.Forms.ListBox();
            this.cmbPizza = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flwContents = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIcindekiler = new System.Windows.Forms.Label();
            this.nmrPizza = new System.Windows.Forms.NumericUpDown();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbL = new System.Windows.Forms.RadioButton();
            this.rdbXL = new System.Windows.Forms.RadioButton();
            this.rdbS = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.lblSiparisToplami = new System.Windows.Forms.Label();
            this.cmbIcecek = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nmrIcecek = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCleanForm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnISepeteEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flwMaterials = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.txtIsimAra = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errPizza = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDrink = new System.Windows.Forms.ErrorProvider(this.components);
            this.errOrder = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblGC = new System.Windows.Forms.LinkLabel();
            this.flwContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIcecek)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMusteri
            // 
            this.lstMusteri.FormattingEnabled = true;
            this.lstMusteri.Location = new System.Drawing.Point(12, 151);
            this.lstMusteri.Name = "lstMusteri";
            this.lstMusteri.Size = new System.Drawing.Size(103, 381);
            this.lstMusteri.TabIndex = 1;
            this.lstMusteri.SelectedIndexChanged += new System.EventHandler(this.lstMusteri_SelectedIndexChanged);
            // 
            // cmbPizza
            // 
            this.cmbPizza.FormattingEnabled = true;
            this.cmbPizza.Location = new System.Drawing.Point(56, 19);
            this.cmbPizza.Name = "cmbPizza";
            this.cmbPizza.Size = new System.Drawing.Size(145, 21);
            this.cmbPizza.TabIndex = 9;
            this.cmbPizza.SelectedIndexChanged += new System.EventHandler(this.cmbPizza_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pizzalar:";
            // 
            // flwContents
            // 
            this.flwContents.Controls.Add(this.lblIcindekiler);
            this.flwContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flwContents.Location = new System.Drawing.Point(9, 64);
            this.flwContents.Name = "flwContents";
            this.flwContents.Size = new System.Drawing.Size(191, 88);
            this.flwContents.TabIndex = 11;
            // 
            // lblIcindekiler
            // 
            this.lblIcindekiler.AutoSize = true;
            this.lblIcindekiler.Location = new System.Drawing.Point(3, 0);
            this.lblIcindekiler.Name = "lblIcindekiler";
            this.lblIcindekiler.Size = new System.Drawing.Size(10, 13);
            this.lblIcindekiler.TabIndex = 0;
            this.lblIcindekiler.Text = "-";
            // 
            // nmrPizza
            // 
            this.nmrPizza.Location = new System.Drawing.Point(154, 179);
            this.nmrPizza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrPizza.Name = "nmrPizza";
            this.nmrPizza.Size = new System.Drawing.Size(46, 20);
            this.nmrPizza.TabIndex = 13;
            this.nmrPizza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrPizza.ValueChanged += new System.EventHandler(this.nmrPizza_ValueChanged);
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Checked = true;
            this.rdbM.Location = new System.Drawing.Point(61, 156);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(45, 17);
            this.rdbM.TabIndex = 14;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "Orta";
            this.rdbM.UseVisualStyleBackColor = true;
            this.rdbM.Click += new System.EventHandler(this.rdbM_Click);
            // 
            // rdbL
            // 
            this.rdbL.AutoSize = true;
            this.rdbL.Location = new System.Drawing.Point(107, 156);
            this.rdbL.Name = "rdbL";
            this.rdbL.Size = new System.Drawing.Size(55, 17);
            this.rdbL.TabIndex = 15;
            this.rdbL.Text = "Büyük";
            this.rdbL.UseVisualStyleBackColor = true;
            this.rdbL.Click += new System.EventHandler(this.rdbL_Click);
            // 
            // rdbXL
            // 
            this.rdbXL.AutoSize = true;
            this.rdbXL.Location = new System.Drawing.Point(163, 156);
            this.rdbXL.Name = "rdbXL";
            this.rdbXL.Size = new System.Drawing.Size(38, 17);
            this.rdbXL.TabIndex = 16;
            this.rdbXL.Text = "XL";
            this.rdbXL.UseVisualStyleBackColor = true;
            this.rdbXL.Click += new System.EventHandler(this.rdbXL_Click);
            // 
            // rdbS
            // 
            this.rdbS.AutoSize = true;
            this.rdbS.Location = new System.Drawing.Point(7, 156);
            this.rdbS.Name = "rdbS";
            this.rdbS.Size = new System.Drawing.Size(56, 17);
            this.rdbS.TabIndex = 17;
            this.rdbS.Text = "Küçük";
            this.rdbS.UseVisualStyleBackColor = true;
            this.rdbS.Click += new System.EventHandler(this.rdbS_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(81, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pizza Adet:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(12, 36);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(73, 20);
            this.txtTel.TabIndex = 1;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(134, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ara Toplam:";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraToplam.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAraToplam.Location = new System.Drawing.Point(271, 338);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAraToplam.Size = new System.Drawing.Size(19, 20);
            this.lblAraToplam.TabIndex = 23;
            this.lblAraToplam.Text = "0";
            // 
            // lstCart
            // 
            this.lstCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstCart.HideSelection = false;
            this.lstCart.Location = new System.Drawing.Point(481, 325);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(327, 207);
            this.lstCart.TabIndex = 24;
            this.lstCart.UseCompatibleStateImageBehavior = false;
            this.lstCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Boy";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(134, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sipariş Toplamı:";
            // 
            // lblSiparisToplami
            // 
            this.lblSiparisToplami.AutoSize = true;
            this.lblSiparisToplami.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparisToplami.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSiparisToplami.Location = new System.Drawing.Point(271, 392);
            this.lblSiparisToplami.Name = "lblSiparisToplami";
            this.lblSiparisToplami.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSiparisToplami.Size = new System.Drawing.Size(19, 20);
            this.lblSiparisToplami.TabIndex = 23;
            this.lblSiparisToplami.Text = "0";
            // 
            // cmbIcecek
            // 
            this.cmbIcecek.FormattingEnabled = true;
            this.cmbIcecek.Location = new System.Drawing.Point(60, 19);
            this.cmbIcecek.Name = "cmbIcecek";
            this.cmbIcecek.Size = new System.Drawing.Size(144, 21);
            this.cmbIcecek.TabIndex = 9;
            this.cmbIcecek.SelectedIndexChanged += new System.EventHandler(this.cmbIcecek_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "İçecek:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "İçindekiler:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(80, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "İçecek Adet:";
            // 
            // nmrIcecek
            // 
            this.nmrIcecek.Location = new System.Drawing.Point(158, 46);
            this.nmrIcecek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrIcecek.Name = "nmrIcecek";
            this.nmrIcecek.Size = new System.Drawing.Size(46, 20);
            this.nmrIcecek.TabIndex = 30;
            this.nmrIcecek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrIcecek.ValueChanged += new System.EventHandler(this.nmrIcecek_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flwContents);
            this.groupBox2.Controls.Add(this.cmbPizza);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nmrPizza);
            this.groupBox2.Controls.Add(this.rdbM);
            this.groupBox2.Controls.Add(this.rdbL);
            this.groupBox2.Controls.Add(this.rdbXL);
            this.groupBox2.Controls.Add(this.rdbS);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(123, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza";
            // 
            // btnCleanForm
            // 
            this.btnCleanForm.BackgroundImage = global::Pizza.UI.Properties.Resources.clear;
            this.btnCleanForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCleanForm.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCleanForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanForm.Location = new System.Drawing.Point(345, 325);
            this.btnCleanForm.Name = "btnCleanForm";
            this.btnCleanForm.Size = new System.Drawing.Size(103, 103);
            this.btnCleanForm.TabIndex = 26;
            this.btnCleanForm.UseVisualStyleBackColor = true;
            this.btnCleanForm.Click += new System.EventHandler(this.btnCleanForm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbIcecek);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.nmrIcecek);
            this.groupBox3.Location = new System.Drawing.Point(123, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 88);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İçecek";
            // 
            // btnISepeteEkle
            // 
            this.btnISepeteEkle.BackgroundImage = global::Pizza.UI.Properties.Resources.addCart;
            this.btnISepeteEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnISepeteEkle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnISepeteEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnISepeteEkle.Location = new System.Drawing.Point(179, 429);
            this.btnISepeteEkle.Name = "btnISepeteEkle";
            this.btnISepeteEkle.Size = new System.Drawing.Size(103, 103);
            this.btnISepeteEkle.TabIndex = 25;
            this.btnISepeteEkle.UseVisualStyleBackColor = true;
            this.btnISepeteEkle.Click += new System.EventHandler(this.btnISepeteEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flwMaterials);
            this.groupBox1.Location = new System.Drawing.Point(339, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 299);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekstra Malzemeler";
            // 
            // flwMaterials
            // 
            this.flwMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flwMaterials.Location = new System.Drawing.Point(6, 13);
            this.flwMaterials.Name = "flwMaterials";
            this.flwMaterials.Size = new System.Drawing.Size(457, 277);
            this.flwMaterials.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Pizza.UI.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(92, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImage = global::Pizza.UI.Properties.Resources.buy;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Location = new System.Drawing.Point(345, 429);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(103, 103);
            this.btnOrder.TabIndex = 27;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.BackgroundImage = global::Pizza.UI.Properties.Resources.addCustomer;
            this.btnCustomerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCustomerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerAdd.Location = new System.Drawing.Point(40, 101);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(45, 41);
            this.btnCustomerAdd.TabIndex = 4;
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // txtIsimAra
            // 
            this.txtIsimAra.Location = new System.Drawing.Point(12, 72);
            this.txtIsimAra.Name = "txtIsimAra";
            this.txtIsimAra.Size = new System.Drawing.Size(73, 20);
            this.txtIsimAra.TabIndex = 1;
            this.txtIsimAra.TextChanged += new System.EventHandler(this.txtIsimAra_TextChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Pizza.UI.Properties.Resources.search;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(92, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ara: İsim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Ara: Tel/Adres";
            // 
            // errPizza
            // 
            this.errPizza.ContainerControl = this;
            // 
            // errDrink
            // 
            this.errDrink.ContainerControl = this;
            // 
            // errOrder
            // 
            this.errOrder.ContainerControl = this;
            // 
            // lblGC
            // 
            this.lblGC.AutoSize = true;
            this.lblGC.Location = new System.Drawing.Point(740, 9);
            this.lblGC.Name = "lblGC";
            this.lblGC.Size = new System.Drawing.Size(68, 13);
            this.lblGC.TabIndex = 37;
            this.lblGC.TabStop = true;
            this.lblGC.Text = "Güvenli Çıkış";
            this.lblGC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGC_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 548);
            this.Controls.Add(this.lblGC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCleanForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnISepeteEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lblSiparisToplami);
            this.Controls.Add(this.lblAraToplam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIsimAra);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.lstMusteri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Sipariş";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.flwContents.ResumeLayout(false);
            this.flwContents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIcecek)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstMusteri;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.ComboBox cmbPizza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flwContents;
        private System.Windows.Forms.NumericUpDown nmrPizza;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbL;
        private System.Windows.Forms.RadioButton rdbXL;
        private System.Windows.Forms.RadioButton rdbS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.ListView lstCart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSiparisToplami;
        private System.Windows.Forms.Button btnISepeteEkle;
        private System.Windows.Forms.Button btnCleanForm;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cmbIcecek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIcindekiler;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmrIcecek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flwMaterials;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIsimAra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errPizza;
        private System.Windows.Forms.ErrorProvider errDrink;
        private System.Windows.Forms.ErrorProvider errOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.LinkLabel lblGC;
    }
}