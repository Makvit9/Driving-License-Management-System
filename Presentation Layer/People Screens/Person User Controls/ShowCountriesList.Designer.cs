namespace Presentation_Layer.Custom_Controls
{
    partial class ShowCountriesList
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
            this.CountriesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CountriesComboBox
            // 
            this.CountriesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CountriesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CountriesComboBox.FormattingEnabled = true;
            this.CountriesComboBox.Location = new System.Drawing.Point(0, 0);
            this.CountriesComboBox.Name = "CountriesComboBox";
            this.CountriesComboBox.Size = new System.Drawing.Size(163, 21);
            this.CountriesComboBox.TabIndex = 0;
            this.CountriesComboBox.Leave += new System.EventHandler(this._CountriesComboBox_Leave);
            // 
            // ShowCountriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CountriesComboBox);
            this.Name = "ShowCountriesList";
            this.Size = new System.Drawing.Size(163, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CountriesComboBox;
    }
}
