namespace TheRangeChecker
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
            this.GrouBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.lblDecision = new System.Windows.Forms.Label();
            this.lblDecisionOutPut = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.GrouBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrouBox
            // 
            this.GrouBox.Controls.Add(this.lblDecisionOutPut);
            this.GrouBox.Controls.Add(this.btnExit);
            this.GrouBox.Controls.Add(this.btnClear);
            this.GrouBox.Controls.Add(this.button1);
            this.GrouBox.Controls.Add(this.lblDecision);
            this.GrouBox.Controls.Add(this.txtRange);
            this.GrouBox.Controls.Add(this.label1);
            this.GrouBox.Location = new System.Drawing.Point(53, 39);
            this.GrouBox.Name = "GrouBox";
            this.GrouBox.Size = new System.Drawing.Size(626, 671);
            this.GrouBox.TabIndex = 0;
            this.GrouBox.TabStop = false;
            this.GrouBox.Text = "Range Checker Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter An Integer In The Range Through 1 To 10";
            // 
            // txtRange
            // 
            this.txtRange.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRange.Location = new System.Drawing.Point(104, 97);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(318, 58);
            this.txtRange.TabIndex = 1;
            // 
            // lblDecision
            // 
            this.lblDecision.AutoSize = true;
            this.lblDecision.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecision.Location = new System.Drawing.Point(116, 193);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(246, 41);
            this.lblDecision.TabIndex = 2;
            this.lblDecision.Text = "Range Dicision";
            // 
            // lblDecisionOutPut
            // 
            this.lblDecisionOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDecisionOutPut.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecisionOutPut.Location = new System.Drawing.Point(104, 261);
            this.lblDecisionOutPut.Name = "lblDecisionOutPut";
            this.lblDecisionOutPut.Size = new System.Drawing.Size(391, 142);
            this.lblDecisionOutPut.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 127);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Check Qualification";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(300, 457);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 51);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(300, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 706);
            this.Controls.Add(this.GrouBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrouBox.ResumeLayout(false);
            this.GrouBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrouBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDecisionOutPut;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.TextBox txtRange;
    }
}

