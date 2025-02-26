namespace Presentation_Layer.Applications
{
    partial class ManageLocalDrivingLicenses
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
            this.components = new System.ComponentModel.Container();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.ComboFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLDLApplications = new System.Windows.Forms.DataGridView();
            this.cmsApplicationOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiApplicationDescription = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditLocalApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteLocalApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelLocalApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnAddNewApplication = new System.Windows.Forms.Button();
            this.tsmiShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).BeginInit();
            this.cmsApplicationOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Location = new System.Drawing.Point(186, 561);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(13, 15);
            this.lblRecordsCount.TabIndex = 15;
            this.lblRecordsCount.Text = "..";
            // 
            // lblColumns
            // 
            this.lblColumns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(90, 561);
            this.lblColumns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(81, 15);
            this.lblColumns.TabIndex = 14;
            this.lblColumns.Text = "# Of Records: ";
            // 
            // ComboFilter
            // 
            this.ComboFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboFilter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ComboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFilter.FormattingEnabled = true;
            this.ComboFilter.Location = new System.Drawing.Point(129, 158);
            this.ComboFilter.Margin = new System.Windows.Forms.Padding(4);
            this.ComboFilter.Name = "ComboFilter";
            this.ComboFilter.Size = new System.Drawing.Size(155, 23);
            this.ComboFilter.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter By:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manage Local Dirivng License Applications";
            // 
            // dgvLDLApplications
            // 
            this.dgvLDLApplications.AllowUserToAddRows = false;
            this.dgvLDLApplications.AllowUserToDeleteRows = false;
            this.dgvLDLApplications.AllowUserToResizeRows = false;
            this.dgvLDLApplications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvLDLApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvLDLApplications.CausesValidation = false;
            this.dgvLDLApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLApplications.ContextMenuStrip = this.cmsApplicationOptions;
            this.dgvLDLApplications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLDLApplications.Location = new System.Drawing.Point(63, 196);
            this.dgvLDLApplications.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLDLApplications.Name = "dgvLDLApplications";
            this.dgvLDLApplications.ReadOnly = true;
            this.dgvLDLApplications.Size = new System.Drawing.Size(1082, 351);
            this.dgvLDLApplications.TabIndex = 8;
            this.dgvLDLApplications.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvLDLApplications_MouseUp);
            // 
            // cmsApplicationOptions
            // 
            this.cmsApplicationOptions.BackColor = System.Drawing.Color.White;
            this.cmsApplicationOptions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsApplicationOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiApplicationDescription,
            this.tsmiEditLocalApplication,
            this.tsmiDeleteLocalApplication,
            this.tsmiCancelLocalApplication,
            this.toolStripSeparator1,
            this.tsmiScheduleTest,
            this.toolStripSeparator2,
            this.issueToolStripMenuItem,
            this.toolStripSeparator3,
            this.tsmiShowLicense});
            this.cmsApplicationOptions.Name = "cmsApplicationOptions";
            this.cmsApplicationOptions.Size = new System.Drawing.Size(247, 198);
            this.cmsApplicationOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplicationOptions_Opening);
            // 
            // tsmiApplicationDescription
            // 
            this.tsmiApplicationDescription.BackColor = System.Drawing.Color.White;
            this.tsmiApplicationDescription.Image = global::Presentation_Layer.Properties.Resources.ApplicationType;
            this.tsmiApplicationDescription.Name = "tsmiApplicationDescription";
            this.tsmiApplicationDescription.Size = new System.Drawing.Size(246, 22);
            this.tsmiApplicationDescription.Text = "Application Details ";
            this.tsmiApplicationDescription.Click += new System.EventHandler(this.tsmiApplicationDescription_Click);
            // 
            // tsmiEditLocalApplication
            // 
            this.tsmiEditLocalApplication.Image = global::Presentation_Layer.Properties.Resources.edit_32;
            this.tsmiEditLocalApplication.Name = "tsmiEditLocalApplication";
            this.tsmiEditLocalApplication.Size = new System.Drawing.Size(246, 22);
            this.tsmiEditLocalApplication.Text = "Edit Application";
            this.tsmiEditLocalApplication.Click += new System.EventHandler(this.tsmiEditLocalApplication_Click);
            // 
            // tsmiDeleteLocalApplication
            // 
            this.tsmiDeleteLocalApplication.BackColor = System.Drawing.Color.Transparent;
            this.tsmiDeleteLocalApplication.Image = global::Presentation_Layer.Properties.Resources.Delete_32_2;
            this.tsmiDeleteLocalApplication.Name = "tsmiDeleteLocalApplication";
            this.tsmiDeleteLocalApplication.Size = new System.Drawing.Size(246, 22);
            this.tsmiDeleteLocalApplication.Text = "Delete Application";
            this.tsmiDeleteLocalApplication.Click += new System.EventHandler(this.tsmiDeleteLocalApplication_Click);
            // 
            // tsmiCancelLocalApplication
            // 
            this.tsmiCancelLocalApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiCancelLocalApplication.Name = "tsmiCancelLocalApplication";
            this.tsmiCancelLocalApplication.Size = new System.Drawing.Size(246, 22);
            this.tsmiCancelLocalApplication.Text = "Cancel Application";
            this.tsmiCancelLocalApplication.Click += new System.EventHandler(this.tsmiCancelLocalApplication_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // tsmiScheduleTest
            // 
            this.tsmiScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVisionTest,
            this.tsmiWrittenTest,
            this.tsmiStreetTest});
            this.tsmiScheduleTest.Name = "tsmiScheduleTest";
            this.tsmiScheduleTest.Size = new System.Drawing.Size(246, 22);
            this.tsmiScheduleTest.Text = "Schedule Test";
            // 
            // tsmiVisionTest
            // 
            this.tsmiVisionTest.Name = "tsmiVisionTest";
            this.tsmiVisionTest.Size = new System.Drawing.Size(180, 22);
            this.tsmiVisionTest.Text = "Vision Test";
            this.tsmiVisionTest.Click += new System.EventHandler(this.tsmiVisionTest_Click);
            // 
            // tsmiWrittenTest
            // 
            this.tsmiWrittenTest.Name = "tsmiWrittenTest";
            this.tsmiWrittenTest.Size = new System.Drawing.Size(180, 22);
            this.tsmiWrittenTest.Text = "Written Test";
            this.tsmiWrittenTest.Click += new System.EventHandler(this.tsmiWrittenTest_Click);
            // 
            // tsmiStreetTest
            // 
            this.tsmiStreetTest.Name = "tsmiStreetTest";
            this.tsmiStreetTest.Size = new System.Drawing.Size(180, 22);
            this.tsmiStreetTest.Text = "Street Test";
            this.tsmiStreetTest.Click += new System.EventHandler(this.tsmiStreetTest_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.issueToolStripMenuItem.Text = "Issue Driving License (First Time)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(243, 6);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(302, 159);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(221, 23);
            this.txtFilter.TabIndex = 16;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_Changed);
            // 
            // btnAddNewApplication
            // 
            this.btnAddNewApplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNewApplication.Image = global::Presentation_Layer.Properties.Resources.New_Application_64;
            this.btnAddNewApplication.Location = new System.Drawing.Point(1070, 112);
            this.btnAddNewApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewApplication.Name = "btnAddNewApplication";
            this.btnAddNewApplication.Size = new System.Drawing.Size(75, 77);
            this.btnAddNewApplication.TabIndex = 10;
            this.btnAddNewApplication.UseVisualStyleBackColor = true;
            this.btnAddNewApplication.Click += new System.EventHandler(this.btnAddNewApplication_Click);
            // 
            // tsmiShowLicense
            // 
            this.tsmiShowLicense.Name = "tsmiShowLicense";
            this.tsmiShowLicense.Size = new System.Drawing.Size(246, 22);
            this.tsmiShowLicense.Text = "Show License";
            this.tsmiShowLicense.Click += new System.EventHandler(this.tsmiShowLicense_Click);
            // 
            // ManageLocalDrivingLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 587);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.ComboFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewApplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLDLApplications);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageLocalDrivingLicenses";
            this.Text = "ManageLocalDrivingLicenses";
            this.Load += new System.EventHandler(this.ManageLocalDrivingLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).EndInit();
            this.cmsApplicationOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.ComboBox ComboFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLDLApplications;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplicationDescription;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditLocalApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteLocalApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelLocalApplication;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiStreetTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLicense;
    }
}