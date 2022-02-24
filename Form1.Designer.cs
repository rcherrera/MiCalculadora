namespace MiCalculadora
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnMultiplica = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblDia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(127, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(127, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Location = new System.Drawing.Point(293, 347);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(20, 25);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(128, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnSuma.Location = new System.Drawing.Point(156, 231);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(75, 48);
            this.BtnSuma.TabIndex = 4;
            this.BtnSuma.Text = "+";
            this.BtnSuma.UseVisualStyleBackColor = false;
            this.BtnSuma.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnResta
            // 
            this.BtnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnResta.Location = new System.Drawing.Point(260, 231);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(75, 48);
            this.BtnResta.TabIndex = 5;
            this.BtnResta.Text = "-";
            this.BtnResta.UseVisualStyleBackColor = false;
            this.BtnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // BtnMultiplica
            // 
            this.BtnMultiplica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnMultiplica.Location = new System.Drawing.Point(355, 231);
            this.BtnMultiplica.Name = "BtnMultiplica";
            this.BtnMultiplica.Size = new System.Drawing.Size(75, 48);
            this.BtnMultiplica.TabIndex = 6;
            this.BtnMultiplica.Text = "*";
            this.BtnMultiplica.UseVisualStyleBackColor = false;
            this.BtnMultiplica.Click += new System.EventHandler(this.BtnMultiplica_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnDivide.Location = new System.Drawing.Point(451, 231);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(75, 48);
            this.BtnDivide.TabIndex = 7;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(230, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 4);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(230, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 4);
            this.panel2.TabIndex = 9;
            // 
            // TxtNum1
            // 
            this.TxtNum1.BackColor = System.Drawing.SystemColors.InfoText;
            this.TxtNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNum1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtNum1.Location = new System.Drawing.Point(230, 70);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(200, 29);
            this.TxtNum1.TabIndex = 10;
            // 
            // TxtNum2
            // 
            this.TxtNum2.BackColor = System.Drawing.SystemColors.InfoText;
            this.TxtNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNum2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtNum2.Location = new System.Drawing.Point(230, 164);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(200, 29);
            this.TxtNum2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Location = new System.Drawing.Point(479, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 77);
            this.button1.TabIndex = 12;
            this.button1.Text = "COMPARAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TxtFecha
            // 
            this.TxtFecha.BackColor = System.Drawing.SystemColors.MenuText;
            this.TxtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFecha.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtFecha.Location = new System.Drawing.Point(588, 12);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(200, 29);
            this.TxtFecha.TabIndex = 13;
            this.TxtFecha.TextChanged += new System.EventHandler(this.TxtFecha_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(588, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 4);
            this.panel3.TabIndex = 9;
            // 
            // LblDia
            // 
            this.LblDia.AutoSize = true;
            this.LblDia.BackColor = System.Drawing.Color.Black;
            this.LblDia.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDia.ForeColor = System.Drawing.Color.Yellow;
            this.LblDia.Location = new System.Drawing.Point(596, 59);
            this.LblDia.Name = "LblDia";
            this.LblDia.Size = new System.Drawing.Size(17, 19);
            this.LblDia.TabIndex = 14;
            this.LblDia.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblDia);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnMultiplica);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.Button BtnMultiplica;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblDia;
    }
}

