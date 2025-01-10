namespace UAS_DB_PamerYuk.F3_Chat.View
{
    partial class SingleContactUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleContactUC));
            this.lblNamaKontak = new System.Windows.Forms.Label();
            this.pPictPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblNamaKontak
            // 
            this.lblNamaKontak.AutoSize = true;
            this.lblNamaKontak.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNamaKontak.ForeColor = System.Drawing.Color.White;
            this.lblNamaKontak.Location = new System.Drawing.Point(65, 25);
            this.lblNamaKontak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaKontak.Name = "lblNamaKontak";
            this.lblNamaKontak.Size = new System.Drawing.Size(77, 13);
            this.lblNamaKontak.TabIndex = 11;
            this.lblNamaKontak.Text = "Hasil Generate";
            // 
            // pPictPanel
            // 
            this.pPictPanel.BackColor = System.Drawing.Color.Transparent;
            this.pPictPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pPictPanel.BackgroundImage")));
            this.pPictPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPictPanel.Location = new System.Drawing.Point(8, 8);
            this.pPictPanel.Name = "pPictPanel";
            this.pPictPanel.Size = new System.Drawing.Size(46, 46);
            this.pPictPanel.TabIndex = 10;
            // 
            // SingleContactUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNamaKontak);
            this.Controls.Add(this.pPictPanel);
            this.Name = "SingleContactUC";
            this.Size = new System.Drawing.Size(364, 60);
            this.Load += new System.EventHandler(this.SingleContactUC_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SingleContactUC_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNamaKontak;
        public System.Windows.Forms.Panel pPictPanel;
    }
}
