namespace Fundamentos
{
    partial class Form02ColoresPosicion
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
            this.txtPositionX = new System.Windows.Forms.TextBox();
            this.txtPositionY = new System.Windows.Forms.TextBox();
            this.lblPositionX = new System.Windows.Forms.Label();
            this.lblPositionY = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.btnCambiarColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPositionX
            // 
            this.txtPositionX.Location = new System.Drawing.Point(190, 34);
            this.txtPositionX.Name = "txtPositionX";
            this.txtPositionX.Size = new System.Drawing.Size(100, 23);
            this.txtPositionX.TabIndex = 0;
            this.txtPositionX.Text = "x";
            // 
            // txtPositionY
            // 
            this.txtPositionY.Location = new System.Drawing.Point(190, 94);
            this.txtPositionY.Name = "txtPositionY";
            this.txtPositionY.Size = new System.Drawing.Size(100, 23);
            this.txtPositionY.TabIndex = 1;
            this.txtPositionY.Text = "y";
            // 
            // lblPositionX
            // 
            this.lblPositionX.AutoSize = true;
            this.lblPositionX.Location = new System.Drawing.Point(64, 37);
            this.lblPositionX.Name = "lblPositionX";
            this.lblPositionX.Size = new System.Drawing.Size(62, 15);
            this.lblPositionX.TabIndex = 2;
            this.lblPositionX.Text = "Posición X";
            // 
            // lblPositionY
            // 
            this.lblPositionY.AutoSize = true;
            this.lblPositionY.Location = new System.Drawing.Point(64, 97);
            this.lblPositionY.Name = "lblPositionY";
            this.lblPositionY.Size = new System.Drawing.Size(62, 15);
            this.lblPositionY.TabIndex = 3;
            this.lblPositionY.Text = "Posición Y";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(122, 153);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(580, 69);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(31, 15);
            this.lblRed.TabIndex = 5;
            this.lblRed.Text = "Rojo";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(580, 110);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 15);
            this.lblGreen.TabIndex = 6;
            this.lblGreen.Text = "Verde";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(580, 157);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(30, 15);
            this.lblBlue.TabIndex = 7;
            this.lblBlue.Text = "Azúl";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(660, 66);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(100, 23);
            this.txtRed.TabIndex = 8;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(660, 102);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(100, 23);
            this.txtGreen.TabIndex = 9;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(660, 153);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(100, 23);
            this.txtBlue.TabIndex = 10;
            // 
            // btnCambiarColor
            // 
            this.btnCambiarColor.Location = new System.Drawing.Point(634, 212);
            this.btnCambiarColor.Name = "btnCambiarColor";
            this.btnCambiarColor.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarColor.TabIndex = 11;
            this.btnCambiarColor.Text = "COLOR";
            this.btnCambiarColor.UseVisualStyleBackColor = true;
            this.btnCambiarColor.Click += new System.EventHandler(this.btnCambiarColor_Click);
            // 
            // Form02ColoresPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCambiarColor);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblPositionY);
            this.Controls.Add(this.lblPositionX);
            this.Controls.Add(this.txtPositionY);
            this.Controls.Add(this.txtPositionX);
            this.Name = "Form02ColoresPosicion";
            this.Text = "Form02ColoresPosicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPositionX;
        private TextBox txtPositionY;
        private Label lblPositionX;
        private Label lblPositionY;
        private Button btnCambiar;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private TextBox txtRed;
        private TextBox txtGreen;
        private TextBox txtBlue;
        private Button btnCambiarColor;
    }
}