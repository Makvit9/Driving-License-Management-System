namespace Presentation_Layer
{
    partial class AddNewPerson
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
            this.lblMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.addNewPersonCard1 = new Presentation_Layer.Custom_Controls.AddNewPersonCard();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(356, 15);
            this.lblMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(154, 24);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "Add New Person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Person ID: ";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(123, 100);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(41, 21);
            this.lblPersonID.TabIndex = 3;
            this.lblPersonID.Text = "N/A";
            // 
            // addNewPersonCard1
            // 
            this.addNewPersonCard1.BackColor = System.Drawing.Color.White;
            this.addNewPersonCard1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPersonCard1.Location = new System.Drawing.Point(15, 113);
            this.addNewPersonCard1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.addNewPersonCard1.Name = "addNewPersonCard1";
            this.addNewPersonCard1.Size = new System.Drawing.Size(837, 538);
            this.addNewPersonCard1.TabIndex = 0;
            this.addNewPersonCard1.EvPassPersonInfo += new System.Action<BL.Person>(this.addNewPersonCard1_EvPassPersonInfo);
            // 
            // AddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 665);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.addNewPersonCard1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNewPerson";
            this.Text = "AddNewPerson";
            this.Activated += new System.EventHandler(this.AddNewPerson_Activated);
            this.Load += new System.EventHandler(this.AddNewPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Custom_Controls.AddNewPersonCard addNewPersonCard1;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonID;
    }
}