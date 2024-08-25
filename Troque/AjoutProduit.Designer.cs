namespace Troque
{
    partial class AjoutProduit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBoxCategory = new System.Windows.Forms.CheckedListBox();
            this.bt_ajoutproduit = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxNomProduit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkedListBoxCategory);
            this.panel1.Controls.Add(this.bt_ajoutproduit);
            this.panel1.Controls.Add(this.richTextBoxDescription);
            this.panel1.Controls.Add(this.textBoxNomProduit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 633);
            this.panel1.TabIndex = 0;
            // 
            // checkedListBoxCategory
            // 
            this.checkedListBoxCategory.FormattingEnabled = true;
            this.checkedListBoxCategory.Location = new System.Drawing.Point(91, 450);
            this.checkedListBoxCategory.Name = "checkedListBoxCategory";
            this.checkedListBoxCategory.Size = new System.Drawing.Size(299, 106);
            this.checkedListBoxCategory.TabIndex = 4;
            // 
            // bt_ajoutproduit
            // 
            this.bt_ajoutproduit.Location = new System.Drawing.Point(173, 572);
            this.bt_ajoutproduit.Name = "bt_ajoutproduit";
            this.bt_ajoutproduit.Size = new System.Drawing.Size(106, 49);
            this.bt_ajoutproduit.TabIndex = 3;
            this.bt_ajoutproduit.Text = "Ajouter";
            this.bt_ajoutproduit.UseVisualStyleBackColor = true;
            this.bt_ajoutproduit.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(91, 302);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(299, 101);
            this.richTextBoxDescription.TabIndex = 1;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxNomProduit
            // 
            this.textBoxNomProduit.Location = new System.Drawing.Point(91, 71);
            this.textBoxNomProduit.Name = "textBoxNomProduit";
            this.textBoxNomProduit.Size = new System.Drawing.Size(299, 22);
            this.textBoxNomProduit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom du produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description du produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ajout de produit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(97, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 114);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "upload image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 633);
            this.Controls.Add(this.panel1);
            this.Name = "AjoutProduit";
            this.Text = "AjoutProduit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNomProduit;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button bt_ajoutproduit;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}