﻿namespace C_sh_project
{
    partial class loGIN
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
            this.userBox = new System.Windows.Forms.TextBox();
            this.passsBox = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Button();
            this.Sign = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(493, 125);
            this.userBox.Multiline = true;
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(125, 32);
            this.userBox.TabIndex = 0;
            // 
            // passsBox
            // 
            this.passsBox.Location = new System.Drawing.Point(493, 177);
            this.passsBox.Multiline = true;
            this.passsBox.Name = "passsBox";
            this.passsBox.PasswordChar = 'S';
            this.passsBox.Size = new System.Drawing.Size(125, 29);
            this.passsBox.TabIndex = 1;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(493, 307);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(85, 43);
            this.log.TabIndex = 2;
            this.log.Text = "LOGIN";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // Sign
            // 
            this.Sign.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sign.Location = new System.Drawing.Point(618, 307);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(82, 43);
            this.Sign.TabIndex = 3;
            this.Sign.Text = "SIGN UP";
            this.Sign.UseVisualStyleBackColor = false;
            this.Sign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.GrayText;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(358, 307);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(89, 40);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "PASSWORD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_sh_project.Properties.Resources.medical_logo;
            this.pictureBox1.Location = new System.Drawing.Point(44, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(291, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 63);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Welcome";
            // 
            // loGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.log);
            this.Controls.Add(this.passsBox);
            this.Controls.Add(this.userBox);
            this.Name = "loGIN";
            this.Load += new System.EventHandler(this.loGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox userBox;
        public System.Windows.Forms.TextBox passsBox;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button Sign;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

