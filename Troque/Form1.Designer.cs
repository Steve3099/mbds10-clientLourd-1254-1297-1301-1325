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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxemail
            // 
            this.textBoxemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxemail.Location = new System.Drawing.Point(43, 38);
            this.textBoxemail.Multiline = true;
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(277, 29);
            this.textBoxemail.TabIndex = 0;
            this.textBoxemail.Text = "perdo-alvarez@it-univerisity.mg";
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(43, 89);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(277, 27);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "motdepasse";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(93, 166);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(141, 57);
            this.Login.TabIndex = 2;
            this.Login.Text = "login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // inscription
            // 
            this.inscription.Location = new System.Drawing.Point(184, 130);
            this.inscription.Name = "inscription";
            this.inscription.Size = new System.Drawing.Size(136, 30);
            this.inscription.TabIndex = 3;
            this.inscription.Text = "s\'inscrire";
            this.inscription.UseVisualStyleBackColor = true;
            this.inscription.Click += new System.EventHandler(this.inscription_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.inscription);
            this.groupBoxLogin.Controls.Add(this.Login);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.textBoxemail);
            this.groupBoxLogin.Location = new System.Drawing.Point(219, 115);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(357, 229);
            this.groupBoxLogin.TabIndex = 4;
            this.groupBoxLogin.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(61, 4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
    }
}

