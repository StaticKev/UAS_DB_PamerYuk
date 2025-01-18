namespace UAS_DB_PamerYuk.F4_Content.View
{
    partial class OverviewUserControl
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
            this.listBox_Like = new System.Windows.Forms.ListBox();
            this.listBox_Comment = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Like";
            // 
            // listBox_Like
            // 
            this.listBox_Like.FormattingEnabled = true;
            this.listBox_Like.Location = new System.Drawing.Point(18, 67);
            this.listBox_Like.Name = "listBox_Like";
            this.listBox_Like.Size = new System.Drawing.Size(365, 199);
            this.listBox_Like.TabIndex = 5;
            // 
            // listBox_Comment
            // 
            this.listBox_Comment.FormattingEnabled = true;
            this.listBox_Comment.Location = new System.Drawing.Point(18, 336);
            this.listBox_Comment.Name = "listBox_Comment";
            this.listBox_Comment.Size = new System.Drawing.Size(365, 199);
            this.listBox_Comment.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tag";
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(245, 572);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(138, 49);
            this.button_Back.TabIndex = 9;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // OverviewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Comment);
            this.Controls.Add(this.listBox_Like);
            this.Controls.Add(this.label1);
            this.Name = "OverviewUserControl";
            this.Size = new System.Drawing.Size(400, 645);
            this.Load += new System.EventHandler(this.OverviewUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Like;
        private System.Windows.Forms.ListBox listBox_Comment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Back;
    }
}
