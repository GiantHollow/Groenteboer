namespace Groenteboer
{
    partial class frmGroenten
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
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNaarFruit = new System.Windows.Forms.Button();
            this.btnNaarWinkelmandje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductPanel
            // 
            this.ProductPanel.Location = new System.Drawing.Point(2, 2);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(660, 364);
            this.ProductPanel.TabIndex = 1;
            // 
            // btnNaarFruit
            // 
            this.btnNaarFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaarFruit.Location = new System.Drawing.Point(12, 407);
            this.btnNaarFruit.Name = "btnNaarFruit";
            this.btnNaarFruit.Size = new System.Drawing.Size(185, 31);
            this.btnNaarFruit.TabIndex = 2;
            this.btnNaarFruit.Text = "Naar fruit";
            this.btnNaarFruit.UseVisualStyleBackColor = true;
            this.btnNaarFruit.Click += new System.EventHandler(this.btnNaarFruit_Click);
            // 
            // btnNaarWinkelmandje
            // 
            this.btnNaarWinkelmandje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaarWinkelmandje.Location = new System.Drawing.Point(467, 407);
            this.btnNaarWinkelmandje.Name = "btnNaarWinkelmandje";
            this.btnNaarWinkelmandje.Size = new System.Drawing.Size(185, 31);
            this.btnNaarWinkelmandje.TabIndex = 3;
            this.btnNaarWinkelmandje.Text = "Naar winkelmandje";
            this.btnNaarWinkelmandje.UseVisualStyleBackColor = true;
            // 
            // frmGroenten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.btnNaarWinkelmandje);
            this.Controls.Add(this.btnNaarFruit);
            this.Controls.Add(this.ProductPanel);
            this.Name = "frmGroenten";
            this.Text = "Groenten";
            this.Load += new System.EventHandler(this.frmGroenten_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private System.Windows.Forms.Button btnNaarFruit;
        private System.Windows.Forms.Button btnNaarWinkelmandje;
    }
}

