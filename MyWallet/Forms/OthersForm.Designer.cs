namespace MyWallet.Forms
{
    partial class OthersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OthersForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.rbBonds = new System.Windows.Forms.RadioButton();
            this.rbRealEstat = new System.Windows.Forms.RadioButton();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvOthers = new System.Windows.Forms.ListView();
            this.Bussiness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbBonds = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbGold = new System.Windows.Forms.TextBox();
            this.tbRE = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(574, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(262, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.SystemColors.Info;
            this.tbAmount.Location = new System.Drawing.Point(361, 146);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(207, 26);
            this.tbAmount.TabIndex = 55;
            this.tbAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbAmount_Validating);
            this.tbAmount.Validated += new System.EventHandler(this.tbAmount_Validated);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(643, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 46);
            this.button2.TabIndex = 54;
            this.button2.Text = "Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(73, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 53;
            this.button1.Text = "History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.BackColor = System.Drawing.Color.Transparent;
            this.rbGold.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGold.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbGold.Location = new System.Drawing.Point(649, 22);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(120, 47);
            this.rbGold.TabIndex = 51;
            this.rbGold.Text = "Gold";
            this.rbGold.UseVisualStyleBackColor = false;
            // 
            // rbBonds
            // 
            this.rbBonds.AutoSize = true;
            this.rbBonds.BackColor = System.Drawing.Color.Transparent;
            this.rbBonds.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBonds.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbBonds.Location = new System.Drawing.Point(361, 22);
            this.rbBonds.Name = "rbBonds";
            this.rbBonds.Size = new System.Drawing.Size(142, 47);
            this.rbBonds.TabIndex = 50;
            this.rbBonds.Text = "Bonds";
            this.rbBonds.UseVisualStyleBackColor = false;
            // 
            // rbRealEstat
            // 
            this.rbRealEstat.AutoSize = true;
            this.rbRealEstat.BackColor = System.Drawing.Color.Transparent;
            this.rbRealEstat.Checked = true;
            this.rbRealEstat.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRealEstat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbRealEstat.Location = new System.Drawing.Point(73, 22);
            this.rbRealEstat.Name = "rbRealEstat";
            this.rbRealEstat.Size = new System.Drawing.Size(216, 47);
            this.rbRealEstat.TabIndex = 46;
            this.rbRealEstat.TabStop = true;
            this.rbRealEstat.Text = "Real Estate";
            this.rbRealEstat.UseVisualStyleBackColor = false;
            // 
            // btnSell
            // 
            this.btnSell.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSell.BackColor = System.Drawing.Color.Transparent;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(470, 84);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(125, 46);
            this.btnSell.TabIndex = 49;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuy.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(241, 84);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(126, 46);
            this.btnBuy.TabIndex = 47;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvOthers);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(449, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 275);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activity";
            // 
            // lvOthers
            // 
            this.lvOthers.BackColor = System.Drawing.SystemColors.Info;
            this.lvOthers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Bussiness,
            this.columnHeader1});
            this.lvOthers.ContextMenuStrip = this.contextMenuStrip1;
            this.lvOthers.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOthers.FullRowSelect = true;
            this.lvOthers.GridLines = true;
            this.lvOthers.HideSelection = false;
            this.lvOthers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvOthers.Location = new System.Drawing.Point(8, 25);
            this.lvOthers.Name = "lvOthers";
            this.lvOthers.Size = new System.Drawing.Size(408, 244);
            this.lvOthers.SmallImageList = this.imageList1;
            this.lvOthers.TabIndex = 26;
            this.lvOthers.UseCompatibleStateImageBehavior = false;
            this.lvOthers.View = System.Windows.Forms.View.Details;
            // 
            // Bussiness
            // 
            this.Bussiness.Text = "Bussiness";
            this.Bussiness.Width = 165;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Amount $";
            this.columnHeader1.Width = 171;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 64);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(134, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bonds.png");
            this.imageList1.Images.SetKeyName(1, "Gold.png");
            this.imageList1.Images.SetKeyName(2, "Real Estate.png");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tbBonds);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.tbGold);
            this.groupBox1.Controls.Add(this.tbRE);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 275);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(373, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(373, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(373, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "$";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 63);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 61);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // tbBonds
            // 
            this.tbBonds.BackColor = System.Drawing.SystemColors.Info;
            this.tbBonds.Location = new System.Drawing.Point(139, 118);
            this.tbBonds.Name = "tbBonds";
            this.tbBonds.ReadOnly = true;
            this.tbBonds.Size = new System.Drawing.Size(228, 26);
            this.tbBonds.TabIndex = 35;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(41, 127);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 39);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // tbGold
            // 
            this.tbGold.BackColor = System.Drawing.SystemColors.Info;
            this.tbGold.Location = new System.Drawing.Point(139, 195);
            this.tbGold.Name = "tbGold";
            this.tbGold.ReadOnly = true;
            this.tbGold.Size = new System.Drawing.Size(228, 26);
            this.tbGold.TabIndex = 34;
            // 
            // tbRE
            // 
            this.tbRE.BackColor = System.Drawing.SystemColors.Info;
            this.tbRE.Location = new System.Drawing.Point(139, 47);
            this.tbRE.Name = "tbRE";
            this.tbRE.ReadOnly = true;
            this.tbRE.Size = new System.Drawing.Size(228, 26);
            this.tbRE.TabIndex = 33;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OthersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(903, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbGold);
            this.Controls.Add(this.rbBonds);
            this.Controls.Add(this.rbRealEstat);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OthersForm";
            this.Text = "BondsForm";
            this.Load += new System.EventHandler(this.OthersForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbGold;
        private System.Windows.Forms.RadioButton rbBonds;
        private System.Windows.Forms.RadioButton rbRealEstat;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvOthers;
        private System.Windows.Forms.ColumnHeader Bussiness;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbBonds;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbGold;
        private System.Windows.Forms.TextBox tbRE;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}