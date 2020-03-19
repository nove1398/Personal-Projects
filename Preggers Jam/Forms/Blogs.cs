using Preggers_Jam.Components;
using Preggers_Jam.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Preggers_Jam.Forms
{
    public partial class Blogs : Form
    {
        private Panel ParentPanel { get; set; }
        private Panel CurrentState { get; set; }

        public Blogs(Panel parent)
        {
            InitializeComponent();
            ParentPanel = parent;
        }

        private void LoadBlogs()
        {
            int i = 0;
            foreach (var blog in Blog.SeedBlogs.OrderBy(x => x.BlogId).ToList())
            {
                RowItem row = new RowItem();
                row.SetTitle(blog.Title);
                row.SetDescription(blog.Description);
                row.Tag = blog.BlogId;
                row.TopLevel = false;
                row.Dock = DockStyle.Top;
                row.BackColor = (i % 2 == 0)?Color.White : Color.LightGray;
                row.Click += new EventHandler(OnRowItemClick);
                panelLBlogList.Controls.Add(row);
                row.Show();
                i++;
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            LoadBlogs();
            panelLBlogList.VerticalScroll.Value = 0;
            Refresh();
        }

        private void OnRowItemClick(object sender, EventArgs e)
        {
            RowItem clickedRow = ((RowItem)sender);
            MessageBox.Show(clickedRow.Tag as string);
            CurrentState = ParentPanel;
        }
    }
}
