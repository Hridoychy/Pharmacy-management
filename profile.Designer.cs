namespace C_sh_project
{
    partial class profile
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
            this.namebox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.gmailBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.gmail = new System.Windows.Forms.Label();
            this.Editp = new System.Windows.Forms.Button();
            this.refress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(203, 43);
            this.namebox.Multiline = true;
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(127, 29);
            this.namebox.TabIndex = 0;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(203, 95);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(127, 25);
            this.phoneBox.TabIndex = 1;
            // 
            // gmailBox
            // 
            this.gmailBox.Location = new System.Drawing.Point(202, 141);
            this.gmailBox.Multiline = true;
            this.gmailBox.Name = "gmailBox";
            this.gmailBox.Size = new System.Drawing.Size(128, 31);
            this.gmailBox.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(133, 45);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(52, 18);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(129, 102);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(56, 18);
            this.phone.TabIndex = 4;
            this.phone.Text = "Phone";
            // 
            // gmail
            // 
            this.gmail.AutoSize = true;
            this.gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmail.Location = new System.Drawing.Point(127, 143);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(58, 18);
            this.gmail.TabIndex = 5;
            this.gmail.Text = "GMAIL";
            // 
            // Editp
            // 
            this.Editp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editp.Location = new System.Drawing.Point(162, 273);
            this.Editp.Name = "Editp";
            this.Editp.Size = new System.Drawing.Size(168, 50);
            this.Editp.TabIndex = 6;
            this.Editp.Text = "Edit Profile";
            this.Editp.UseVisualStyleBackColor = true;
            this.Editp.Click += new System.EventHandler(this.Editp_Click);
            // 
            // refress
            // 
            this.refress.Location = new System.Drawing.Point(385, 290);
            this.refress.Name = "refress";
            this.refress.Size = new System.Drawing.Size(90, 33);
            this.refress.TabIndex = 7;
            this.refress.Text = "refress";
            this.refress.UseVisualStyleBackColor = true;
            this.refress.Click += new System.EventHandler(this.refress_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refress);
            this.Controls.Add(this.Editp);
            this.Controls.Add(this.gmail);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.gmailBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.namebox);
           // this.Name = "profile";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox gmailBox;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label gmail;
        private System.Windows.Forms.Button Editp;
        private System.Windows.Forms.Button refress;
    }
}