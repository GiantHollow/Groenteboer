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
            this.ucProductDisplay1 = new Groenteboer.ucProductDisplay();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNaarFruit = new System.Windows.Forms.Button();
            this.btnNaarWinkelmandje = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucProductDisplay1
            // 
            this.ucProductDisplay1.Location = new System.Drawing.Point(5, 5);
            this.ucProductDisplay1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucProductDisplay1.Name = "ucProductDisplay1";
            this.ucProductDisplay1.Size = new System.Drawing.Size(164, 257);
            this.ucProductDisplay1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucProductDisplay1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(880, 448);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnNaarFruit
            // 
            this.btnNaarFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaarFruit.Location = new System.Drawing.Point(16, 501);
            this.btnNaarFruit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNaarFruit.Name = "btnNaarFruit";
            this.btnNaarFruit.Size = new System.Drawing.Size(247, 38);
            this.btnNaarFruit.TabIndex = 2;
            this.btnNaarFruit.Text = "Naar fruit";
            this.btnNaarFruit.UseVisualStyleBackColor = true;
            this.btnNaarFruit.Click += new System.EventHandler(this.btnNaarFruit_Click);
            // 
            // btnNaarWinkelmandje
            // 
            this.btnNaarWinkelmandje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaarWinkelmandje.Location = new System.Drawing.Point(623, 501);
            this.btnNaarWinkelmandje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNaarWinkelmandje.Name = "btnNaarWinkelmandje";
            this.btnNaarWinkelmandje.Size = new System.Drawing.Size(247, 38);
            this.btnNaarWinkelmandje.TabIndex = 3;
            this.btnNaarWinkelmandje.Text = "Naar winkelmandje";
            this.btnNaarWinkelmandje.UseVisualStyleBackColor = true;
            // 
            // frmGroenten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 554);
            this.Controls.Add(this.btnNaarWinkelmandje);
            this.Controls.Add(this.btnNaarFruit);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGroenten";
            this.Text = "Groenten";
            this.Load += new System.EventHandler(this.frmGroenten_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucProductDisplay ucProductDisplay1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNaarFruit;
        private System.Windows.Forms.Button btnNaarWinkelmandje;
    }
}

