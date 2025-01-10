namespace UAS_DB_PamerYuk.F3_Chat.View
{
    partial class ChatRoomUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatRoomUC));
            this.btnback = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(327, 18);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 48);
            this.btnback.TabIndex = 24;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 78);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(359, 524);
            this.listBox1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.ContentSendButton;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(326, 605);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 605);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(22, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(46, 3);
            this.panel6.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(24, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(46, 3);
            this.panel5.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(22, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 46);
            this.panel4.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(68, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 46);
            this.panel3.TabIndex = 32;
            // 
            // pPictPanel
            // 
            this.pPictPanel.BackColor = System.Drawing.Color.Transparent;
            this.pPictPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pPictPanel.BackgroundImage")));
            this.pPictPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPictPanel.Controls.Add(this.pictureBox2);
            this.pPictPanel.Location = new System.Drawing.Point(24, 19);
            this.pPictPanel.Name = "pPictPanel";
            this.pPictPanel.Size = new System.Drawing.Size(46, 46);
            this.pPictPanel.TabIndex = 31;
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
            this.label_Username.Location = new System.Drawing.Point(74, 34);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(76, 16);
            this.label_Username.TabIndex = 30;
            this.label_Username.Text = "bn_sj2013";
            // 
            // ChatRoomUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pPictPanel);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "ChatRoomUC";
            this.Size = new System.Drawing.Size(400, 645);
            this.Load += new System.EventHandler(this.ChatRoomUC_Load);
            this.pPictPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pPictPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Username;
    }
}
