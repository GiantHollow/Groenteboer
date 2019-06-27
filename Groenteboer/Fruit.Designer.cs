namespace Groenteboer
{
    partial class Fruit
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
            this.btnNaarGroente = new System.Windows.Forms.Button();
            this.btnNaarWinkelmandje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNaarGroente
            // 
            this.btnNaarGroente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaarGroente.Location = new System.Drawing.Point(12, 405);
            this.btnNaarGroente.Name = "btnNaarGroente";
            this.btnNaarGroente.Size = new System.Drawing.Size(179, 33);
            this.btnNaarGroente.TabIndex = 0;
            this.btnNaarGroente.Text = "Naar groente";
            this.btnNaarGroente.UseVisualStyleBackColor = true;
            // 
            // btnNaarWinkelmandje
            // 
            this.btnNaarWinkelmandje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaarWinkelmandje.Location = new System.Drawing.Point(609, 405);
            this.btnNaarWinkelmandje.Name = "btnNaarWinkelmandje";
            this.btnNaarWinkelmandje.Size = new System.Drawing.Size(179, 33);
            this.btnNaarWinkelmandje.TabIndex = 1;
            this.btnNaarWinkelmandje.Text = "Naar winkelmandje";
            this.btnNaarWinkelmandje.UseVisualStyleBackColor = true;
            // 
            // Fruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNaarWinkelmandje);
            this.Controls.Add(this.btnNaarGroente);
            this.Name = "Fruit";
            this.Text = "Fruit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNaarGroente;
        private System.Windows.Forms.Button btnNaarWinkelmandje;
    }
}