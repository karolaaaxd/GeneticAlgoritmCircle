using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class PointAndCircleDrawer : Control
{
    private List<PointF> _points;
    private PointF _circleCenter;
    private double _circleRadius;
    private Color _circleColor;

    public PointAndCircleDrawer()
    {
        _points = new List<PointF>();
        _circleCenter = new PointF(0, 0);
        _circleRadius = 50;

        Width = 300;
        Height = 300;
    }

    public void Draw(List<PointF> points, PointF circleCenter, double circleRadius, Color col)
    {
        _points = points;
        _circleCenter = circleCenter;
        _circleRadius = circleRadius;
        _circleColor = col;
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var g = e.Graphics;

        var scaleX = Width / 2.0 / 2.0;
        var scaleY = Height / 2.0 / 2.0;
        var offsetX = Width / 4.0;
        var offsetY = Height / 1.2;

        using (var blackPen = new Pen(Color.Black))
        {
            g.DrawLine(blackPen, 0, (float)offsetY, Width, (float)offsetY);
            g.DrawLine(blackPen, (float)offsetX, 0, (float)offsetX, Height);
        }

        using (var blackPen = new Pen(Color.Black))
        {
            foreach (var point in _points)
            {
                var x = (float)(point.X * scaleX + offsetX);
                var y = (float)(-point.Y * scaleY + offsetY);
                g.DrawRectangle(blackPen, x, y, 1, 1);
            }
        }

        using (var redPen = new Pen(_circleColor))
        {
            var x = (float)(_circleCenter.X * scaleX + offsetX);
            var y = (float)(-_circleCenter.Y * scaleY + offsetY);
            g.DrawRectangle(redPen, x, y, 1, 1);
        }

        using (var redPen = new Pen(_circleColor))
        {
            var x = (float)(_circleCenter.X * scaleX + offsetX);
            var y = (float)(-_circleCenter.Y * scaleY + offsetY);
            var r = (float)(_circleRadius * scaleX);
            g.DrawEllipse(redPen, x - r, y - r, 2 * r, 2 * r);
        }
    }
}
