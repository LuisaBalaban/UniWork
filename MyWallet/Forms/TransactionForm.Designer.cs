namespace MyWallet
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lvTransactions = new System.Windows.Forms.ListView();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.investToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTheNewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(419, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(419, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(419, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(419, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "Other Info";
            // 
            // tbInfo
            // 
            this.tbInfo.AllowDrop = true;
            this.tbInfo.BackColor = System.Drawing.SystemColors.Info;
            this.tbInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbInfo.Location = new System.Drawing.Point(561, 221);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(218, 26);
            this.tbInfo.TabIndex = 17;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.Info;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(561, 103);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(218, 28);
            this.cbCategory.TabIndex = 18;
            // 
            // tbItem
            // 
            this.tbItem.AllowDrop = true;
            this.tbItem.BackColor = System.Drawing.SystemColors.Info;
            this.tbItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbItem.Location = new System.Drawing.Point(561, 142);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(218, 26);
            this.tbItem.TabIndex = 19;
            // 
            // tbAmount
            // 
            this.tbAmount.AllowDrop = true;
            this.tbAmount.BackColor = System.Drawing.SystemColors.Info;
            this.tbAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAmount.Location = new System.Drawing.Point(561, 185);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(184, 26);
            this.tbAmount.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(425, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 57);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(618, 267);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 57);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(425, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 57);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinish.BackColor = System.Drawing.Color.Transparent;
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFinish.Location = new System.Drawing.Point(618, 352);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(161, 57);
            this.btnFinish.TabIndex = 24;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lvTransactions
            // 
            this.lvTransactions.BackColor = System.Drawing.SystemColors.Info;
            this.lvTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTransactions.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTransactions.FullRowSelect = true;
            this.lvTransactions.GridLines = true;
            this.lvTransactions.HideSelection = false;
            this.lvTransactions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvTransactions.Location = new System.Drawing.Point(23, 185);
            this.lvTransactions.Name = "lvTransactions";
            this.lvTransactions.Size = new System.Drawing.Size(378, 224);
            this.lvTransactions.SmallImageList = this.imageList1;
            this.lvTransactions.TabIndex = 25;
            this.lvTransactions.UseCompatibleStateImageBehavior = false;
            this.lvTransactions.View = System.Windows.Forms.View.Details;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 90;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount $";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Other Info";
            this.columnHeader3.Width = 104;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "food.png");
            this.imageList1.Images.SetKeyName(1, "house.png");
            this.imageList1.Images.SetKeyName(2, "medicine.png");
            this.imageList1.Images.SetKeyName(3, "clothing.png");
            this.imageList1.Images.SetKeyName(4, "electronics.png");
            this.imageList1.Images.SetKeyName(5, "gas.png");
            this.imageList1.Images.SetKeyName(6, "rent.png");
            this.imageList1.Images.SetKeyName(7, "leisure.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Candara Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 64);
            this.label5.TabIndex = 26;
            this.label5.Text = "Add Transaction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Candara Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(419, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 35);
            this.label6.TabIndex = 27;
            this.label6.Text = "Date";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CalendarFont = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTime.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpDateTime.Location = new System.Drawing.Point(561, 68);
            this.dtpDateTime.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpDateTime.MinDate = new System.DateTime(2020, 7, 26, 0, 0, 0, 0);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(218, 26);
            this.dtpDateTime.TabIndex = 28;
            this.dtpDateTime.Value = new System.DateTime(2020, 9, 8, 0, 0, 0, 0);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportStatsToolStripMenuItem,
            this.investToolStripMenuItem,
            this.saveUpToolStripMenuItem,
            this.checkTheNewsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(50, 20, 100, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 47);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportStatsToolStripMenuItem
            // 
            this.exportStatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLExportToolStripMenuItem,
            this.tXTExportToolStripMenuItem});
            this.exportStatsToolStripMenuItem.Name = "exportStatsToolStripMenuItem";
            this.exportStatsToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.exportStatsToolStripMenuItem.Text = "Export Stats";
            // 
            // xMLExportToolStripMenuItem
            // 
            this.xMLExportToolStripMenuItem.Name = "xMLExportToolStripMenuItem";
            this.xMLExportToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.xMLExportToolStripMenuItem.Text = "XML serialization";
            this.xMLExportToolStripMenuItem.Click += new System.EventHandler(this.xMLExportToolStripMenuItem_Click);
            // 
            // tXTExportToolStripMenuItem
            // 
            this.tXTExportToolStripMenuItem.Name = "tXTExportToolStripMenuItem";
            this.tXTExportToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.tXTExportToolStripMenuItem.Text = "TXT export";
            this.tXTExportToolStripMenuItem.Click += new System.EventHandler(this.tXTExportToolStripMenuItem_Click);
            // 
            // investToolStripMenuItem
            // 
            this.investToolStripMenuItem.Name = "investToolStripMenuItem";
            this.investToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.investToolStripMenuItem.Text = "Invest";
            this.investToolStripMenuItem.Click += new System.EventHandler(this.investToolStripMenuItem_Click);
            // 
            // saveUpToolStripMenuItem
            // 
            this.saveUpToolStripMenuItem.Name = "saveUpToolStripMenuItem";
            this.saveUpToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.saveUpToolStripMenuItem.Text = "Save up!";
            this.saveUpToolStripMenuItem.Click += new System.EventHandler(this.saveUpToolStripMenuItem_Click);
            // 
            // checkTheNewsToolStripMenuItem
            // 
            this.checkTheNewsToolStripMenuItem.Name = "checkTheNewsToolStripMenuItem";
            this.checkTheNewsToolStripMenuItem.Size = new System.Drawing.Size(144, 25);
            this.checkTheNewsToolStripMenuItem.Text = "Check the news";
            this.checkTheNewsToolStripMenuItem.Click += new System.EventHandler(this.checkTheNewsToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Candara Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(752, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 35);
            this.label7.TabIndex = 30;
            this.label7.Text = "$";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvTransactions);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ListView lvTransactions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem investToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkTheNewsToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}