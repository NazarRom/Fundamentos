namespace Fundamentos
{
    partial class Form09ColeccionMultiple
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
            this.lblItem = new System.Windows.Forms.Label();
            this.lblIndice = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtNewElement = new System.Windows.Forms.TextBox();
            this.lblNewElement = new System.Windows.Forms.Label();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.lblElementos = new System.Windows.Forms.Label();
            this.btnSeleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblItem.Location = new System.Drawing.Point(93, 397);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(44, 15);
            this.lblItem.TabIndex = 17;
            this.lblItem.Text = "lblItem";
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIndice.Location = new System.Drawing.Point(93, 359);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(52, 15);
            this.lblIndice.TabIndex = 16;
            this.lblIndice.Text = "lblIndice";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteAll.Location = new System.Drawing.Point(497, 174);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(211, 23);
            this.btnDeleteAll.TabIndex = 15;
            this.btnDeleteAll.Text = "Borrar Todo";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(497, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertar.Location = new System.Drawing.Point(497, 115);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(211, 23);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtNewElement
            // 
            this.txtNewElement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNewElement.Location = new System.Drawing.Point(497, 74);
            this.txtNewElement.Name = "txtNewElement";
            this.txtNewElement.Size = new System.Drawing.Size(211, 23);
            this.txtNewElement.TabIndex = 12;
            // 
            // lblNewElement
            // 
            this.lblNewElement.AutoSize = true;
            this.lblNewElement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNewElement.Location = new System.Drawing.Point(497, 52);
            this.lblNewElement.Name = "lblNewElement";
            this.lblNewElement.Size = new System.Drawing.Size(95, 15);
            this.lblNewElement.TabIndex = 11;
            this.lblNewElement.Text = "Nuevo Elemento";
            // 
            // lstElementos
            // 
            this.lstElementos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 15;
            this.lstElementos.Location = new System.Drawing.Point(93, 74);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(120, 259);
            this.lstElementos.TabIndex = 10;
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblElementos.Location = new System.Drawing.Point(93, 39);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(62, 15);
            this.lblElementos.TabIndex = 9;
            this.lblElementos.Text = "Elementos";
            // 
            // btnSeleccionados
            // 
            this.btnSeleccionados.Location = new System.Drawing.Point(497, 310);
            this.btnSeleccionados.Name = "btnSeleccionados";
            this.btnSeleccionados.Size = new System.Drawing.Size(219, 23);
            this.btnSeleccionados.TabIndex = 18;
            this.btnSeleccionados.Text = "Seleccionados";
            this.btnSeleccionados.UseVisualStyleBackColor = true;
            this.btnSeleccionados.Click += new System.EventHandler(this.btnSeleccionados_Click);
            // 
            // Form09ColeccionMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeleccionados);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtNewElement);
            this.Controls.Add(this.lblNewElement);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.lblElementos);
            this.Name = "Form09ColeccionMultiple";
            this.Text = "Form09ColeccionMultiple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblItem;
        private Label lblIndice;
        private Button btnDeleteAll;
        private Button btnDelete;
        private Button btnInsertar;
        private TextBox txtNewElement;
        private Label lblNewElement;
        private ListBox lstElementos;
        private Label lblElementos;
        private Button btnSeleccionados;
    }
}