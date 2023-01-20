namespace Fundamentos
{
    partial class Form20TemperaturasAnualesClases
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTempMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTempAnual = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.comboAnios = new System.Windows.Forms.ComboBox();
            this.txtMedAnual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinAnual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxAnual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpMes = new System.Windows.Forms.GroupBox();
            this.gpAnio = new System.Windows.Forms.GroupBox();
            this.gpMes.SuspendLayout();
            this.gpAnio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeses.Location = new System.Drawing.Point(34, 132);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(65, 25);
            this.lblMeses.TabIndex = 20;
            this.lblMeses.Text = "Meses";
            // 
            // btnMeses
            // 
            this.btnMeses.Location = new System.Drawing.Point(319, 72);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(115, 43);
            this.btnMeses.TabIndex = 21;
            this.btnMeses.Text = "Generar Meses";
            this.btnMeses.UseVisualStyleBackColor = true;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 15;
            this.lstMeses.Location = new System.Drawing.Point(34, 169);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(172, 259);
            this.lstMeses.TabIndex = 29;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Temperatura máxima";
            // 
            // txtTempMax
            // 
            this.txtTempMax.Location = new System.Drawing.Point(54, 65);
            this.txtTempMax.Name = "txtTempMax";
            this.txtTempMax.Size = new System.Drawing.Size(116, 23);
            this.txtTempMax.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Temperatura minima";
            // 
            // txtTempMin
            // 
            this.txtTempMin.Location = new System.Drawing.Point(54, 128);
            this.txtTempMin.Name = "txtTempMin";
            this.txtTempMin.Size = new System.Drawing.Size(116, 23);
            this.txtTempMin.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "media ";
            // 
            // txtTempAnual
            // 
            this.txtTempAnual.Location = new System.Drawing.Point(54, 187);
            this.txtTempAnual.Name = "txtTempAnual";
            this.txtTempAnual.Size = new System.Drawing.Size(116, 23);
            this.txtTempAnual.TabIndex = 28;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(34, 26);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(34, 15);
            this.lblAnio.TabIndex = 30;
            this.lblAnio.Text = "Años";
            // 
            // comboAnios
            // 
            this.comboAnios.FormattingEnabled = true;
            this.comboAnios.Location = new System.Drawing.Point(34, 59);
            this.comboAnios.Name = "comboAnios";
            this.comboAnios.Size = new System.Drawing.Size(121, 23);
            this.comboAnios.TabIndex = 31;
            this.comboAnios.SelectedIndexChanged += new System.EventHandler(this.comboAnios_SelectedIndexChanged);
            // 
            // txtMedAnual
            // 
            this.txtMedAnual.Location = new System.Drawing.Point(52, 195);
            this.txtMedAnual.Name = "txtMedAnual";
            this.txtMedAnual.Size = new System.Drawing.Size(116, 23);
            this.txtMedAnual.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "MediaAnual";
            // 
            // txtMinAnual
            // 
            this.txtMinAnual.Location = new System.Drawing.Point(52, 136);
            this.txtMinAnual.Name = "txtMinAnual";
            this.txtMinAnual.Size = new System.Drawing.Size(116, 23);
            this.txtMinAnual.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "MinimaAnual";
            // 
            // txtMaxAnual
            // 
            this.txtMaxAnual.Location = new System.Drawing.Point(52, 73);
            this.txtMaxAnual.Name = "txtMaxAnual";
            this.txtMaxAnual.Size = new System.Drawing.Size(116, 23);
            this.txtMaxAnual.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "MaxiamaAnual";
            // 
            // gpMes
            // 
            this.gpMes.Controls.Add(this.txtTempAnual);
            this.gpMes.Controls.Add(this.label3);
            this.gpMes.Controls.Add(this.txtTempMin);
            this.gpMes.Controls.Add(this.label2);
            this.gpMes.Controls.Add(this.txtTempMax);
            this.gpMes.Controls.Add(this.label1);
            this.gpMes.Location = new System.Drawing.Point(262, 185);
            this.gpMes.Name = "gpMes";
            this.gpMes.Size = new System.Drawing.Size(234, 243);
            this.gpMes.TabIndex = 39;
            this.gpMes.TabStop = false;
            this.gpMes.Text = "datosMes";
            // 
            // gpAnio
            // 
            this.gpAnio.Controls.Add(this.label6);
            this.gpAnio.Controls.Add(this.txtMedAnual);
            this.gpAnio.Controls.Add(this.label4);
            this.gpAnio.Controls.Add(this.txtMinAnual);
            this.gpAnio.Controls.Add(this.label5);
            this.gpAnio.Controls.Add(this.txtMaxAnual);
            this.gpAnio.Location = new System.Drawing.Point(508, 185);
            this.gpAnio.Name = "gpAnio";
            this.gpAnio.Size = new System.Drawing.Size(251, 245);
            this.gpAnio.TabIndex = 40;
            this.gpAnio.TabStop = false;
            this.gpAnio.Text = "datosAnio";
            // 
            // Form20TemperaturasAnualesClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpAnio);
            this.Controls.Add(this.gpMes);
            this.Controls.Add(this.comboAnios);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.lblMeses);
            this.Name = "Form20TemperaturasAnualesClases";
            this.Text = "Form20TemperaturasAnualesClases";
            this.gpMes.ResumeLayout(false);
            this.gpMes.PerformLayout();
            this.gpAnio.ResumeLayout(false);
            this.gpAnio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMeses;
        private Button btnMeses;
        private ListBox lstMeses;
        private Label label1;
        private TextBox txtTempMax;
        private Label label2;
        private TextBox txtTempMin;
        private Label label3;
        private TextBox txtTempAnual;
        private Label lblAnio;
        private ComboBox comboAnios;
        private TextBox txtMedAnual;
        private Label label4;
        private TextBox txtMinAnual;
        private Label label5;
        private TextBox txtMaxAnual;
        private Label label6;
        private GroupBox gpMes;
        private GroupBox gpAnio;
    }
}