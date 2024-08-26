namespace Troque
{
    partial class CreateEchange
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
            this.flowLayoutPanelHe = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOtherUser = new System.Windows.Forms.Label();
            this.flowLayoutPanelMe = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Deliveryaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelHe
            // 
            this.flowLayoutPanelHe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelHe.AutoScroll = true;
            this.flowLayoutPanelHe.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelHe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelHe.Location = new System.Drawing.Point(754, 86);
            this.flowLayoutPanelHe.Name = "flowLayoutPanelHe";
            this.flowLayoutPanelHe.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelHe.Size = new System.Drawing.Size(777, 512);
            this.flowLayoutPanelHe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes Produits";
            // 
            // labelOtherUser
            // 
            this.labelOtherUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOtherUser.AutoSize = true;
            this.labelOtherUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherUser.Location = new System.Drawing.Point(1028, 61);
            this.labelOtherUser.Name = "labelOtherUser";
            this.labelOtherUser.Size = new System.Drawing.Size(156, 28);
            this.labelOtherUser.TabIndex = 3;
            this.labelOtherUser.Text = "Les Produits de";
            // 
            // flowLayoutPanelMe
            // 
            this.flowLayoutPanelMe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelMe.AutoScroll = true;
            this.flowLayoutPanelMe.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelMe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMe.Location = new System.Drawing.Point(0, 86);
            this.flowLayoutPanelMe.Name = "flowLayoutPanelMe";
            this.flowLayoutPanelMe.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelMe.Size = new System.Drawing.Size(748, 512);
            this.flowLayoutPanelMe.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(648, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Proposer Échange";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deliveryaddress
            // 
            this.Deliveryaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Deliveryaddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Deliveryaddress.Location = new System.Drawing.Point(202, 8);
            this.Deliveryaddress.Name = "Deliveryaddress";
            this.Deliveryaddress.Size = new System.Drawing.Size(336, 30);
            this.Deliveryaddress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adresse de livraison";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightGray;
            this.panelHeader.Controls.Add(this.Deliveryaddress);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1531, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.LightGray;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 604);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1531, 46);
            this.panelFooter.TabIndex = 1;
            // 
            // CreateEchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1531, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanelMe);
            this.Controls.Add(this.labelOtherUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelHe);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Name = "CreateEchange";
            this.Text = "Create Echange";
            this.Load += new System.EventHandler(this.CreateEchange_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOtherUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Deliveryaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
    }
}
