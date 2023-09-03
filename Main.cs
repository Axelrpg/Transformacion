using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transformacion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        private Pen penBlack = new Pen(Color.Black, 1);
        private Pen penRed = new Pen(Color.Red, 1);
        private PointF[] points;
        private int centerX, centerY;

        private float firstX, firstY, secondX, secondY, thirdX, thirdY;

        private void concealer()
        {
            notNull();

            //Delete previous drawing
            cartesianPlane.Refresh();
        }

        private void getPoints()
        {
            //Get points
            firstX = txtFirstX.Text != "" ? Convert.ToSingle(txtFirstX.Text) : 0;
            firstY = txtFirstY.Text != "" ? Convert.ToSingle(txtFirstY.Text) : 0;
            secondX = txtSecondX.Text != "" ? Convert.ToSingle(txtSecondX.Text) : 0;
            secondY = txtSecondY.Text != "" ? Convert.ToSingle(txtSecondY.Text) : 0;
            thirdX = txtThirdX.Text != "" ? Convert.ToSingle(txtThirdX.Text) : 0;
            thirdY = txtThirdY.Text != "" ? Convert.ToSingle(txtThirdY.Text) : 0;
        }

        private void draw()
        {
            points = new PointF[]
            {
                new PointF(firstX, firstY),
                new PointF(secondX, secondY),
                new PointF(thirdX, thirdY),
            };

            //For each point
            for (int i = 0; i < points.Length; i++)
            {
                //Draw a circle
                graphics.DrawEllipse(penRed, centerX + (points[i].X * 22) - 2, centerY - (points[i].Y * 22) - 2, 4, 4);

                //Draw a line between points
                if (i + 1 < points.Length)
                {
                    graphics.DrawLine(penRed, centerX + (points[i].X * 22), centerY - (points[i].Y * 22), centerX + (points[i + 1].X * 22), centerY - (points[i + 1].Y * 22));
                }

                //Draw a line between last and first point
                if (i == points.Length - 1)
                {
                    graphics.DrawLine(penRed, centerX + (points[i].X * 22), centerY - (points[i].Y * 22), centerX + (points[0].X * 22), centerY - (points[0].Y * 22));
                }
            }

            graphics.DrawPolygon(penRed, points);
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            concealer();
            getPoints();
            draw();

            btnScaled.Enabled = true;
            btnTranslation.Enabled = true;
        }

        private void btnScaled_Click(object sender, EventArgs e)
        {
            concealer();
            getPoints();

            float scaled = txtScaled.Text != "" ? Convert.ToSingle(txtScaled.Text) : 0;

            firstX *= scaled;
            firstY *= scaled;
            secondX *= scaled;
            secondY *= scaled;
            thirdX *= scaled;
            thirdY *= scaled;

            txtFirstX.Text = firstX.ToString();
            txtFirstY.Text = firstY.ToString();
            txtSecondX.Text = secondX.ToString();
            txtSecondY.Text = secondY.ToString();
            txtThirdX.Text = thirdX.ToString();
            txtThirdY.Text = thirdY.ToString();

            draw();
        }

        private void btnTranslation_Click(object sender, EventArgs e)
        {
            concealer();
            getPoints();

            float translationX = txtTranslationX.Text != "" ? Convert.ToSingle(txtTranslationX.Text) : 0;
            float translationY = txtTranslationY.Text != "" ? Convert.ToSingle(txtTranslationY.Text) : 0;

            firstX += translationX;
            firstY += translationY;
            secondX += translationX;
            secondY += translationY;
            thirdX += translationX;
            thirdY += translationY;

            txtFirstX.Text = firstX.ToString();
            txtFirstY.Text = firstY.ToString();
            txtSecondX.Text = secondX.ToString();
            txtSecondY.Text = secondY.ToString();
            txtThirdX.Text = thirdX.ToString();
            txtThirdY.Text = thirdY.ToString();

            draw();
        }

        private void cartesianPlane_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 1);
            Font font = new Font("Arial", 6);
            Brush brush = new SolidBrush(Color.Black);

            graphics = e.Graphics;

            centerX = cartesianPlane.Width / 2;
            centerY = cartesianPlane.Height / 2;

            // Draw cartesian plane
            graphics.DrawLine(pen, 0, centerY, cartesianPlane.Width, centerY);
            graphics.DrawLine(pen, centerX, 0, centerX, cartesianPlane.Height);

            // Draw X and Y axis
            for (int i = -10; i <= 10; i++)
            {
                if (i != 0)
                {
                    graphics.DrawString(i.ToString(), font, brush, centerX + (i * 22) - 5, centerY + 5);
                    graphics.DrawString(i.ToString(), font, brush, centerX + 10, centerY - (i * 22) - 5);
                }

            }

            // Draw X and Y
            graphics.DrawString("X", font, brush, cartesianPlane.Width - 10, centerY - 20);
            graphics.DrawString("Y", font, brush, centerX + -20, 0);

            // Draw X and Y lines
            for (int i = -10; i <= 10; i++)
            {
                if (i != 0)
                {
                    graphics.DrawLine(pen, centerX + (i * 22), centerY - 2, centerX + (i * 22), centerY + 2);
                    graphics.DrawLine(pen, centerX - 2, centerY - (i * 22), centerX + 2, centerY - (i * 22));
                }
            }

            graphics = cartesianPlane.CreateGraphics();
        }

        private void notNull()
        {
            if (txtFirstX.Text.Length == 0)
            {
                txtFirstX.Text = "0";
            }

            if (txtFirstY.Text.Length == 0)
            {
                txtFirstY.Text = "0";
            }

            if (txtSecondX.Text.Length == 0)
            {
                txtSecondX.Text = "0";
            }

            if (txtSecondY.Text.Length == 0)
            {
                txtSecondY.Text = "0";
            }

            if (txtThirdX.Text.Length == 0)
            {
                txtThirdX.Text = "0";
            }

            if (txtThirdY.Text.Length == 0)
            {
                txtThirdY.Text = "0";
            }

            if (txtTranslationX.Text.Length == 0)
            {
                txtTranslationX.Text = "0";
            }

            if (txtTranslationY.Text.Length == 0)
            {
                txtTranslationY.Text = "0";
            }
        }

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Si la tecla presionada es un número, un punto o una tecla de control
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar))
            {
                // Permitir números, punto y teclas de control
                // Pero asegurarse de que no haya más de un punto
                if (e.KeyChar == '.' && textBox.Text.Contains("."))
                {
                    e.Handled = true; // Suprimir el segundo punto
                }
                else
                {
                    e.Handled = false;
                }
            }
            // Si la tecla presionada es el signo de menos y está al principio
            else if (e.KeyChar == '-' && textBox.SelectionStart == 0 && !textBox.Text.Contains("-"))
            {
                // Permitir solo un signo de menos al principio
                e.Handled = false;
            }
            else
            {
                // Suprimir cualquier otro carácter
                e.Handled = true;
            }
        }

        private void txtFirstX_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtFirstY_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtSecondX_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtSecondY_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtThirdX_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtThirdY_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtTranslationX_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtTranslationY_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }
    }
}
