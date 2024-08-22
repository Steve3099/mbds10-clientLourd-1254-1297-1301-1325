namespace Troque
{
    partial class EchangeCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.owner = new System.Windows.Forms.Label();
            this.flowLayoutPanelOwner = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTaker = new System.Windows.Forms.FlowLayoutPanel();
            this.Taker = new System.Windows.Forms.Label();
            this.buttonAccepter = new System.Windows.Forms.Button();
            this.buttonRefuser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.flowLayoutPanelOwner);
            this.panel1.Controls.Add(this.owner);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 215);
            this.panel1.TabIndex = 0;
            // 
            // owner
            // 
            this.owner.AutoSize = true;
            this.owner.Location = new System.Drawing.Point(3, 0);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(43, 16);
            this.owner.TabIndex = 0;
            this.owner.Text = "User1";
            // 
            // flowLayoutPanelOwner
            // 
            this.flowLayoutPanelOwner.AutoScroll = true;
            this.flowLayoutPanelOwner.Location = new System.Drawing.Point(6, 49);
            this.flowLayoutPanelOwner.Name = "flowLayoutPanelOwner";
            this.flowLayoutPanelOwner.Size = new System.Drawing.Size(489, 163);
            this.flowLayoutPanelOwner.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.flowLayoutPanelTaker);
            this.panel2.Controls.Add(this.Taker);
            this.panel2.Location = new System.Drawing.Point(535, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 215);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanelTaker
            // 
            this.flowLayoutPanelTaker.AutoScroll = true;
            this.flowLayoutPanelTaker.Location = new System.Drawing.Point(6, 49);
            this.flowLayoutPanelTaker.Name = "flowLayoutPanelTaker";
            this.flowLayoutPanelTaker.Size = new System.Drawing.Size(489, 163);
            this.flowLayoutPanelTaker.TabIndex = 1;
            // 
            // Taker
            // 
            this.Taker.AutoSize = true;
            this.Taker.Location = new System.Drawing.Point(3, 0);
            this.Taker.Name = "Taker";
            this.Taker.Size = new System.Drawing.Size(43, 16);
            this.Taker.TabIndex = 0;
            this.Taker.Text = "User1";
            // 
            // buttonAccepter
            // 
            this.buttonAccepter.BackColor = System.Drawing.Color.Lime;
            this.buttonAccepter.Location = new System.Drawing.Point(363, 230);
            this.buttonAccepter.Name = "buttonAccepter";
            this.buttonAccepter.Size = new System.Drawing.Size(152, 28);
            this.buttonAccepter.TabIndex = 3;
            this.buttonAccepter.Text = "Accepter";
            this.buttonAccepter.UseVisualStyleBackColor = false;
            // 
            // buttonRefuser
            // 
            this.buttonRefuser.BackColor = System.Drawing.Color.Salmon;
            this.buttonRefuser.Location = new System.Drawing.Point(538, 230);
            this.buttonRefuser.Name = "buttonRefuser";
            this.buttonRefuser.Size = new System.Drawing.Size(152, 28);
            this.buttonRefuser.TabIndex = 4;
            this.buttonRefuser.Text = "Refuser";
            this.buttonRefuser.UseVisualStyleBackColor = false;
            // 
            // EchangeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.buttonRefuser);
            this.Controls.Add(this.buttonAccepter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EchangeCard";
            this.Size = new System.Drawing.Size(1062, 267);
            this.Load += new System.EventHandler(this.EchangeCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label owner;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOwner;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTaker;
        private System.Windows.Forms.Label Taker;
        private System.Windows.Forms.Button buttonAccepter;
        private System.Windows.Forms.Button buttonRefuser;
    }
}
