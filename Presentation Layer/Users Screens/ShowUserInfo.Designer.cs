namespace Presentation_Layer.Users_Screens
{
    partial class ShowUserInfo
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
            this.userCardInfo1 = new Presentation_Layer.Users_Screens.UserCardInfo();
            this.SuspendLayout();
            // 
            // userCardInfo1
            // 
            this.userCardInfo1.BackColor = System.Drawing.Color.White;
            this.userCardInfo1.Location = new System.Drawing.Point(21, 12);
            this.userCardInfo1.Name = "userCardInfo1";
            this.userCardInfo1.Size = new System.Drawing.Size(788, 331);
            this.userCardInfo1.TabIndex = 0;
            // 
            // ShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 350);
            this.Controls.Add(this.userCardInfo1);
            this.Name = "ShowUserInfo";
            this.Text = "ShowUserInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private UserCardInfo userCardInfo1;
    }
}