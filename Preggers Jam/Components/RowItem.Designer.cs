namespace Preggers_Jam.Components
{
    partial class RowItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBlogTitle = new System.Windows.Forms.Label();
            this.labelBlogDescription = new System.Windows.Forms.Label();
            this.labelDateBlog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelBlogTitle
            // 
            this.labelBlogTitle.AutoSize = true;
            this.labelBlogTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBlogTitle.Location = new System.Drawing.Point(104, 16);
            this.labelBlogTitle.MaximumSize = new System.Drawing.Size(200, 23);
            this.labelBlogTitle.Name = "labelBlogTitle";
            this.labelBlogTitle.Size = new System.Drawing.Size(92, 23);
            this.labelBlogTitle.TabIndex = 1;
            this.labelBlogTitle.Text = "Blog Title";
            this.labelBlogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBlogDescription
            // 
            this.labelBlogDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBlogDescription.AutoEllipsis = true;
            this.labelBlogDescription.ForeColor = System.Drawing.Color.Gray;
            this.labelBlogDescription.Location = new System.Drawing.Point(104, 40);
            this.labelBlogDescription.MaximumSize = new System.Drawing.Size(300, 30);
            this.labelBlogDescription.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelBlogDescription.Name = "labelBlogDescription";
            this.labelBlogDescription.Size = new System.Drawing.Size(300, 50);
            this.labelBlogDescription.TabIndex = 2;
            this.labelBlogDescription.Text = "This blog is used to talk about this awesome topic right now, this topic is so go" +
    "od it had to be talked about";
            this.labelBlogDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateBlog
            // 
            this.labelDateBlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateBlog.AutoSize = true;
            this.labelDateBlog.Location = new System.Drawing.Point(680, 16);
            this.labelDateBlog.Name = "labelDateBlog";
            this.labelDateBlog.Size = new System.Drawing.Size(96, 21);
            this.labelDateBlog.TabIndex = 3;
            this.labelDateBlog.Text = "21/10/2020";
            // 
            // RowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 95);
            this.Controls.Add(this.labelDateBlog);
            this.Controls.Add(this.labelBlogDescription);
            this.Controls.Add(this.labelBlogTitle);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RowItem";
            this.Text = "RowItem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBlogTitle;
        private System.Windows.Forms.Label labelBlogDescription;
        private System.Windows.Forms.Label labelDateBlog;
    }
}