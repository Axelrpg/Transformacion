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

        private void endButton()
        {
            txtFirstX.Text = firstX.ToString();
            txtFirstY.Text = firstY.ToString();
            txtSecondX.Text = secondX.ToString();
            txtSecondY.Text = secondY.ToString();
            txtThirdX.Text = thirdX.ToString();
            txtThirdY.Text = thirdY.ToString();

            draw();
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

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtFirstX.Text = "0";
            txtFirstY.Text = "0";
            txtSecondX.Text = "0";
            txtSecondY.Text = "0";
            txtThirdX.Text = "0";
            txtThirdY.Text = "0";
            txtTranslationX.Text = "0";
            txtTranslationY.Text = "0";
            txtScaled.Text = "0";
            txtRotation.Text = "0";
            txtShearingX.Text = "0";
            txtShearingY.Text = "0";

            concealer();
            getPoints();
            draw();
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            concealer();
            getPoints();
            draw();

            btnScaled.Enabled = true;
            btnShearingX.Enabled = true;
            btnShearingY.Enabled = true;
            btnRotation.Enabled = true;
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

            endButton();
        }

        private void btnShearingX_Click(object sender, EventArgs e)
        {
            concealer();
            getPoints();

            float shearing = txtShearingX.Text != "" ? Convert.ToSingle(txtShearingX.Text) : 0;

            firstX = firstX + shearing * firstY;
            secondX = secondX + shearing * secondY;
            thirdX = thirdX + shearing * thirdY;

            endButton();
        }

        private void btnShearingY_Click(object sender, EventArgs e)
        {
            concealer();
            getPoints();

            float shearing = txtShearingY.Text != "" ? Convert.ToSingle(txtShearingY.Text) : 0;

            firstY = firstY + shearing * firstX;
            secondY = secondY + shearing * secondX;
            thirdY = thirdY + shearing * thirdX;

            endButton();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            concealer();

            firstX = 0;
            firstY = 0;
            secondX = 0;
            secondY = 3;
            thirdX = 3;
            thirdY = 0;

            endButton();
        }

        private void btnRotation_Click(object sender, EventArgs e)
        {
            concealer();
            getPoints();

            float degrees = txtRotation.Text != "" ? Convert.ToSingle(txtRotation.Text) : 0;
            double radians = (Math.PI * degrees / 180.0);

            double cosTheta = Math.Cos(radians);
            double sinTheta = Math.Sin(radians);

            float backupFirstX = firstX;
            float backupFirstY = firstY;
            float backupSecondX = secondX;
            float backupSecondY = secondY;
            float backupThirdX = thirdX;
            float backupThirdY = thirdY;

            firstX = (float)(backupFirstX * cosTheta - backupFirstY * sinTheta);
            firstY = (float)(backupFirstX * sinTheta + backupFirstY * cosTheta);
            secondX = (float)(backupSecondX * cosTheta - backupSecondY * sinTheta);
            secondY = (float)(backupSecondX * sinTheta + backupSecondY * cosTheta);
            thirdX = (float)(backupThirdX * cosTheta - backupThirdY * sinTheta);
            thirdY = (float)(backupThirdX * sinTheta + backupThirdY * cosTheta);

            endButton();
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

            endButton();
        }

        private void cartesianPlane_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Arial", 6);
            Brush brush = new SolidBrush(Color.Black);

            graphics = e.Graphics;

            centerX = cartesianPlane.Width / 2;
            centerY = cartesianPlane.Height / 2;

            // Draw cartesian plane
            graphics.DrawLine(penBlack, 0, centerY, cartesianPlane.Width, centerY);
            graphics.DrawLine(penBlack, centerX, 0, centerX, cartesianPlane.Height);

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
                    graphics.DrawLine(penBlack, centerX + (i * 22), centerY - 2, centerX + (i * 22), centerY + 2);
                    graphics.DrawLine(penBlack, centerX - 2, centerY - (i * 22), centerX + 2, centerY - (i * 22));
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

            if (txtScaled.Text.Length == 0)
            {
                txtScaled.Text = "0";
            }

            if (txtRotation.Text.Length == 0)
            {
                txtRotation.Text = "0";
            }

            if (txtShearingX.Text.Length == 0)
            {
                txtShearingX.Text = "0";
            }

            if (txtShearingY.Text.Length == 0)
            {
                txtShearingY.Text = "0";
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

        private void txtRotation_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtScaled_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtShearingX_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtShearingY_KeyPress(object sender, KeyPressEventArgs e)
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
