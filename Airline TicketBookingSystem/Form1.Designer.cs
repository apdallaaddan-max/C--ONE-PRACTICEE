namespace Airline_TicketBookingSystem
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
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblNumofTicket = new System.Windows.Forms.Label();
            this.lblPassengerAge = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNormalClass = new System.Windows.Forms.RadioButton();
            this.rdoBusinessClass = new System.Windows.Forms.RadioButton();
            this.rdo1stClass = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkInsurance = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerName.Location = new System.Drawing.Point(55, 44);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(305, 40);
            this.lblPassengerName.TabIndex = 0;
            this.lblPassengerName.Text = "Passenger Name:";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(-1, 216);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(361, 40);
            this.lblKg.TabIndex = 1;
            this.lblKg.Text = "Baggage Weight(Kg):";
            // 
            // lblNumofTicket
            // 
            this.lblNumofTicket.AutoSize = true;
            this.lblNumofTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumofTicket.Location = new System.Drawing.Point(51, 165);
            this.lblNumofTicket.Name = "lblNumofTicket";
            this.lblNumofTicket.Size = new System.Drawing.Size(309, 40);
            this.lblNumofTicket.TabIndex = 2;
            this.lblNumofTicket.Text = "Number Of Ticket:";
            // 
            // lblPassengerAge
            // 
            this.lblPassengerAge.AutoSize = true;
            this.lblPassengerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerAge.Location = new System.Drawing.Point(87, 104);
            this.lblPassengerAge.Name = "lblPassengerAge";
            this.lblPassengerAge.Size = new System.Drawing.Size(273, 40);
            this.lblPassengerAge.TabIndex = 3;
            this.lblPassengerAge.Text = "Passenger Age:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(366, 36);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(360, 48);
            this.txtname.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(366, 96);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(360, 48);
            this.txtAge.TabIndex = 5;
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(366, 157);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(360, 48);
            this.txtTicket.TabIndex = 6;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(366, 216);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(360, 48);
            this.txtWeight.TabIndex = 7;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox.Controls.Add(this.txtTicket);
            this.groupBox.Controls.Add(this.txtWeight);
            this.groupBox.Controls.Add(this.lblPassengerName);
            this.groupBox.Controls.Add(this.lblKg);
            this.groupBox.Controls.Add(this.txtAge);
            this.groupBox.Controls.Add(this.lblNumofTicket);
            this.groupBox.Controls.Add(this.txtname);
            this.groupBox.Controls.Add(this.lblPassengerAge);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(764, 301);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Personal Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNormalClass);
            this.groupBox1.Controls.Add(this.rdoBusinessClass);
            this.groupBox1.Controls.Add(this.rdo1stClass);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 140);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Travel Class";
            // 
            // rdoNormalClass
            // 
            this.rdoNormalClass.AutoSize = true;
            this.rdoNormalClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormalClass.Location = new System.Drawing.Point(202, 72);
            this.rdoNormalClass.Name = "rdoNormalClass";
            this.rdoNormalClass.Size = new System.Drawing.Size(208, 36);
            this.rdoNormalClass.TabIndex = 2;
            this.rdoNormalClass.TabStop = true;
            this.rdoNormalClass.Text = "Normal Class";
            this.rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // rdoBusinessClass
            // 
            this.rdoBusinessClass.AutoSize = true;
            this.rdoBusinessClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBusinessClass.Location = new System.Drawing.Point(435, 72);
            this.rdoBusinessClass.Name = "rdoBusinessClass";
            this.rdoBusinessClass.Size = new System.Drawing.Size(233, 36);
            this.rdoBusinessClass.TabIndex = 1;
            this.rdoBusinessClass.TabStop = true;
            this.rdoBusinessClass.Text = "Business Class";
            this.rdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // rdo1stClass
            // 
            this.rdo1stClass.AutoSize = true;
            this.rdo1stClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo1stClass.Location = new System.Drawing.Point(6, 72);
            this.rdo1stClass.Name = "rdo1stClass";
            this.rdo1stClass.Size = new System.Drawing.Size(172, 36);
            this.rdo1stClass.TabIndex = 0;
            this.rdo1stClass.TabStop = true;
            this.rdo1stClass.Text = "First Class";
            this.rdo1stClass.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkInsurance);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 168);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AdditionalOption";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInsurance.Location = new System.Drawing.Point(6, 72);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(591, 36);
            this.chkInsurance.TabIndex = 0;
            this.chkInsurance.TabStop = true;
            this.chkInsurance.Text = "Additional Travel Insurance (25$ Per Ticket)";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(115, 639);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 42);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(283, 639);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 42);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(425, 639);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 42);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(856, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 624);
            this.listBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 818);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblNumofTicket;
        private System.Windows.Forms.Label lblPassengerAge;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNormalClass;
        private System.Windows.Forms.RadioButton rdoBusinessClass;
        private System.Windows.Forms.RadioButton rdo1stClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton chkInsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

