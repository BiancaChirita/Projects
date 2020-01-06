using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class PaintForm : Form
    {
        Graphics graphics;
        private Point points1 = new Point(-1, -1);
        private Point points2 = new Point(-1, -1);
        int x = -1, width, height;
        int y = -1;
        bool moving = false, rectangle = false;
        Pen pen;
        int pressedButton, buttonSize, penSize = 5;
        List<Point> curPoints = new List<Point>();
        List<List<Point>> allPoints = new List<List<Point>>();
        List<String> typeList = new List<String>();
        List<Color> penColors = new List<Color>();
        List<int> penWidth = new List<int>();
        List<Point> rectanglePoints = new List<Point>();
        List<Point> circlePoints = new List<Point>();

        public PaintForm()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(PanelCanvas_MouseDown);
            this.MouseUp += new MouseEventHandler(PanelCanvas_MouseUp);
            this.MouseMove += new MouseEventHandler(PanelCanvas_MouseMove);

            graphics = panelCanvas.CreateGraphics();
            pen = new Pen(selectedColor.BackColor, penSize);
            _ = pressedButton == (int)PaintTools.Pencil;

        }


        private void PanelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (pressedButton == (int)PaintTools.Pencil || pressedButton == (int)PaintTools.Eraser)
            {
                curPoints.Add(e.Location);
                curPoints.Clear();
                typeList.Add("line");
                moving = true;
                x = e.X;
                y = e.Y;
            }

            if (pressedButton == (int)PaintTools.StraightLine)
            {
                curPoints.Add(e.Location);
                curPoints.Clear();
                typeList.Add("line");
                if (points1.X == -1)
                {
                    points1.X = e.X;
                    points1.Y = e.Y;
                }
            }

            if (pressedButton == (int)PaintTools.Rectangle)
            {
                typeList.Add("rectangle");
                rectangle = true;
                x = e.X;
                y = e.Y;
                Point point = new Point(x, y);
                rectanglePoints.Add(point);
            }

            if(pressedButton == (int)PaintTools.Circle)
            {
                typeList.Add("circle");
                rectangle = true;
                x = e.X;
                y = e.Y;
                Point point = new Point(x, y);
                circlePoints.Add(point);
            }

            if (buttonSize == (int)PaintTools.Plus)
            {
                if (penSize < 25)
                {
                    penSize += 5;
                    pen.Width = penSize;
                    buttonSize = 0;
                }
            }

            if (buttonSize == (int)PaintTools.Minus)
            {
                if (penSize > 1)
                {
                    penSize -= 5;
                    pen.Width = penSize;
                    buttonSize = 0;
                }
            }


            penWidth.Add(penSize);
            penColors.Add(selectedColor.BackColor);

        }
        private void PanelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(pressedButton != (int) PaintTools.Eraser)
            {
                pen.Color = selectedColor.BackColor;
            }
            else
            {
                pen.Color = Color.White;
            }
            
            if(moving == true && x!=-1 && y != -1)
            {
                curPoints.Add(e.Location);
                graphics.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
            if (e.Button != MouseButtons.Left) return;
        }

        private void PanelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (pressedButton == (int)PaintTools.Pencil || pressedButton == (int)PaintTools.Eraser)
            {
                allPoints.Add(curPoints.ToList());
                curPoints.Clear();
                moving = false;
                x = -1;
                y = -1;
            }

            if (pressedButton == (int)PaintTools.StraightLine)
            {
                allPoints.Add(curPoints.ToList());
                curPoints.Clear();
                if (points2.X == -1)
                {
                    points2.X = e.X;
                    points2.Y = e.Y;
                    graphics.DrawLine(pen, points1, points2);
                    points1.X = points1.Y = points2.X = points2.Y = -1;
                }
            }

            if (pressedButton == (int)PaintTools.Rectangle)
            {
                int width = e.X , height = e.Y ;
                Point startPoint = new Point(e.X, e.Y);
                Point point = new Point(width, height);
                rectanglePoints.Add(point);
                allPoints.Add(rectanglePoints.ToList());
                rectanglePoints.Clear();
                Rectangle rectangle = new Rectangle(Math.Min(e.X, x), Math.Min(e.Y, y),
                                                    Math.Abs(e.X - x), Math.Abs(e.Y - y));
                graphics.DrawRectangle(pen, rectangle);
            }

            if (pressedButton == (int)PaintTools.Circle)
            {
                int width = e.X, height = e.Y;
                Point point = new Point(width, height);
                circlePoints.Add(point);
                allPoints.Add(circlePoints.ToList());
                circlePoints.Clear();
                Rectangle rectangle = new Rectangle(Math.Min(e.X, x), Math.Min(e.Y, y),
                                                    Math.Abs(e.X - x), Math.Abs(e.Y - y));
                graphics.DrawEllipse(pen, rectangle);
            }

                
        }

        private void PanelColors_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox) sender;
            if(pressedButton != (int)PaintTools.Eraser )
            {
                pen.Color = pictureBox.BackColor;
            }
            this.selectedColor.BackColor = pictureBox.BackColor;
        }

        private void MnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void MnInsert_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                panelCanvas.BackgroundImage = Image.FromFile(open.FileName);
            }
        }

        private void MnUndo_Click(object sender, EventArgs e)
        {
            allPoints.RemoveAt(allPoints.Count - 1);
            penColors.RemoveAt(penColors.Count - 1);
            penWidth.RemoveAt(penWidth.Count - 1);
            typeList.RemoveAt(typeList.Count - 1);
            panelCanvas.Invalidate();
            pen.Color = selectedColor.BackColor;
        }

        private void MnNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to start a new canvas?", "New", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Rectangle r = new Rectangle(0, 0, panelCanvas.Width, panelCanvas.Height);
                SolidBrush solidBrush = new SolidBrush(whiteColor.BackColor);
                graphics.FillRectangle(solidBrush, r);
                allPoints.Clear();
                panelCanvas.BackgroundImage = null;
            }
        }

        private void MnSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(panelCanvas.Width);
                int height = Convert.ToInt32(panelCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                panelCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Png);
            }
            
        }

        private void PanelCanvas_Paint(object sender, PaintEventArgs e)
        {              
            for(int i = 0; i < allPoints.Count; i++)
            {
                pen.Width = penWidth[i];
                pen.Color = penColors[i];
                if(typeList[i] == "line"){
                    e.Graphics.DrawLines(pen, allPoints[i].ToArray());
                }else 
                    if(typeList[i] == "rectangle")
                {
                    var rectPoints = allPoints[i].ToArray();
                    Point pointA = rectPoints[0];
                    Point pointB = rectPoints[1];
                    Rectangle rect = new Rectangle(Math.Min(pointB.X, pointA.X), Math.Min(pointB.Y, pointA.Y),
                        Math.Abs(pointB.X - pointA.X), Math.Abs(pointB.Y - pointA.Y));
                    e.Graphics.DrawRectangle(pen, rect);

                }else
                    if(typeList[i] == "circle")
                {
                    var rectPoints = allPoints[i].ToArray();
                    Point pointA = rectPoints[0];
                    Point pointB = rectPoints[1];
                    Rectangle rect = new Rectangle(Math.Min(pointB.X, pointA.X), Math.Min(pointB.Y, pointA.Y),
                        Math.Abs(pointB.X - pointA.X), Math.Abs(pointB.Y - pointA.Y));
                    e.Graphics.DrawEllipse(pen, rect);
                }
                
            }

           
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;

            toolTip.ShowAlways = true;

            toolTip.SetToolTip(this.btnPencil, "Draw a free form line");
            toolTip.SetToolTip(this.btnEraser, "Delete part of the picture");
            toolTip.SetToolTip(this.btnStraightLine, "Draw a line between 2 points");
            toolTip.SetToolTip(this.btnRectangle, "Draw a rectangle from 2 points");
            toolTip.SetToolTip(this.btnCircle, "Draw a circle from 2 points");
            toolTip.SetToolTip(this.btnPlus, "Widen the width of the pen");
            toolTip.SetToolTip(this.btnMinus, "Shrink the width of the pen");
        }

        private void buttons_Click(object sender, MouseEventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnPencil":
                    pen.Color = selectedColor.BackColor;
                    pressedButton = (int)PaintTools.Pencil;
                    break;

                case "btnEraser":
                    pen.Color = Color.White;
                    pressedButton = (int)PaintTools.Eraser;
                    break;

                case "btnStraightLine":
                    pen.Color = selectedColor.BackColor;
                    pressedButton = (int)PaintTools.StraightLine;
                    break;

                case "btnRectangle":
                    pen.Color = selectedColor.BackColor;
                    pressedButton = (int)PaintTools.Rectangle;
                    break;

                case "btnCircle":
                    pen.Color = selectedColor.BackColor;
                    pressedButton = (int)PaintTools.Circle;
                    break;

                case "btnPlus":
                    buttonSize = (int)PaintTools.Plus;
                    break;

                case "btnMinus":
                    buttonSize = (int)PaintTools.Minus;
                    break;

                default:
                    break;
            }
            
        }
    }

    enum PaintTools
    {
        Pencil = 0,
        Eraser = 1,
        StraightLine = 2,
        Rectangle = 3,
        Circle = 4,
        Minus = 5,
        Plus = 6
    }

}
