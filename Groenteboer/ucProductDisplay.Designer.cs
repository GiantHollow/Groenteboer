namespace Groenteboer
{
    partial class ucProductDisplay
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
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.lblProductNaam = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.btnWinkelmand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProduct
            // 
            this.pbProduct.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbProduct.Location = new System.Drawing.Point(4, 4);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(115, 116);
            this.pbProduct.TabIndex = 0;
            this.pbProduct.TabStop = false;
            // 
            // lblProductNaam
            // 
            this.lblProductNaam.AutoSize = true;
            this.lblProductNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNaam.Location = new System.Drawing.Point(3, 123);
            this.lblProductNaam.Name = "lblProductNaam";
            this.lblProductNaam.Size = new System.Drawing.Size(106, 16);
            this.lblProductNaam.TabIndex = 1;
            this.lblProductNaam.Text = "Sample Text boi";
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijs.Location = new System.Drawing.Point(3, 139);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(47, 16);
            this.lblPrijs.TabIndex = 2;
            this.lblPrijs.Text = "Prijs: €";
            // 
            // btnWinkelmand
            // 
            this.btnWinkelmand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWinkelmand.Location = new System.Drawing.Point(4, 158);
            this.btnWinkelmand.Name = "btnWinkelmand";
            this.btnWinkelmand.Size = new System.Drawing.Size(115, 48);
            this.btnWinkelmand.TabIndex = 3;
            this.btnWinkelmand.Text = "Toevoegen aan winkelmand";
            this.btnWinkelmand.UseVisualStyleBackColor = true;
            this.btnWinkelmand.Click += new System.EventHandler(this.btnWinkelmand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // ucProductDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWinkelmand);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblProductNaam);
            this.Controls.Add(this.pbProduct);
            this.Name = "ucProductDisplay";
            this.Size = new System.Drawing.Size(123, 209);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Label lblProductNaam;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Button btnWinkelmand;
        private System.Windows.Forms.Label label1;
    }
}
