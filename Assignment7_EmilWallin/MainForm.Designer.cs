namespace Assignment7_EmilWallin
{
    partial class testingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testingForm));
            this.grpPending = new System.Windows.Forms.GroupBox();
            this.btnEditInquiry = new System.Windows.Forms.Button();
            this.btnAddReport = new System.Windows.Forms.Button();
            this.btnOpenPendingInquiry = new System.Windows.Forms.Button();
            this.btnNewInquiry = new System.Windows.Forms.Button();
            this.listBoxPending = new System.Windows.Forms.ListBox();
            this.grpCompleted = new System.Windows.Forms.GroupBox();
            this.btnOpenCompletedInquiry = new System.Windows.Forms.Button();
            this.btnEditReport = new System.Windows.Forms.Button();
            this.btnOpenReport = new System.Windows.Forms.Button();
            this.listBoxCompleted = new System.Windows.Forms.ListBox();
            this.btnViewTestStandards = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTestStandardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInquiriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteInquiry = new System.Windows.Forms.Button();
            this.grpPending.SuspendLayout();
            this.grpCompleted.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPending
            // 
            this.grpPending.Controls.Add(this.btnDeleteInquiry);
            this.grpPending.Controls.Add(this.btnEditInquiry);
            this.grpPending.Controls.Add(this.btnAddReport);
            this.grpPending.Controls.Add(this.btnOpenPendingInquiry);
            this.grpPending.Controls.Add(this.btnNewInquiry);
            this.grpPending.Controls.Add(this.listBoxPending);
            this.grpPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPending.ForeColor = System.Drawing.Color.MediumBlue;
            this.grpPending.Location = new System.Drawing.Point(13, 27);
            this.grpPending.Name = "grpPending";
            this.grpPending.Size = new System.Drawing.Size(765, 322);
            this.grpPending.TabIndex = 0;
            this.grpPending.TabStop = false;
            this.grpPending.Text = "Pending";
            // 
            // btnEditInquiry
            // 
            this.btnEditInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInquiry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditInquiry.Location = new System.Drawing.Point(657, 82);
            this.btnEditInquiry.Name = "btnEditInquiry";
            this.btnEditInquiry.Size = new System.Drawing.Size(102, 56);
            this.btnEditInquiry.TabIndex = 4;
            this.btnEditInquiry.Text = "Edit Inquiry";
            this.btnEditInquiry.UseVisualStyleBackColor = true;
            this.btnEditInquiry.Click += new System.EventHandler(this.btnEditInquiry_Click);
            // 
            // btnAddReport
            // 
            this.btnAddReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddReport.Location = new System.Drawing.Point(657, 206);
            this.btnAddReport.Name = "btnAddReport";
            this.btnAddReport.Size = new System.Drawing.Size(102, 56);
            this.btnAddReport.TabIndex = 3;
            this.btnAddReport.Text = "Add  Report";
            this.btnAddReport.UseVisualStyleBackColor = true;
            this.btnAddReport.Click += new System.EventHandler(this.btnAddReport_Click);
            // 
            // btnOpenPendingInquiry
            // 
            this.btnOpenPendingInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPendingInquiry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenPendingInquiry.Location = new System.Drawing.Point(657, 144);
            this.btnOpenPendingInquiry.Name = "btnOpenPendingInquiry";
            this.btnOpenPendingInquiry.Size = new System.Drawing.Size(102, 56);
            this.btnOpenPendingInquiry.TabIndex = 2;
            this.btnOpenPendingInquiry.Text = "Open Inquiry";
            this.btnOpenPendingInquiry.UseVisualStyleBackColor = true;
            this.btnOpenPendingInquiry.Click += new System.EventHandler(this.btnOpenPendingInquiry_Click);
            // 
            // btnNewInquiry
            // 
            this.btnNewInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewInquiry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewInquiry.Location = new System.Drawing.Point(657, 20);
            this.btnNewInquiry.Name = "btnNewInquiry";
            this.btnNewInquiry.Size = new System.Drawing.Size(102, 56);
            this.btnNewInquiry.TabIndex = 1;
            this.btnNewInquiry.Text = "New  Inquiry";
            this.btnNewInquiry.UseVisualStyleBackColor = true;
            this.btnNewInquiry.Click += new System.EventHandler(this.btnNewInquiry_Click);
            // 
            // listBoxPending
            // 
            this.listBoxPending.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPending.FormattingEnabled = true;
            this.listBoxPending.HorizontalScrollbar = true;
            this.listBoxPending.ItemHeight = 14;
            this.listBoxPending.Location = new System.Drawing.Point(6, 20);
            this.listBoxPending.Name = "listBoxPending";
            this.listBoxPending.Size = new System.Drawing.Size(645, 284);
            this.listBoxPending.TabIndex = 0;
            this.listBoxPending.SelectedIndexChanged += new System.EventHandler(this.listBoxPending_SelectedIndexChanged);
            // 
            // grpCompleted
            // 
            this.grpCompleted.Controls.Add(this.btnOpenCompletedInquiry);
            this.grpCompleted.Controls.Add(this.btnEditReport);
            this.grpCompleted.Controls.Add(this.btnOpenReport);
            this.grpCompleted.Controls.Add(this.listBoxCompleted);
            this.grpCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompleted.ForeColor = System.Drawing.Color.MediumBlue;
            this.grpCompleted.Location = new System.Drawing.Point(13, 391);
            this.grpCompleted.Name = "grpCompleted";
            this.grpCompleted.Size = new System.Drawing.Size(765, 319);
            this.grpCompleted.TabIndex = 1;
            this.grpCompleted.TabStop = false;
            this.grpCompleted.Text = "Completed";
            // 
            // btnOpenCompletedInquiry
            // 
            this.btnOpenCompletedInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCompletedInquiry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenCompletedInquiry.Location = new System.Drawing.Point(657, 82);
            this.btnOpenCompletedInquiry.Name = "btnOpenCompletedInquiry";
            this.btnOpenCompletedInquiry.Size = new System.Drawing.Size(102, 56);
            this.btnOpenCompletedInquiry.TabIndex = 4;
            this.btnOpenCompletedInquiry.Text = "Open Inquiry";
            this.btnOpenCompletedInquiry.UseVisualStyleBackColor = true;
            this.btnOpenCompletedInquiry.Click += new System.EventHandler(this.btnOpenCompletedInquiry_Click);
            // 
            // btnEditReport
            // 
            this.btnEditReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditReport.Location = new System.Drawing.Point(657, 144);
            this.btnEditReport.Name = "btnEditReport";
            this.btnEditReport.Size = new System.Drawing.Size(102, 56);
            this.btnEditReport.TabIndex = 3;
            this.btnEditReport.Text = "Edit Report";
            this.btnEditReport.UseVisualStyleBackColor = true;
            this.btnEditReport.Click += new System.EventHandler(this.btnEditReport_Click);
            // 
            // btnOpenReport
            // 
            this.btnOpenReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenReport.Location = new System.Drawing.Point(657, 20);
            this.btnOpenReport.Name = "btnOpenReport";
            this.btnOpenReport.Size = new System.Drawing.Size(102, 56);
            this.btnOpenReport.TabIndex = 2;
            this.btnOpenReport.Text = "Open Report";
            this.btnOpenReport.UseVisualStyleBackColor = true;
            this.btnOpenReport.Click += new System.EventHandler(this.btnOpenReport_Click);
            // 
            // listBoxCompleted
            // 
            this.listBoxCompleted.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCompleted.FormattingEnabled = true;
            this.listBoxCompleted.HorizontalScrollbar = true;
            this.listBoxCompleted.ItemHeight = 14;
            this.listBoxCompleted.Location = new System.Drawing.Point(6, 20);
            this.listBoxCompleted.Name = "listBoxCompleted";
            this.listBoxCompleted.Size = new System.Drawing.Size(645, 284);
            this.listBoxCompleted.TabIndex = 0;
            // 
            // btnViewTestStandards
            // 
            this.btnViewTestStandards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTestStandards.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewTestStandards.Location = new System.Drawing.Point(599, 355);
            this.btnViewTestStandards.Name = "btnViewTestStandards";
            this.btnViewTestStandards.Size = new System.Drawing.Size(179, 30);
            this.btnViewTestStandards.TabIndex = 4;
            this.btnViewTestStandards.Text = "View Test Standards";
            this.btnViewTestStandards.UseVisualStyleBackColor = true;
            this.btnViewTestStandards.Click += new System.EventHandler(this.btnViewTestStandards_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTestStandardsToolStripMenuItem,
            this.saveInquiriesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveTestStandardsToolStripMenuItem
            // 
            this.saveTestStandardsToolStripMenuItem.Name = "saveTestStandardsToolStripMenuItem";
            this.saveTestStandardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveTestStandardsToolStripMenuItem.Text = "Save Test Standards";
            this.saveTestStandardsToolStripMenuItem.Click += new System.EventHandler(this.saveTestStandardsToolStripMenuItem_Click);
            // 
            // saveInquiriesToolStripMenuItem
            // 
            this.saveInquiriesToolStripMenuItem.Name = "saveInquiriesToolStripMenuItem";
            this.saveInquiriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveInquiriesToolStripMenuItem.Text = "Save Inquiries";
            this.saveInquiriesToolStripMenuItem.Click += new System.EventHandler(this.saveInquiriesToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnDeleteInquiry
            // 
            this.btnDeleteInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInquiry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteInquiry.Location = new System.Drawing.Point(657, 268);
            this.btnDeleteInquiry.Name = "btnDeleteInquiry";
            this.btnDeleteInquiry.Size = new System.Drawing.Size(102, 48);
            this.btnDeleteInquiry.TabIndex = 5;
            this.btnDeleteInquiry.Text = "Delete Inquiry";
            this.btnDeleteInquiry.UseVisualStyleBackColor = true;
            this.btnDeleteInquiry.Click += new System.EventHandler(this.btnDeleteInquiry_Click);
            // 
            // testingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 723);
            this.Controls.Add(this.btnViewTestStandards);
            this.Controls.Add(this.grpCompleted);
            this.Controls.Add(this.grpPending);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "testingForm";
            this.Text = "Testing Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.testingForm_FormClosing);
            this.grpPending.ResumeLayout(false);
            this.grpCompleted.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPending;
        private System.Windows.Forms.Button btnEditInquiry;
        private System.Windows.Forms.Button btnAddReport;
        private System.Windows.Forms.Button btnOpenPendingInquiry;
        private System.Windows.Forms.Button btnNewInquiry;
        private System.Windows.Forms.ListBox listBoxPending;
        private System.Windows.Forms.GroupBox grpCompleted;
        private System.Windows.Forms.Button btnEditReport;
        private System.Windows.Forms.Button btnOpenReport;
        private System.Windows.Forms.ListBox listBoxCompleted;
        private System.Windows.Forms.Button btnViewTestStandards;
        private System.Windows.Forms.Button btnOpenCompletedInquiry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTestStandardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInquiriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteInquiry;
    }
}

