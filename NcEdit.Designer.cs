namespace ncEdit
{
    partial class NcEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NcEdit));
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.Btn_ConvertNC = new System.Windows.Forms.Button();
            this.original_code = new System.Windows.Forms.RichTextBox();
            this.converted_code = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tb_fileSize = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxYOffset = new System.Windows.Forms.TextBox();
            this.txtBoxXOffset = new System.Windows.Forms.TextBox();
            this.chkOffset = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OpenFile.Location = new System.Drawing.Point(12, 12);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(85, 23);
            this.Btn_OpenFile.TabIndex = 0;
            this.Btn_OpenFile.Text = "Open File";
            this.Btn_OpenFile.UseVisualStyleBackColor = true;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // Btn_ConvertNC
            // 
            this.Btn_ConvertNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConvertNC.Location = new System.Drawing.Point(106, 12);
            this.Btn_ConvertNC.Name = "Btn_ConvertNC";
            this.Btn_ConvertNC.Size = new System.Drawing.Size(114, 23);
            this.Btn_ConvertNC.TabIndex = 1;
            this.Btn_ConvertNC.Text = "Convert to F1";
            this.Btn_ConvertNC.UseVisualStyleBackColor = true;
            this.Btn_ConvertNC.Click += new System.EventHandler(this.Btn_ConvertNC_Click);
            // 
            // original_code
            // 
            this.original_code.BackColor = System.Drawing.SystemColors.Desktop;
            this.original_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.original_code.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.original_code.ForeColor = System.Drawing.Color.White;
            this.original_code.Location = new System.Drawing.Point(0, 0);
            this.original_code.Name = "original_code";
            this.original_code.Size = new System.Drawing.Size(295, 576);
            this.original_code.TabIndex = 4;
            this.original_code.Text = "";
            // 
            // converted_code
            // 
            this.converted_code.BackColor = System.Drawing.SystemColors.Desktop;
            this.converted_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.converted_code.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converted_code.ForeColor = System.Drawing.Color.White;
            this.converted_code.Location = new System.Drawing.Point(0, 0);
            this.converted_code.Name = "converted_code";
            this.converted_code.Size = new System.Drawing.Size(293, 576);
            this.converted_code.TabIndex = 5;
            this.converted_code.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original NC File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Converted NC File";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 97);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.original_code);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.converted_code);
            this.splitContainer1.Size = new System.Drawing.Size(592, 576);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer2.Location = new System.Drawing.Point(0, 59);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tb_fileSize);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(592, 38);
            this.splitContainer2.SplitterDistance = 296;
            this.splitContainer2.TabIndex = 9;
            // 
            // tb_fileSize
            // 
            this.tb_fileSize.Location = new System.Drawing.Point(180, 7);
            this.tb_fileSize.Name = "tb_fileSize";
            this.tb_fileSize.Size = new System.Drawing.Size(100, 20);
            this.tb_fileSize.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBoxYOffset);
            this.panel1.Controls.Add(this.txtBoxXOffset);
            this.panel1.Controls.Add(this.chkOffset);
            this.panel1.Controls.Add(this.Btn_OpenFile);
            this.panel1.Controls.Add(this.Btn_ConvertNC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(606, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 60);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y Offset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "X Offset";
            // 
            // txtBoxYOffset
            // 
            this.txtBoxYOffset.Location = new System.Drawing.Point(480, 33);
            this.txtBoxYOffset.Name = "txtBoxYOffset";
            this.txtBoxYOffset.Size = new System.Drawing.Size(100, 20);
            this.txtBoxYOffset.TabIndex = 4;
            this.txtBoxYOffset.Text = "1.0";
            // 
            // txtBoxXOffset
            // 
            this.txtBoxXOffset.Location = new System.Drawing.Point(480, 12);
            this.txtBoxXOffset.Name = "txtBoxXOffset";
            this.txtBoxXOffset.Size = new System.Drawing.Size(100, 20);
            this.txtBoxXOffset.TabIndex = 3;
            this.txtBoxXOffset.Text = "0.0";
            // 
            // chkOffset
            // 
            this.chkOffset.AutoSize = true;
            this.chkOffset.Location = new System.Drawing.Point(259, 12);
            this.chkOffset.Name = "chkOffset";
            this.chkOffset.Size = new System.Drawing.Size(92, 17);
            this.chkOffset.TabIndex = 2;
            this.chkOffset.Text = "Include Offset";
            this.chkOffset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(608, 712);
            this.Name = "Form1";
            this.Text = "   V6 NC Conversion";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_OpenFile;
        private System.Windows.Forms.Button Btn_ConvertNC;
        private System.Windows.Forms.RichTextBox original_code;
        private System.Windows.Forms.RichTextBox converted_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_fileSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxYOffset;
        private System.Windows.Forms.TextBox txtBoxXOffset;
        private System.Windows.Forms.CheckBox chkOffset;
    }
}
