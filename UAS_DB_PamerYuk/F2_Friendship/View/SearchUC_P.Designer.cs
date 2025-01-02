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
            this.dataGridViewPencarian = new System.Windows.Forms.DataGridView();
            this.foto_Profil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thn_Awal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thn_Akhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Aksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPencarian = new System.Windows.Forms.Button();
            this.labelJudul = new System.Windows.Forms.Label();
            this.textBoxPencarian = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPencarian)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPencarian
            // 
            this.dataGridViewPencarian.AllowUserToAddRows = false;
            this.dataGridViewPencarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPencarian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foto_Profil,
            this.username,
            this.thn_Awal,
            this.thn_Akhir,
            this.button_Aksi});
            this.dataGridViewPencarian.Location = new System.Drawing.Point(15, 255);
            this.dataGridViewPencarian.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPencarian.Name = "dataGridViewPencarian";
            this.dataGridViewPencarian.RowHeadersVisible = false;
            this.dataGridViewPencarian.RowHeadersWidth = 82;
            this.dataGridViewPencarian.RowTemplate.Height = 33;
            this.dataGridViewPencarian.Size = new System.Drawing.Size(370, 197);
            this.dataGridViewPencarian.TabIndex = 7;
            // 
            // foto_Profil
            // 
            this.foto_Profil.HeaderText = "Foto Profil";
            this.foto_Profil.MinimumWidth = 10;
            this.foto_Profil.Name = "foto_Profil";
            this.foto_Profil.Width = 200;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 10;
            this.username.Name = "username";
            this.username.Width = 200;
            // 
            // thn_Awal
            // 
            this.thn_Awal.HeaderText = "Tahun Awal";
            this.thn_Awal.MinimumWidth = 10;
            this.thn_Awal.Name = "thn_Awal";
            this.thn_Awal.Width = 200;
            // 
            // thn_Akhir
            // 
            this.thn_Akhir.HeaderText = "Tahun Akhir";
            this.thn_Akhir.MinimumWidth = 10;
            this.thn_Akhir.Name = "thn_Akhir";
            this.thn_Akhir.Width = 200;
            // 
            // button_Aksi
            // 
            this.button_Aksi.HeaderText = "Tombol_Aksi";
            this.button_Aksi.MinimumWidth = 10;
            this.button_Aksi.Name = "button_Aksi";
            this.button_Aksi.Width = 200;
            // 
            // buttonPencarian
            // 
            this.buttonPencarian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonPencarian.Location = new System.Drawing.Point(302, 133);
            this.buttonPencarian.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPencarian.Name = "buttonPencarian";
            this.buttonPencarian.Size = new System.Drawing.Size(78, 30);
            this.buttonPencarian.TabIndex = 6;
            this.buttonPencarian.Text = "Find Friends";
            this.buttonPencarian.UseVisualStyleBackColor = true;
            this.buttonPencarian.Click += new System.EventHandler(this.buttonPencarian_Click);
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Old English Text MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(50, 58);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(293, 38);
            this.labelJudul.TabIndex = 5;
            this.labelJudul.Text = "Find New Friends";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPencarian
            // 
            this.textBoxPencarian.BackColor = System.Drawing.Color.RosyBrown;
            this.textBoxPencarian.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPencarian.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPencarian.Location = new System.Drawing.Point(18, 133);
            this.textBoxPencarian.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPencarian.Name = "textBoxPencarian";
            this.textBoxPencarian.Size = new System.Drawing.Size(262, 33);
            this.textBoxPencarian.TabIndex = 4;
            this.textBoxPencarian.Text = "Enter School or Company Name";
            this.textBoxPencarian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchUC_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.dataGridViewPencarian);
            this.Controls.Add(this.buttonPencarian);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.textBoxPencarian);
            this.Name = "SearchUC_P";
            this.Size = new System.Drawing.Size(400, 645);
            this.Load += new System.EventHandler(this.SearchUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPencarian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPencarian;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto_Profil;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn thn_Awal;
        private System.Windows.Forms.DataGridViewTextBoxColumn thn_Akhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn button_Aksi;
        private System.Windows.Forms.Button buttonPencarian;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox textBoxPencarian;
    }
}
