namespace MyWallet
{
    partial class InvestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvestForm));
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmsCrypto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.learnMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.cmsBonds = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.learnMoreToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.cmsStocks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.learnMoreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.investToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCrypto.SuspendLayout();
            this.cmsBonds.SuspendLayout();
            this.cmsStocks.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Candara Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(54, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(457, 128);
            this.label5.TabIndex = 27;
            this.label5.Text = "Choose one\r\ninvestment method";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.ContextMenuStrip = this.cmsCrypto;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(540, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(233, 79);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Cryptocurrency";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmsCrypto
            // 
            this.cmsCrypto.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsCrypto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learnMoreToolStripMenuItem});
            this.cmsCrypto.Name = "cmsCrypto";
            this.cmsCrypto.Size = new System.Drawing.Size(174, 34);
            this.cmsCrypto.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCrypto_Opening);
            // 
            // learnMoreToolStripMenuItem
            // 
            this.learnMoreToolStripMenuItem.Name = "learnMoreToolStripMenuItem";
            this.learnMoreToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.learnMoreToolStripMenuItem.Text = "Learn more";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ContextMenuStrip = this.cmsBonds;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(540, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 71);
            this.button1.TabIndex = 29;
            this.button1.Text = "Other";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmsBonds
            // 
            this.cmsBonds.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsBonds.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learnMoreToolStripMenuItem2});
            this.cmsBonds.Name = "cmsBonds";
            this.cmsBonds.Size = new System.Drawing.Size(174, 34);
            this.cmsBonds.Opening += new System.ComponentModel.CancelEventHandler(this.cmsBonds_Opening);
            // 
            // learnMoreToolStripMenuItem2
            // 
            this.learnMoreToolStripMenuItem2.Name = "learnMoreToolStripMenuItem2";
            this.learnMoreToolStripMenuItem2.Size = new System.Drawing.Size(173, 30);
            this.learnMoreToolStripMenuItem2.Text = "Learn more";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ContextMenuStrip = this.cmsStocks;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(540, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 79);
            this.button2.TabIndex = 30;
            this.button2.Text = "Stocks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmsStocks
            // 
            this.cmsStocks.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsStocks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learnMoreToolStripMenuItem1});
            this.cmsStocks.Name = "cmsStocks";
            this.cmsStocks.Size = new System.Drawing.Size(174, 34);
            this.cmsStocks.Opening += new System.ComponentModel.CancelEventHandler(this.cmsStocks_Opening);
            // 
            // learnMoreToolStripMenuItem1
            // 
            this.learnMoreToolStripMenuItem1.Name = "learnMoreToolStripMenuItem1";
            this.learnMoreToolStripMenuItem1.Size = new System.Drawing.Size(173, 30);
            this.learnMoreToolStripMenuItem1.Text = "Learn More";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportStatsToolStripMenuItem,
            this.investToolStripMenuItem,
            this.saveUpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(50, 20, 100, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 47);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportStatsToolStripMenuItem
            // 
            this.exportStatsToolStripMenuItem.Name = "exportStatsToolStripMenuItem";
            this.exportStatsToolStripMenuItem.Size = new System.Drawing.Size(148, 25);
            this.exportStatsToolStripMenuItem.Text = "Add transaction";
            this.exportStatsToolStripMenuItem.Click += new System.EventHandler(this.exportStatsToolStripMenuItem_Click);
            // 
            // investToolStripMenuItem
            // 
            this.investToolStripMenuItem.Name = "investToolStripMenuItem";
            this.investToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.investToolStripMenuItem.Text = "Save up!";
            this.investToolStripMenuItem.Click += new System.EventHandler(this.investToolStripMenuItem_Click);
            // 
            // saveUpToolStripMenuItem
            // 
            this.saveUpToolStripMenuItem.Name = "saveUpToolStripMenuItem";
            this.saveUpToolStripMenuItem.Size = new System.Drawing.Size(144, 25);
            this.saveUpToolStripMenuItem.Text = "Check the news";
            this.saveUpToolStripMenuItem.Click += new System.EventHandler(this.saveUpToolStripMenuItem_Click);
            // 
            // InvestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Name = "InvestForm";
            this.Text = "InvestForm";
            this.cmsCrypto.ResumeLayout(false);
            this.cmsBonds.ResumeLayout(false);
            this.cmsStocks.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem investToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveUpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsCrypto;
        private System.Windows.Forms.ToolStripMenuItem learnMoreToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsBonds;
        private System.Windows.Forms.ContextMenuStrip cmsStocks;
        private System.Windows.Forms.ToolStripMenuItem learnMoreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem learnMoreToolStripMenuItem2;
    }
}