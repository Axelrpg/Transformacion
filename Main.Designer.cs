namespace Transformacion
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartesianPlane = new System.Windows.Forms.PictureBox();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.firstPoint = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstX = new System.Windows.Forms.TextBox();
            this.txtFirstY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondPoint = new System.Windows.Forms.GroupBox();
            this.txtSecondY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecondX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thirdPoint = new System.Windows.Forms.GroupBox();
            this.txtThirdY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThirdX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartesianPlane)).BeginInit();
            this.firstPoint.SuspendLayout();
            this.secondPoint.SuspendLayout();
            this.thirdPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartesianPlane
            // 
            this.cartesianPlane.Location = new System.Drawing.Point(181, 13);
            this.cartesianPlane.Name = "cartesianPlane";
            this.cartesianPlane.Size = new System.Drawing.Size(450, 450);
            this.cartesianPlane.TabIndex = 0;
            this.cartesianPlane.TabStop = false;
            this.cartesianPlane.Paint += new System.Windows.Forms.PaintEventHandler(this.cartesianPlane_Paint);
            // 
            // btnPolygon
            // 
            this.btnPolygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolygon.Location = new System.Drawing.Point(12, 176);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(162, 31);
            this.btnPolygon.TabIndex = 1;
            this.btnPolygon.Text = "Dibujar poligono";
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // firstPoint
            // 
            this.firstPoint.Controls.Add(this.txtFirstY);
            this.firstPoint.Controls.Add(this.label2);
            this.firstPoint.Controls.Add(this.txtFirstX);
            this.firstPoint.Controls.Add(this.label1);
            this.firstPoint.Location = new System.Drawing.Point(12, 13);
            this.firstPoint.Name = "firstPoint";
            this.firstPoint.Size = new System.Drawing.Size(162, 48);
            this.firstPoint.TabIndex = 2;
            this.firstPoint.TabStop = false;
            this.firstPoint.Text = "Primer punto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // txtFirstX
            // 
            this.txtFirstX.Location = new System.Drawing.Point(28, 20);
            this.txtFirstX.Name = "txtFirstX";
            this.txtFirstX.Size = new System.Drawing.Size(50, 20);
            this.txtFirstX.TabIndex = 1;
            this.txtFirstX.Text = "0";
            this.txtFirstX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstX.TextChanged += new System.EventHandler(this.txtFirstX_TextChanged);
            this.txtFirstX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstX_KeyPress);
            // 
            // txtFirstY
            // 
            this.txtFirstY.Location = new System.Drawing.Point(106, 20);
            this.txtFirstY.Name = "txtFirstY";
            this.txtFirstY.Size = new System.Drawing.Size(50, 20);
            this.txtFirstY.TabIndex = 3;
            this.txtFirstY.Text = "0";
            this.txtFirstY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstY.TextChanged += new System.EventHandler(this.txtFirstY_TextChanged);
            this.txtFirstY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstY_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // secondPoint
            // 
            this.secondPoint.Controls.Add(this.txtSecondY);
            this.secondPoint.Controls.Add(this.label3);
            this.secondPoint.Controls.Add(this.txtSecondX);
            this.secondPoint.Controls.Add(this.label4);
            this.secondPoint.Location = new System.Drawing.Point(12, 67);
            this.secondPoint.Name = "secondPoint";
            this.secondPoint.Size = new System.Drawing.Size(162, 48);
            this.secondPoint.TabIndex = 4;
            this.secondPoint.TabStop = false;
            this.secondPoint.Text = "Segundo punto:";
            // 
            // txtSecondY
            // 
            this.txtSecondY.Location = new System.Drawing.Point(106, 20);
            this.txtSecondY.Name = "txtSecondY";
            this.txtSecondY.Size = new System.Drawing.Size(50, 20);
            this.txtSecondY.TabIndex = 3;
            this.txtSecondY.Text = "0";
            this.txtSecondY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecondY.TextChanged += new System.EventHandler(this.txtSecondY_TextChanged);
            this.txtSecondY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondY_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // txtSecondX
            // 
            this.txtSecondX.Location = new System.Drawing.Point(28, 20);
            this.txtSecondX.Name = "txtSecondX";
            this.txtSecondX.Size = new System.Drawing.Size(50, 20);
            this.txtSecondX.TabIndex = 1;
            this.txtSecondX.Text = "0";
            this.txtSecondX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecondX.TextChanged += new System.EventHandler(this.txtSecondX_TextChanged);
            this.txtSecondX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondX_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            // 
            // thirdPoint
            // 
            this.thirdPoint.Controls.Add(this.txtThirdY);
            this.thirdPoint.Controls.Add(this.label5);
            this.thirdPoint.Controls.Add(this.txtThirdX);
            this.thirdPoint.Controls.Add(this.label6);
            this.thirdPoint.Location = new System.Drawing.Point(12, 121);
            this.thirdPoint.Name = "thirdPoint";
            this.thirdPoint.Size = new System.Drawing.Size(162, 48);
            this.thirdPoint.TabIndex = 5;
            this.thirdPoint.TabStop = false;
            this.thirdPoint.Text = "Tercer punto:";
            // 
            // txtThirdY
            // 
            this.txtThirdY.Location = new System.Drawing.Point(106, 20);
            this.txtThirdY.Name = "txtThirdY";
            this.txtThirdY.Size = new System.Drawing.Size(50, 20);
            this.txtThirdY.TabIndex = 3;
            this.txtThirdY.Text = "0";
            this.txtThirdY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThirdY.TextChanged += new System.EventHandler(this.txtThirdY_TextChanged);
            this.txtThirdY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThirdY_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Y";
            // 
            // txtThirdX
            // 
            this.txtThirdX.Location = new System.Drawing.Point(28, 20);
            this.txtThirdX.Name = "txtThirdX";
            this.txtThirdX.Size = new System.Drawing.Size(50, 20);
            this.txtThirdX.TabIndex = 1;
            this.txtThirdX.Text = "0";
            this.txtThirdX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThirdX.TextChanged += new System.EventHandler(this.txtThirdX_TextChanged);
            this.txtThirdX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThirdX_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "X";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 474);
            this.Controls.Add(this.thirdPoint);
            this.Controls.Add(this.secondPoint);
            this.Controls.Add(this.firstPoint);
            this.Controls.Add(this.btnPolygon);
            this.Controls.Add(this.cartesianPlane);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transformaciones";
            ((System.ComponentModel.ISupportInitialize)(this.cartesianPlane)).EndInit();
            this.firstPoint.ResumeLayout(false);
            this.firstPoint.PerformLayout();
            this.secondPoint.ResumeLayout(false);
            this.secondPoint.PerformLayout();
            this.thirdPoint.ResumeLayout(false);
            this.thirdPoint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cartesianPlane;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.GroupBox firstPoint;
        private System.Windows.Forms.TextBox txtFirstY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox secondPoint;
        private System.Windows.Forms.TextBox txtSecondY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecondX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox thirdPoint;
        private System.Windows.Forms.TextBox txtThirdY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThirdX;
        private System.Windows.Forms.Label label6;
    }
}

