namespace UAS_DB_PamerYuk.F1_UserManager.View
{
    partial class ListKisahHidup
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
            this.label1 = new System.Windows.Forms.Label();
            this.tambah = new System.Windows.Forms.Button();
            this.comboBox_Organisasi = new System.Windows.Forms.ComboBox();
            this.Organisasi = new System.Windows.Forms.Label();
            this.textBox_ThAwal = new System.Windows.Forms.TextBox();
            this.textBox_ThAkhir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Caption = new System.Windows.Forms.RichTextBox();
            this.notificationButton = new System.Windows.Forms.PictureBox();
            this.button_TambahOrganisasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notificationButton)).BeginInit();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.Location = new System.Drawing.Point(0, 243);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(400, 390);
            this.flp.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kisah Hidup";
            // 
            // tambah
            // 
            this.tambah.Location = new System.Drawing.Point(173, 184);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(208, 41);
            this.tambah.TabIndex = 24;
            this.tambah.Text = "Tambah Kisah Hidup";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.ButtonTambah_Click);
            // 
            // comboBox_Organisasi
            // 
            this.comboBox_Organisasi.FormattingEnabled = true;
            this.comboBox_Organisasi.Location = new System.Drawing.Point(173, 71);
            this.comboBox_Organisasi.Name = "comboBox_Organisasi";
            this.comboBox_Organisasi.Size = new System.Drawing.Size(208, 21);
            this.comboBox_Organisasi.TabIndex = 25;
            // 
            // Organisasi
            // 
            this.Organisasi.AutoSize = true;
            this.Organisasi.Location = new System.Drawing.Point(170, 55);
            this.Organisasi.Name = "Organisasi";
            this.Organisasi.Size = new System.Drawing.Size(56, 13);
            this.Organisasi.TabIndex = 26;
            this.Organisasi.Text = "Organisasi";
            // 
            // textBox_ThAwal
            // 
            this.textBox_ThAwal.Location = new System.Drawing.Point(19, 72);
            this.textBox_ThAwal.Name = "textBox_ThAwal";
            this.textBox_ThAwal.Size = new System.Drawing.Size(60, 20);
            this.textBox_ThAwal.TabIndex = 27;
            // 
            // textBox_ThAkhir
            // 
            this.textBox_ThAkhir.Location = new System.Drawing.Point(96, 72);
            this.textBox_ThAkhir.Name = "textBox_ThAkhir";
            this.textBox_ThAkhir.Size = new System.Drawing.Size(60, 20);
            this.textBox_ThAkhir.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tahun Awal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tahun Akhir";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(23, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 1);
            this.panel1.TabIndex = 32;
            // 
            // textBox_Caption
            // 
            this.textBox_Caption.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_Caption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Caption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Caption.Location = new System.Drawing.Point(18, 104);
            this.textBox_Caption.Name = "textBox_Caption";
            this.textBox_Caption.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBox_Caption.Size = new System.Drawing.Size(363, 68);
            this.textBox_Caption.TabIndex = 33;
            this.textBox_Caption.Text = "";
            // 
            // notificationButton
            // 
            this.notificationButton.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.IconBack;
            this.notificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notificationButton.Location = new System.Drawing.Point(356, 11);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(25, 25);
            this.notificationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notificationButton.TabIndex = 20;
            this.notificationButton.TabStop = false;
            this.notificationButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button_TambahOrganisasi
            // 
            this.button_TambahOrganisasi.Location = new System.Drawing.Point(19, 184);
            this.button_TambahOrganisasi.Name = "button_TambahOrganisasi";
            this.button_TambahOrganisasi.Size = new System.Drawing.Size(137, 41);
            this.button_TambahOrganisasi.TabIndex = 34;
            this.button_TambahOrganisasi.Text = "Tambah Organisasi";
            this.button_TambahOrganisasi.UseVisualStyleBackColor = true;
            this.button_TambahOrganisasi.Click += new System.EventHandler(this.button_TambahOrganisasi_Click);
            // 
            // ListKisahHidup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_TambahOrganisasi);
            this.Controls.Add(this.textBox_Caption);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ThAkhir);
            this.Controls.Add(this.textBox_ThAwal);
            this.Controls.Add(this.Organisasi);
            this.Controls.Add(this.comboBox_Organisasi);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.notificationButton);
            this.Controls.Add(this.label1);
            this.Name = "ListKisahHidup";
            this.Size = new System.Drawing.Size(400, 645);
            this.Load += new System.EventHandler(this.ListKisahHidup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notificationButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.PictureBox notificationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.ComboBox comboBox_Organisasi;
        private System.Windows.Forms.Label Organisasi;
        private System.Windows.Forms.TextBox textBox_ThAwal;
        private System.Windows.Forms.TextBox textBox_ThAkhir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox textBox_Caption;
        private System.Windows.Forms.Button button_TambahOrganisasi;
    }
}
