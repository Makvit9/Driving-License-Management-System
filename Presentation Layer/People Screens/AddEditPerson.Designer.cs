namespace Presentation_Layer
{
    partial class AddEditPerson
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCountries = new System.Windows.Forms.ComboBox();
            this.lnkRemove = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lnkSetImage = new System.Windows.Forms.LinkLabel();
            this.rtxAddress = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFemale = new System.Windows.Forms.RadioButton();
            this.btnMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNationalNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThirdname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecondname = new System.Windows.Forms.TextBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.errEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.errInvalidEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNumbersOnly = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNumbersOnly)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name: ";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(153, 73);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(195, 20);
            this.txtFirstname.TabIndex = 5;
            this.txtFirstname.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.txtFirstname.Validated += new System.EventHandler(this.ClearError);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCountries);
            this.groupBox1.Controls.Add(this.lnkRemove);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.picProfile);
            this.groupBox1.Controls.Add(this.lnkSetImage);
            this.groupBox1.Controls.Add(this.rtxAddress);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnFemale);
            this.groupBox1.Controls.Add(this.btnMale);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNationalNumber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.dtpBirthdate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtThirdname);
            this.groupBox1.Controls.Add(this.txtLastname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSecondname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 506);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cboCountries
            // 
            this.cboCountries.FormattingEnabled = true;
            this.cboCountries.Location = new System.Drawing.Point(153, 310);
            this.cboCountries.Name = "cboCountries";
            this.cboCountries.Size = new System.Drawing.Size(195, 21);
            this.cboCountries.TabIndex = 51;
            // 
            // lnkRemove
            // 
            this.lnkRemove.AutoSize = true;
            this.lnkRemove.Location = new System.Drawing.Point(649, 167);
            this.lnkRemove.Name = "lnkRemove";
            this.lnkRemove.Size = new System.Drawing.Size(47, 13);
            this.lnkRemove.TabIndex = 50;
            this.lnkRemove.TabStop = true;
            this.lnkRemove.Tag = "";
            this.lnkRemove.Text = "Remove";
            this.lnkRemove.Visible = false;
            this.lnkRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveProfilePic);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(270, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 41);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.CloseForm);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 41);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ClickSave);
            // 
            // picProfile
            // 
            this.picProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picProfile.InitialImage = global::Presentation_Layer.Properties.Resources.user;
            this.picProfile.Location = new System.Drawing.Point(652, 19);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(132, 141);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 47;
            this.picProfile.TabStop = false;
            // 
            // lnkSetImage
            // 
            this.lnkSetImage.AutoSize = true;
            this.lnkSetImage.Location = new System.Drawing.Point(725, 167);
            this.lnkSetImage.Name = "lnkSetImage";
            this.lnkSetImage.Size = new System.Drawing.Size(55, 13);
            this.lnkSetImage.TabIndex = 46;
            this.lnkSetImage.TabStop = true;
            this.lnkSetImage.Tag = "";
            this.lnkSetImage.Text = "Set Image";
            this.lnkSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetProfilePic);
            // 
            // rtxAddress
            // 
            this.rtxAddress.Location = new System.Drawing.Point(392, 218);
            this.rtxAddress.Name = "rtxAddress";
            this.rtxAddress.Size = new System.Drawing.Size(392, 207);
            this.rtxAddress.TabIndex = 44;
            this.rtxAddress.Text = "";
            this.rtxAddress.Leave += new System.EventHandler(this.AddressRtxt_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(388, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 21);
            this.label12.TabIndex = 45;
            this.label12.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 43;
            this.label11.Text = "Country: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 270);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 42;
            this.label10.Text = "Gender:";
            // 
            // btnFemale
            // 
            this.btnFemale.AutoSize = true;
            this.btnFemale.Location = new System.Drawing.Point(285, 268);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(59, 17);
            this.btnFemale.TabIndex = 34;
            this.btnFemale.Tag = "F";
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.CheckedChanged += new System.EventHandler(this.btnFemale_CheckedChanged);
            // 
            // btnMale
            // 
            this.btnMale.AutoSize = true;
            this.btnMale.Checked = true;
            this.btnMale.Location = new System.Drawing.Point(150, 268);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(48, 17);
            this.btnMale.TabIndex = 33;
            this.btnMale.TabStop = true;
            this.btnMale.Tag = "M";
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.CheckedChanged += new System.EventHandler(this.btnMale_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "National No:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 405);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 39;
            this.txtEmail.TextChanged += new System.EventHandler(this.Emailtxt_TextChanged);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.txtEmail.Validated += new System.EventHandler(this.ClearError);
            // 
            // txtNationalNumber
            // 
            this.txtNationalNumber.Location = new System.Drawing.Point(153, 189);
            this.txtNationalNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.Size = new System.Drawing.Size(195, 20);
            this.txtNationalNumber.TabIndex = 31;
            this.txtNationalNumber.TextChanged += new System.EventHandler(this.NumbersOnlyValidator);
            this.txtNationalNumber.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.txtNationalNumber.Validated += new System.EventHandler(this.ClearError);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 403);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Email: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Date of birth:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(153, 358);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(195, 20);
            this.txtPhone.TabIndex = 38;
            this.txtPhone.TextChanged += new System.EventHandler(this.NumbersOnlyValidator);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.txtPhone.Validated += new System.EventHandler(this.ClearError);
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(153, 227);
            this.dtpBirthdate.MaxDate = new System.DateTime(2024, 10, 27, 0, 0, 0, 0);
            this.dtpBirthdate.MinDate = new System.DateTime(1924, 1, 1, 0, 0, 0, 0);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(195, 20);
            this.dtpBirthdate.TabIndex = 32;
            this.dtpBirthdate.Value = new System.DateTime(2024, 10, 27, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 358);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Third Name (Optional)";
            // 
            // txtThirdname
            // 
            this.txtThirdname.Location = new System.Drawing.Point(153, 140);
            this.txtThirdname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtThirdname.Name = "txtThirdname";
            this.txtThirdname.Size = new System.Drawing.Size(195, 20);
            this.txtThirdname.TabIndex = 9;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(392, 140);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(195, 20);
            this.txtLastname.TabIndex = 10;
            this.txtLastname.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.txtLastname.Validated += new System.EventHandler(this.ClearError);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Second Name";
            // 
            // txtSecondname
            // 
            this.txtSecondname.Location = new System.Drawing.Point(392, 73);
            this.txtSecondname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSecondname.Name = "txtSecondname";
            this.txtSecondname.Size = new System.Drawing.Size(195, 20);
            this.txtSecondname.TabIndex = 6;
            this.txtSecondname.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.txtSecondname.Validated += new System.EventHandler(this.ClearError);
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(89, 94);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(41, 21);
            this.lblPersonID.TabIndex = 9;
            this.lblPersonID.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Person ID: ";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(322, 9);
            this.lblMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(154, 24);
            this.lblMode.TabIndex = 7;
            this.lblMode.Text = "Add New Person";
            // 
            // errEmpty
            // 
            this.errEmpty.ContainerControl = this;
            // 
            // errInvalidEmail
            // 
            this.errInvalidEmail.ContainerControl = this;
            // 
            // errNumbersOnly
            // 
            this.errNumbersOnly.ContainerControl = this;
            // 
            // AddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 639);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddEditPerson";
            this.Text = "AddEditPerson";
            this.Load += new System.EventHandler(this._LoadForm);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNumbersOnly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecondname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThirdname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton btnFemale;
        private System.Windows.Forms.RadioButton btnMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNationalNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.LinkLabel lnkSetImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ErrorProvider errEmpty;
        private System.Windows.Forms.ErrorProvider errInvalidEmail;
        private System.Windows.Forms.ErrorProvider errNumbersOnly;
        private System.Windows.Forms.LinkLabel lnkRemove;
        private System.Windows.Forms.ComboBox cboCountries;
    }
}