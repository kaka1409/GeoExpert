using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GeoExpert.Views.Widget.Custom
{
    public class RoundedPanel : Panel
    {
        private int _radius = 6;
        private Color _borderColor = Color.FromArgb(128, 64, 0);
        private float _borderThickness = 5;

        public int Radius
        {
            get => _radius;
            set { _radius = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public float BorderThickness
        {
            get => _borderThickness;
            set { _borderThickness = value; Invalidate(); }
        }

        public RoundedPanel()
        {
            DoubleBuffered = true;
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2f;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = GetRoundedRectanglePath(rect, Radius))
            {
                // Set the panel's shape to rounded rectangle
                Region = new Region(path);

                // Draw border with specified color and thickness
                using (Pen pen = new Pen(BorderColor, BorderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
