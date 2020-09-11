namespace MyWallet
{
    partial class BalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbHabits = new System.Windows.Forms.RichTextBox();
            this.btnSaveUp = new System.Windows.Forms.Button();
            this.rtbRecom = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.investToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPrintRecom = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagePreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTheNewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara Light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(610, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 97);
            this.label1.TabIndex = 13;
            this.label1.Text = "Save up!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(667, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Weekly stats";
            // 
            // rtbHabits
            // 
            this.rtbHabits.Location = new System.Drawing.Point(674, 174);
            this.rtbHabits.Name = "rtbHabits";
            this.rtbHabits.Size = new System.Drawing.Size(314, 173);
            this.rtbHabits.TabIndex = 15;
            this.rtbHabits.Text = "";
            // 
            // btnSaveUp
            // 
            this.btnSaveUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSaveUp.ForeColor = System.Drawing.Color.White;
            this.btnSaveUp.Location = new System.Drawing.Point(502, 240);
            this.btnSaveUp.Name = "btnSaveUp";
            this.btnSaveUp.Size = new System.Drawing.Size(109, 37);
            this.btnSaveUp.TabIndex = 17;
            this.btnSaveUp.Text = "Find out";
            this.btnSaveUp.UseVisualStyleBackColor = true;
            this.btnSaveUp.Click += new System.EventHandler(this.btnSaveUp_Click);
            // 
            // rtbRecom
            // 
            this.rtbRecom.Location = new System.Drawing.Point(674, 370);
            this.rtbRecom.Name = "rtbRecom";
            this.rtbRecom.Size = new System.Drawing.Size(314, 165);
            this.rtbRecom.TabIndex = 18;
            this.rtbRecom.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara Light", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(498, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 48);
            this.label3.TabIndex = 19;
            this.label3.Text = "What is my biggest \r\nspending habit?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara Light", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(498, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 48);
            this.label4.TabIndex = 20;
            this.label4.Text = "How can I save \r\nmoney?";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(502, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Find out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionToolStripMenuItem,
            this.investToolStripMenuItem,
            this.exportStatsToolStripMenuItem,
            this.checkTheNewsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(50, 20, 100, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1016, 47);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addTransactionToolStripMenuItem
            // 
            this.addTransactionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addTransactionToolStripMenuItem.Name = "addTransactionToolStripMenuItem";
            this.addTransactionToolStripMenuItem.Size = new System.Drawing.Size(151, 25);
            this.addTransactionToolStripMenuItem.Text = "Add Transaction";
            this.addTransactionToolStripMenuItem.Click += new System.EventHandler(this.addTransactionToolStripMenuItem_Click);
            // 
            // investToolStripMenuItem
            // 
            this.investToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.investToolStripMenuItem.Name = "investToolStripMenuItem";
            this.investToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.investToolStripMenuItem.Text = "Invest";
            this.investToolStripMenuItem.Click += new System.EventHandler(this.investToolStripMenuItem_Click);
            // 
            // exportStatsToolStripMenuItem
            // 
            this.exportStatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsPrintRecom,
            this.tXTExportToolStripMenuItem,
            this.pageSetupToolStripMenuItem});
            this.exportStatsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportStatsToolStripMenuItem.Name = "exportStatsToolStripMenuItem";
            this.exportStatsToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.exportStatsToolStripMenuItem.Text = "Print ";
            // 
            // cmsPrintRecom
            // 
            this.cmsPrintRecom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageSetupToolStripMenuItem1,
            this.pagePreviewToolStripMenuItem});
            this.cmsPrintRecom.Name = "cmsPrintRecom";
            this.cmsPrintRecom.Size = new System.Drawing.Size(277, 30);
            this.cmsPrintRecom.Text = "Print recommendations";
            this.cmsPrintRecom.Click += new System.EventHandler(this.cmsPrintRecom_Click);
            // 
            // pageSetupToolStripMenuItem1
            // 
            this.pageSetupToolStripMenuItem1.Name = "pageSetupToolStripMenuItem1";
            this.pageSetupToolStripMenuItem1.Size = new System.Drawing.Size(197, 30);
            this.pageSetupToolStripMenuItem1.Text = "Page setup";
            this.pageSetupToolStripMenuItem1.Click += new System.EventHandler(this.pageSetupToolStripMenuItem1_Click);
            // 
            // pagePreviewToolStripMenuItem
            // 
            this.pagePreviewToolStripMenuItem.Name = "pagePreviewToolStripMenuItem";
            this.pagePreviewToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.pagePreviewToolStripMenuItem.Text = "Page preview";
            this.pagePreviewToolStripMenuItem.Click += new System.EventHandler(this.pagePreviewToolStripMenuItem_Click);
            // 
            // tXTExportToolStripMenuItem
            // 
            this.tXTExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem});
            this.tXTExportToolStripMenuItem.Name = "tXTExportToolStripMenuItem";
            this.tXTExportToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.tXTExportToolStripMenuItem.Text = "Print habits";
            this.tXTExportToolStripMenuItem.Click += new System.EventHandler(this.tXTExportToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.printPreviewToolStripMenuItem.Text = "Print preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.pageSetupToolStripMenuItem.Text = "Page setup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // checkTheNewsToolStripMenuItem
            // 
            this.checkTheNewsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.checkTheNewsToolStripMenuItem.Name = "checkTheNewsToolStripMenuItem";
            this.checkTheNewsToolStripMenuItem.Size = new System.Drawing.Size(247, 25);
            this.checkTheNewsToolStripMenuItem.Text = "Check tips for saving money";
            this.checkTheNewsToolStripMenuItem.Click += new System.EventHandler(this.checkTheNewsToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument2
            // 
            this.printDocument2.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument2_BeginPrint);
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // pageSetupDialog2
            // 
            this.pageSetupDialog2.Document = this.printDocument2;
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.printDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // printDialog2
            // 
            this.printDialog2.Document = this.printDocument2;
            this.printDialog2.UseEXDialog = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.AutoFitMinFontSize = 5;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSpacing = 10;
            legend2.Name = "Legend1";
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 70);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Color = System.Drawing.Color.Teal;
            series9.Legend = "Legend1";
            series9.Name = "Medicine";
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.OliveDrab;
            series10.Legend = "Legend1";
            series10.Name = "Rent";
            series11.ChartArea = "ChartArea1";
            series11.Color = System.Drawing.Color.DeepSkyBlue;
            series11.Legend = "Legend1";
            series11.Name = "Clothing";
            series12.ChartArea = "ChartArea1";
            series12.Color = System.Drawing.Color.PaleGreen;
            series12.Legend = "Legend1";
            series12.Name = "Gas";
            series13.ChartArea = "ChartArea1";
            series13.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series13.Legend = "Legend1";
            series13.Name = "Electronics";
            series14.ChartArea = "ChartArea1";
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series14.Legend = "Legend1";
            series14.Name = "Food";
            series15.ChartArea = "ChartArea1";
            series15.Color = System.Drawing.Color.Navy;
            series15.Legend = "Legend1";
            series15.Name = "Household Items";
            series16.ChartArea = "ChartArea1";
            series16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series16.Legend = "Legend1";
            series16.Name = "Leisure";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Size = new System.Drawing.Size(492, 433);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // BalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1016, 547);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbRecom);
            this.Controls.Add(this.btnSaveUp);
            this.Controls.Add(this.rtbHabits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BalanceForm";
            this.Text = "BalanceForm";
            this.Load += new System.EventHandler(this.BalanceForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbHabits;
        private System.Windows.Forms.Button btnSaveUp;
        private System.Windows.Forms.RichTextBox rtbRecom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem investToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsPrintRecom;
        private System.Windows.Forms.ToolStripMenuItem tXTExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkTheNewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pagePreviewToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}