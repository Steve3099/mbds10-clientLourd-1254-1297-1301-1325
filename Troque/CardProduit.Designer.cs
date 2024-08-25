namespace Troque
{
    partial class CardProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardProduit));
            this.labelNomProduit = new System.Windows.Forms.Label();
            this.labeldescription = new System.Windows.Forms.Label();
            this.labelcategorie = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.buttonMesProduits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomProduit
            // 
            this.labelNomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomProduit.Location = new System.Drawing.Point(2, 15);
            this.labelNomProduit.Name = "labelNomProduit";
            this.labelNomProduit.Size = new System.Drawing.Size(541, 27);
            this.labelNomProduit.TabIndex = 1;
            this.labelNomProduit.Text = "titre";
            this.labelNomProduit.Click += new System.EventHandler(this.nomProduit_Click);
            // 
            // labeldescription
            // 
            this.labeldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldescription.Location = new System.Drawing.Point(3, 68);
            this.labeldescription.Name = "labeldescription";
            this.labeldescription.Size = new System.Drawing.Size(334, 42);
            this.labeldescription.TabIndex = 2;
            this.labeldescription.Text = "Description";
            this.labeldescription.Click += new System.EventHandler(this.description_Click);
            // 
            // labelcategorie
            // 
            this.labelcategorie.AutoSize = true;
            this.labelcategorie.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelcategorie.Location = new System.Drawing.Point(5, 42);
            this.labelcategorie.Name = "labelcategorie";
            this.labelcategorie.Size = new System.Drawing.Size(80, 16);
            this.labelcategorie.TabIndex = 3;
            this.labelcategorie.Text = "categories : ";
            this.labelcategorie.Click += new System.EventHandler(this.label3_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.InitialImage")));
            this.pictureBoxImage.Location = new System.Drawing.Point(15, 20);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(124, 121);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.pictureBoxImage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 149);
            this.panel1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Honeydew;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(15, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 25);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.buttonMesProduits);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Details);
            this.panel2.Controls.Add(this.labelcategorie);
            this.panel2.Controls.Add(this.labeldescription);
            this.panel2.Controls.Add(this.labelNomProduit);
            this.panel2.Location = new System.Drawing.Point(159, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 121);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(441, 68);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(102, 42);
            this.Details.TabIndex = 6;
            this.Details.Text = "+ de produits";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // buttonMesProduits
            // 
            this.buttonMesProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonMesProduits.Location = new System.Drawing.Point(441, 15);
            this.buttonMesProduits.Name = "buttonMesProduits";
            this.buttonMesProduits.Size = new System.Drawing.Size(101, 42);
            this.buttonMesProduits.TabIndex = 8;
            this.buttonMesProduits.Text = "Mes Produits";
            this.buttonMesProduits.UseVisualStyleBackColor = false;
            this.buttonMesProduits.Click += new System.EventHandler(this.buttonMesProduits_Click);
            // 
            // CardProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CardProduit";
            this.Size = new System.Drawing.Size(733, 164);
            this.Load += new System.EventHandler(this.CardProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNomProduit;
        private System.Windows.Forms.Label labeldescription;
        private System.Windows.Forms.Label labelcategorie;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonMesProduits;
    }
}
