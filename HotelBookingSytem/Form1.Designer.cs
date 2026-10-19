namespace HotelBookingSytem
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
            this.grpPerSonalInfo = new System.Windows.Forms.GroupBox();
            this.txtNumofGuest = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNumOfGuest = new System.Windows.Forms.Label();
            this.lblNumOfNight = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.rdohigh = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.grpAdditionalOptions = new System.Windows.Forms.GroupBox();
            this.chkAdditional = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstBooking = new System.Windows.Forms.ListBox();
            this.grpPerSonalInfo.SuspendLayout();
            this.grpRoomType.SuspendLayout();
            this.grpAdditionalOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPerSonalInfo
            // 
            this.grpPerSonalInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpPerSonalInfo.Controls.Add(this.txtNumofGuest);
            this.grpPerSonalInfo.Controls.Add(this.txtNights);
            this.grpPerSonalInfo.Controls.Add(this.txtAge);
            this.grpPerSonalInfo.Controls.Add(this.txtName);
            this.grpPerSonalInfo.Controls.Add(this.lblNumOfGuest);
            this.grpPerSonalInfo.Controls.Add(this.lblNumOfNight);
            this.grpPerSonalInfo.Controls.Add(this.lblAge);
            this.grpPerSonalInfo.Controls.Add(this.lblGuestName);
            this.grpPerSonalInfo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPerSonalInfo.Location = new System.Drawing.Point(12, 12);
            this.grpPerSonalInfo.Name = "grpPerSonalInfo";
            this.grpPerSonalInfo.Size = new System.Drawing.Size(570, 318);
            this.grpPerSonalInfo.TabIndex = 0;
            this.grpPerSonalInfo.TabStop = false;
            this.grpPerSonalInfo.Text = "Personal Information";
            // 
            // txtNumofGuest
            // 
            this.txtNumofGuest.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumofGuest.Location = new System.Drawing.Point(292, 243);
            this.txtNumofGuest.Name = "txtNumofGuest";
            this.txtNumofGuest.Size = new System.Drawing.Size(264, 44);
            this.txtNumofGuest.TabIndex = 7;
            // 
            // txtNights
            // 
            this.txtNights.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNights.Location = new System.Drawing.Point(292, 181);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(264, 44);
            this.txtNights.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(292, 122);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(264, 44);
            this.txtAge.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(292, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 44);
            this.txtName.TabIndex = 4;
            // 
            // lblNumOfGuest
            // 
            this.lblNumOfGuest.AutoSize = true;
            this.lblNumOfGuest.Location = new System.Drawing.Point(22, 241);
            this.lblNumOfGuest.Name = "lblNumOfGuest";
            this.lblNumOfGuest.Size = new System.Drawing.Size(264, 46);
            this.lblNumOfGuest.TabIndex = 3;
            this.lblNumOfGuest.Text = "Num Of Guest:";
            // 
            // lblNumOfNight
            // 
            this.lblNumOfNight.AutoSize = true;
            this.lblNumOfNight.Location = new System.Drawing.Point(7, 178);
            this.lblNumOfNight.Name = "lblNumOfNight";
            this.lblNumOfNight.Size = new System.Drawing.Size(279, 46);
            this.lblNumOfNight.TabIndex = 2;
            this.lblNumOfNight.Text = "Num Of Nights:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(89, 122);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(197, 46);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Guest Age:";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(58, 67);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(228, 46);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Guest Name:";
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.rdohigh);
            this.grpRoomType.Controls.Add(this.rdoNormal);
            this.grpRoomType.Controls.Add(this.rdoStandard);
            this.grpRoomType.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRoomType.Location = new System.Drawing.Point(12, 357);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Size = new System.Drawing.Size(570, 127);
            this.grpRoomType.TabIndex = 1;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Room Type";
            // 
            // rdohigh
            // 
            this.rdohigh.AutoSize = true;
            this.rdohigh.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdohigh.Location = new System.Drawing.Point(419, 58);
            this.rdohigh.Name = "rdohigh";
            this.rdohigh.Size = new System.Drawing.Size(95, 40);
            this.rdohigh.TabIndex = 2;
            this.rdohigh.TabStop = true;
            this.rdohigh.Text = "High";
            this.rdohigh.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormal.Location = new System.Drawing.Point(243, 58);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(130, 40);
            this.rdoNormal.TabIndex = 1;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStandard.Location = new System.Drawing.Point(44, 58);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(152, 40);
            this.rdoStandard.TabIndex = 0;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "Standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // grpAdditionalOptions
            // 
            this.grpAdditionalOptions.Controls.Add(this.chkAdditional);
            this.grpAdditionalOptions.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdditionalOptions.Location = new System.Drawing.Point(12, 473);
            this.grpAdditionalOptions.Name = "grpAdditionalOptions";
            this.grpAdditionalOptions.Size = new System.Drawing.Size(570, 147);
            this.grpAdditionalOptions.TabIndex = 2;
            this.grpAdditionalOptions.TabStop = false;
            this.grpAdditionalOptions.Text = "Additional Option";
            // 
            // chkAdditional
            // 
            this.chkAdditional.AutoSize = true;
            this.chkAdditional.Location = new System.Drawing.Point(30, 62);
            this.chkAdditional.Name = "chkAdditional";
            this.chkAdditional.Size = new System.Drawing.Size(520, 40);
            this.chkAdditional.TabIndex = 0;
            this.chkAdditional.Text = "BreakFast($10 Per Guest Per Nights)";
            this.chkAdditional.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(109, 652);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 46);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(311, 652);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 46);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(514, 652);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 46);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstBooking
            // 
            this.lstBooking.FormattingEnabled = true;
            this.lstBooking.ItemHeight = 20;
            this.lstBooking.Location = new System.Drawing.Point(588, 12);
            this.lstBooking.Name = "lstBooking";
            this.lstBooking.Size = new System.Drawing.Size(528, 544);
            this.lstBooking.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 789);
            this.Controls.Add(this.lstBooking);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpAdditionalOptions);
            this.Controls.Add(this.grpRoomType);
            this.Controls.Add(this.grpPerSonalInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPerSonalInfo.ResumeLayout(false);
            this.grpPerSonalInfo.PerformLayout();
            this.grpRoomType.ResumeLayout(false);
            this.grpRoomType.PerformLayout();
            this.grpAdditionalOptions.ResumeLayout(false);
            this.grpAdditionalOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPerSonalInfo;
        private System.Windows.Forms.Label lblNumOfGuest;
        private System.Windows.Forms.Label lblNumOfNight;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumofGuest;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.GroupBox grpAdditionalOptions;
        private System.Windows.Forms.RadioButton rdohigh;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.CheckBox chkAdditional;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstBooking;
    }
}

