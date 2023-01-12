namespace Fundamentos
{
    partial class Form05Char
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.txtSimbolos = new System.Windows.Forms.TextBox();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letras";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(37, 58);
            this.txtLetra.Multiline = true;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(200, 126);
            this.txtLetra.TabIndex = 1;
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(619, 58);
            this.txtNumeros.Multiline = true;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(200, 126);
            this.txtNumeros.TabIndex = 2;
            // 
            // txtSimbolos
            // 
            this.txtSimbolos.Location = new System.Drawing.Point(37, 324);
            this.txtSimbolos.Multiline = true;
            this.txtSimbolos.Name = "txtSimbolos";
            this.txtSimbolos.Size = new System.Drawing.Size(200, 126);
            this.txtSimbolos.TabIndex = 3;
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(633, 312);
            this.txtPuntuacion.Multiline = true;
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(200, 126);
            this.txtPuntuacion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Números";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puntuación";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Símbolos";
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(356, 441);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(133, 39);
            this.btnRecorrer.TabIndex = 8;
            this.btnRecorrer.Text = "RecorrerASCII";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // Form05Char
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 503);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.txtSimbolos);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.label1);
            this.Name = "Form05Char";
            this.Text = "Form05Char";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtLetra;
        private TextBox txtNumeros;
        private TextBox txtSimbolos;
        private TextBox txtPuntuacion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRecorrer;
    }
}