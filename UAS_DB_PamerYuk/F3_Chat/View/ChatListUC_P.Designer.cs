namespace UAS_DB_PamerYuk.F3_Chat.View
{
    partial class ChatListUC_P
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
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.lblHeaderChat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Search
            // 
            this.textBox_Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Search.Location = new System.Drawing.Point(4, 32);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(396, 20);
            this.textBox_Search.TabIndex = 7;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // lblHeaderChat
            // 
            this.lblHeaderChat.AutoSize = true;
            this.lblHeaderChat.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderChat.Location = new System.Drawing.Point(2, 4);
            this.lblHeaderChat.Name = "lblHeaderChat";
            this.lblHeaderChat.Size = new System.Drawing.Size(91, 25);
            this.lblHeaderChat.TabIndex = 6;
            this.lblHeaderChat.Text = "Chat | ";
            // 
            // ChatListUC_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.lblHeaderChat);
            this.Name = "ChatListUC_P";
            this.Size = new System.Drawing.Size(400, 645);
            this.Load += new System.EventHandler(this.ChatListUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_Search;
        public System.Windows.Forms.Label lblHeaderChat;
    }
}
