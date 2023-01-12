namespace Fundamentos
{
    partial class Form04DateTime
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
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.chkFormato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIncremento = new System.Windows.Forms.Button();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbAnyo = new System.Windows.Forms.RadioButton();
            this.rdbMeses = new System.Windows.Forms.RadioButton();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFecha.Location = new System.Drawing.Point(56, 67);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(648, 33);
            this.txtFecha.TabIndex = 0;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaActual.Location = new System.Drawing.Point(71, 40);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(93, 20);
            this.lblFechaActual.TabIndex = 1;
            this.lblFechaActual.Text = "Fecha Actual";
            // 
            // chkFormato
            // 
            this.chkFormato.AutoSize = true;
            this.chkFormato.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFormato.Location = new System.Drawing.Point(71, 116);
            this.chkFormato.Name = "chkFormato";
            this.chkFormato.Size = new System.Drawing.Size(231, 29);
            this.chkFormato.TabIndex = 2;
            this.chkFormato.Text = "Cambiar Formato Fecha";
            this.chkFormato.UseVisualStyleBackColor = true;
            this.chkFormato.CheckedChanged += new System.EventHandler(this.chkFormato_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncremento);
            this.groupBox1.Controls.Add(this.txtIncremento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbAnyo);
            this.groupBox1.Controls.Add(this.rdbMeses);
            this.groupBox1.Controls.Add(this.rdbDias);
            this.groupBox1.Location = new System.Drawing.Point(42, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incrementar fecha";
            // 
            // btnIncremento
            // 
            this.btnIncremento.Location = new System.Drawing.Point(118, 130);
            this.btnIncremento.Name = "btnIncremento";
            this.btnIncremento.Size = new System.Drawing.Size(192, 23);
            this.btnIncremento.TabIndex = 5;
            this.btnIncremento.Text = "Incremento";
            this.btnIncremento.UseVisualStyleBackColor = true;
            this.btnIncremento.Click += new System.EventHandler(this.btnIncremento_Click);
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(201, 44);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(100, 23);
            this.txtIncremento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Incremento";
            // 
            // rdbAnyo
            // 
            this.rdbAnyo.AutoSize = true;
            this.rdbAnyo.Location = new System.Drawing.Point(21, 134);
            this.rdbAnyo.Name = "rdbAnyo";
            this.rdbAnyo.Size = new System.Drawing.Size(52, 19);
            this.rdbAnyo.TabIndex = 2;
            this.rdbAnyo.TabStop = true;
            this.rdbAnyo.Text = "Años";
            this.rdbAnyo.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            this.rdbMeses.AutoSize = true;
            this.rdbMeses.Location = new System.Drawing.Point(22, 76);
            this.rdbMeses.Name = "rdbMeses";
            this.rdbMeses.Size = new System.Drawing.Size(58, 19);
            this.rdbMeses.TabIndex = 1;
            this.rdbMeses.TabStop = true;
            this.rdbMeses.Text = "Meses";
            this.rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.Location = new System.Drawing.Point(25, 26);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(47, 19);
            this.rdbDias.TabIndex = 0;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Dias";
            this.rdbDias.UseVisualStyleBackColor = true;
            this.rdbDias.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva Fecha";
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(61, 406);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(643, 23);
            this.txtNuevaFecha.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkFormato);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.txtFecha);
            this.Name = "Form04DateTime";
            this.Text = "Form04DateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFecha;
        private Label lblFechaActual;
        private CheckBox chkFormato;
        private GroupBox groupBox1;
        private RadioButton rdbAnyo;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private Button btnIncremento;
        private TextBox txtIncremento;
        private Label label1;
        private Label label2;
        private TextBox txtNuevaFecha;
    }
}