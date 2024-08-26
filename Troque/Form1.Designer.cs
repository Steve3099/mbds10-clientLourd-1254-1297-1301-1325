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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backStageView1 = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.inscription = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Error = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 51);
            this.panel1.TabIndex = 5;
            // 
            // backStageView1
            // 
            this.backStageView1.BackStage = null;
            this.backStageView1.HostControl = null;
            this.backStageView1.HostForm = this;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 447);
            this.panel2.TabIndex = 6;
            // 
            // inscription
            // 
            this.inscription.BackColor = System.Drawing.Color.Black;
            this.inscription.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.inscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inscription.Location = new System.Drawing.Point(429, 286);
            this.inscription.Name = "inscription";
            this.inscription.Size = new System.Drawing.Size(147, 30);
            this.inscription.TabIndex = 3;
            this.inscription.Text = "s\'inscrire";
            this.inscription.UseVisualStyleBackColor = false;
            this.inscription.Click += new System.EventHandler(this.inscription_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Black;
            this.Login.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Lime;
            this.Login.Location = new System.Drawing.Point(275, 322);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(141, 57);
            this.Login.TabIndex = 2;
            this.Login.Text = "login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            this.Login.MouseEnter += new System.EventHandler(this.Login_MouseEnter);
            this.Login.MouseLeave += new System.EventHandler(this.Login_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(299, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBoxemail);
            this.panel4.Location = new System.Drawing.Point(98, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(478, 81);
            this.panel4.TabIndex = 7;
            // 
            // textBoxemail
            // 
            this.textBoxemail.BackColor = System.Drawing.Color.Black;
            this.textBoxemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxemail.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxemail.Location = new System.Drawing.Point(137, 19);
            this.textBoxemail.Multiline = true;
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(277, 29);
            this.textBoxemail.TabIndex = 0;
            this.textBoxemail.Text = "perdo-alvarez@it-univerisity.mg";
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(137, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(326, 3);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.textBoxPassword);
            this.panel6.Location = new System.Drawing.Point(98, 201);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(478, 59);
            this.panel6.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPassword.Location = new System.Drawing.Point(137, 18);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(326, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "motdepasse";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(40, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(137, 44);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(326, 3);
            this.panel7.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(466, 313);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(70, 3);
            this.panel8.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.Error);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Login);
            this.panel3.Controls.Add(this.inscription);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(259, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 447);
            this.panel3.TabIndex = 7;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(176, 263);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(251, 20);
            this.Error.TabIndex = 11;
            this.Error.Text = "Email ou mot de passe incorrect";
            this.Error.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(155)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(924, 498);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.BackStageView backStageView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button inscription;
        private System.Windows.Forms.Label Error;
    }
}

