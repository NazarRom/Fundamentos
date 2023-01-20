namespace Fundamentos
{
    partial class Form19TemperaturasClase
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.txtTempAnual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTempMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnMeses = new System.Windows.Forms.Button();
            this.lblMeses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 15;
            this.lstMeses.Location = new System.Drawing.Point(200, 89);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(173, 319);
            this.lstMeses.TabIndex = 19;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // txtTempAnual
            // 
            this.txtTempAnual.Location = new System.Drawing.Point(482, 369);
            this.txtTempAnual.Name = "txtTempAnual";
            this.txtTempAnual.Size = new System.Drawing.Size(117, 23);
            this.txtTempAnual.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "media anual";
            // 
            // txtTempMin
            // 
            this.txtTempMin.Location = new System.Drawing.Point(482, 310);
            this.txtTempMin.Name = "txtTempMin";
            this.txtTempMin.Size = new System.Drawing.Size(117, 23);
            this.txtTempMin.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Temperatura minima";
            // 
            // txtTempMax
            // 
            this.txtTempMax.Location = new System.Drawing.Point(482, 247);
            this.txtTempMax.Name = "txtTempMax";
            this.txtTempMax.Size = new System.Drawing.Size(117, 23);
            this.txtTempMax.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Temperatura máxima";
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(485, 128);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(116, 38);
            this.btnDatos.TabIndex = 12;
            this.btnDatos.Text = "Mostar datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            // 
            // btnMeses
            // 
            this.btnMeses.Location = new System.Drawing.Point(485, 69);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(116, 43);
            this.btnMeses.TabIndex = 11;
            this.btnMeses.Text = "Generar Meses";
            this.btnMeses.UseVisualStyleBackColor = true;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeses.Location = new System.Drawing.Point(200, 42);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(65, 25);
            this.lblMeses.TabIndex = 10;
            this.lblMeses.Text = "Meses";
            // 
            // Form19TemperaturasClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form19TemperaturasClase";
            this.Text = "Form19TemperaturasClase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstMeses;
        private TextBox txtTempAnual;
        private Label label3;
        private TextBox txtTempMin;
        private Label label2;
        private TextBox txtTempMax;
        private Label label1;
        private Button btnDatos;
        private Button btnMeses;
        private Label lblMeses;
    }
}