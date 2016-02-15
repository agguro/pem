namespace PEM
{
    partial class IC
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
            this.captionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // captionLabel
            // 
            this.captionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captionLabel.Location = new System.Drawing.Point(0, 0);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(139, 94);
            this.captionLabel.TabIndex = 0;
            this.captionLabel.Text = "CAPTION";
            this.captionLabel.Click += new System.EventHandler(this.captionLabel_Click);
            // 
            // IC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.captionLabel);
            this.Name = "IC";
            this.Size = new System.Drawing.Size(139, 94);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label captionLabel;
    }
}
