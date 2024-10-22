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
            this.addNewPersonCard1 = new Presentation_Layer.Custom_Controls.AddNewPersonCard();
            this.SuspendLayout();
            // 
            // addNewPersonCard1
            // 
            this.addNewPersonCard1.BackColor = System.Drawing.Color.White;
            this.addNewPersonCard1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPersonCard1.Location = new System.Drawing.Point(13, 40);
            this.addNewPersonCard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addNewPersonCard1.Name = "addNewPersonCard1";
            this.addNewPersonCard1.Size = new System.Drawing.Size(832, 441);
            this.addNewPersonCard1.TabIndex = 0;
            // 
            // AddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 493);
            this.Controls.Add(this.addNewPersonCard1);
            this.Name = "AddNewPerson";
            this.Text = "AddNewPerson";
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls.AddNewPersonCard addNewPersonCard1;
    }
}