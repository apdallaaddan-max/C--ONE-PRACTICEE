namespace AssigmentFiles
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnOpeningFile = new System.Windows.Forms.Button();
            this.btnDeletingSelectedFile = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnDeletingFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 26);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(263, 144);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Creating Files";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpeningFile
            // 
            this.btnOpeningFile.Location = new System.Drawing.Point(343, 36);
            this.btnOpeningFile.Name = "btnOpeningFile";
            this.btnOpeningFile.Size = new System.Drawing.Size(263, 144);
            this.btnOpeningFile.TabIndex = 1;
            this.btnOpeningFile.Text = "Opening Files";
            this.btnOpeningFile.UseVisualStyleBackColor = true;
            this.btnOpeningFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeletingSelectedFile
            // 
            this.btnDeletingSelectedFile.Location = new System.Drawing.Point(12, 206);
            this.btnDeletingSelectedFile.Name = "btnDeletingSelectedFile";
            this.btnDeletingSelectedFile.Size = new System.Drawing.Size(263, 144);
            this.btnDeletingSelectedFile.TabIndex = 2;
            this.btnDeletingSelectedFile.Text = "Deleting Selected File";
            this.btnDeletingSelectedFile.UseVisualStyleBackColor = true;
            this.btnDeletingSelectedFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 20;
            this.lstResult.Location = new System.Drawing.Point(644, 26);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(417, 524);
            this.lstResult.TabIndex = 3;
            // 
            // btnDeletingFile
            // 
            this.btnDeletingFile.Location = new System.Drawing.Point(343, 206);
            this.btnDeletingFile.Name = "btnDeletingFile";
            this.btnDeletingFile.Size = new System.Drawing.Size(263, 144);
            this.btnDeletingFile.TabIndex = 4;
            this.btnDeletingFile.Text = "Deleting File";
            this.btnDeletingFile.UseVisualStyleBackColor = true;
            this.btnDeletingFile.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 764);
            this.Controls.Add(this.btnDeletingFile);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnDeletingSelectedFile);
            this.Controls.Add(this.btnOpeningFile);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnOpeningFile;
        private System.Windows.Forms.Button btnDeletingSelectedFile;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnDeletingFile;
    }
}

