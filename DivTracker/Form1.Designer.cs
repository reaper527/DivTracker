namespace DivTracker
{
    partial class Form1
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
            this.FetchDividends = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextExDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DividendCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DividendCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearlyTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Stock2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shares2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dividend2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DividendTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearlyTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Stock3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shares3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfigButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // FetchDividends
            // 
            this.FetchDividends.Location = new System.Drawing.Point(296, 12);
            this.FetchDividends.Name = "FetchDividends";
            this.FetchDividends.Size = new System.Drawing.Size(145, 23);
            this.FetchDividends.TabIndex = 5;
            this.FetchDividends.Text = "Fetch Upcoming Dividends";
            this.FetchDividends.UseVisualStyleBackColor = true;
            this.FetchDividends.Click += new System.EventHandler(this.FetchDividends_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stock,
            this.Shares,
            this.NextExDate,
            this.PayDate,
            this.DividendCol,
            this.DividendCol2,
            this.Frequency,
            this.YearlyTotalCol});
            this.dataGridView1.Location = new System.Drawing.Point(26, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 231);
            this.dataGridView1.TabIndex = 6;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Shares
            // 
            this.Shares.HeaderText = "Shares";
            this.Shares.Name = "Shares";
            // 
            // NextExDate
            // 
            this.NextExDate.HeaderText = "Next ExDate";
            this.NextExDate.Name = "NextExDate";
            // 
            // PayDate
            // 
            this.PayDate.HeaderText = "Pay Date";
            this.PayDate.Name = "PayDate";
            // 
            // DividendCol
            // 
            this.DividendCol.HeaderText = "Dividend (Per Share)";
            this.DividendCol.Name = "DividendCol";
            // 
            // DividendCol2
            // 
            this.DividendCol2.HeaderText = "Dividend (Total)";
            this.DividendCol2.Name = "DividendCol2";
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            // 
            // YearlyTotalCol
            // 
            this.YearlyTotalCol.HeaderText = "Yearly Total";
            this.YearlyTotalCol.Name = "YearlyTotalCol";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stock2,
            this.Shares2,
            this.ExDate2,
            this.Dividend2,
            this.DividendTotal2,
            this.Frequency2,
            this.YearlyTotal2});
            this.dataGridView2.Location = new System.Drawing.Point(26, 304);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(845, 380);
            this.dataGridView2.TabIndex = 7;
            // 
            // Stock2
            // 
            this.Stock2.HeaderText = "Stock";
            this.Stock2.Name = "Stock2";
            // 
            // Shares2
            // 
            this.Shares2.HeaderText = "Shares";
            this.Shares2.Name = "Shares2";
            // 
            // ExDate2
            // 
            this.ExDate2.HeaderText = "ExDate";
            this.ExDate2.Name = "ExDate2";
            // 
            // Dividend2
            // 
            this.Dividend2.HeaderText = "Dividend (Per Share)";
            this.Dividend2.Name = "Dividend2";
            // 
            // DividendTotal2
            // 
            this.DividendTotal2.HeaderText = "Dividend (Total)";
            this.DividendTotal2.Name = "DividendTotal2";
            // 
            // Frequency2
            // 
            this.Frequency2.HeaderText = "Frequency";
            this.Frequency2.Name = "Frequency2";
            // 
            // YearlyTotal2
            // 
            this.YearlyTotal2.HeaderText = "Yearly Total";
            this.YearlyTotal2.Name = "YearlyTotal2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Upcoming Dividends";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Issued in last 6 months";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stock3,
            this.Shares3});
            this.dataGridView3.Location = new System.Drawing.Point(26, 725);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(845, 210);
            this.dataGridView3.TabIndex = 10;
            // 
            // Stock3
            // 
            this.Stock3.HeaderText = "Stock";
            this.Stock3.Name = "Stock3";
            // 
            // Shares3
            // 
            this.Shares3.HeaderText = "Shares";
            this.Shares3.Name = "Shares3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 701);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Non-Dividend";
            // 
            // ConfigButton
            // 
            this.ConfigButton.Location = new System.Drawing.Point(463, 12);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(75, 23);
            this.ConfigButton.TabIndex = 14;
            this.ConfigButton.Text = "Config";
            this.ConfigButton.UseVisualStyleBackColor = true;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 947);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FetchDividends);
            this.Name = "Form1";
            this.Text = "r527 - DivTracker - 0.1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FetchDividends;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shares2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dividend2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DividendTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency2;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearlyTotal2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shares3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shares;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextExDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DividendCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DividendCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearlyTotalCol;
        private System.Windows.Forms.Button ConfigButton;
    }
}

