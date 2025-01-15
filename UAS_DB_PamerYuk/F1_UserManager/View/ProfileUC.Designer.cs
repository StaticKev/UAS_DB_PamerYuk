namespace UAS_DB_PamerYuk.F1_UserManager.View
{
    partial class ProfileUC
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_ProfilePict = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            this.button_friendList = new System.Windows.Forms.Button();
            this.button_kisahHidup = new System.Windows.Forms.Button();
            this.label_noKtp = new System.Windows.Forms.Label();
            this.label_tanggalLahir = new System.Windows.Forms.Label();
            this.label_logout = new System.Windows.Forms.Label();
            this.panel_ProfilePict.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(276, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 105);
            this.panel4.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(377, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 105);
            this.panel3.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(278, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 3);
            this.panel2.TabIndex = 23;
            // 
            // panel_ProfilePict
            // 
            this.panel_ProfilePict.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_ProfilePict.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.DefaultProfilePict;
            this.panel_ProfilePict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_ProfilePict.Controls.Add(this.pictureBox1);
            this.panel_ProfilePict.Location = new System.Drawing.Point(278, 32);
            this.panel_ProfilePict.Name = "panel_ProfilePict";
            this.panel_ProfilePict.Size = new System.Drawing.Size(100, 100);
            this.panel_ProfilePict.TabIndex = 21;
            this.panel_ProfilePict.Click += new System.EventHandler(this.Panel_ProfilePict_OnClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.profileFrame;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 98);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(273, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 3);
            this.panel1.TabIndex = 22;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(23, 38);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(91, 20);
            this.label_username.TabIndex = 26;
            this.label_username.Text = "Username";
            // 
            // button_friendList
            // 
            this.button_friendList.Location = new System.Drawing.Point(26, 109);
            this.button_friendList.Name = "button_friendList";
            this.button_friendList.Size = new System.Drawing.Size(100, 23);
            this.button_friendList.TabIndex = 27;
            this.button_friendList.Text = "Friend List";
            this.button_friendList.UseVisualStyleBackColor = true;
            this.button_friendList.Click += new System.EventHandler(this.button_friendList_Click);
            // 
            // button_kisahHidup
            // 
            this.button_kisahHidup.Location = new System.Drawing.Point(133, 109);
            this.button_kisahHidup.Name = "button_kisahHidup";
            this.button_kisahHidup.Size = new System.Drawing.Size(100, 23);
            this.button_kisahHidup.TabIndex = 28;
            this.button_kisahHidup.Text = "Kisah Hidup";
            this.button_kisahHidup.UseVisualStyleBackColor = true;
            this.button_kisahHidup.Click += new System.EventHandler(this.button_kisahHidup_Click);
            // 
            // label_noKtp
            // 
            this.label_noKtp.AutoSize = true;
            this.label_noKtp.Location = new System.Drawing.Point(25, 63);
            this.label_noKtp.Name = "label_noKtp";
            this.label_noKtp.Size = new System.Drawing.Size(103, 13);
            this.label_noKtp.TabIndex = 29;
            this.label_noKtp.Text = "0000000000000000";
            // 
            // label_tanggalLahir
            // 
            this.label_tanggalLahir.AutoSize = true;
            this.label_tanggalLahir.Location = new System.Drawing.Point(25, 80);
            this.label_tanggalLahir.Name = "label_tanggalLahir";
            this.label_tanggalLahir.Size = new System.Drawing.Size(61, 13);
            this.label_tanggalLahir.TabIndex = 30;
            this.label_tanggalLahir.Text = "00-00-0000";
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.ForeColor = System.Drawing.Color.Blue;
            this.label_logout.Location = new System.Drawing.Point(311, 137);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(36, 13);
            this.label_logout.TabIndex = 31;
            this.label_logout.Text = "logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            // 
            // ProfileUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.label_tanggalLahir);
            this.Controls.Add(this.label_noKtp);
            this.Controls.Add(this.button_kisahHidup);
            this.Controls.Add(this.button_friendList);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ProfilePict);
            this.Name = "ProfileUC";
            this.Size = new System.Drawing.Size(400, 164);
            this.Load += new System.EventHandler(this.ProfileUC_Load);
            this.panel_ProfilePict.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_ProfilePict;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_friendList;
        private System.Windows.Forms.Button button_kisahHidup;
        private System.Windows.Forms.Label label_noKtp;
        private System.Windows.Forms.Label label_tanggalLahir;
        private System.Windows.Forms.Label label_logout;
    }
}
