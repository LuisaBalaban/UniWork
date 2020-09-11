namespace MyWallet.Forms
{
    partial class CryptoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptoForm));
            this.rbBitcoin = new System.Windows.Forms.RadioButton();
            this.rbEthereum = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRVBit = new System.Windows.Forms.TextBox();
            this.tbRVEth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbEth = new System.Windows.Forms.TextBox();
            this.tbBitcoin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvCrypto = new System.Windows.Forms.ListView();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbBitcoin
            // 
            this.rbBitcoin.AutoSize = true;
            this.rbBitcoin.BackColor = System.Drawing.Color.Transparent;
            this.rbBitcoin.Checked = true;
            this.rbBitcoin.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBitcoin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbBitcoin.Location = new System.Drawing.Point(185, 84);
            this.rbBitcoin.Name = "rbBitcoin";
            this.rbBitcoin.Size = new System.Drawing.Size(153, 47);
            this.rbBitcoin.TabIndex = 0;
            this.rbBitcoin.TabStop = true;
            this.rbBitcoin.Text = "Bitcoin";
            this.rbBitcoin.UseVisualStyleBackColor = false;
            this.rbBitcoin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbEthereum
            // 
            this.rbEthereum.AutoSize = true;
            this.rbEthereum.BackColor = System.Drawing.Color.Transparent;
            this.rbEthereum.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEthereum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbEthereum.Location = new System.Drawing.Point(425, 84);
            this.rbEthereum.Name = "rbEthereum";
            this.rbEthereum.Size = new System.Drawing.Size(196, 47);
            this.rbEthereum.TabIndex = 1;
            this.rbEthereum.Text = "Ethereum";
            this.rbEthereum.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbRVBit);
            this.groupBox1.Controls.Add(this.tbRVEth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.tbEth);
            this.groupBox1.Controls.Add(this.tbBitcoin);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assets";
            // 
            // tbRVBit
            // 
            this.tbRVBit.BackColor = System.Drawing.SystemColors.Info;
            this.tbRVBit.Location = new System.Drawing.Point(274, 51);
            this.tbRVBit.Name = "tbRVBit";
            this.tbRVBit.ReadOnly = true;
            this.tbRVBit.Size = new System.Drawing.Size(93, 26);
            this.tbRVBit.TabIndex = 49;
            // 
            // tbRVEth
            // 
            this.tbRVEth.BackColor = System.Drawing.SystemColors.Info;
            this.tbRVEth.Location = new System.Drawing.Point(274, 128);
            this.tbRVEth.Name = "tbRVEth";
            this.tbRVEth.ReadOnly = true;
            this.tbRVEth.Size = new System.Drawing.Size(93, 26);
            this.tbRVEth.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(253, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(247, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "$";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 117);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 62);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 70);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // tbEth
            // 
            this.tbEth.BackColor = System.Drawing.SystemColors.Info;
            this.tbEth.Location = new System.Drawing.Point(112, 127);
            this.tbEth.Name = "tbEth";
            this.tbEth.ReadOnly = true;
            this.tbEth.Size = new System.Drawing.Size(135, 26);
            this.tbEth.TabIndex = 34;
            // 
            // tbBitcoin
            // 
            this.tbBitcoin.BackColor = System.Drawing.SystemColors.Info;
            this.tbBitcoin.Location = new System.Drawing.Point(112, 52);
            this.tbBitcoin.Name = "tbBitcoin";
            this.tbBitcoin.ReadOnly = true;
            this.tbBitcoin.Size = new System.Drawing.Size(135, 26);
            this.tbBitcoin.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvCrypto);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(391, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 205);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activity";
            // 
            // lvCrypto
            // 
            this.lvCrypto.BackColor = System.Drawing.SystemColors.Info;
            this.lvCrypto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.columnHeader1});
            this.lvCrypto.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCrypto.FullRowSelect = true;
            this.lvCrypto.GridLines = true;
            this.lvCrypto.HideSelection = false;
            this.lvCrypto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvCrypto.Location = new System.Drawing.Point(4, 25);
            this.lvCrypto.Name = "lvCrypto";
            this.lvCrypto.Size = new System.Drawing.Size(376, 174);
            this.lvCrypto.SmallImageList = this.imageList1;
            this.lvCrypto.TabIndex = 26;
            this.lvCrypto.UseCompatibleStateImageBehavior = false;
            this.lvCrypto.View = System.Windows.Forms.View.Details;
            // 
            // Category
            // 
            this.Category.Text = "Currency";
            this.Category.Width = 139;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Amount";
            this.columnHeader1.Width = 153;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "etherum.png");
            this.imageList1.Images.SetKeyName(1, "bitcoin.png");
            // 
            // btnBuy
            // 
            this.btnBuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuy.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(263, 141);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(126, 46);
            this.btnBuy.TabIndex = 27;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSell.BackColor = System.Drawing.Color.Transparent;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(395, 141);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(125, 46);
            this.btnSell.TabIndex = 28;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 62);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(242, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 70);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.SystemColors.Info;
            this.tbAmount.Location = new System.Drawing.Point(395, 201);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(207, 26);
            this.tbAmount.TabIndex = 31;
            this.tbAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbAmount_Validating);
            this.tbAmount.Validated += new System.EventHandler(this.tbAmount_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(259, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(608, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "$";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 46;
            this.button1.Text = "Export ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbEthereum);
            this.Controls.Add(this.rbBitcoin);
            this.Name = "CryptoForm";
            this.Text = "CryptoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CryptoForm_FormClosing);
            this.Load += new System.EventHandler(this.CryptoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBitcoin;
        private System.Windows.Forms.RadioButton rbEthereum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvCrypto;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbEth;
        private System.Windows.Forms.TextBox tbBitcoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbRVBit;
        private System.Windows.Forms.TextBox tbRVEth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}