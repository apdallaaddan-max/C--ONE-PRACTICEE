namespace PayRollWithTime
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHoursWroked = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtHourlypayrate = new System.Windows.Forms.TextBox();
            this.lblGrossPayLabel = new System.Windows.Forms.Label();
            this.btnCalculateButton = new System.Windows.Forms.Button();
            this.btnClearButton = new System.Windows.Forms.Button();
            this.btnExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExitButton);
            this.panel1.Controls.Add(this.btnClearButton);
            this.panel1.Controls.Add(this.btnCalculateButton);
            this.panel1.Controls.Add(this.lblGrossPayLabel);
            this.panel1.Controls.Add(this.txtHourlypayrate);
            this.panel1.Controls.Add(this.txtHoursWorked);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblHoursWroked);
            this.panel1.Location = new System.Drawing.Point(28, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 548);
            this.panel1.TabIndex = 0;
            // 
            // lblHoursWroked
            // 
            this.lblHoursWroked.AutoSize = true;
            this.lblHoursWroked.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWroked.Location = new System.Drawing.Point(47, 62);
            this.lblHoursWroked.Name = "lblHoursWroked";
            this.lblHoursWroked.Size = new System.Drawing.Size(216, 36);
            this.lblHoursWroked.TabIndex = 0;
            this.lblHoursWroked.Text = "Hours Worked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourly Per Paid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grosspay";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoursWorked.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(314, 62);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(241, 48);
            this.txtHoursWorked.TabIndex = 3;
            // 
            // txtHourlypayrate
            // 
            this.txtHourlypayrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHourlypayrate.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlypayrate.Location = new System.Drawing.Point(314, 122);
            this.txtHourlypayrate.Name = "txtHourlypayrate";
            this.txtHourlypayrate.Size = new System.Drawing.Size(241, 48);
            this.txtHourlypayrate.TabIndex = 4;
            // 
            // lblGrossPayLabel
            // 
            this.lblGrossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrossPayLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPayLabel.Location = new System.Drawing.Point(308, 229);
            this.lblGrossPayLabel.Name = "lblGrossPayLabel";
            this.lblGrossPayLabel.Size = new System.Drawing.Size(247, 57);
            this.lblGrossPayLabel.TabIndex = 5;
            // 
            // btnCalculateButton
            // 
            this.btnCalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateButton.Location = new System.Drawing.Point(19, 401);
            this.btnCalculateButton.Name = "btnCalculateButton";
            this.btnCalculateButton.Size = new System.Drawing.Size(214, 91);
            this.btnCalculateButton.TabIndex = 6;
            this.btnCalculateButton.Text = "&Calculate Gross Pay";
            this.btnCalculateButton.UseVisualStyleBackColor = true;
            this.btnCalculateButton.Click += new System.EventHandler(this.btnCalculateButton_Click);
            // 
            // btnClearButton
            // 
            this.btnClearButton.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearButton.Location = new System.Drawing.Point(239, 401);
            this.btnClearButton.Name = "btnClearButton";
            this.btnClearButton.Size = new System.Drawing.Size(162, 81);
            this.btnClearButton.TabIndex = 7;
            this.btnClearButton.Text = "C&lear";
            this.btnClearButton.UseVisualStyleBackColor = true;
            this.btnClearButton.Click += new System.EventHandler(this.btnClearButton_Click);
            // 
            // btnExitButton
            // 
            this.btnExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitButton.Location = new System.Drawing.Point(439, 408);
            this.btnExitButton.Name = "btnExitButton";
            this.btnExitButton.Size = new System.Drawing.Size(143, 64);
            this.btnExitButton.TabIndex = 8;
            this.btnExitButton.Text = "&Exit";
            this.btnExitButton.UseVisualStyleBackColor = true;
            this.btnExitButton.Click += new System.EventHandler(this.btnExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 727);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHourlypayrate;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHoursWroked;
        private System.Windows.Forms.Button btnExitButton;
        private System.Windows.Forms.Button btnClearButton;
        private System.Windows.Forms.Button btnCalculateButton;
        private System.Windows.Forms.Label lblGrossPayLabel;
    }
}

