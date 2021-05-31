namespace EstudoSwitch
{
    partial class frmSwitch
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
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btnVerificarNumero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número a ser verificado:";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(131, 6);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 1;
            // 
            // btnVerificarNumero
            // 
            this.btnVerificarNumero.Location = new System.Drawing.Point(237, 4);
            this.btnVerificarNumero.Name = "btnVerificarNumero";
            this.btnVerificarNumero.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarNumero.TabIndex = 2;
            this.btnVerificarNumero.Text = "Verificar";
            this.btnVerificarNumero.UseVisualStyleBackColor = true;
            this.btnVerificarNumero.Click += new System.EventHandler(this.btnVerificarNumero_Click);
            // 
            // frmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 35);
            this.Controls.Add(this.btnVerificarNumero);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmSwitch";
            this.Text = "TreinaWeb - Estudo do Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Button btnVerificarNumero;
    }
}

