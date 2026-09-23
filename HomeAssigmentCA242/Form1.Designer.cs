namespace HomeAssigmentCA242
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
            this.LblDayOfTheWeek = new System.Windows.Forms.Label();
            this.LblNameOfTheMonth = new System.Windows.Forms.Label();
            this.lblNumericofthemonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtdayoftheweek = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.btnshowdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDayOfTheWeek
            // 
            this.LblDayOfTheWeek.AutoSize = true;
            this.LblDayOfTheWeek.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDayOfTheWeek.Location = new System.Drawing.Point(191, 70);
            this.LblDayOfTheWeek.Name = "LblDayOfTheWeek";
            this.LblDayOfTheWeek.Size = new System.Drawing.Size(382, 41);
            this.LblDayOfTheWeek.TabIndex = 0;
            this.LblDayOfTheWeek.Text = "Enter Day Of The Week";
            // 
            // LblNameOfTheMonth
            // 
            this.LblNameOfTheMonth.AutoSize = true;
            this.LblNameOfTheMonth.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameOfTheMonth.Location = new System.Drawing.Point(143, 129);
            this.LblNameOfTheMonth.Name = "LblNameOfTheMonth";
            this.LblNameOfTheMonth.Size = new System.Drawing.Size(430, 41);
            this.LblNameOfTheMonth.TabIndex = 1;
            this.LblNameOfTheMonth.Text = "Enter Name Of The Month";
            // 
            // lblNumericofthemonth
            // 
            this.lblNumericofthemonth.AutoSize = true;
            this.lblNumericofthemonth.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumericofthemonth.Location = new System.Drawing.Point(34, 188);
            this.lblNumericofthemonth.Name = "lblNumericofthemonth";
            this.lblNumericofthemonth.Size = new System.Drawing.Size(539, 41);
            this.lblNumericofthemonth.TabIndex = 2;
            this.lblNumericofthemonth.Text = "Enter The Numeric Of The Month";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(359, 241);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(214, 41);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Enter A Year";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(150, 400);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(731, 70);
            this.lbloutput.TabIndex = 4;
            this.lbloutput.Click += new System.EventHandler(this.lbloutput_Click);
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayoftheweek.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayoftheweek.Location = new System.Drawing.Point(596, 70);
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(285, 38);
            this.txtdayoftheweek.TabIndex = 5;
            // 
            // txtyear
            // 
            this.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(596, 256);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(285, 38);
            this.txtyear.TabIndex = 7;
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayofthemonth.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayofthemonth.Location = new System.Drawing.Point(596, 188);
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(285, 38);
            this.txtdayofthemonth.TabIndex = 8;
            // 
            // txtmonth
            // 
            this.txtmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmonth.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.Location = new System.Drawing.Point(596, 129);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(285, 38);
            this.txtmonth.TabIndex = 9;
            // 
            // btnshowdate
            // 
            this.btnshowdate.AutoSize = true;
            this.btnshowdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowdate.Location = new System.Drawing.Point(275, 530);
            this.btnshowdate.Name = "btnshowdate";
            this.btnshowdate.Size = new System.Drawing.Size(215, 99);
            this.btnshowdate.TabIndex = 10;
            this.btnshowdate.Text = "Show Date";
            this.btnshowdate.UseVisualStyleBackColor = true;
            this.btnshowdate.Click += new System.EventHandler(this.btnshowdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.AutoSize = true;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(515, 530);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(171, 99);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(710, 530);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(171, 99);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 656);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowdate);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayoftheweek);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblNumericofthemonth);
            this.Controls.Add(this.LblNameOfTheMonth);
            this.Controls.Add(this.LblDayOfTheWeek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDayOfTheWeek;
        private System.Windows.Forms.Label LblNameOfTheMonth;
        private System.Windows.Forms.Label lblNumericofthemonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtdayoftheweek;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.Button btnshowdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}

