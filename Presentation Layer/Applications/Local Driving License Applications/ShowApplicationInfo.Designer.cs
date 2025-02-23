namespace Presentation_Layer.Applications
{
    partial class ShowApplicationInfo
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
            this.localApplicationInfo1 = new Presentation_Layer.Applications.LocalApplicationInfo();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // localApplicationInfo1
            // 
            this.localApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.localApplicationInfo1.Location = new System.Drawing.Point(53, 116);
            this.localApplicationInfo1.Name = "localApplicationInfo1";
            this.localApplicationInfo1.Size = new System.Drawing.Size(857, 367);
            this.localApplicationInfo1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitle.Location = new System.Drawing.Point(218, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(452, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Local Driving License Application Information ";
            // 
            // ShowApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 560);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.localApplicationInfo1);
            this.Name = "ShowApplicationInfo";
            this.Text = "Application Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalApplicationInfo localApplicationInfo1;
        private System.Windows.Forms.Label lblTitle;
    }
}