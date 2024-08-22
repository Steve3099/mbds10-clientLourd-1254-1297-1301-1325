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
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelMe = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Deliveryaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelHe
            // 
            this.flowLayoutPanelHe.AutoScroll = true;
            this.flowLayoutPanelHe.Location = new System.Drawing.Point(529, 86);
            this.flowLayoutPanelHe.Name = "flowLayoutPanelHe";
            this.flowLayoutPanelHe.Size = new System.Drawing.Size(554, 408);
            this.flowLayoutPanelHe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes Produits";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "les Produits de ";
            // 
            // flowLayoutPanelMe
            // 
            this.flowLayoutPanelMe.AutoScroll = true;
            this.flowLayoutPanelMe.Location = new System.Drawing.Point(-2, 85);
            this.flowLayoutPanelMe.Name = "flowLayoutPanelMe";
            this.flowLayoutPanelMe.Size = new System.Drawing.Size(533, 408);
            this.flowLayoutPanelMe.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(433, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "proposer echange";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deliveryaddress
            // 
            this.Deliveryaddress.Location = new System.Drawing.Point(157, 15);
            this.Deliveryaddress.Name = "Deliveryaddress";
            this.Deliveryaddress.Size = new System.Drawing.Size(336, 22);
            this.Deliveryaddress.TabIndex = 6;
            this.Deliveryaddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adresse de livraison";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CreateEchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Deliveryaddress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanelMe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelHe);
            this.Name = "CreateEchange";
            this.Text = "CreateEchange";
            this.Load += new System.EventHandler(this.CreateEchange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Deliveryaddress;
        private System.Windows.Forms.Label label3;
    }
}