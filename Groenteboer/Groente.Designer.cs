﻿namespace Groenteboer
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
            this.ucProductDisplay1.Location = new System.Drawing.Point(3, 3);
            this.ucProductDisplay1.Name = "ucProductDisplay1";
            this.ucProductDisplay1.Size = new System.Drawing.Size(123, 209);
            this.ucProductDisplay1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucProductDisplay1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(660, 364);
            this.flowLayoutPanel1.TabIndex = 1;
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
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmGroenten";
            this.Text = "Groenten";
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

