namespace C_sh_project
{
    partial class Edit_profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.naBox = new System.Windows.Forms.TextBox();
            this.phBox = new System.Windows.Forms.TextBox();
            this.gmBox = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gmail";
            // 
            // naBox
            // 
            this.naBox.Location = new System.Drawing.Point(330, 91);
            this.naBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.naBox.Name = "naBox";
            this.naBox.Size = new System.Drawing.Size(132, 21);
            this.naBox.TabIndex = 3;
            // 
            // phBox
            // 
            this.phBox.Location = new System.Drawing.Point(330, 153);
            this.phBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phBox.Name = "phBox";
            this.phBox.Size = new System.Drawing.Size(132, 21);
            this.phBox.TabIndex = 4;
            // 
            // gmBox
            // 
            this.gmBox.Location = new System.Drawing.Point(330, 218);
            this.gmBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gmBox.Name = "gmBox";
            this.gmBox.Size = new System.Drawing.Size(132, 21);
            this.gmBox.TabIndex = 5;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(298, 333);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(166, 42);
            this.Update.TabIndex = 6;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Edit_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::C_sh_project.Properties.Resources.medical_logo;
            this.ClientSize = new System.Drawing.Size(896, 445);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.gmBox);
            this.Controls.Add(this.phBox);
            this.Controls.Add(this.naBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Edit_profile";
            this.Text = "Edit_profile";
            this.Load += new System.EventHandler(this.Edit_profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox naBox;
        private System.Windows.Forms.TextBox phBox;
        private System.Windows.Forms.TextBox gmBox;
        private System.Windows.Forms.Button Update;
    }
}