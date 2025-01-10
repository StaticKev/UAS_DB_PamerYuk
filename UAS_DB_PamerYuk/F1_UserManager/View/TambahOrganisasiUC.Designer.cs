namespace UAS_DB_PamerYuk.F1_UserManager.View
{
    partial class TambahOrganisasiUC
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
            this.notificationButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tambah = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nama = new System.Windows.Forms.TextBox();
            this.comboBox_Kota = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.notificationButton)).BeginInit();
            this.SuspendLayout();
            // 
            // notificationButton
            // 
            this.notificationButton.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.IconBack;
            this.notificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notificationButton.Location = new System.Drawing.Point(356, 11);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(25, 25);
            this.notificationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notificationButton.TabIndex = 35;
            this.notificationButton.TabStop = false;
            this.notificationButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tambah Organisasi";
            // 
            // tambah
            // 
            this.tambah.Location = new System.Drawing.Point(18, 166);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(363, 41);
            this.tambah.TabIndex = 37;
            this.tambah.Text = "Tambah";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(23, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 1);
            this.panel1.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Kota";
            // 
            // textBox_Nama
            // 
            this.textBox_Nama.Location = new System.Drawing.Point(18, 76);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(363, 20);
            this.textBox_Nama.TabIndex = 47;
            // 
            // comboBox_Kota
            // 
            this.comboBox_Kota.FormattingEnabled = true;
            this.comboBox_Kota.Location = new System.Drawing.Point(18, 124);
            this.comboBox_Kota.Name = "comboBox_Kota";
            this.comboBox_Kota.Size = new System.Drawing.Size(363, 21);
            this.comboBox_Kota.TabIndex = 48;
            // 
            // TambahOrganisasiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_Kota);
            this.Controls.Add(this.textBox_Nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.notificationButton);
            this.Controls.Add(this.label1);
            this.Name = "TambahOrganisasiUC";
            this.Size = new System.Drawing.Size(400, 645);
            this.Load += new System.EventHandler(this.TambahOrganisasiUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notificationButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox notificationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Nama;
        private System.Windows.Forms.ComboBox comboBox_Kota;
    }
}
