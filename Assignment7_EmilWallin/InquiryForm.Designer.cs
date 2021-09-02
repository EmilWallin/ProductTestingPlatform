namespace Assignment7_EmilWallin
{
    partial class InquiryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InquiryForm));
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.grpBoxProductInfo = new System.Windows.Forms.GroupBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.grpBoxTestInfo = new System.Windows.Forms.GroupBox();
            this.checkBoxNewStandard = new System.Windows.Forms.CheckBox();
            this.textBoxTestDescription = new System.Windows.Forms.TextBox();
            this.labelTestDescription = new System.Windows.Forms.Label();
            this.labelTestName = new System.Windows.Forms.Label();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.labelTestCode = new System.Windows.Forms.Label();
            this.comboBoxTestCode = new System.Windows.Forms.ComboBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxInquiryNotes = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelNumbersOnly = new System.Windows.Forms.Label();
            this.grpBoxProductInfo.SuspendLayout();
            this.grpBoxTestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(150, 46);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(285, 20);
            this.textBoxProductName.TabIndex = 1;
            this.textBoxProductName.TextChanged += new System.EventHandler(this.textBoxProductName_TextChanged);
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Location = new System.Drawing.Point(6, 46);
            this.textBoxProductCode.MaxLength = 7;
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.Size = new System.Drawing.Size(138, 20);
            this.textBoxProductCode.TabIndex = 0;
            this.textBoxProductCode.TextChanged += new System.EventHandler(this.textBoxProductCode_TextChanged);
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
            // grpBoxProductInfo
            // 
            this.grpBoxProductInfo.Controls.Add(this.labelNumbersOnly);
            this.grpBoxProductInfo.Controls.Add(this.labelProductName);
            this.grpBoxProductInfo.Controls.Add(this.textBoxProductName);
            this.grpBoxProductInfo.Controls.Add(this.labelProductCode);
            this.grpBoxProductInfo.Controls.Add(this.textBoxProductCode);
            this.grpBoxProductInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpBoxProductInfo.Location = new System.Drawing.Point(12, 12);
            this.grpBoxProductInfo.Name = "grpBoxProductInfo";
            this.grpBoxProductInfo.Size = new System.Drawing.Size(441, 79);
            this.grpBoxProductInfo.TabIndex = 3;
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
            // grpBoxTestInfo
            // 
            this.grpBoxTestInfo.Controls.Add(this.checkBoxNewStandard);
            this.grpBoxTestInfo.Controls.Add(this.textBoxTestDescription);
            this.grpBoxTestInfo.Controls.Add(this.labelTestDescription);
            this.grpBoxTestInfo.Controls.Add(this.labelTestName);
            this.grpBoxTestInfo.Controls.Add(this.textBoxTestName);
            this.grpBoxTestInfo.Controls.Add(this.labelTestCode);
            this.grpBoxTestInfo.Controls.Add(this.comboBoxTestCode);
            this.grpBoxTestInfo.Controls.Add(this.labelNotes);
            this.grpBoxTestInfo.Controls.Add(this.textBoxInquiryNotes);
            this.grpBoxTestInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpBoxTestInfo.Location = new System.Drawing.Point(12, 97);
            this.grpBoxTestInfo.Name = "grpBoxTestInfo";
            this.grpBoxTestInfo.Size = new System.Drawing.Size(441, 332);
            this.grpBoxTestInfo.TabIndex = 4;
            this.grpBoxTestInfo.TabStop = false;
            this.grpBoxTestInfo.Text = "Test Details";
            // 
            // checkBoxNewStandard
            // 
            this.checkBoxNewStandard.AutoSize = true;
            this.checkBoxNewStandard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxNewStandard.Location = new System.Drawing.Point(12, 35);
            this.checkBoxNewStandard.Name = "checkBoxNewStandard";
            this.checkBoxNewStandard.Size = new System.Drawing.Size(100, 17);
            this.checkBoxNewStandard.TabIndex = 8;
            this.checkBoxNewStandard.Text = "New Standard?";
            this.checkBoxNewStandard.UseVisualStyleBackColor = true;
            this.checkBoxNewStandard.CheckedChanged += new System.EventHandler(this.checkBoxNewStandard_CheckedChanged);
            // 
            // textBoxTestDescription
            // 
            this.textBoxTestDescription.Location = new System.Drawing.Point(205, 52);
            this.textBoxTestDescription.Multiline = true;
            this.textBoxTestDescription.Name = "textBoxTestDescription";
            this.textBoxTestDescription.ReadOnly = true;
            this.textBoxTestDescription.Size = new System.Drawing.Size(230, 116);
            this.textBoxTestDescription.TabIndex = 2;
            this.textBoxTestDescription.TextChanged += new System.EventHandler(this.textBoxTestDescription_TextChanged);
            // 
            // labelTestDescription
            // 
            this.labelTestDescription.AutoSize = true;
            this.labelTestDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTestDescription.Location = new System.Drawing.Point(202, 36);
            this.labelTestDescription.Name = "labelTestDescription";
            this.labelTestDescription.Size = new System.Drawing.Size(87, 13);
            this.labelTestDescription.TabIndex = 6;
            this.labelTestDescription.Text = "Test Description:";
            // 
            // labelTestName
            // 
            this.labelTestName.AutoSize = true;
            this.labelTestName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTestName.Location = new System.Drawing.Point(6, 112);
            this.labelTestName.Name = "labelTestName";
            this.labelTestName.Size = new System.Drawing.Size(62, 13);
            this.labelTestName.TabIndex = 5;
            this.labelTestName.Text = "Test Name:";
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.Location = new System.Drawing.Point(6, 128);
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.ReadOnly = true;
            this.textBoxTestName.Size = new System.Drawing.Size(193, 20);
            this.textBoxTestName.TabIndex = 1;
            this.textBoxTestName.TextChanged += new System.EventHandler(this.textBoxTestName_TextChanged);
            // 
            // labelTestCode
            // 
            this.labelTestCode.AutoSize = true;
            this.labelTestCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTestCode.Location = new System.Drawing.Point(9, 72);
            this.labelTestCode.Name = "labelTestCode";
            this.labelTestCode.Size = new System.Drawing.Size(59, 13);
            this.labelTestCode.TabIndex = 1;
            this.labelTestCode.Text = "Test Code:";
            // 
            // comboBoxTestCode
            // 
            this.comboBoxTestCode.AllowDrop = true;
            this.comboBoxTestCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTestCode.FormattingEnabled = true;
            this.comboBoxTestCode.Location = new System.Drawing.Point(6, 88);
            this.comboBoxTestCode.Name = "comboBoxTestCode";
            this.comboBoxTestCode.Size = new System.Drawing.Size(138, 21);
            this.comboBoxTestCode.TabIndex = 0;
            this.comboBoxTestCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxTestCode_SelectedIndexChanged);
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNotes.Location = new System.Drawing.Point(6, 188);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(191, 13);
            this.labelNotes.TabIndex = 1;
            this.labelNotes.Text = "Notes, Instructions, and Specifications:";
            // 
            // textBoxInquiryNotes
            // 
            this.textBoxInquiryNotes.Location = new System.Drawing.Point(9, 204);
            this.textBoxInquiryNotes.Multiline = true;
            this.textBoxInquiryNotes.Name = "textBoxInquiryNotes";
            this.textBoxInquiryNotes.Size = new System.Drawing.Size(426, 122);
            this.textBoxInquiryNotes.TabIndex = 3;
            this.textBoxInquiryNotes.TextChanged += new System.EventHandler(this.textBoxInquiryNotes_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Enabled = false;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(94, 435);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 29);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(270, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelNumbersOnly
            // 
            this.labelNumbersOnly.AutoSize = true;
            this.labelNumbersOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumbersOnly.ForeColor = System.Drawing.Color.Red;
            this.labelNumbersOnly.Location = new System.Drawing.Point(79, 30);
            this.labelNumbersOnly.Name = "labelNumbersOnly";
            this.labelNumbersOnly.Size = new System.Drawing.Size(72, 13);
            this.labelNumbersOnly.TabIndex = 4;
            this.labelNumbersOnly.Text = "Numbers Only";
            this.labelNumbersOnly.Visible = false;
            // 
            // InquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 476);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpBoxTestInfo);
            this.Controls.Add(this.grpBoxProductInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InquiryForm";
            this.Text = "Inquiry Form";
            this.grpBoxProductInfo.ResumeLayout(false);
            this.grpBoxProductInfo.PerformLayout();
            this.grpBoxTestInfo.ResumeLayout(false);
            this.grpBoxTestInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.Label labelProductCode;
        private System.Windows.Forms.GroupBox grpBoxProductInfo;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.GroupBox grpBoxTestInfo;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxInquiryNotes;
        private System.Windows.Forms.TextBox textBoxTestDescription;
        private System.Windows.Forms.Label labelTestDescription;
        private System.Windows.Forms.Label labelTestName;
        private System.Windows.Forms.TextBox textBoxTestName;
        private System.Windows.Forms.Label labelTestCode;
        private System.Windows.Forms.ComboBox comboBoxTestCode;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxNewStandard;
        private System.Windows.Forms.Label labelNumbersOnly;
    }
}