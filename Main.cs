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
        private Point[] points;
        private int centerX, centerY;

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

        private void txtFirstX_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtFirstY_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            //Delete previous drawing
            cartesianPlane.Refresh();

            //Get points
            int firstX = txtFirstX.Text != "" ? Convert.ToInt32(txtFirstX.Text) : 0;
            int firstY = txtFirstY.Text != "" ? Convert.ToInt32(txtFirstY.Text) : 0;
            int secondX = txtSecondX.Text != "" ? Convert.ToInt32(txtSecondX.Text) : 0;
            int secondY = txtSecondY.Text != "" ? Convert.ToInt32(txtSecondY.Text) : 0;
            int thirdX = txtThirdX.Text != "" ? Convert.ToInt32(txtThirdX.Text) : 0;
            int thirdY = txtThirdY.Text != "" ? Convert.ToInt32(txtThirdY.Text) : 0;

            Pen pen = new Pen(Color.Red, 1);

            points = new Point[]
            {
                new Point(firstX, firstY),
                new Point(secondX, secondY),
                new Point(thirdX, thirdY),
            };

            //For each point
            for (int i = 0; i < points.Length; i++)
            {
                //Draw a circle
                graphics.DrawEllipse(pen, centerX + (points[i].X * 22) - 2, centerY - (points[i].Y * 22) - 2, 4, 4);

                //Draw a line between points
                if (i + 1 < points.Length)
                {
                    graphics.DrawLine(pen, centerX + (points[i].X * 22), centerY - (points[i].Y * 22), centerX + (points[i + 1].X * 22), centerY - (points[i + 1].Y * 22));
                }

                //Draw a line between last and first point
                if (i == points.Length - 1)
                {
                    graphics.DrawLine(pen, centerX + (points[i].X * 22), centerY - (points[i].Y * 22), centerX + (points[0].X * 22), centerY - (points[0].Y * 22));
                }
            }

            graphics.DrawPolygon(pen, points);
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

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Si la tecla presionada es un número o una tecla de control
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                // Permitir números y teclas de control
                e.Handled = false;
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

        private void txtFirstX_TextChanged(object sender, EventArgs e)
        {
            notNull(sender, e);
        }

        private void txtFirstY_TextChanged(object sender, EventArgs e)
        {
            notNull(sender, e);
        }

        private void txtSecondX_TextChanged(object sender, EventArgs e)
        {
            notNull(sender, e);
        }

        private void txtSecondY_TextChanged(object sender, EventArgs e)
        {
            notNull(sender, e);
        }

        private void txtThirdX_TextChanged(object sender, EventArgs e)
        {
            notNull(sender, e);
        }

        private void txtThirdY_TextChanged(object sender, EventArgs e)
        {
            notNull(sender, e);
        }

        private void notNull(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "0"; // Establecer a 0 si está vacío
            }
        }
    }
}
