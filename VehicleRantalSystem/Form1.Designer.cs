namespace VehicleRantalSystem
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
            this.lstDetails = new System.Windows.Forms.ListBox();
            this.lblcustomerName = new System.Windows.Forms.Label();
            this.lblDrivingExperience = new System.Windows.Forms.Label();
            this.lblNumRental = new System.Windows.Forms.Label();
            this.lblCusAge = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdosuv = new System.Windows.Forms.RadioButton();
            this.rdoluxury = new System.Windows.Forms.RadioButton();
            this.rdoeconomy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtRentalDays = new System.Windows.Forms.TextBox();
            this.txtYearofExperience = new System.Windows.Forms.TextBox();
            this.btnEXit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDetails
            // 
            this.lstDetails.FormattingEnabled = true;
            this.lstDetails.ItemHeight = 20;
            this.lstDetails.Location = new System.Drawing.Point(902, 12);
            this.lstDetails.Name = "lstDetails";
            this.lstDetails.Size = new System.Drawing.Size(389, 644);
            this.lstDetails.TabIndex = 34;
            // 
            // lblcustomerName
            // 
            this.lblcustomerName.AutoSize = true;
            this.lblcustomerName.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerName.Location = new System.Drawing.Point(237, 49);
            this.lblcustomerName.Name = "lblcustomerName";
            this.lblcustomerName.Size = new System.Drawing.Size(333, 52);
            this.lblcustomerName.TabIndex = 0;
            this.lblcustomerName.Text = "CustomerName:";
            // 
            // lblDrivingExperience
            // 
            this.lblDrivingExperience.AutoSize = true;
            this.lblDrivingExperience.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivingExperience.Location = new System.Drawing.Point(17, 216);
            this.lblDrivingExperience.Name = "lblDrivingExperience";
            this.lblDrivingExperience.Size = new System.Drawing.Size(553, 52);
            this.lblDrivingExperience.TabIndex = 3;
            this.lblDrivingExperience.Text = "Years Of DrivingExperience:";
            // 
            // lblNumRental
            // 
            this.lblNumRental.AutoSize = true;
            this.lblNumRental.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRental.Location = new System.Drawing.Point(82, 164);
            this.lblNumRental.Name = "lblNumRental";
            this.lblNumRental.Size = new System.Drawing.Size(488, 52);
            this.lblNumRental.TabIndex = 4;
            this.lblNumRental.Text = "Number Of Rental Days:";
            // 
            // lblCusAge
            // 
            this.lblCusAge.AutoSize = true;
            this.lblCusAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusAge.Location = new System.Drawing.Point(275, 101);
            this.lblCusAge.Name = "lblCusAge";
            this.lblCusAge.Size = new System.Drawing.Size(295, 52);
            this.lblCusAge.TabIndex = 5;
            this.lblCusAge.Text = "CustomerAge:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("MingLiU-ExtB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(576, 49);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(280, 46);
            this.txtCustomerName.TabIndex = 6;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(350, 622);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(143, 53);
            this.btnclear.TabIndex = 32;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(157, 622);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(143, 53);
            this.btnCal.TabIndex = 31;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.Location = new System.Drawing.Point(17, 48);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(451, 45);
            this.chkinsurance.TabIndex = 0;
            this.chkinsurance.Text = "Add Insurance($15 Per Day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.chkinsurance);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 470);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(857, 119);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insurance Option";
            // 
            // rdosuv
            // 
            this.rdosuv.AutoSize = true;
            this.rdosuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdosuv.Location = new System.Drawing.Point(339, 58);
            this.rdosuv.Name = "rdosuv";
            this.rdosuv.Size = new System.Drawing.Size(97, 36);
            this.rdosuv.TabIndex = 2;
            this.rdosuv.TabStop = true;
            this.rdosuv.Text = "SUV";
            this.rdosuv.UseVisualStyleBackColor = true;
            // 
            // rdoluxury
            // 
            this.rdoluxury.AutoSize = true;
            this.rdoluxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoluxury.Location = new System.Drawing.Point(538, 58);
            this.rdoluxury.Name = "rdoluxury";
            this.rdoluxury.Size = new System.Drawing.Size(124, 36);
            this.rdoluxury.TabIndex = 1;
            this.rdoluxury.TabStop = true;
            this.rdoluxury.Text = "Luxury";
            this.rdoluxury.UseVisualStyleBackColor = true;
            // 
            // rdoeconomy
            // 
            this.rdoeconomy.AutoSize = true;
            this.rdoeconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoeconomy.Location = new System.Drawing.Point(65, 58);
            this.rdoeconomy.Name = "rdoeconomy";
            this.rdoeconomy.Size = new System.Drawing.Size(157, 36);
            this.rdoeconomy.TabIndex = 0;
            this.rdoeconomy.TabStop = true;
            this.rdoeconomy.Text = "Economy";
            this.rdoeconomy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblcustomerName);
            this.groupBox1.Controls.Add(this.lblDrivingExperience);
            this.groupBox1.Controls.Add(this.lblNumRental);
            this.groupBox1.Controls.Add(this.lblCusAge);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtRentalDays);
            this.groupBox1.Controls.Add(this.txtYearofExperience);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 296);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CustomerInfo";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("MingLiU-ExtB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(576, 101);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(280, 46);
            this.txtAge.TabIndex = 11;
            // 
            // txtRentalDays
            // 
            this.txtRentalDays.Font = new System.Drawing.Font("MingLiU-ExtB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentalDays.Location = new System.Drawing.Point(576, 165);
            this.txtRentalDays.Name = "txtRentalDays";
            this.txtRentalDays.Size = new System.Drawing.Size(280, 46);
            this.txtRentalDays.TabIndex = 10;
            // 
            // txtYearofExperience
            // 
            this.txtYearofExperience.Font = new System.Drawing.Font("MingLiU-ExtB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearofExperience.Location = new System.Drawing.Point(576, 222);
            this.txtYearofExperience.Name = "txtYearofExperience";
            this.txtYearofExperience.Size = new System.Drawing.Size(280, 46);
            this.txtYearofExperience.TabIndex = 9;
            // 
            // btnEXit
            // 
            this.btnEXit.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXit.Location = new System.Drawing.Point(541, 622);
            this.btnEXit.Name = "btnEXit";
            this.btnEXit.Size = new System.Drawing.Size(143, 53);
            this.btnEXit.TabIndex = 33;
            this.btnEXit.Text = "Exit";
            this.btnEXit.UseVisualStyleBackColor = true;
            this.btnEXit.Click += new System.EventHandler(this.btnEXit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.rdosuv);
            this.groupBox2.Controls.Add(this.rdoluxury);
            this.groupBox2.Controls.Add(this.rdoeconomy);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 129);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 804);
            this.Controls.Add(this.lstDetails);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEXit);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDetails;
        private System.Windows.Forms.Label lblcustomerName;
        private System.Windows.Forms.Label lblDrivingExperience;
        private System.Windows.Forms.Label lblNumRental;
        private System.Windows.Forms.Label lblCusAge;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdosuv;
        private System.Windows.Forms.RadioButton rdoluxury;
        private System.Windows.Forms.RadioButton rdoeconomy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtRentalDays;
        private System.Windows.Forms.TextBox txtYearofExperience;
        private System.Windows.Forms.Button btnEXit;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

