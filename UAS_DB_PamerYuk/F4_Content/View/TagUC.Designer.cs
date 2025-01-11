namespace UAS_DB_PamerYuk.F4_Content.View
{
    partial class TagUC
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
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.notificationButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notificationButton)).BeginInit();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.Location = new System.Drawing.Point(0, 62);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(400, 583);
            this.flp.TabIndex = 21;
            // 
            // notificationButton
            // 
            this.notificationButton.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.IconBack;
            this.notificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notificationButton.Location = new System.Drawing.Point(356, 23);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(25, 25);
            this.notificationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notificationButton.TabIndex = 20;
            this.notificationButton.TabStop = false;
            this.notificationButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tag";
            // 
            // TagUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.flp);
            this.Controls.Add(this.notificationButton);
            this.Controls.Add(this.label1);
            this.Name = "TagUC";
            this.Size = new System.Drawing.Size(400, 645);
            this.Load += new System.EventHandler(this.TagUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notificationButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.PictureBox notificationButton;
        private System.Windows.Forms.Label label1;
    }
}
