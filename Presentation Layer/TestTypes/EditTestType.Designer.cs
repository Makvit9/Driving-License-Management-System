namespace Presentation_Layer.TestTypes
{
    partial class EditTestType
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTestTypeID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTestTypeFee = new System.Windows.Forms.Label();
            this.lblTestTypeName = new System.Windows.Forms.Label();
            this.txtTestTypeFee = new System.Windows.Forms.TextBox();
            this.txtTestTypeTitle = new System.Windows.Forms.TextBox();
            this.lblTestTypeDescription = new System.Windows.Forms.Label();
            this.txtTestTypeDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID: ";
            // 
            // lblTestTypeID
            // 
            this.lblTestTypeID.AutoSize = true;
            this.lblTestTypeID.Location = new System.Drawing.Point(167, 83);
            this.lblTestTypeID.Name = "lblTestTypeID";
            this.lblTestTypeID.Size = new System.Drawing.Size(16, 13);
            this.lblTestTypeID.TabIndex = 14;
            this.lblTestTypeID.Text = "...";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(142, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 13);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Update Test Type";
            // 
            // lblTestTypeFee
            // 
            this.lblTestTypeFee.AutoSize = true;
            this.lblTestTypeFee.Location = new System.Drawing.Point(12, 306);
            this.lblTestTypeFee.Name = "lblTestTypeFee";
            this.lblTestTypeFee.Size = new System.Drawing.Size(49, 13);
            this.lblTestTypeFee.TabIndex = 12;
            this.lblTestTypeFee.Text = "Test Fee";
            // 
            // lblTestTypeName
            // 
            this.lblTestTypeName.AutoSize = true;
            this.lblTestTypeName.Location = new System.Drawing.Point(14, 119);
            this.lblTestTypeName.Name = "lblTestTypeName";
            this.lblTestTypeName.Size = new System.Drawing.Size(59, 13);
            this.lblTestTypeName.TabIndex = 11;
            this.lblTestTypeName.Text = "Test Name";
            // 
            // txtTestTypeFee
            // 
            this.txtTestTypeFee.Location = new System.Drawing.Point(168, 299);
            this.txtTestTypeFee.Name = "txtTestTypeFee";
            this.txtTestTypeFee.Size = new System.Drawing.Size(193, 20);
            this.txtTestTypeFee.TabIndex = 10;
            // 
            // txtTestTypeTitle
            // 
            this.txtTestTypeTitle.Location = new System.Drawing.Point(170, 113);
            this.txtTestTypeTitle.Name = "txtTestTypeTitle";
            this.txtTestTypeTitle.Size = new System.Drawing.Size(193, 20);
            this.txtTestTypeTitle.TabIndex = 9;
            // 
            // lblTestTypeDescription
            // 
            this.lblTestTypeDescription.AutoSize = true;
            this.lblTestTypeDescription.Location = new System.Drawing.Point(17, 157);
            this.lblTestTypeDescription.Name = "lblTestTypeDescription";
            this.lblTestTypeDescription.Size = new System.Drawing.Size(84, 13);
            this.lblTestTypeDescription.TabIndex = 18;
            this.lblTestTypeDescription.Text = "Test Description";
            // 
            // txtTestTypeDescription
            // 
            this.txtTestTypeDescription.Location = new System.Drawing.Point(170, 157);
            this.txtTestTypeDescription.Name = "txtTestTypeDescription";
            this.txtTestTypeDescription.Size = new System.Drawing.Size(194, 130);
            this.txtTestTypeDescription.TabIndex = 19;
            this.txtTestTypeDescription.Text = "";
            // 
            // EditTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 383);
            this.Controls.Add(this.txtTestTypeDescription);
            this.Controls.Add(this.lblTestTypeDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTestTypeID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTestTypeFee);
            this.Controls.Add(this.lblTestTypeName);
            this.Controls.Add(this.txtTestTypeFee);
            this.Controls.Add(this.txtTestTypeTitle);
            this.Name = "EditTestType";
            this.Text = "EditTestType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTestTypeID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTestTypeFee;
        private System.Windows.Forms.Label lblTestTypeName;
        private System.Windows.Forms.TextBox txtTestTypeFee;
        private System.Windows.Forms.TextBox txtTestTypeTitle;
        private System.Windows.Forms.Label lblTestTypeDescription;
        private System.Windows.Forms.RichTextBox txtTestTypeDescription;
    }
}