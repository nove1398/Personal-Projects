using System.Drawing;
using System.Windows.Forms;

namespace Preggers_Jam.Components
{
    public partial class RowItem : Form
    {
        public RowItem()
        {
            InitializeComponent();
        }

        public string GetTitle => labelBlogTitle.Text.Trim();
        public string GetDescription => labelBlogDescription.Text.Trim();

        public void SetTitle(string text)
        {
            labelBlogTitle.Text = text.Trim();
        }

        public void SetDescription(string text)
        {
            labelBlogDescription.Text = text.Trim();
        }

        public void SetImage(Image img)
        {

        }
    }
}
