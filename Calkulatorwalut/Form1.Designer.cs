namespace Calkulatorwalut
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

        private void InitializeComponent()
        {
            this.lblAmountInPLN = new System.Windows.Forms.Label();
            this.txtAmountInPLN = new System.Windows.Forms.TextBox();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultUSD = new System.Windows.Forms.Label();
            this.lblRates = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmountInPLN
            // 
            this.lblAmountInPLN.AutoSize = true;
            this.lblAmountInPLN.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAmountInPLN.Location = new System.Drawing.Point(61, 61);
            this.lblAmountInPLN.Name = "lblAmountInPLN";
            this.lblAmountInPLN.Size = new System.Drawing.Size(172, 26);
            this.lblAmountInPLN.TabIndex = 0;
            this.lblAmountInPLN.Text = "Kwota w PLN:";
            this.lblAmountInPLN.Click += new System.EventHandler(this.lblAmountInPLN_Click);
            // 
            // txtAmountInPLN
            // 
            this.txtAmountInPLN.Location = new System.Drawing.Point(95, 113);
            this.txtAmountInPLN.Name = "txtAmountInPLN";
            this.txtAmountInPLN.Size = new System.Drawing.Size(100, 20);
            this.txtAmountInPLN.TabIndex = 1;
            this.txtAmountInPLN.TextChanged += new System.EventHandler(this.txtAmountInPLN_TextChanged);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(95, 159);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(100, 21);
            this.cmbCurrency.TabIndex = 2;
            this.cmbCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(95, 210);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Przelicz";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(77, 326);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(214, 60);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Tu pojawi się kwota w wybranej walucie";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblResultUSD
            // 
            this.lblResultUSD.Location = new System.Drawing.Point(77, 255);
            this.lblResultUSD.Name = "lblResultUSD";
            this.lblResultUSD.Size = new System.Drawing.Size(214, 60);
            this.lblResultUSD.TabIndex = 5;
            this.lblResultUSD.Text = "Tu pojawi się kwota w USD";
            this.lblResultUSD.Click += new System.EventHandler(this.lblResultUSD_Click);
            // 
            // lblRates
            // 
            this.lblRates.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRates.Location = new System.Drawing.Point(350, 61);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(205, 214);
            this.lblRates.TabIndex = 6;
            this.lblRates.Text = "Kursy";
            this.lblRates.Click += new System.EventHandler(this.lblRates_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(817, 627);
            this.Controls.Add(this.lblRates);
            this.Controls.Add(this.lblResultUSD);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.txtAmountInPLN);
            this.Controls.Add(this.lblAmountInPLN);
            this.Name = "Form1";
            this.Text = "Kalkulator Walutowy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmountInPLN;
        private System.Windows.Forms.TextBox txtAmountInPLN;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultUSD;  // Nowa labela dla USD
        private System.Windows.Forms.Label lblRates;
    }
}