namespace EmplooyeeAttendence
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAttendence = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoAbsent = new System.Windows.Forms.RadioButton();
            this.rdoPresent = new System.Windows.Forms.RadioButton();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.OpenAs = new System.Windows.Forms.OpenFileDialog();
            this.SaveAs = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmplooyeeId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmplooyeeName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "DepatmentName:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(329, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(323, 53);
            this.txtId.TabIndex = 3;
            // 
            // txtDep
            // 
            this.txtDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDep.Location = new System.Drawing.Point(329, 163);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(323, 53);
            this.txtDep.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(329, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(323, 53);
            this.txtName.TabIndex = 5;
            // 
            // lblAttendence
            // 
            this.lblAttendence.AutoSize = true;
            this.lblAttendence.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendence.Location = new System.Drawing.Point(61, 333);
            this.lblAttendence.Name = "lblAttendence";
            this.lblAttendence.Size = new System.Drawing.Size(140, 33);
            this.lblAttendence.TabIndex = 6;
            this.lblAttendence.Text = "Attendence";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoAbsent);
            this.panel1.Controls.Add(this.rdoPresent);
            this.panel1.Location = new System.Drawing.Point(219, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 133);
            this.panel1.TabIndex = 7;
            // 
            // rdoAbsent
            // 
            this.rdoAbsent.AutoSize = true;
            this.rdoAbsent.Location = new System.Drawing.Point(190, 20);
            this.rdoAbsent.Name = "rdoAbsent";
            this.rdoAbsent.Size = new System.Drawing.Size(83, 24);
            this.rdoAbsent.TabIndex = 1;
            this.rdoAbsent.TabStop = true;
            this.rdoAbsent.Text = "absent";
            this.rdoAbsent.UseVisualStyleBackColor = true;
            // 
            // rdoPresent
            // 
            this.rdoPresent.AutoSize = true;
            this.rdoPresent.Location = new System.Drawing.Point(32, 20);
            this.rdoPresent.Name = "rdoPresent";
            this.rdoPresent.Size = new System.Drawing.Size(89, 24);
            this.rdoPresent.TabIndex = 0;
            this.rdoPresent.TabStop = true;
            this.rdoPresent.Text = "Present";
            this.rdoPresent.UseVisualStyleBackColor = true;
            this.rdoPresent.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.AutoSize = true;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(2, 626);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(199, 50);
            this.btnRecord.TabIndex = 8;
            this.btnRecord.Text = "Attendence";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(219, 626);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(147, 50);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(389, 626);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(301, 50);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "RemoveSelected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCount
            // 
            this.btnCount.AutoSize = true;
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(696, 626);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(147, 50);
            this.btnCount.TabIndex = 11;
            this.btnCount.Text = "Record";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(849, 626);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 50);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1031, 626);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 50);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 20;
            this.lst1.Location = new System.Drawing.Point(871, 101);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(437, 404);
            this.lst1.TabIndex = 14;
            // 
            // OpenAs
            // 
            this.OpenAs.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 803);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAttendence);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAttendence;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoAbsent;
        private System.Windows.Forms.RadioButton rdoPresent;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.OpenFileDialog OpenAs;
        private System.Windows.Forms.SaveFileDialog SaveAs;
    }
}

