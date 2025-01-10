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
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // comboBox_Organisasi
            // 
            this.comboBox_Organisasi.FormattingEnabled = true;
            this.comboBox_Organisasi.Location = new System.Drawing.Point(23, 69);
            this.comboBox_Organisasi.Name = "comboBox_Organisasi";
            this.comboBox_Organisasi.Size = new System.Drawing.Size(354, 21);
            this.comboBox_Organisasi.TabIndex = 0;
            this.comboBox_Organisasi.SelectedIndexChanged += new System.EventHandler(this.comboBox_Organisasi_SelectedIndexChanged);
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
            this.panel1.Location = new System.Drawing.Point(23, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 1);
            this.panel1.TabIndex = 5;
            // 
            // flp
            // 
            this.flp.Location = new System.Drawing.Point(23, 115);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(354, 530);
            this.flp.TabIndex = 11;
            // 
            // SearchUC_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.flp);
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
        private System.Windows.Forms.FlowLayoutPanel flp;
    }
}
