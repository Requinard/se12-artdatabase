using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private readonly Database db;
        private short drawState;
        private Point lastPoint;

        public Form1()
        {
            InitializeComponent();

            drawState = 0;
            lastPoint = new Point();

            db = new Database();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            var me = (MouseEventArgs) e;

            // If there is no point yet, set it as a point
            if (lastPoint.IsEmpty)
            {
                lastPoint = me.Location;
            }
            else
            {
                // calculate distance for circle
                Point currentPoint = me.Location;

                insertIntoDatabse(currentPoint);

                // Draw line
                drawShape(g, currentPoint);
            }
        }

        private void drawShape(Graphics g, Point currentPoint)
        {
            if (drawState == 0)
            {
                var p = new Pen(Brushes.Black, 3);
                g.DrawLine(p, lastPoint, currentPoint);
            }
            else if (drawState == 1)
            {
                var p = new Pen(Brushes.Brown, 3);

                int across = 0;
                double lenX = Math.Abs(currentPoint.X - lastPoint.X);
                double lenY = Math.Abs(currentPoint.Y - lastPoint.Y);
                across = (int) (Math.Sqrt(Math.Pow(lenX, 2) + Math.Pow(lenY, 2))*2);

                g.DrawEllipse(p, lastPoint.X - (across/2), lastPoint.Y - (across/2), across, across);
            }
            else if (drawState == 2)
            {
                var p = new Pen(Brushes.Crimson);

                int lengX = currentPoint.X - lastPoint.X;
                int lengY = currentPoint.Y - lastPoint.Y;

                if (lengX >= 0 || lengY >= 0)
                    g.DrawRectangle(p, lastPoint.X, lastPoint.Y, lengX, lengY);
                else
                    g.DrawRectangle(p, currentPoint.X, currentPoint.Y, Math.Abs(lengX), Math.Abs(lengY));
            }

            lastPoint = new Point();
        }

        private void insertIntoDatabse(Point currentPoint)
        {
            db.InsertShapeIntoDatabase(drawState, lastPoint, currentPoint);
        }

        private void btnSetLine_Click(object sender, EventArgs e)
        {
            drawState = 0;
        }

        private void btnSetCircle_Click(object sender, EventArgs e)
        {
            drawState = 1;
        }

        private void btnDrawRectangle_Click(object sender, EventArgs e)
        {
            drawState = 2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            g.Clear(Color.White);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Shape> shapes = db.SelectAllShapes();

            Graphics g = pictureBox1.CreateGraphics();

            foreach (Shape shape in shapes)
            {
                drawState = (short) shape.shape;
                lastPoint = shape.p1;
                drawShape(g, shape.p2);
            }
        }
    }
}