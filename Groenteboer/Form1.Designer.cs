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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(633, 361);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // frmGroenten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmGroenten";
            this.Text = "Groenten";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucProductDisplay ucProductDisplay1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

