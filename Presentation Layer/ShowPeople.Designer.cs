namespace Presentation_Layer
{
    partial class ShowPeople
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
            this.DgvPeopleList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeopleList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPeopleList
            // 
            this.DgvPeopleList.BackgroundColor = System.Drawing.Color.White;
            this.DgvPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPeopleList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvPeopleList.Location = new System.Drawing.Point(0, 141);
            this.DgvPeopleList.Name = "DgvPeopleList";
            this.DgvPeopleList.Size = new System.Drawing.Size(800, 309);
            this.DgvPeopleList.TabIndex = 0;
            // 
            // ShowPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvPeopleList);
            this.Name = "ShowPeople";
            this.Text = "ShowPeople";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeopleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPeopleList;
    }
}