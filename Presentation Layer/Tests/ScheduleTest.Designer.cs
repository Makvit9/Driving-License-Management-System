namespace Presentation_Layer.Tests
{
    partial class ScheduleTest
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
            this.testScheduleControl1 = new Presentation_Layer.Tests.User_Controls.TestScheduleControl();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testScheduleControl1
            // 
            this.testScheduleControl1.BackColor = System.Drawing.Color.White;
            this.testScheduleControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testScheduleControl1.Location = new System.Drawing.Point(14, 14);
            this.testScheduleControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.testScheduleControl1.Name = "testScheduleControl1";
            this.testScheduleControl1.Size = new System.Drawing.Size(498, 684);
            this.testScheduleControl1.TabIndex = 0;
            this.testScheduleControl1.TestTypeID = BL.TestType.enTestType.VisionTest;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(175, 717);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 772);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.testScheduleControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScheduleTest";
            this.Text = "ScheduleTest";
            this.Load += new System.EventHandler(this.ScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.TestScheduleControl testScheduleControl1;
        private System.Windows.Forms.Button btnExit;
    }
}