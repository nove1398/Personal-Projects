namespace Preggers_Jam.Forms
{
    partial class Blogs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBlogsTitle = new System.Windows.Forms.Label();
            this.panelLBlogList = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.labelBlogsTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 40);
            this.panel1.TabIndex = 0;
            // 
            // labelBlogsTitle
            // 
            this.labelBlogsTitle.AutoSize = true;
            this.labelBlogsTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelBlogsTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBlogsTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBlogsTitle.Location = new System.Drawing.Point(440, 0);
            this.labelBlogsTitle.Name = "labelBlogsTitle";
            this.labelBlogsTitle.Padding = new System.Windows.Forms.Padding(5);
            this.labelBlogsTitle.Size = new System.Drawing.Size(157, 40);
            this.labelBlogsTitle.TabIndex = 0;
            this.labelBlogsTitle.Text = "Blog Entries";
            // 
            // panelLBlogList
            // 
            this.panelLBlogList.AutoScroll = true;
            this.panelLBlogList.BackColor = System.Drawing.Color.LightGray;
            this.panelLBlogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLBlogList.Location = new System.Drawing.Point(0, 40);
            this.panelLBlogList.Name = "panelLBlogList";
            this.panelLBlogList.Size = new System.Drawing.Size(1022, 577);
            this.panelLBlogList.TabIndex = 1;
            // 
            // Blogs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1022, 617);
            this.Controls.Add(this.panelLBlogList);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Blogs";
            this.Text = "Blogs";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBlogsTitle;
        private System.Windows.Forms.Panel panelLBlogList;
    }
}