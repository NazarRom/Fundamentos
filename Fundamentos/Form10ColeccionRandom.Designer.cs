namespace Fundamentos
{
    partial class Form10ColeccionRandom
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
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblPares = new System.Windows.Forms.Label();
            this.lblImpares = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtPares = new System.Windows.Forms.TextBox();
            this.txtImpares = new System.Windows.Forms.TextBox();
            this.btnSumarSelecionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Números";
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 15;
            this.lstElementos.Location = new System.Drawing.Point(43, 89);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(120, 184);
            this.lstElementos.TabIndex = 1;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(361, 30);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(164, 23);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Generar ranom";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(361, 80);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(164, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(361, 187);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(50, 15);
            this.lblSuma.TabIndex = 4;
            this.lblSuma.Text = "lblSuma";
            // 
            // lblPares
            // 
            this.lblPares.AutoSize = true;
            this.lblPares.Location = new System.Drawing.Point(361, 231);
            this.lblPares.Name = "lblPares";
            this.lblPares.Size = new System.Drawing.Size(35, 15);
            this.lblPares.TabIndex = 5;
            this.lblPares.Text = "Pares";
            // 
            // lblImpares
            // 
            this.lblImpares.AutoSize = true;
            this.lblImpares.Location = new System.Drawing.Point(361, 272);
            this.lblImpares.Name = "lblImpares";
            this.lblImpares.Size = new System.Drawing.Size(49, 15);
            this.lblImpares.TabIndex = 6;
            this.lblImpares.Text = "Impares";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(425, 187);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 23);
            this.txtSuma.TabIndex = 7;
            // 
            // txtPares
            // 
            this.txtPares.Location = new System.Drawing.Point(425, 228);
            this.txtPares.Name = "txtPares";
            this.txtPares.Size = new System.Drawing.Size(100, 23);
            this.txtPares.TabIndex = 8;
            // 
            // txtImpares
            // 
            this.txtImpares.Location = new System.Drawing.Point(425, 264);
            this.txtImpares.Name = "txtImpares";
            this.txtImpares.Size = new System.Drawing.Size(100, 23);
            this.txtImpares.TabIndex = 9;
            // 
            // btnSumarSelecionados
            // 
            this.btnSumarSelecionados.Location = new System.Drawing.Point(361, 131);
            this.btnSumarSelecionados.Name = "btnSumarSelecionados";
            this.btnSumarSelecionados.Size = new System.Drawing.Size(164, 23);
            this.btnSumarSelecionados.TabIndex = 10;
            this.btnSumarSelecionados.Text = "Mostrar Seleccionados";
            this.btnSumarSelecionados.UseVisualStyleBackColor = true;
            this.btnSumarSelecionados.Click += new System.EventHandler(this.btnSumarSelecionados_Click);
            // 
            // Form10ColeccionRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 640);
            this.Controls.Add(this.btnSumarSelecionados);
            this.Controls.Add(this.txtImpares);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.lblImpares);
            this.Controls.Add(this.lblPares);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.label1);
            this.Name = "Form10ColeccionRandom";
            this.Text = "Form10ColeccionRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private Button btnRandom;
        private Button btnMostrar;
        private Label lblSuma;
        private Label lblPares;
        private Label lblImpares;
        private TextBox txtSuma;
        private TextBox txtPares;
        private TextBox txtImpares;
        private Button btnSumarSelecionados;
    }
}