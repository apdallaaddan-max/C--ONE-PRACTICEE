namespace Statement
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
            this.txt2ndnum = new System.Windows.Forms.TextBox();
            this.txt1stnum = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lblTXT2 = new System.Windows.Forms.Label();
            this.lbl1txt = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt2ndnum
            // 
            this.txt2ndnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2ndnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2ndnum.Location = new System.Drawing.Point(457, 106);
            this.txt2ndnum.Name = "txt2ndnum";
            this.txt2ndnum.Size = new System.Drawing.Size(267, 48);
            this.txt2ndnum.TabIndex = 9;
            // 
            // txt1stnum
            // 
            this.txt1stnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1stnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1stnum.Location = new System.Drawing.Point(457, 41);
            this.txt1stnum.Name = "txt1stnum";
            this.txt1stnum.Size = new System.Drawing.Size(267, 48);
            this.txt1stnum.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(509, 359);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 51);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(166, 359);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(180, 51);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "ShowNum";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(166, 212);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(477, 108);
            this.lbloutput.TabIndex = 6;
            this.lbloutput.Click += new System.EventHandler(this.lbloutput_Click);
            // 
            // lblTXT2
            // 
            this.lblTXT2.AutoSize = true;
            this.lblTXT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTXT2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTXT2.Location = new System.Drawing.Point(77, 106);
            this.lblTXT2.Name = "lblTXT2";
            this.lblTXT2.Size = new System.Drawing.Size(306, 43);
            this.lblTXT2.TabIndex = 4;
            this.lblTXT2.Text = "ENTER 2ND NUM";
            // 
            // lbl1txt
            // 
            this.lbl1txt.AutoSize = true;
            this.lbl1txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1txt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1txt.Location = new System.Drawing.Point(89, 41);
            this.lbl1txt.Name = "lbl1txt";
            this.lbl1txt.Size = new System.Drawing.Size(294, 43);
            this.lbl1txt.TabIndex = 5;
            this.lbl1txt.Text = "ENTER 1ST NUM";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(377, 359);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 51);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txt2ndnum);
            this.Controls.Add(this.txt1stnum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblTXT2);
            this.Controls.Add(this.lbl1txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt2ndnum;
        private System.Windows.Forms.TextBox txt1stnum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lblTXT2;
        private System.Windows.Forms.Label lbl1txt;
        private System.Windows.Forms.Button btnClear;
    }
}

