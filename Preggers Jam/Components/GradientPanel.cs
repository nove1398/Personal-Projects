using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Preggers_Jam.Components
{
    class GradientPanel : Panel
    {

        private Color ColorTop { get; set; }
        private Color ColorBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, ColorTop, ColorBottom, 90F);
            Graphics grpahics = e.Graphics;
            grpahics.FillRectangle(brush,ClientRectangle);
            base.OnPaint(e);
        }

        public void SetTopColor(Color color)
        {
            ColorTop = color;
        }

        public void SetBottomColor(Color color)
        {
            ColorBottom = color;
        }
    }
}
