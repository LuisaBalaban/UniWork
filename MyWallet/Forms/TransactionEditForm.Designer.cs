namespace MyWallet
{
    partial class TransactionEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionEditForm));
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CalendarFont = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTime.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpDateTime.Location = new System.Drawing.Point(180, 110);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(218, 26);
            this.dtpDateTime.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Candara Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(38, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 35);
            this.label6.TabIndex = 37;
            this.label6.Text = "Date";
            // 
            // tbAmount
            // 
            this.tbAmount.AllowDrop = true;
            this.tbAmount.BackColor = System.Drawing.SystemColors.Info;
            this.tbAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAmount.Location = new System.Drawing.Point(180, 227);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(218, 26);
            this.tbAmount.TabIndex = 36;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // tbItem
            // 
            this.tbItem.AllowDrop = true;
            this.tbItem.BackColor = System.Drawing.Color.Ivory;
            this.tbItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbItem.Location = new System.Drawing.Point(180, 184);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(218, 26);
            this.tbItem.TabIndex = 35;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.Info;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(180, 145);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(218, 28);
            this.cbCategory.TabIndex = 34;
            // 
            // tbInfo
            // 
            this.tbInfo.AllowDrop = true;
            this.tbInfo.BackColor = System.Drawing.SystemColors.Info;
            this.tbInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbInfo.Location = new System.Drawing.Point(180, 263);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(218, 26);
            this.tbInfo.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(38, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 35);
            this.label4.TabIndex = 32;
            this.label4.Text = "Other Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(38, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 35);
            this.label3.TabIndex = 31;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 35);
            this.label2.TabIndex = 30;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 35);
            this.label1.TabIndex = 29;
            this.label1.Text = "Category";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(237, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 57);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Exit";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(44, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 57);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TransactionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransactionEditForm";
            this.Text = "TransactionEditForm";
            this.Load += new System.EventHandler(this.TransactionEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}