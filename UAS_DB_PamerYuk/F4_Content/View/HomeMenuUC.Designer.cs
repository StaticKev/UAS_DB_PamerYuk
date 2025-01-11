namespace UAS_DB_PamerYuk.F4_Content.View
{
    partial class HomeMenuUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notificationButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addVideoButton = new System.Windows.Forms.PictureBox();
            this.addPhotoButton = new System.Windows.Forms.PictureBox();
            this.sendLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.PictureBox();
            this.captionTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.notificationButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addVideoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPhotoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Home | ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "10 December 2024";
            // 
            // notificationButton
            // 
            this.notificationButton.Image = global::UAS_DB_PamerYuk.Properties.Resources.notification;
            this.notificationButton.Location = new System.Drawing.Point(334, 23);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(28, 28);
            this.notificationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notificationButton.TabIndex = 6;
            this.notificationButton.TabStop = false;
            this.notificationButton.Click += new System.EventHandler(this.notificationButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.UploadPane;
            this.panel1.Controls.Add(this.addVideoButton);
            this.panel1.Controls.Add(this.addPhotoButton);
            this.panel1.Controls.Add(this.sendLabel);
            this.panel1.Controls.Add(this.sendButton);
            this.panel1.Controls.Add(this.captionTextBox);
            this.panel1.Location = new System.Drawing.Point(15, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 130);
            this.panel1.TabIndex = 5;
            // 
            // addVideoButton
            // 
            this.addVideoButton.BackColor = System.Drawing.Color.Transparent;
            this.addVideoButton.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.AddVideoButton;
            this.addVideoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addVideoButton.Location = new System.Drawing.Point(53, 92);
            this.addVideoButton.Name = "addVideoButton";
            this.addVideoButton.Size = new System.Drawing.Size(26, 26);
            this.addVideoButton.TabIndex = 4;
            this.addVideoButton.TabStop = false;
            this.addVideoButton.Click += new System.EventHandler(this.addVideoButton_Click);
            // 
            // addPhotoButton
            // 
            this.addPhotoButton.BackColor = System.Drawing.Color.Transparent;
            this.addPhotoButton.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.AddPhotoButton;
            this.addPhotoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addPhotoButton.Location = new System.Drawing.Point(16, 92);
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.Size = new System.Drawing.Size(26, 26);
            this.addPhotoButton.TabIndex = 3;
            this.addPhotoButton.TabStop = false;
            this.addPhotoButton.Click += new System.EventHandler(this.addPhotoButton_Click);
            // 
            // sendLabel
            // 
            this.sendLabel.AutoSize = true;
            this.sendLabel.Location = new System.Drawing.Point(283, 98);
            this.sendLabel.Name = "sendLabel";
            this.sendLabel.Size = new System.Drawing.Size(32, 13);
            this.sendLabel.TabIndex = 2;
            this.sendLabel.Text = "Send";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Transparent;
            this.sendButton.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.ContentSendButton;
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendButton.Location = new System.Drawing.Point(261, 92);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 26);
            this.sendButton.TabIndex = 1;
            this.sendButton.TabStop = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // captionTextBox
            // 
            this.captionTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.captionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.captionTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.captionTextBox.Location = new System.Drawing.Point(16, 15);
            this.captionTextBox.Name = "captionTextBox";
            this.captionTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.captionTextBox.Size = new System.Drawing.Size(320, 68);
            this.captionTextBox.TabIndex = 0;
            this.captionTextBox.Text = "Write your caption here...";
            this.captionTextBox.Click += new System.EventHandler(this.captionTextBox_Click);
            this.captionTextBox.Leave += new System.EventHandler(this.captionTextBox_Leave);
            // 
            // HomeMenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.notificationButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomeMenuUC";
            this.Size = new System.Drawing.Size(382, 208);
            this.Load += new System.EventHandler(this.HomeMenuUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notificationButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addVideoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPhotoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox captionTextBox;
        private System.Windows.Forms.PictureBox notificationButton;
        private System.Windows.Forms.PictureBox sendButton;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.PictureBox addVideoButton;
        private System.Windows.Forms.PictureBox addPhotoButton;
    }
}
