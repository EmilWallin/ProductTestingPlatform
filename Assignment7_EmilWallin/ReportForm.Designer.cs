namespace Assignment7_EmilWallin
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpBoxTestInfo = new System.Windows.Forms.GroupBox();
            this.labelAdditionalComments = new System.Windows.Forms.Label();
            this.textBoxAdditionalComments = new System.Windows.Forms.TextBox();
            this.labelTestResult = new System.Windows.Forms.Label();
            this.comboBoxResult = new System.Windows.Forms.ComboBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxTestNotes = new System.Windows.Forms.TextBox();
            this.grpBoxProductInfo = new System.Windows.Forms.GroupBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.btnOpenInquiry = new System.Windows.Forms.Button();
            this.grpBoxTestInfo.SuspendLayout();
            this.grpBoxProductInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(327, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Enabled = false;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(145, 459);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 29);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpBoxTestInfo
            // 
            this.grpBoxTestInfo.Controls.Add(this.labelAdditionalComments);
            this.grpBoxTestInfo.Controls.Add(this.textBoxAdditionalComments);
            this.grpBoxTestInfo.Controls.Add(this.labelTestResult);
            this.grpBoxTestInfo.Controls.Add(this.comboBoxResult);
            this.grpBoxTestInfo.Controls.Add(this.labelNotes);
            this.grpBoxTestInfo.Controls.Add(this.textBoxTestNotes);
            this.grpBoxTestInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpBoxTestInfo.Location = new System.Drawing.Point(12, 97);
            this.grpBoxTestInfo.Name = "grpBoxTestInfo";
            this.grpBoxTestInfo.Size = new System.Drawing.Size(548, 356);
            this.grpBoxTestInfo.TabIndex = 8;
            this.grpBoxTestInfo.TabStop = false;
            this.grpBoxTestInfo.Text = "Test Details";
            // 
            // labelAdditionalComments
            // 
            this.labelAdditionalComments.AutoSize = true;
            this.labelAdditionalComments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAdditionalComments.Location = new System.Drawing.Point(6, 271);
            this.labelAdditionalComments.Name = "labelAdditionalComments";
            this.labelAdditionalComments.Size = new System.Drawing.Size(108, 13);
            this.labelAdditionalComments.TabIndex = 5;
            this.labelAdditionalComments.Text = "Additional Comments:";
            // 
            // textBoxAdditionalComments
            // 
            this.textBoxAdditionalComments.Location = new System.Drawing.Point(6, 287);
            this.textBoxAdditionalComments.Multiline = true;
            this.textBoxAdditionalComments.Name = "textBoxAdditionalComments";
            this.textBoxAdditionalComments.Size = new System.Drawing.Size(247, 56);
            this.textBoxAdditionalComments.TabIndex = 4;
            this.textBoxAdditionalComments.TextChanged += new System.EventHandler(this.textBoxAdditionalComments_TextChanged);
            // 
            // labelTestResult
            // 
            this.labelTestResult.AutoSize = true;
            this.labelTestResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTestResult.Location = new System.Drawing.Point(6, 31);
            this.labelTestResult.Name = "labelTestResult";
            this.labelTestResult.Size = new System.Drawing.Size(64, 13);
            this.labelTestResult.TabIndex = 3;
            this.labelTestResult.Text = "Test Result:";
            this.labelTestResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxResult
            // 
            this.comboBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxResult.FormattingEnabled = true;
            this.comboBoxResult.Location = new System.Drawing.Point(6, 47);
            this.comboBoxResult.Name = "comboBoxResult";
            this.comboBoxResult.Size = new System.Drawing.Size(207, 24);
            this.comboBoxResult.TabIndex = 2;
            this.comboBoxResult.SelectedIndexChanged += new System.EventHandler(this.comboBoxResult_SelectedIndexChanged);
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNotes.Location = new System.Drawing.Point(6, 84);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(62, 13);
            this.labelNotes.TabIndex = 1;
            this.labelNotes.Text = "Test Notes:";
            // 
            // textBoxTestNotes
            // 
            this.textBoxTestNotes.Location = new System.Drawing.Point(6, 100);
            this.textBoxTestNotes.Multiline = true;
            this.textBoxTestNotes.Name = "textBoxTestNotes";
            this.textBoxTestNotes.Size = new System.Drawing.Size(536, 168);
            this.textBoxTestNotes.TabIndex = 0;
            this.textBoxTestNotes.TextChanged += new System.EventHandler(this.textBoxTestNotes_TextChanged);
            // 
            // grpBoxProductInfo
            // 
            this.grpBoxProductInfo.Controls.Add(this.labelProductName);
            this.grpBoxProductInfo.Controls.Add(this.textBoxProductName);
            this.grpBoxProductInfo.Controls.Add(this.labelProductCode);
            this.grpBoxProductInfo.Controls.Add(this.textBoxProductCode);
            this.grpBoxProductInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpBoxProductInfo.Location = new System.Drawing.Point(12, 12);
            this.grpBoxProductInfo.Name = "grpBoxProductInfo";
            this.grpBoxProductInfo.Size = new System.Drawing.Size(441, 79);
            this.grpBoxProductInfo.TabIndex = 7;
            this.grpBoxProductInfo.TabStop = false;
            this.grpBoxProductInfo.Text = "Product Info";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelProductName.Location = new System.Drawing.Point(147, 30);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(78, 13);
            this.labelProductName.TabIndex = 3;
            this.labelProductName.Text = "Product Name:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(150, 46);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(285, 20);
            this.textBoxProductName.TabIndex = 0;
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelProductCode.Location = new System.Drawing.Point(6, 30);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(75, 13);
            this.labelProductCode.TabIndex = 2;
            this.labelProductCode.Text = "Product Code;";
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Location = new System.Drawing.Point(6, 46);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.ReadOnly = true;
            this.textBoxProductCode.Size = new System.Drawing.Size(138, 20);
            this.textBoxProductCode.TabIndex = 1;
            // 
            // btnOpenInquiry
            // 
            this.btnOpenInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenInquiry.Location = new System.Drawing.Point(459, 26);
            this.btnOpenInquiry.Name = "btnOpenInquiry";
            this.btnOpenInquiry.Size = new System.Drawing.Size(95, 52);
            this.btnOpenInquiry.TabIndex = 11;
            this.btnOpenInquiry.Text = "Show Inquiry";
            this.btnOpenInquiry.UseVisualStyleBackColor = true;
            this.btnOpenInquiry.Click += new System.EventHandler(this.btnOpenInquiry_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 497);
            this.Controls.Add(this.btnOpenInquiry);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpBoxTestInfo);
            this.Controls.Add(this.grpBoxProductInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Report Form";
            this.grpBoxTestInfo.ResumeLayout(false);
            this.grpBoxTestInfo.PerformLayout();
            this.grpBoxProductInfo.ResumeLayout(false);
            this.grpBoxProductInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpBoxTestInfo;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxTestNotes;
        private System.Windows.Forms.GroupBox grpBoxProductInfo;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelProductCode;
        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.Label labelTestResult;
        private System.Windows.Forms.ComboBox comboBoxResult;
        private System.Windows.Forms.Button btnOpenInquiry;
        private System.Windows.Forms.Label labelAdditionalComments;
        private System.Windows.Forms.TextBox textBoxAdditionalComments;
    }
}