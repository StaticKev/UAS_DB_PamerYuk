﻿namespace UAS_DB_PamerYuk.F4_Content.View
{
    partial class SingleUserRequestUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleUserRequestUC));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pPictPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.pPictPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(17, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(46, 3);
            this.panel6.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(19, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(46, 3);
            this.panel5.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(17, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 46);
            this.panel4.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(63, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 46);
            this.panel3.TabIndex = 19;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(69, 23);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(76, 16);
            this.usernameLabel.TabIndex = 17;
            this.usernameLabel.Text = "bn_sj2013";
            // 
            // pPictPanel
            // 
            this.pPictPanel.BackColor = System.Drawing.Color.Transparent;
            this.pPictPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pPictPanel.BackgroundImage")));
            this.pPictPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPictPanel.Controls.Add(this.pictureBox2);
            this.pPictPanel.Location = new System.Drawing.Point(19, 8);
            this.pPictPanel.Name = "pPictPanel";
            this.pPictPanel.Size = new System.Drawing.Size(46, 46);
            this.pPictPanel.TabIndex = 18;
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
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(272, 14);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(91, 33);
            this.buttonAccept.TabIndex = 24;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // SingleUserRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pPictPanel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "SingleUserRequest";
            this.Size = new System.Drawing.Size(382, 61);
            this.Load += new System.EventHandler(this.SingleUserRequest_Load);
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
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button buttonAccept;
    }
}