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
            this.txtFirstY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTranslation = new System.Windows.Forms.Button();
            this.txtTranslationY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTranslationX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnScaled = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtScaled = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRotation = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRotation = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShearingY = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtShearingY = new System.Windows.Forms.TextBox();
            this.btnShearingX = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtShearingX = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartesianPlane)).BeginInit();
            this.firstPoint.SuspendLayout();
            this.secondPoint.SuspendLayout();
            this.thirdPoint.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // txtFirstY
            // 
            this.txtFirstY.Location = new System.Drawing.Point(106, 20);
            this.txtFirstY.Name = "txtFirstY";
            this.txtFirstY.Size = new System.Drawing.Size(50, 20);
            this.txtFirstY.TabIndex = 3;
            this.txtFirstY.Text = "0";
            this.txtFirstY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtFirstX
            // 
            this.txtFirstX.Location = new System.Drawing.Point(28, 20);
            this.txtFirstX.Name = "txtFirstX";
            this.txtFirstX.Size = new System.Drawing.Size(50, 20);
            this.txtFirstX.TabIndex = 1;
            this.txtFirstX.Text = "0";
            this.txtFirstX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstX_KeyPress);
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
            this.txtSecondY.Text = "3";
            this.txtSecondY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtThirdX.Text = "3";
            this.txtThirdX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTranslation);
            this.groupBox1.Controls.Add(this.txtTranslationY);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTranslationX);
            this.groupBox1.Location = new System.Drawing.Point(637, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traslación";
            // 
            // btnTranslation
            // 
            this.btnTranslation.Enabled = false;
            this.btnTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslation.Location = new System.Drawing.Point(9, 48);
            this.btnTranslation.Name = "btnTranslation";
            this.btnTranslation.Size = new System.Drawing.Size(144, 30);
            this.btnTranslation.TabIndex = 6;
            this.btnTranslation.Text = "Trasladar";
            this.btnTranslation.UseVisualStyleBackColor = true;
            this.btnTranslation.Click += new System.EventHandler(this.btnTranslation_Click);
            // 
            // txtTranslationY
            // 
            this.txtTranslationY.Location = new System.Drawing.Point(106, 20);
            this.txtTranslationY.Name = "txtTranslationY";
            this.txtTranslationY.Size = new System.Drawing.Size(50, 20);
            this.txtTranslationY.TabIndex = 7;
            this.txtTranslationY.Text = "0";
            this.txtTranslationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTranslationY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTranslationY_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "X";
            // 
            // txtTranslationX
            // 
            this.txtTranslationX.Location = new System.Drawing.Point(28, 20);
            this.txtTranslationX.Name = "txtTranslationX";
            this.txtTranslationX.Size = new System.Drawing.Size(50, 20);
            this.txtTranslationX.TabIndex = 5;
            this.txtTranslationX.Text = "0";
            this.txtTranslationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTranslationX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTranslationX_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnScaled);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtScaled);
            this.groupBox2.Location = new System.Drawing.Point(637, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 90);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escalado";
            // 
            // btnScaled
            // 
            this.btnScaled.Enabled = false;
            this.btnScaled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScaled.Location = new System.Drawing.Point(9, 48);
            this.btnScaled.Name = "btnScaled";
            this.btnScaled.Size = new System.Drawing.Size(144, 30);
            this.btnScaled.TabIndex = 6;
            this.btnScaled.Text = "Escalar";
            this.btnScaled.UseVisualStyleBackColor = true;
            this.btnScaled.Click += new System.EventHandler(this.btnScaled_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Escala";
            // 
            // txtScaled
            // 
            this.txtScaled.Location = new System.Drawing.Point(51, 20);
            this.txtScaled.Name = "txtScaled";
            this.txtScaled.Size = new System.Drawing.Size(50, 20);
            this.txtScaled.TabIndex = 5;
            this.txtScaled.Text = "0";
            this.txtScaled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtScaled.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScaled_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRotation);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtRotation);
            this.groupBox3.Location = new System.Drawing.Point(637, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 90);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rotación antihorario";
            // 
            // btnRotation
            // 
            this.btnRotation.Enabled = false;
            this.btnRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotation.Location = new System.Drawing.Point(9, 48);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.Size = new System.Drawing.Size(144, 30);
            this.btnRotation.TabIndex = 6;
            this.btnRotation.Text = "Rotar";
            this.btnRotation.UseVisualStyleBackColor = true;
            this.btnRotation.Click += new System.EventHandler(this.btnRotation_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Grados";
            // 
            // txtRotation
            // 
            this.txtRotation.Location = new System.Drawing.Point(51, 20);
            this.txtRotation.Name = "txtRotation";
            this.txtRotation.Size = new System.Drawing.Size(50, 20);
            this.txtRotation.TabIndex = 5;
            this.txtRotation.Text = "0";
            this.txtRotation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRotation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRotation_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnShearingY);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtShearingY);
            this.groupBox4.Controls.Add(this.btnShearingX);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtShearingX);
            this.groupBox4.Location = new System.Drawing.Point(637, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 151);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sesgado";
            // 
            // btnShearingY
            // 
            this.btnShearingY.Enabled = false;
            this.btnShearingY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShearingY.Location = new System.Drawing.Point(9, 114);
            this.btnShearingY.Name = "btnShearingY";
            this.btnShearingY.Size = new System.Drawing.Size(144, 30);
            this.btnShearingY.TabIndex = 9;
            this.btnShearingY.Text = "Cizallar en Y";
            this.btnShearingY.UseVisualStyleBackColor = true;
            this.btnShearingY.Click += new System.EventHandler(this.btnShearingY_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Y";
            // 
            // txtShearingY
            // 
            this.txtShearingY.Location = new System.Drawing.Point(26, 86);
            this.txtShearingY.Name = "txtShearingY";
            this.txtShearingY.Size = new System.Drawing.Size(50, 20);
            this.txtShearingY.TabIndex = 8;
            this.txtShearingY.Text = "0";
            this.txtShearingY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtShearingY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShearingY_KeyPress);
            // 
            // btnShearingX
            // 
            this.btnShearingX.Enabled = false;
            this.btnShearingX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShearingX.Location = new System.Drawing.Point(9, 48);
            this.btnShearingX.Name = "btnShearingX";
            this.btnShearingX.Size = new System.Drawing.Size(144, 30);
            this.btnShearingX.TabIndex = 6;
            this.btnShearingX.Text = "Cizallar en X";
            this.btnShearingX.UseVisualStyleBackColor = true;
            this.btnShearingX.Click += new System.EventHandler(this.btnShearingX_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "X";
            // 
            // txtShearingX
            // 
            this.txtShearingX.Location = new System.Drawing.Point(26, 20);
            this.txtShearingX.Name = "txtShearingX";
            this.txtShearingX.Size = new System.Drawing.Size(50, 20);
            this.txtShearingX.TabIndex = 5;
            this.txtShearingX.Text = "0";
            this.txtShearingX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtShearingX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShearingX_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 432);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(162, 31);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(12, 395);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(162, 31);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 474);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.thirdPoint);
            this.Controls.Add(this.secondPoint);
            this.Controls.Add(this.firstPoint);
            this.Controls.Add(this.btnPolygon);
            this.Controls.Add(this.cartesianPlane);
            this.MaximizeBox = false;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTranslation;
        private System.Windows.Forms.TextBox txtTranslationY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTranslationX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnScaled;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtScaled;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRotation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRotation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnShearingY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtShearingY;
        private System.Windows.Forms.Button btnShearingX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtShearingX;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClean;
    }
}

