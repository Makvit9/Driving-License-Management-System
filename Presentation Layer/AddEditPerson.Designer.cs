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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditPerson));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNametxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondNametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ThirdNametxt = new System.Windows.Forms.TextBox();
            this.LastNametxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFemale = new System.Windows.Forms.RadioButton();
            this.btnMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.NationalNotxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.DateOfBirthtxt = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.AddressRtxt = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.errEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.errInvalidEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNumbersOnly = new System.Windows.Forms.ErrorProvider(this.components);
            this.CountriesList = new Presentation_Layer.Custom_Controls.ShowCountriesList();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
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
            // FirstNametxt
            // 
            this.FirstNametxt.Location = new System.Drawing.Point(153, 73);
            this.FirstNametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.Size = new System.Drawing.Size(195, 20);
            this.FirstNametxt.TabIndex = 5;
            this.FirstNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.FirstNametxt.Validated += new System.EventHandler(this.ClearError);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.ProfilePic);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.AddressRtxt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CountriesList);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnFemale);
            this.groupBox1.Controls.Add(this.btnMale);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Emailtxt);
            this.groupBox1.Controls.Add(this.NationalNotxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Phonetxt);
            this.groupBox1.Controls.Add(this.DateOfBirthtxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ThirdNametxt);
            this.groupBox1.Controls.Add(this.LastNametxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SecondNametxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FirstNametxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 506);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
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
            // SecondNametxt
            // 
            this.SecondNametxt.Location = new System.Drawing.Point(392, 73);
            this.SecondNametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SecondNametxt.Name = "SecondNametxt";
            this.SecondNametxt.Size = new System.Drawing.Size(195, 20);
            this.SecondNametxt.TabIndex = 6;
            this.SecondNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.SecondNametxt.Validated += new System.EventHandler(this.ClearError);
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
            // ThirdNametxt
            // 
            this.ThirdNametxt.Location = new System.Drawing.Point(153, 140);
            this.ThirdNametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ThirdNametxt.Name = "ThirdNametxt";
            this.ThirdNametxt.Size = new System.Drawing.Size(195, 20);
            this.ThirdNametxt.TabIndex = 9;
            // 
            // LastNametxt
            // 
            this.LastNametxt.Location = new System.Drawing.Point(392, 140);
            this.LastNametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.Size = new System.Drawing.Size(195, 20);
            this.LastNametxt.TabIndex = 10;
            this.LastNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.LastNametxt.Validated += new System.EventHandler(this.ClearError);
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
            this.btnFemale.TabStop = true;
            this.btnFemale.Tag = "F";
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.CheckedChanged += new System.EventHandler(this.btnFemale_CheckedChanged);
            // 
            // btnMale
            // 
            this.btnMale.AutoSize = true;
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
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(153, 405);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(195, 20);
            this.Emailtxt.TabIndex = 39;
            this.Emailtxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.Emailtxt.Validated += new System.EventHandler(this.ClearError);
            // 
            // NationalNotxt
            // 
            this.NationalNotxt.Location = new System.Drawing.Point(153, 189);
            this.NationalNotxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NationalNotxt.Name = "NationalNotxt";
            this.NationalNotxt.Size = new System.Drawing.Size(195, 20);
            this.NationalNotxt.TabIndex = 31;
            this.NationalNotxt.TextChanged += new System.EventHandler(this.NumbersOnlyValidator);
            this.NationalNotxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.NationalNotxt.Validated += new System.EventHandler(this.ClearError);
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
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(153, 358);
            this.Phonetxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(195, 20);
            this.Phonetxt.TabIndex = 38;
            this.Phonetxt.TextChanged += new System.EventHandler(this.NumbersOnlyValidator);
            this.Phonetxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.Phonetxt.Validated += new System.EventHandler(this.ClearError);
            // 
            // DateOfBirthtxt
            // 
            this.DateOfBirthtxt.Location = new System.Drawing.Point(153, 227);
            this.DateOfBirthtxt.MaxDate = new System.DateTime(2024, 10, 27, 0, 0, 0, 0);
            this.DateOfBirthtxt.MinDate = new System.DateTime(1924, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthtxt.Name = "DateOfBirthtxt";
            this.DateOfBirthtxt.Size = new System.Drawing.Size(195, 20);
            this.DateOfBirthtxt.TabIndex = 32;
            this.DateOfBirthtxt.Value = new System.DateTime(2024, 10, 27, 0, 0, 0, 0);
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
            // AddressRtxt
            // 
            this.AddressRtxt.Location = new System.Drawing.Point(392, 218);
            this.AddressRtxt.Name = "AddressRtxt";
            this.AddressRtxt.Size = new System.Drawing.Size(392, 207);
            this.AddressRtxt.TabIndex = 44;
            this.AddressRtxt.Text = "";
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
            // ProfilePic
            // 
            this.ProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfilePic.InitialImage = ((System.Drawing.Image)(resources.GetObject("ProfilePic.InitialImage")));
            this.ProfilePic.Location = new System.Drawing.Point(652, 19);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(132, 141);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 47;
            this.ProfilePic.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(725, 167);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "";
            this.linkLabel1.Text = "Set Image";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(270, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 41);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 41);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // CountriesList
            // 
            this.CountriesList.Location = new System.Drawing.Point(153, 311);
            this.CountriesList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CountriesList.Name = "CountriesList";
            this.CountriesList.Size = new System.Drawing.Size(195, 23);
            this.CountriesList.TabIndex = 36;
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
            this.Load += new System.EventHandler(this.AddNewPersonCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNumbersOnly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNametxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecondNametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ThirdNametxt;
        private System.Windows.Forms.TextBox LastNametxt;
        private System.Windows.Forms.Label label11;
        private Custom_Controls.ShowCountriesList CountriesList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton btnFemale;
        private System.Windows.Forms.RadioButton btnMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox NationalNotxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.DateTimePicker DateOfBirthtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox AddressRtxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox ProfilePic;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ErrorProvider errEmpty;
        private System.Windows.Forms.ErrorProvider errInvalidEmail;
        private System.Windows.Forms.ErrorProvider errNumbersOnly;
    }
}