namespace ncEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.Btn_ConvertNC = new System.Windows.Forms.Button();
            this.ck_ShuttleTable = new System.Windows.Forms.CheckBox();
            this.original_code = new System.Windows.Forms.RichTextBox();
            this.converted_code = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OpenFile.Location = new System.Drawing.Point(15, 12);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(85, 23);
            this.Btn_OpenFile.TabIndex = 0;
            this.Btn_OpenFile.Text = "Open File";
            this.Btn_OpenFile.UseVisualStyleBackColor = true;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // Btn_ConvertNC
            // 
            this.Btn_ConvertNC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConvertNC.Location = new System.Drawing.Point(433, 12);
            this.Btn_ConvertNC.Name = "Btn_ConvertNC";
            this.Btn_ConvertNC.Size = new System.Drawing.Size(96, 23);
            this.Btn_ConvertNC.TabIndex = 1;
            this.Btn_ConvertNC.Text = "Convert NC";
            this.Btn_ConvertNC.UseVisualStyleBackColor = true;
            this.Btn_ConvertNC.Click += new System.EventHandler(this.Btn_ConvertNC_Click);
            // 
            // ck_ShuttleTable
            // 
            this.ck_ShuttleTable.AutoSize = true;
            this.ck_ShuttleTable.Location = new System.Drawing.Point(15, 45);
            this.ck_ShuttleTable.Name = "ck_ShuttleTable";
            this.ck_ShuttleTable.Size = new System.Drawing.Size(92, 17);
            this.ck_ShuttleTable.TabIndex = 2;
            this.ck_ShuttleTable.Text = "Pallet Change";
            this.ck_ShuttleTable.UseVisualStyleBackColor = true;
            // 
            // original_code
            // 
            this.original_code.BackColor = System.Drawing.SystemColors.Desktop;
            this.original_code.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.original_code.ForeColor = System.Drawing.Color.White;
            this.original_code.Location = new System.Drawing.Point(11, 84);
            this.original_code.Name = "original_code";
            this.original_code.Size = new System.Drawing.Size(388, 415);
            this.original_code.TabIndex = 4;
            this.original_code.Text = "";
            // 
            // converted_code
            // 
            this.converted_code.BackColor = System.Drawing.SystemColors.Desktop;
            this.converted_code.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converted_code.ForeColor = System.Drawing.Color.White;
            this.converted_code.Location = new System.Drawing.Point(433, 84);
            this.converted_code.Name = "converted_code";
            this.converted_code.Size = new System.Drawing.Size(389, 415);
            this.converted_code.TabIndex = 5;
            this.converted_code.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original NC File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Converted NC File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.converted_code);
            this.Controls.Add(this.original_code);
            this.Controls.Add(this.ck_ShuttleTable);
            this.Controls.Add(this.Btn_ConvertNC);
            this.Controls.Add(this.Btn_OpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "V6 NC Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_OpenFile;
        private System.Windows.Forms.Button Btn_ConvertNC;
        private System.Windows.Forms.CheckBox ck_ShuttleTable;
        private System.Windows.Forms.RichTextBox original_code;
        private System.Windows.Forms.RichTextBox converted_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

