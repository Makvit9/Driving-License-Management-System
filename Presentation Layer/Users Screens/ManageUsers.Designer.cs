namespace Presentation_Layer.Users_Screens
{
    partial class ManageUsers
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ComboFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 9;
            // 
            // ComboFilter
            // 
            this.ComboFilter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ComboFilter.FormattingEnabled = true;
            this.ComboFilter.Location = new System.Drawing.Point(71, 155);
            this.ComboFilter.Name = "ComboFilter";
            this.ComboFilter.Size = new System.Drawing.Size(134, 21);
            this.ComboFilter.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter By:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(944, 513);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(787, 155);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(136, 28);
            this.btnNewUser.TabIndex = 10;
            this.btnNewUser.Text = "Add New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(944, 723);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ComboFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox ComboFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewUser;
    }
}