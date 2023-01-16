namespace Fundamentos
{
    partial class Form17TemperaturasAnuales
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
            this.lblMeses = new System.Windows.Forms.Label();
            this.btnMeses = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTempMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTempAnual = new System.Windows.Forms.TextBox();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeses.Location = new System.Drawing.Point(65, 80);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(65, 25);
            this.lblMeses.TabIndex = 0;
            this.lblMeses.Text = "Meses";
            // 
            // btnMeses
            // 
            this.btnMeses.Location = new System.Drawing.Point(350, 107);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(116, 43);
            this.btnMeses.TabIndex = 1;
            this.btnMeses.Text = "Generar Meses";
            this.btnMeses.UseVisualStyleBackColor = true;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(350, 166);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(116, 38);
            this.btnDatos.TabIndex = 2;
            this.btnDatos.Text = "Mostar datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperatura máxima";
            // 
            // txtTempMax
            // 
            this.txtTempMax.Location = new System.Drawing.Point(347, 285);
            this.txtTempMax.Name = "txtTempMax";
            this.txtTempMax.Size = new System.Drawing.Size(117, 23);
            this.txtTempMax.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperatura minima";
            // 
            // txtTempMin
            // 
            this.txtTempMin.Location = new System.Drawing.Point(347, 348);
            this.txtTempMin.Name = "txtTempMin";
            this.txtTempMin.Size = new System.Drawing.Size(117, 23);
            this.txtTempMin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "media anual";
            // 
            // txtTempAnual
            // 
            this.txtTempAnual.Location = new System.Drawing.Point(347, 407);
            this.txtTempAnual.Name = "txtTempAnual";
            this.txtTempAnual.Size = new System.Drawing.Size(117, 23);
            this.txtTempAnual.TabIndex = 8;
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 15;
            this.lstMeses.Location = new System.Drawing.Point(65, 127);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(173, 319);
            this.lstMeses.TabIndex = 9;
            // 
            // Form17TemperaturasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.txtTempAnual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTempMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTempMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.lblMeses);
            this.Name = "Form17TemperaturasAnuales";
            this.Text = "Form17TemperaturasAnuales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMeses;
        private Button btnMeses;
        private Button btnDatos;
        private Label label1;
        private TextBox txtTempMax;
        private Label label2;
        private TextBox txtTempMin;
        private Label label3;
        private TextBox txtTempAnual;
        private ListBox lstMeses;
    }
}