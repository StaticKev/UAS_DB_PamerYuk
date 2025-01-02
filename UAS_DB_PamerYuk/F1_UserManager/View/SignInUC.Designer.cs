namespace UAS_DB_PamerYuk.F1_UserManager
{
    partial class SignInUC
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
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_TglLahir = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NomorKTP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Kota = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_changePicture = new System.Windows.Forms.Label();
            this.panel_ProfilePict = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.label_LogIn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_ProfilePict.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(100, 325);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(200, 20);
            this.textBox_Password.TabIndex = 8;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(100, 266);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(200, 20);
            this.textBox_Username.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // dateTimePicker_TglLahir
            // 
            this.dateTimePicker_TglLahir.Location = new System.Drawing.Point(100, 385);
            this.dateTimePicker_TglLahir.Name = "dateTimePicker_TglLahir";
            this.dateTimePicker_TglLahir.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_TglLahir.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Birthday";
            // 
            // textBox_NomorKTP
            // 
            this.textBox_NomorKTP.Location = new System.Drawing.Point(100, 444);
            this.textBox_NomorKTP.Name = "textBox_NomorKTP";
            this.textBox_NomorKTP.PasswordChar = '*';
            this.textBox_NomorKTP.Size = new System.Drawing.Size(200, 20);
            this.textBox_NomorKTP.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "KTP No.";
            // 
            // comboBox_Kota
            // 
            this.comboBox_Kota.FormattingEnabled = true;
            this.comboBox_Kota.Location = new System.Drawing.Point(100, 504);
            this.comboBox_Kota.Name = "comboBox_Kota";
            this.comboBox_Kota.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Kota.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "City";
            // 
            // label_changePicture
            // 
            this.label_changePicture.AutoSize = true;
            this.label_changePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_changePicture.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_changePicture.Location = new System.Drawing.Point(160, 197);
            this.label_changePicture.Name = "label_changePicture";
            this.label_changePicture.Size = new System.Drawing.Size(79, 13);
            this.label_changePicture.TabIndex = 15;
            this.label_changePicture.Text = "Change Picture";
            this.label_changePicture.Click += new System.EventHandler(this.label_changePicture_Click);
            // 
            // panel_ProfilePict
            // 
            this.panel_ProfilePict.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_ProfilePict.Controls.Add(this.pictureBox1);
            this.panel_ProfilePict.Location = new System.Drawing.Point(125, 39);
            this.panel_ProfilePict.Name = "panel_ProfilePict";
            this.panel_ProfilePict.Size = new System.Drawing.Size(150, 150);
            this.panel_ProfilePict.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(121, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 3);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(121, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 3);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(274, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 160);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(123, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 160);
            this.panel4.TabIndex = 20;
            // 
            // button_SignIn
            // 
            this.button_SignIn.Location = new System.Drawing.Point(100, 558);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(200, 40);
            this.button_SignIn.TabIndex = 21;
            this.button_SignIn.Text = "Sign in";
            this.button_SignIn.UseVisualStyleBackColor = true;
            this.button_SignIn.Click += new System.EventHandler(this.button_SignIn_Click);
            // 
            // label_LogIn
            // 
            this.label_LogIn.AutoSize = true;
            this.label_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_LogIn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_LogIn.Location = new System.Drawing.Point(248, 645);
            this.label_LogIn.Name = "label_LogIn";
            this.label_LogIn.Size = new System.Drawing.Size(36, 13);
            this.label_LogIn.TabIndex = 24;
            this.label_LogIn.Text = "Log in";
            this.label_LogIn.Click += new System.EventHandler(this.label_LogIn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label7.Location = new System.Drawing.Point(121, 645);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Already have an account?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.profileFrame;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 148);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // SignInUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.label_LogIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_SignIn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ProfilePict);
            this.Controls.Add(this.label_changePicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Kota);
            this.Controls.Add(this.textBox_NomorKTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_TglLahir);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "SignInUC";
            this.Size = new System.Drawing.Size(400, 700);
            this.Load += new System.EventHandler(this.SignInUserControl_Load);
            this.panel_ProfilePict.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TglLahir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NomorKTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Kota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_changePicture;
        private System.Windows.Forms.Panel panel_ProfilePict;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_SignIn;
        private System.Windows.Forms.Label label_LogIn;
        private System.Windows.Forms.Label label7;
    }
}
