namespace Troque
{
    partial class Rating
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
            Syncfusion.Windows.Forms.Tools.CustomImageCollection customImageCollection5 = new Syncfusion.Windows.Forms.Tools.CustomImageCollection();
            Syncfusion.Windows.Forms.Tools.ResetButton resetButton5 = new Syncfusion.Windows.Forms.Tools.ResetButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ratingControl1 = new Syncfusion.Windows.Forms.Tools.RatingControl();
            this.label1 = new System.Windows.Forms.Label();
            this.Commentaire = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Commentaire);
            this.panel1.Controls.Add(this.ratingControl1);
            this.panel1.Location = new System.Drawing.Point(27, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 205);
            this.panel1.TabIndex = 0;
            // 
            // ratingControl1
            // 
            this.ratingControl1.Images = customImageCollection5;
            this.ratingControl1.Location = new System.Drawing.Point(27, 145);
            this.ratingControl1.Name = "ratingControl1";
            this.ratingControl1.ResetButton = resetButton5;
            this.ratingControl1.Size = new System.Drawing.Size(186, 35);
            this.ratingControl1.TabIndex = 0;
            this.ratingControl1.Text = "ratingControl1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "rate the user";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Commentaire
            // 
            this.Commentaire.Location = new System.Drawing.Point(27, 24);
            this.Commentaire.Name = "Commentaire";
            this.Commentaire.Size = new System.Drawing.Size(299, 95);
            this.Commentaire.TabIndex = 1;
            this.Commentaire.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Commentaire";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Rating";
            this.Text = "Rating";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.RatingControl ratingControl1;
        private System.Windows.Forms.RichTextBox Commentaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}