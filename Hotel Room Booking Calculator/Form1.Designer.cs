namespace Hotel_Room_Booking_Calculator
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
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblNumOfNight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.lblServiceTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtRoomType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(111, 43);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(313, 41);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Enter Guest Name:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(126, 113);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(298, 41);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "Enter Room Type:";
            // 
            // lblNumOfNight
            // 
            this.lblNumOfNight.AutoSize = true;
            this.lblNumOfNight.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfNight.Location = new System.Drawing.Point(18, 175);
            this.lblNumOfNight.Name = "lblNumOfNight";
            this.lblNumOfNight.Size = new System.Drawing.Size(406, 41);
            this.lblNumOfNight.TabIndex = 2;
            this.lblNumOfNight.Text = "Enter Number Of Nights:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Price Per Night:";
            // 
            // txtGuestName
            // 
            this.txtGuestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuestName.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(467, 42);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(284, 53);
            this.txtGuestName.TabIndex = 4;
            this.txtGuestName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceNight.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceNight.Location = new System.Drawing.Point(467, 241);
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.Size = new System.Drawing.Size(284, 53);
            this.txtPriceNight.TabIndex = 5;
            // 
            // txtNights
            // 
            this.txtNights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNights.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNights.Location = new System.Drawing.Point(467, 175);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(284, 53);
            this.txtNights.TabIndex = 6;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.AutoSize = true;
            this.BtnCalculate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.Location = new System.Drawing.Point(215, 331);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(306, 73);
            this.BtnCalculate.TabIndex = 8;
            this.BtnCalculate.Text = "Calculate Booking";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.AutoSize = true;
            this.lblServiceTax.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceTax.Location = new System.Drawing.Point(47, 433);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(377, 40);
            this.lblServiceTax.TabIndex = 9;
            this.lblServiceTax.Text = "Service Taxt(10%):";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(27, 499);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(397, 40);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "DiscountAmount(5%):";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(147, 558);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(277, 40);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // txtTax
            // 
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(430, 428);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(325, 53);
            this.txtTax.TabIndex = 12;
            // 
            // txtdiscount
            // 
            this.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(430, 494);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(325, 53);
            this.txtdiscount.TabIndex = 12;
            // 
            // txtamount
            // 
            this.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtamount.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(430, 553);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(325, 53);
            this.txtamount.TabIndex = 12;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(543, 331);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(186, 73);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.FormattingEnabled = true;
            this.txtRoomType.Items.AddRange(new object[] {
            "Vip ",
            "Normal ",
            "Suit "});
            this.txtRoomType.Location = new System.Drawing.Point(467, 113);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(288, 48);
            this.txtRoomType.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 662);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblServiceTax);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumOfNight);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblGuestName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblNumOfNight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label lblServiceTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ComboBox txtRoomType;
    }
}

