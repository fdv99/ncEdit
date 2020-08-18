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
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_ConvertNC = new System.Windows.Forms.Button();
            this.ck_ShuttleTable = new System.Windows.Forms.CheckBox();
            this.ck_GoHome = new System.Windows.Forms.CheckBox();
            this.original_code = new System.Windows.Forms.RichTextBox();
            this.converted_code = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenFile.Location = new System.Drawing.Point(34, 39);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(85, 23);
            this.btn_OpenFile.TabIndex = 0;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_ConvertNC
            // 
            this.btn_ConvertNC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConvertNC.Location = new System.Drawing.Point(153, 39);
            this.btn_ConvertNC.Name = "btn_ConvertNC";
            this.btn_ConvertNC.Size = new System.Drawing.Size(96, 23);
            this.btn_ConvertNC.TabIndex = 1;
            this.btn_ConvertNC.Text = "Convert NC";
            this.btn_ConvertNC.UseVisualStyleBackColor = true;
            // 
            // ck_ShuttleTable
            // 
            this.ck_ShuttleTable.AutoSize = true;
            this.ck_ShuttleTable.Location = new System.Drawing.Point(34, 87);
            this.ck_ShuttleTable.Name = "ck_ShuttleTable";
            this.ck_ShuttleTable.Size = new System.Drawing.Size(92, 17);
            this.ck_ShuttleTable.TabIndex = 2;
            this.ck_ShuttleTable.Text = "Pallet Change";
            this.ck_ShuttleTable.UseVisualStyleBackColor = true;
            // 
            // ck_GoHome
            // 
            this.ck_GoHome.AutoSize = true;
            this.ck_GoHome.Location = new System.Drawing.Point(34, 111);
            this.ck_GoHome.Name = "ck_GoHome";
            this.ck_GoHome.Size = new System.Drawing.Size(85, 17);
            this.ck_GoHome.TabIndex = 3;
            this.ck_GoHome.Text = "Rapid Home";
            this.ck_GoHome.UseVisualStyleBackColor = true;
            // 
            // original_code
            // 
            this.original_code.Location = new System.Drawing.Point(12, 159);
            this.original_code.Name = "original_code";
            this.original_code.Size = new System.Drawing.Size(388, 340);
            this.original_code.TabIndex = 4;
            this.original_code.Text = "";
            // 
            // converted_code
            // 
            this.converted_code.Location = new System.Drawing.Point(433, 159);
            this.converted_code.Name = "converted_code";
            this.converted_code.Size = new System.Drawing.Size(389, 340);
            this.converted_code.TabIndex = 5;
            this.converted_code.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original NC File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Converted NC File";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(295, 39);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save New NC";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.converted_code);
            this.Controls.Add(this.original_code);
            this.Controls.Add(this.ck_GoHome);
            this.Controls.Add(this.ck_ShuttleTable);
            this.Controls.Add(this.btn_ConvertNC);
            this.Controls.Add(this.btn_OpenFile);
            this.Name = "Form1";
            this.Text = "V6 NC Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btn_ConvertNC;
        private System.Windows.Forms.CheckBox ck_ShuttleTable;
        private System.Windows.Forms.CheckBox ck_GoHome;
        private System.Windows.Forms.RichTextBox original_code;
        private System.Windows.Forms.RichTextBox converted_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save;
    }
}

