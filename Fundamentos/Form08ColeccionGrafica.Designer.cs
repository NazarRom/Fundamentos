namespace Fundamentos
{
    partial class Form08ColeccionGrafica
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
            this.lblElementos = new System.Windows.Forms.Label();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.lblNewElement = new System.Windows.Forms.Label();
            this.txtNewElement = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(39, 37);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(62, 15);
            this.lblElementos.TabIndex = 0;
            this.lblElementos.Text = "Elementos";
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 15;
            this.lstElementos.Location = new System.Drawing.Point(39, 72);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(120, 259);
            this.lstElementos.TabIndex = 1;
            this.lstElementos.SelectedIndexChanged += new System.EventHandler(this.lstElementos_SelectedIndexChanged);
            // 
            // lblNewElement
            // 
            this.lblNewElement.AutoSize = true;
            this.lblNewElement.Location = new System.Drawing.Point(443, 50);
            this.lblNewElement.Name = "lblNewElement";
            this.lblNewElement.Size = new System.Drawing.Size(95, 15);
            this.lblNewElement.TabIndex = 2;
            this.lblNewElement.Text = "Nuevo Elemento";
            // 
            // txtNewElement
            // 
            this.txtNewElement.Location = new System.Drawing.Point(443, 72);
            this.txtNewElement.Name = "txtNewElement";
            this.txtNewElement.Size = new System.Drawing.Size(211, 23);
            this.txtNewElement.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(443, 113);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(211, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(443, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(443, 172);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(211, 23);
            this.btnDeleteAll.TabIndex = 6;
            this.btnDeleteAll.Text = "Borrar Todo";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(39, 357);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(52, 15);
            this.lblIndice.TabIndex = 7;
            this.lblIndice.Text = "lblIndice";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(39, 395);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(44, 15);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "lblItem";
            // 
            // Form08ColeccionGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtNewElement);
            this.Controls.Add(this.lblNewElement);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.lblElementos);
            this.Name = "Form08ColeccionGrafica";
            this.Text = "Form08ColeccionGrafica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblElementos;
        private ListBox lstElementos;
        private Label lblNewElement;
        private TextBox txtNewElement;
        private Button btnInsertar;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Label lblIndice;
        private Label lblItem;
    }
}