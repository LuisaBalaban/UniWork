namespace MyWallet
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnAddTrans = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnSaveUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTrans
            // 
            this.btnAddTrans.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTrans.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTrans.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrans.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddTrans.ForeColor = System.Drawing.Color.White;
            this.btnAddTrans.Location = new System.Drawing.Point(348, 29);
            this.btnAddTrans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTrans.Name = "btnAddTrans";
            this.btnAddTrans.Size = new System.Drawing.Size(153, 58);
            this.btnAddTrans.TabIndex = 0;
            this.btnAddTrans.Text = "Add Transaction";
            this.btnAddTrans.UseVisualStyleBackColor = true;
            this.btnAddTrans.Click += new System.EventHandler(this.btnAddTrans_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(36, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Course Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Candara Light", 32F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(94, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 53);
            this.label1.TabIndex = 12;
            this.label1.Text = "My Wallet";
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckBalance.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheckBalance.ForeColor = System.Drawing.Color.White;
            this.btnCheckBalance.Location = new System.Drawing.Point(348, 116);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(153, 62);
            this.btnCheckBalance.TabIndex = 13;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnSaveUp
            // 
            this.btnSaveUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUp.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveUp.ForeColor = System.Drawing.Color.White;
            this.btnSaveUp.Location = new System.Drawing.Point(348, 207);
            this.btnSaveUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveUp.Name = "btnSaveUp";
            this.btnSaveUp.Size = new System.Drawing.Size(153, 62);
            this.btnSaveUp.TabIndex = 14;
            this.btnSaveUp.Text = "Invest";
            this.btnSaveUp.UseVisualStyleBackColor = true;
            this.btnSaveUp.Click += new System.EventHandler(this.btnSaveUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Candara Light", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(73, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 58);
            this.label3.TabIndex = 15;
            this.label3.Text = "Everything that doesn\'t\r\n fit in your wallet!";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(207)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(518, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveUp);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTrans);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnSaveUp;
        private System.Windows.Forms.Label label3;
    }
}

