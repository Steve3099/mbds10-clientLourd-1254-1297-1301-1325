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
            this.flowLayoutPanelOwner = new System.Windows.Forms.FlowLayoutPanel();
            this.owner = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTaker = new System.Windows.Forms.FlowLayoutPanel();
            this.Taker = new System.Windows.Forms.Label();
            this.buttonAccepter = new System.Windows.Forms.Button();
            this.buttonRefuser = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.buttonReceived = new System.Windows.Forms.Button();
            this.buttonrecevoir = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(626, 275);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanelOwner
            // 
            this.flowLayoutPanelOwner.AutoScroll = true;
            this.flowLayoutPanelOwner.Location = new System.Drawing.Point(6, 49);
            this.flowLayoutPanelOwner.Name = "flowLayoutPanelOwner";
            this.flowLayoutPanelOwner.Size = new System.Drawing.Size(597, 203);
            this.flowLayoutPanelOwner.TabIndex = 1;
            // 
            // owner
            // 
            this.owner.AutoSize = true;
            this.owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner.Location = new System.Drawing.Point(284, 0);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(54, 20);
            this.owner.TabIndex = 0;
            this.owner.Text = "User1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.flowLayoutPanelTaker);
            this.panel2.Controls.Add(this.Taker);
            this.panel2.Location = new System.Drawing.Point(674, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 275);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanelTaker
            // 
            this.flowLayoutPanelTaker.AutoScroll = true;
            this.flowLayoutPanelTaker.Location = new System.Drawing.Point(6, 49);
            this.flowLayoutPanelTaker.Name = "flowLayoutPanelTaker";
            this.flowLayoutPanelTaker.Size = new System.Drawing.Size(685, 203);
            this.flowLayoutPanelTaker.TabIndex = 1;
            // 
            // Taker
            // 
            this.Taker.AutoSize = true;
            this.Taker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taker.Location = new System.Drawing.Point(287, 0);
            this.Taker.Name = "Taker";
            this.Taker.Size = new System.Drawing.Size(54, 20);
            this.Taker.TabIndex = 0;
            this.Taker.Text = "User1";
            this.Taker.Click += new System.EventHandler(this.Taker_Click_1);
            // 
            // buttonAccepter
            // 
            this.buttonAccepter.BackColor = System.Drawing.Color.Lime;
            this.buttonAccepter.Location = new System.Drawing.Point(494, 313);
            this.buttonAccepter.Name = "buttonAccepter";
            this.buttonAccepter.Size = new System.Drawing.Size(152, 28);
            this.buttonAccepter.TabIndex = 3;
            this.buttonAccepter.Text = "Accepter";
            this.buttonAccepter.UseVisualStyleBackColor = false;
            this.buttonAccepter.Click += new System.EventHandler(this.buttonAccepter_Click);
            // 
            // buttonRefuser
            // 
            this.buttonRefuser.BackColor = System.Drawing.Color.Salmon;
            this.buttonRefuser.Location = new System.Drawing.Point(674, 313);
            this.buttonRefuser.Name = "buttonRefuser";
            this.buttonRefuser.Size = new System.Drawing.Size(152, 28);
            this.buttonRefuser.TabIndex = 4;
            this.buttonRefuser.Text = "Refuser";
            this.buttonRefuser.UseVisualStyleBackColor = false;
            this.buttonRefuser.Click += new System.EventHandler(this.buttonRefuser_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(628, 7);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(64, 25);
            this.Status.TabIndex = 2;
            this.Status.Text = "label1";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // buttonReceived
            // 
            this.buttonReceived.Location = new System.Drawing.Point(0, 0);
            this.buttonReceived.Name = "buttonReceived";
            this.buttonReceived.Size = new System.Drawing.Size(75, 23);
            this.buttonReceived.TabIndex = 0;
            // 
            // buttonrecevoir
            // 
            this.buttonrecevoir.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonrecevoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrecevoir.Location = new System.Drawing.Point(575, 354);
            this.buttonrecevoir.Name = "buttonrecevoir";
            this.buttonrecevoir.Size = new System.Drawing.Size(166, 31);
            this.buttonrecevoir.TabIndex = 5;
            this.buttonrecevoir.Text = "recevoir";
            this.buttonrecevoir.UseVisualStyleBackColor = false;
            this.buttonrecevoir.Click += new System.EventHandler(this.buttonrecevoir_Click);
            // 
            // EchangeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.buttonrecevoir);
            this.Controls.Add(this.buttonReceived);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.buttonRefuser);
            this.Controls.Add(this.buttonAccepter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EchangeCard";
            this.Size = new System.Drawing.Size(1291, 388);
            this.Load += new System.EventHandler(this.EchangeCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button buttonReceived;
        private System.Windows.Forms.Button buttonrecevoir;
    }
}
