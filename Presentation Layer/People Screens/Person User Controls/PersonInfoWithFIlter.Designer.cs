namespace Presentation_Layer.People_Screens.User_Controls
{
    partial class PersonInfoWithFIlter
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
            this.components = new System.ComponentModel.Container();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gboxPersonInfo = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorProviderEmptyTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.personInfoUpdated1 = new Presentation_Layer.People_Screens.Person_User_Controls.PersonInfoUpdated();
            this.gbFilter.SuspendLayout();
            this.gboxPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmptyTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAdd);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Controls.Add(this.cbFilters);
            this.gbFilter.Controls.Add(this.lblFindBy);
            this.gbFilter.Location = new System.Drawing.Point(20, 17);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFilter.Size = new System.Drawing.Size(787, 76);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(285, 26);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(207, 23);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            this.txtFilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilter_Validating);
            this.txtFilter.Validated += new System.EventHandler(this.txtFilter_Validated);
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "National Number",
            "Person ID"});
            this.cbFilters.Location = new System.Drawing.Point(74, 26);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(190, 23);
            this.cbFilters.TabIndex = 2;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
            // 
            // lblFindBy
            // 
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindBy.Location = new System.Drawing.Point(16, 29);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(52, 15);
            this.lblFindBy.TabIndex = 1;
            this.lblFindBy.Text = "Find By: ";
            // 
            // gboxPersonInfo
            // 
            this.gboxPersonInfo.Controls.Add(this.personInfoUpdated1);
            this.gboxPersonInfo.Location = new System.Drawing.Point(20, 99);
            this.gboxPersonInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxPersonInfo.Name = "gboxPersonInfo";
            this.gboxPersonInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxPersonInfo.Size = new System.Drawing.Size(787, 254);
            this.gboxPersonInfo.TabIndex = 2;
            this.gboxPersonInfo.TabStop = false;
            this.gboxPersonInfo.Text = "Person Info";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // errorProviderEmptyTxt
            // 
            this.errorProviderEmptyTxt.ContainerControl = this;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::Presentation_Layer.Properties.Resources.SearchPerson;
            this.btnFind.Location = new System.Drawing.Point(544, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(53, 40);
            this.btnFind.TabIndex = 6;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.ClickFind);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Presentation_Layer.Properties.Resources.Add_Person_40;
            this.btnAdd.Location = new System.Drawing.Point(624, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // personInfoUpdated1
            // 
            this.personInfoUpdated1.BackColor = System.Drawing.Color.White;
            this.personInfoUpdated1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personInfoUpdated1.Location = new System.Drawing.Point(19, 33);
            this.personInfoUpdated1.Margin = new System.Windows.Forms.Padding(4);
            this.personInfoUpdated1.Name = "personInfoUpdated1";
            this.personInfoUpdated1.Size = new System.Drawing.Size(749, 216);
            this.personInfoUpdated1.TabIndex = 0;
            // 
            // PersonInfoWithFIlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gboxPersonInfo);
            this.Controls.Add(this.gbFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PersonInfoWithFIlter";
            this.Size = new System.Drawing.Size(825, 363);
            this.Load += new System.EventHandler(this.PersonInfoWithFIlter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gboxPersonInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmptyTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label lblFindBy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gboxPersonInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Person_User_Controls.PersonInfoUpdated personInfoUpdated1;
        private System.Windows.Forms.ErrorProvider errorProviderEmptyTxt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
    }
}
