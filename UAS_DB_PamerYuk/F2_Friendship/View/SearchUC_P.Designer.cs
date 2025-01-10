namespace UAS_DB_PamerYuk.F2_Friendship.View
{
    partial class SearchUC_P
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
            this.comboBox_Organisasi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_ThAwal = new System.Windows.Forms.TextBox();
            this.textBox_ThAkhir = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_TahunAwal = new System.Windows.Forms.RadioButton();
            this.radioButton_TahunAkhir = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // comboBox_Organisasi
            // 
            this.comboBox_Organisasi.FormattingEnabled = true;
            this.comboBox_Organisasi.Location = new System.Drawing.Point(23, 69);
            this.comboBox_Organisasi.Name = "comboBox_Organisasi";
            this.comboBox_Organisasi.Size = new System.Drawing.Size(354, 21);
            this.comboBox_Organisasi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(23, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 1);
            this.panel1.TabIndex = 5;
            // 
            // textBox_ThAwal
            // 
            this.textBox_ThAwal.Location = new System.Drawing.Point(23, 116);
            this.textBox_ThAwal.Name = "textBox_ThAwal";
            this.textBox_ThAwal.Size = new System.Drawing.Size(170, 20);
            this.textBox_ThAwal.TabIndex = 6;
            // 
            // textBox_ThAkhir
            // 
            this.textBox_ThAkhir.Location = new System.Drawing.Point(207, 116);
            this.textBox_ThAkhir.Name = "textBox_ThAkhir";
            this.textBox_ThAkhir.Size = new System.Drawing.Size(170, 20);
            this.textBox_ThAkhir.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 163);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 469);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // radioButton_TahunAwal
            // 
            this.radioButton_TahunAwal.AutoSize = true;
            this.radioButton_TahunAwal.Location = new System.Drawing.Point(27, 97);
            this.radioButton_TahunAwal.Name = "radioButton_TahunAwal";
            this.radioButton_TahunAwal.Size = new System.Drawing.Size(82, 17);
            this.radioButton_TahunAwal.TabIndex = 12;
            this.radioButton_TahunAwal.TabStop = true;
            this.radioButton_TahunAwal.Text = "Tahun Awal";
            this.radioButton_TahunAwal.UseVisualStyleBackColor = true;
            // 
            // radioButton_TahunAkhir
            // 
            this.radioButton_TahunAkhir.AutoSize = true;
            this.radioButton_TahunAkhir.Location = new System.Drawing.Point(211, 97);
            this.radioButton_TahunAkhir.Name = "radioButton_TahunAkhir";
            this.radioButton_TahunAkhir.Size = new System.Drawing.Size(83, 17);
            this.radioButton_TahunAkhir.TabIndex = 13;
            this.radioButton_TahunAkhir.TabStop = true;
            this.radioButton_TahunAkhir.Text = "Tahun Akhir";
            this.radioButton_TahunAkhir.UseVisualStyleBackColor = true;
            // 
            // SearchUC_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.radioButton_TahunAkhir);
            this.Controls.Add(this.radioButton_TahunAwal);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox_ThAkhir);
            this.Controls.Add(this.textBox_ThAwal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Organisasi);
            this.Name = "SearchUC_P";
            this.Size = new System.Drawing.Size(400, 645);
            this.Load += new System.EventHandler(this.SearchUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Organisasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_ThAwal;
        private System.Windows.Forms.TextBox textBox_ThAkhir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton_TahunAwal;
        private System.Windows.Forms.RadioButton radioButton_TahunAkhir;
    }
}
