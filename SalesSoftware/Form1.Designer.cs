namespace SalesSoftware
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
            this.grpPurchase = new System.Windows.Forms.GroupBox();
            this.lblNumofPack = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.txtNumPackage = new System.Windows.Forms.TextBox();
            this.txtPricePackage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstSoftwareResult = new System.Windows.Forms.ListBox();
            this.grpPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPurchase
            // 
            this.grpPurchase.Controls.Add(this.btnExit);
            this.grpPurchase.Controls.Add(this.btnClear);
            this.grpPurchase.Controls.Add(this.btnCalculate);
            this.grpPurchase.Controls.Add(this.txtPricePackage);
            this.grpPurchase.Controls.Add(this.txtNumPackage);
            this.grpPurchase.Controls.Add(this.lblPackage);
            this.grpPurchase.Controls.Add(this.lblNumofPack);
            this.grpPurchase.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPurchase.Location = new System.Drawing.Point(12, 21);
            this.grpPurchase.Name = "grpPurchase";
            this.grpPurchase.Size = new System.Drawing.Size(676, 539);
            this.grpPurchase.TabIndex = 0;
            this.grpPurchase.TabStop = false;
            this.grpPurchase.Text = "Purchase Information";
            // 
            // lblNumofPack
            // 
            this.lblNumofPack.AutoSize = true;
            this.lblNumofPack.Location = new System.Drawing.Point(4, 61);
            this.lblNumofPack.Name = "lblNumofPack";
            this.lblNumofPack.Size = new System.Drawing.Size(309, 41);
            this.lblNumofPack.TabIndex = 0;
            this.lblNumofPack.Text = "Number Of Package";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(45, 125);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(268, 41);
            this.lblPackage.TabIndex = 1;
            this.lblPackage.Text = "Price PerPackage";
            // 
            // txtNumPackage
            // 
            this.txtNumPackage.Location = new System.Drawing.Point(342, 61);
            this.txtNumPackage.Name = "txtNumPackage";
            this.txtNumPackage.Size = new System.Drawing.Size(328, 49);
            this.txtNumPackage.TabIndex = 2;
            // 
            // txtPricePackage
            // 
            this.txtPricePackage.Location = new System.Drawing.Point(342, 117);
            this.txtPricePackage.Name = "txtPricePackage";
            this.txtPricePackage.Size = new System.Drawing.Size(328, 49);
            this.txtPricePackage.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Location = new System.Drawing.Point(25, 341);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(161, 51);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(223, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(161, 51);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(422, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 51);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstSoftwareResult
            // 
            this.lstSoftwareResult.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSoftwareResult.FormattingEnabled = true;
            this.lstSoftwareResult.ItemHeight = 24;
            this.lstSoftwareResult.Location = new System.Drawing.Point(710, 36);
            this.lstSoftwareResult.Name = "lstSoftwareResult";
            this.lstSoftwareResult.Size = new System.Drawing.Size(531, 508);
            this.lstSoftwareResult.TabIndex = 1;
            this.lstSoftwareResult.SelectedIndexChanged += new System.EventHandler(this.lstSoftwareResult_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 743);
            this.Controls.Add(this.lstSoftwareResult);
            this.Controls.Add(this.grpPurchase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPurchase.ResumeLayout(false);
            this.grpPurchase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPurchase;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblNumofPack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPricePackage;
        private System.Windows.Forms.TextBox txtNumPackage;
        private System.Windows.Forms.ListBox lstSoftwareResult;
    }
}

