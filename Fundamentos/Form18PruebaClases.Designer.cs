namespace Fundamentos
{
    partial class Form18PruebaClases
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
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.Datos = new System.Windows.Forms.Label();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.ItemHeight = 15;
            this.lstPersonas.Location = new System.Drawing.Point(40, 51);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(632, 349);
            this.lstPersonas.TabIndex = 0;
            // 
            // Datos
            // 
            this.Datos.AutoSize = true;
            this.Datos.Location = new System.Drawing.Point(47, 20);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(38, 15);
            this.Datos.TabIndex = 1;
            this.Datos.Text = "label1";
            // 
            // btnPersonas
            // 
            this.btnPersonas.Location = new System.Drawing.Point(813, 70);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(103, 41);
            this.btnPersonas.TabIndex = 2;
            this.btnPersonas.Text = "ver Personas";
            this.btnPersonas.UseVisualStyleBackColor = true;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(688, 70);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(87, 56);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "Crear Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // Form18PruebaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnPersonas);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.lstPersonas);
            this.Name = "Form18PruebaClases";
            this.Text = "Form18PruebaClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstPersonas;
        private Label Datos;
        private Button btnPersonas;
        private Button btnEmpleados;
    }
}