namespace Assignment7_EmilWallin
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.grpBoxTestStandard = new System.Windows.Forms.GroupBox();
            this.checkBoxNewStandard = new System.Windows.Forms.CheckBox();
            this.textBoxTestDescription = new System.Windows.Forms.TextBox();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.labelTestName = new System.Windows.Forms.Label();
            this.labelTestDescription = new System.Windows.Forms.Label();
            this.labelTestCode = new System.Windows.Forms.Label();
            this.comboBoxTestCode = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBoxTestStandard.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxTestStandard
            // 
            this.grpBoxTestStandard.Controls.Add(this.checkBoxNewStandard);
            this.grpBoxTestStandard.Controls.Add(this.textBoxTestDescription);
            this.grpBoxTestStandard.Controls.Add(this.textBoxTestName);
            this.grpBoxTestStandard.Controls.Add(this.labelTestName);
            this.grpBoxTestStandard.Controls.Add(this.labelTestDescription);
            this.grpBoxTestStandard.Controls.Add(this.labelTestCode);
            this.grpBoxTestStandard.Controls.Add(this.comboBoxTestCode);
            this.grpBoxTestStandard.ForeColor = System.Drawing.Color.MediumBlue;
            this.grpBoxTestStandard.Location = new System.Drawing.Point(12, 12);
            this.grpBoxTestStandard.Name = "grpBoxTestStandard";
            this.grpBoxTestStandard.Size = new System.Drawing.Size(358, 338);
            this.grpBoxTestStandard.TabIndex = 0;
            this.grpBoxTestStandard.TabStop = false;
            this.grpBoxTestStandard.Text = "Test Standard";
            // 
            // checkBoxNewStandard
            // 
            this.checkBoxNewStandard.AutoSize = true;
            this.checkBoxNewStandard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxNewStandard.Location = new System.Drawing.Point(153, 20);
            this.checkBoxNewStandard.Name = "checkBoxNewStandard";
            this.checkBoxNewStandard.Size = new System.Drawing.Size(94, 17);
            this.checkBoxNewStandard.TabIndex = 6;
            this.checkBoxNewStandard.Text = "New Standard";
            this.checkBoxNewStandard.UseVisualStyleBackColor = true;
            this.checkBoxNewStandard.CheckedChanged += new System.EventHandler(this.checkBoxNewStandard_CheckedChanged);
            // 
            // textBoxTestDescription
            // 
            this.textBoxTestDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxTestDescription.Location = new System.Drawing.Point(6, 101);
            this.textBoxTestDescription.Multiline = true;
            this.textBoxTestDescription.Name = "textBoxTestDescription";
            this.textBoxTestDescription.ReadOnly = true;
            this.textBoxTestDescription.Size = new System.Drawing.Size(339, 231);
            this.textBoxTestDescription.TabIndex = 5;
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxTestName.Location = new System.Drawing.Point(153, 61);
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.ReadOnly = true;
            this.textBoxTestName.Size = new System.Drawing.Size(192, 20);
            this.textBoxTestName.TabIndex = 4;
            // 
            // labelTestName
            // 
            this.labelTestName.AutoSize = true;
            this.labelTestName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTestName.Location = new System.Drawing.Point(150, 45);
            this.labelTestName.Name = "labelTestName";
            this.labelTestName.Size = new System.Drawing.Size(62, 13);
            this.labelTestName.TabIndex = 3;
            this.labelTestName.Text = "Test Name:";
            // 
            // labelTestDescription
            // 
            this.labelTestDescription.AutoSize = true;
            this.labelTestDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTestDescription.Location = new System.Drawing.Point(6, 85);
            this.labelTestDescription.Name = "labelTestDescription";
            this.labelTestDescription.Size = new System.Drawing.Size(87, 13);
            this.labelTestDescription.TabIndex = 2;
            this.labelTestDescription.Text = "Test Description:";
            // 
            // labelTestCode
            // 
            this.labelTestCode.AutoSize = true;
            this.labelTestCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTestCode.Location = new System.Drawing.Point(6, 45);
            this.labelTestCode.Name = "labelTestCode";
            this.labelTestCode.Size = new System.Drawing.Size(59, 13);
            this.labelTestCode.TabIndex = 1;
            this.labelTestCode.Text = "Test Code:";
            // 
            // comboBoxTestCode
            // 
            this.comboBoxTestCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTestCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxTestCode.FormattingEnabled = true;
            this.comboBoxTestCode.Location = new System.Drawing.Point(6, 61);
            this.comboBoxTestCode.Name = "comboBoxTestCode";
            this.comboBoxTestCode.Size = new System.Drawing.Size(141, 21);
            this.comboBoxTestCode.TabIndex = 0;
            this.comboBoxTestCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxTestCode_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(100, 356);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(84, 42);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(190, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 410);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpBoxTestStandard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestForm";
            this.Text = "Test Standards";
            this.grpBoxTestStandard.ResumeLayout(false);
            this.grpBoxTestStandard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxTestStandard;
        private System.Windows.Forms.ComboBox comboBoxTestCode;
        private System.Windows.Forms.TextBox textBoxTestDescription;
        private System.Windows.Forms.TextBox textBoxTestName;
        private System.Windows.Forms.Label labelTestName;
        private System.Windows.Forms.Label labelTestDescription;
        private System.Windows.Forms.Label labelTestCode;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkBoxNewStandard;
    }
}