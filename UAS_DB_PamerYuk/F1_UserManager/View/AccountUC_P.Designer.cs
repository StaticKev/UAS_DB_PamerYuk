namespace UAS_DB_PamerYuk.F1_UserManager
{
    partial class AccountUC_P
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
            this.panel_profile = new System.Windows.Forms.Panel();
            this.flp_content = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel_profile
            // 
            this.panel_profile.Location = new System.Drawing.Point(0, 0);
            this.panel_profile.Name = "panel_profile";
            this.panel_profile.Size = new System.Drawing.Size(400, 164);
            this.panel_profile.TabIndex = 0;
            this.panel_profile.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_profile_Paint);
            // 
            // flp_content
            // 
            this.flp_content.AutoScroll = true;
            this.flp_content.Location = new System.Drawing.Point(0, 164);
            this.flp_content.Name = "flp_content";
            this.flp_content.Size = new System.Drawing.Size(400, 481);
            this.flp_content.TabIndex = 1;
            this.flp_content.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_content_Paint);
            // 
            // AccountUC_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.flp_content);
            this.Controls.Add(this.panel_profile);
            this.Name = "AccountUC_P";
            this.Size = new System.Drawing.Size(400, 645);
            this.Load += new System.EventHandler(this.ProfileUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_profile;
        public System.Windows.Forms.FlowLayoutPanel flp_content;
    }
}
