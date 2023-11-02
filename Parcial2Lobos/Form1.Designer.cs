namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.parIzq = new System.Windows.Forms.Button();
            this.parDer = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.mas = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(14, 18);
            this.txtResultado.MaxLength = 20;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(318, 39);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0\r\n\r\n";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boton1
            // 
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(12, 224);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(75, 66);
            this.boton1.TabIndex = 1;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // boton2
            // 
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(93, 224);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(75, 66);
            this.boton2.TabIndex = 2;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // boton3
            // 
            this.boton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.Location = new System.Drawing.Point(174, 224);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(75, 66);
            this.boton3.TabIndex = 3;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // boton4
            // 
            this.boton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.Location = new System.Drawing.Point(12, 152);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(75, 66);
            this.boton4.TabIndex = 4;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // boton5
            // 
            this.boton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.Location = new System.Drawing.Point(93, 152);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(75, 66);
            this.boton5.TabIndex = 5;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = true;
            this.boton5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // boton6
            // 
            this.boton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.Location = new System.Drawing.Point(174, 152);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(75, 66);
            this.boton6.TabIndex = 6;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = true;
            this.boton6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // boton7
            // 
            this.boton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.Location = new System.Drawing.Point(12, 82);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(75, 66);
            this.boton7.TabIndex = 7;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = true;
            this.boton7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // boton8
            // 
            this.boton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.Location = new System.Drawing.Point(93, 82);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(75, 66);
            this.boton8.TabIndex = 8;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = true;
            this.boton8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // boton9
            // 
            this.boton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.Location = new System.Drawing.Point(174, 82);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(75, 66);
            this.boton9.TabIndex = 9;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = true;
            this.boton9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(255, 82);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 66);
            this.mult.TabIndex = 10;
            this.mult.Tag = "*";
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.clickOperador);
            // 
            // boton0
            // 
            this.boton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.Location = new System.Drawing.Point(12, 296);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(75, 66);
            this.boton0.TabIndex = 11;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = true;
            this.boton0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // parIzq
            // 
            this.parIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parIzq.Location = new System.Drawing.Point(93, 296);
            this.parIzq.Name = "parIzq";
            this.parIzq.Size = new System.Drawing.Size(75, 66);
            this.parIzq.TabIndex = 12;
            this.parIzq.Text = "(";
            this.parIzq.UseVisualStyleBackColor = true;
            // 
            // parDer
            // 
            this.parDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parDer.Location = new System.Drawing.Point(174, 296);
            this.parDer.Name = "parDer";
            this.parDer.Size = new System.Drawing.Size(75, 66);
            this.parDer.TabIndex = 13;
            this.parDer.Text = ")";
            this.parDer.UseVisualStyleBackColor = true;
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(255, 152);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 66);
            this.div.TabIndex = 14;
            this.div.Tag = "/";
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.clickOperador);
            // 
            // menos
            // 
            this.menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menos.Location = new System.Drawing.Point(255, 224);
            this.menos.Name = "menos";
            this.menos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menos.Size = new System.Drawing.Size(75, 66);
            this.menos.TabIndex = 15;
            this.menos.Tag = "-";
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = true;
            this.menos.Click += new System.EventHandler(this.clickOperador);
            // 
            // mas
            // 
            this.mas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mas.Location = new System.Drawing.Point(255, 296);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(75, 66);
            this.mas.TabIndex = 16;
            this.mas.Tag = "+";
            this.mas.Text = "+";
            this.mas.UseVisualStyleBackColor = true;
            this.mas.Click += new System.EventHandler(this.clickOperador);
            // 
            // igual
            // 
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(12, 368);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(237, 66);
            this.igual.TabIndex = 17;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.ForeColor = System.Drawing.SystemColors.Control;
            this.CE.Location = new System.Drawing.Point(257, 369);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(75, 66);
            this.CE.TabIndex = 18;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 454);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.mas);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.div);
            this.Controls.Add(this.parDer);
            this.Controls.Add(this.parIzq);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.txtResultado);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button parIzq;
        private System.Windows.Forms.Button parDer;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button mas;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button CE;

        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button mult;

        private System.Windows.Forms.TextBox txtResultado;

        #endregion
    }
}