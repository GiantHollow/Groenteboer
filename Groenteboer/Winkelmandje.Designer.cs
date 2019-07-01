namespace Groenteboer
{
    partial class Winkelmandje
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
            this.btnAfrekenen = new System.Windows.Forms.Button();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.btnNaarFruit = new System.Windows.Forms.Button();
            this.btnNaarGroente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfrekenen
            // 
            this.btnAfrekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfrekenen.Location = new System.Drawing.Point(677, 405);
            this.btnAfrekenen.Name = "btnAfrekenen";
            this.btnAfrekenen.Size = new System.Drawing.Size(111, 33);
            this.btnAfrekenen.TabIndex = 0;
            this.btnAfrekenen.Text = "Afrekenen";
            this.btnAfrekenen.UseVisualStyleBackColor = true;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijs.Location = new System.Drawing.Point(586, 409);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(63, 24);
            this.lblPrijs.TabIndex = 1;
            this.lblPrijs.Text = "Empty";
            // 
            // btnNaarFruit
            // 
            this.btnNaarFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaarFruit.Location = new System.Drawing.Point(169, 409);
            this.btnNaarFruit.Name = "btnNaarFruit";
            this.btnNaarFruit.Size = new System.Drawing.Size(133, 33);
            this.btnNaarFruit.TabIndex = 2;
            this.btnNaarFruit.Text = "Naar fruit";
            this.btnNaarFruit.UseVisualStyleBackColor = true;
            this.btnNaarFruit.Click += new System.EventHandler(this.btnNaarFruit_Click);
            // 
            // btnNaarGroente
            // 
            this.btnNaarGroente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaarGroente.Location = new System.Drawing.Point(12, 409);
            this.btnNaarGroente.Name = "btnNaarGroente";
            this.btnNaarGroente.Size = new System.Drawing.Size(133, 33);
            this.btnNaarGroente.TabIndex = 3;
            this.btnNaarGroente.Text = "Naar groente";
            this.btnNaarGroente.UseVisualStyleBackColor = true;
            this.btnNaarGroente.Click += new System.EventHandler(this.btnNaarGroente_Click);
            // 
            // Winkelmandje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNaarGroente);
            this.Controls.Add(this.btnNaarFruit);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.btnAfrekenen);
            this.Name = "Winkelmandje";
            this.Text = "Winkelmandje";
            this.Load += new System.EventHandler(this.Winkelmandje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfrekenen;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Button btnNaarFruit;
        private System.Windows.Forms.Button btnNaarGroente;
    }
}