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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pPictPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.pPictPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(19, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(46, 3);
            this.panel6.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(21, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(46, 3);
            this.panel5.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(19, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 46);
            this.panel4.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(65, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 46);
            this.panel3.TabIndex = 26;
            // 
            // pPictPanel
            // 
            this.pPictPanel.BackColor = System.Drawing.Color.Transparent;
            this.pPictPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pPictPanel.BackgroundImage")));
            this.pPictPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPictPanel.Controls.Add(this.pictureBox2);
            this.pPictPanel.Location = new System.Drawing.Point(21, 7);
            this.pPictPanel.Name = "pPictPanel";
            this.pPictPanel.Size = new System.Drawing.Size(46, 46);
            this.pPictPanel.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.profileFrame;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(71, 22);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(76, 16);
            this.label_Username.TabIndex = 24;
            this.label_Username.Text = "bn_sj2013";
            // 
            // SingleContactUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pPictPanel);
            this.Controls.Add(this.label_Username);
            this.Name = "SingleContactUC";
            this.Size = new System.Drawing.Size(364, 60);
            this.Load += new System.EventHandler(this.SingleContactUC_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SingleContactUC_MouseClick);
            this.pPictPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pPictPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Username;
    }
}
