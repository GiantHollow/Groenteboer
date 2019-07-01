namespace Groenteboer
{
    partial class ucWinkelmandjeDisplay
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
            this.tbProductHoeveelheid = new System.Windows.Forms.TextBox();
            this.lblProductNaam = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbProductHoeveelheid
            // 
            this.tbProductHoeveelheid.Location = new System.Drawing.Point(73, 5);
            this.tbProductHoeveelheid.Name = "tbProductHoeveelheid";
            this.tbProductHoeveelheid.Size = new System.Drawing.Size(107, 20);
            this.tbProductHoeveelheid.TabIndex = 0;
            // 
            // lblProductNaam
            // 
            this.lblProductNaam.AutoSize = true;
            this.lblProductNaam.Location = new System.Drawing.Point(3, 9);
            this.lblProductNaam.Name = "lblProductNaam";
            this.lblProductNaam.Size = new System.Drawing.Size(62, 13);
            this.lblProductNaam.TabIndex = 1;
            this.lblProductNaam.Text = "Sample text";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(203, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(82, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Voeg toe";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(291, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Verwijder product";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ucWinkelmandjeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblProductNaam);
            this.Controls.Add(this.tbProductHoeveelheid);
            this.Name = "ucWinkelmandjeDisplay";
            this.Size = new System.Drawing.Size(407, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProductHoeveelheid;
        private System.Windows.Forms.Label lblProductNaam;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
    }
}
