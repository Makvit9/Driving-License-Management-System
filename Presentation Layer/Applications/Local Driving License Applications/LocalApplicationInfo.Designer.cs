namespace Presentation_Layer.Applications
{
    partial class LocalApplicationInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDrivingLicenseInfo = new System.Windows.Forms.GroupBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblLocalLicenseApplication = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.baseApplicationInfo1 = new Presentation_Layer.Applications.BaseApplicationInfo();
            this.grpDrivingLicenseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDrivingLicenseInfo
            // 
            this.grpDrivingLicenseInfo.BackColor = System.Drawing.Color.White;
            this.grpDrivingLicenseInfo.Controls.Add(this.lblClassName);
            this.grpDrivingLicenseInfo.Controls.Add(this.pictureBox10);
            this.grpDrivingLicenseInfo.Controls.Add(this.lblLocalLicenseApplication);
            this.grpDrivingLicenseInfo.Controls.Add(this.pictureBox9);
            this.grpDrivingLicenseInfo.Controls.Add(this.label10);
            this.grpDrivingLicenseInfo.Controls.Add(this.label9);
            this.grpDrivingLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDrivingLicenseInfo.Location = new System.Drawing.Point(4, 3);
            this.grpDrivingLicenseInfo.Name = "grpDrivingLicenseInfo";
            this.grpDrivingLicenseInfo.Size = new System.Drawing.Size(795, 126);
            this.grpDrivingLicenseInfo.TabIndex = 0;
            this.grpDrivingLicenseInfo.TabStop = false;
            this.grpDrivingLicenseInfo.Text = "Driving License Application Info";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.Color.White;
            this.lblClassName.Location = new System.Drawing.Point(487, 38);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(34, 17);
            this.lblClassName.TabIndex = 11;
            this.lblClassName.Text = "[???]";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.Image = global::Presentation_Layer.Properties.Resources.License_Type_32;
            this.pictureBox10.Location = new System.Drawing.Point(452, 38);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(17, 19);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // lblLocalLicenseApplication
            // 
            this.lblLocalLicenseApplication.AutoSize = true;
            this.lblLocalLicenseApplication.BackColor = System.Drawing.Color.White;
            this.lblLocalLicenseApplication.Location = new System.Drawing.Point(175, 38);
            this.lblLocalLicenseApplication.Name = "lblLocalLicenseApplication";
            this.lblLocalLicenseApplication.Size = new System.Drawing.Size(34, 17);
            this.lblLocalLicenseApplication.TabIndex = 11;
            this.lblLocalLicenseApplication.Text = "[???]";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Image = global::Presentation_Layer.Properties.Resources.Number_32;
            this.pictureBox9.Location = new System.Drawing.Point(139, 36);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(17, 19);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(315, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Applied for License: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Local Application ID: ";
            // 
            // baseApplicationInfo1
            // 
            this.baseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.baseApplicationInfo1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseApplicationInfo1.Location = new System.Drawing.Point(3, 136);
            this.baseApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.baseApplicationInfo1.Name = "baseApplicationInfo1";
            this.baseApplicationInfo1.Size = new System.Drawing.Size(807, 217);
            this.baseApplicationInfo1.TabIndex = 1;
            // 
            // LocalApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.baseApplicationInfo1);
            this.Controls.Add(this.grpDrivingLicenseInfo);
            this.Name = "LocalApplicationInfo";
            this.Size = new System.Drawing.Size(815, 369);
            this.grpDrivingLicenseInfo.ResumeLayout(false);
            this.grpDrivingLicenseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDrivingLicenseInfo;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblLocalLicenseApplication;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private BaseApplicationInfo baseApplicationInfo1;
    }
}
