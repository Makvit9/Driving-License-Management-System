namespace Presentation_Layer.Custom_Controls
{
    partial class AddNewPersonCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewPersonCard));
            this.FirstNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ThirdNametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LastNametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateOfBirthtxt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.NationalNotxt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMale = new System.Windows.Forms.RadioButton();
            this.btnFemale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AddressRtxt = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
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
            // FirstNametxt
            // 
            this.FirstNametxt.Location = new System.Drawing.Point(153, 68);
            this.FirstNametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.Size = new System.Drawing.Size(195, 23);
            this.FirstNametxt.TabIndex = 2;
            this.FirstNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.FirstNametxt.Validated += new System.EventHandler(this.ClearError);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Second Name";
            // 
            // SecondNametxt
            // 
            this.SecondNametxt.Location = new System.Drawing.Point(360, 68);
            this.SecondNametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SecondNametxt.Name = "SecondNametxt";
            this.SecondNametxt.Size = new System.Drawing.Size(195, 23);
            this.SecondNametxt.TabIndex = 3;
            this.SecondNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.SecondNametxt.Validated += new System.EventHandler(this.ClearError);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Third Name (Optional)";
            // 
            // ThirdNametxt
            // 
            this.ThirdNametxt.Location = new System.Drawing.Point(153, 125);
            this.ThirdNametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ThirdNametxt.Name = "ThirdNametxt";
            this.ThirdNametxt.Size = new System.Drawing.Size(195, 23);
            this.ThirdNametxt.TabIndex = 4;
            this.ThirdNametxt.Validated += new System.EventHandler(this.ClearError);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name";
            // 
            // LastNametxt
            // 
            this.LastNametxt.Location = new System.Drawing.Point(360, 125);
            this.LastNametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.Size = new System.Drawing.Size(195, 23);
            this.LastNametxt.TabIndex = 5;
            this.LastNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.LastNametxt.Validated += new System.EventHandler(this.ClearError);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date of birth:";
            // 
            // DateOfBirthtxt
            // 
            this.DateOfBirthtxt.Location = new System.Drawing.Point(153, 222);
            this.DateOfBirthtxt.MaxDate = new System.DateTime(2024, 10, 27, 0, 0, 0, 0);
            this.DateOfBirthtxt.MinDate = new System.DateTime(1924, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthtxt.Name = "DateOfBirthtxt";
            this.DateOfBirthtxt.Size = new System.Drawing.Size(195, 23);
            this.DateOfBirthtxt.TabIndex = 7;
            this.DateOfBirthtxt.Value = new System.DateTime(2024, 10, 27, 0, 0, 0, 0);
            this.DateOfBirthtxt.ValueChanged += new System.EventHandler(this.DateOfBirthtxt_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "National No:";
            // 
            // NationalNotxt
            // 
            this.NationalNotxt.Location = new System.Drawing.Point(153, 184);
            this.NationalNotxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NationalNotxt.Name = "NationalNotxt";
            this.NationalNotxt.Size = new System.Drawing.Size(195, 23);
            this.NationalNotxt.TabIndex = 6;
            this.NationalNotxt.TextChanged += new System.EventHandler(this.NumbersOnlyValidator);
            this.NationalNotxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.NationalNotxt.Validated += new System.EventHandler(this.ClearError);
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(153, 353);
            this.Phonetxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(193, 23);
            this.Phonetxt.TabIndex = 11;
            this.Phonetxt.TextChanged += new System.EventHandler(this.NumbersOnlyValidator);
            this.Phonetxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.Phonetxt.Validated += new System.EventHandler(this.ClearError);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phone:";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(153, 400);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(195, 23);
            this.Emailtxt.TabIndex = 12;
            this.Emailtxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCellValidation);
            this.Emailtxt.Validated += new System.EventHandler(this.ClearError);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 398);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email: ";
            // 
            // btnMale
            // 
            this.btnMale.AutoSize = true;
            this.btnMale.Location = new System.Drawing.Point(150, 263);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(51, 19);
            this.btnMale.TabIndex = 8;
            this.btnMale.TabStop = true;
            this.btnMale.Tag = "M";
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.CheckedChanged += new System.EventHandler(this.btnMale_CheckedChanged);
            // 
            // btnFemale
            // 
            this.btnFemale.AutoSize = true;
            this.btnFemale.Location = new System.Drawing.Point(285, 263);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(63, 19);
            this.btnFemale.TabIndex = 9;
            this.btnFemale.TabStop = true;
            this.btnFemale.Tag = "F";
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.CheckedChanged += new System.EventHandler(this.btnFemale_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 265);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Gender:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(387, 202);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Address";
            // 
            // AddressRtxt
            // 
            this.AddressRtxt.Location = new System.Drawing.Point(391, 226);
            this.AddressRtxt.Name = "AddressRtxt";
            this.AddressRtxt.Size = new System.Drawing.Size(392, 197);
            this.AddressRtxt.TabIndex = 13;
            this.AddressRtxt.Text = "";
            this.AddressRtxt.Validating += new System.ComponentModel.CancelEventHandler(this.AddressRtxt_Validating);
            this.AddressRtxt.Validated += new System.EventHandler(this.ClearError);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(704, 192);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 15);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "";
            this.linkLabel1.Text = "Set Image";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Country: ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(418, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 41);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.AddressRtxt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ProfilePic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CountriesList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FirstNametxt);
            this.groupBox1.Controls.Add(this.SecondNametxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ThirdNametxt);
            this.groupBox1.Controls.Add(this.btnFemale);
            this.groupBox1.Controls.Add(this.LastNametxt);
            this.groupBox1.Controls.Add(this.btnMale);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Emailtxt);
            this.groupBox1.Controls.Add(this.NationalNotxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Phonetxt);
            this.groupBox1.Controls.Add(this.DateOfBirthtxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 528);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(296, 465);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 41);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ProfilePic
            // 
            this.ProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfilePic.InitialImage = ((System.Drawing.Image)(resources.GetObject("ProfilePic.InitialImage")));
            this.ProfilePic.Location = new System.Drawing.Point(631, 44);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(132, 141);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 24;
            this.ProfilePic.TabStop = false;
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
            this.CountriesList.Location = new System.Drawing.Point(153, 306);
            this.CountriesList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CountriesList.Name = "CountriesList";
            this.CountriesList.Size = new System.Drawing.Size(195, 23);
            this.CountriesList.TabIndex = 10;
            this.CountriesList.EvIndexSelected += new System.Action<int>(this.CountriesList_EvIndexSelected);
            // 
            // AddNewPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddNewPersonCard";
            this.Size = new System.Drawing.Size(834, 536);
            this.Load += new System.EventHandler(this.AddNewPersonCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNumbersOnly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecondNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ThirdNametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastNametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateOfBirthtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NationalNotxt;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton btnMale;
        private System.Windows.Forms.RadioButton btnFemale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox AddressRtxt;
        private System.Windows.Forms.PictureBox ProfilePic;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ShowCountriesList CountriesList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errEmpty;
        private System.Windows.Forms.ErrorProvider errInvalidEmail;
        private System.Windows.Forms.ErrorProvider errNumbersOnly;
    }
}
