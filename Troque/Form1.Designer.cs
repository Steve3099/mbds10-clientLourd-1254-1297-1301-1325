namespace Troque
{
    partial class Form1
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
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.inscription = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(43, 24);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(267, 22);
            this.textBoxemail.TabIndex = 0;
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(43, 80);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(267, 22);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(131, 147);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 29);
            this.Login.TabIndex = 2;
            this.Login.Text = "login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // inscription
            // 
            this.inscription.Location = new System.Drawing.Point(208, 117);
            this.inscription.Name = "inscription";
            this.inscription.Size = new System.Drawing.Size(101, 30);
            this.inscription.TabIndex = 3;
            this.inscription.Text = "s\'inscrire";
            this.inscription.UseVisualStyleBackColor = true;
            this.inscription.Click += new System.EventHandler(this.inscription_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.inscription);
            this.groupBoxLogin.Controls.Add(this.Login);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.textBoxemail);
            this.groupBoxLogin.Location = new System.Drawing.Point(217, 123);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(349, 199);
            this.groupBoxLogin.TabIndex = 4;
            this.groupBoxLogin.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(155)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button inscription;
        private System.Windows.Forms.GroupBox groupBoxLogin;
    }
}

