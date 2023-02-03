
namespace ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnejecutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoN = new System.Windows.Forms.Label();
            this.txtParImpar = new System.Windows.Forms.TextBox();
            this.txtPositivoNegativo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(89, 28);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(313, 29);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Ingrese un numero entero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(135, 60);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(212, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // btnejecutar
            // 
            this.btnejecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnejecutar.Location = new System.Drawing.Point(185, 103);
            this.btnejecutar.Name = "btnejecutar";
            this.btnejecutar.Size = new System.Drawing.Size(98, 47);
            this.btnejecutar.TabIndex = 2;
            this.btnejecutar.Text = "Ejecutar";
            this.btnejecutar.UseVisualStyleBackColor = true;
            this.btnejecutar.Click += new System.EventHandler(this.btnejecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paro o Impar";
            // 
            // lblPoN
            // 
            this.lblPoN.AutoSize = true;
            this.lblPoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoN.Location = new System.Drawing.Point(27, 226);
            this.lblPoN.Name = "lblPoN";
            this.lblPoN.Size = new System.Drawing.Size(161, 20);
            this.lblPoN.TabIndex = 4;
            this.lblPoN.Text = "Positivo o Negativo";
            // 
            // txtParImpar
            // 
            this.txtParImpar.Location = new System.Drawing.Point(206, 177);
            this.txtParImpar.Name = "txtParImpar";
            this.txtParImpar.Size = new System.Drawing.Size(168, 20);
            this.txtParImpar.TabIndex = 5;
            // 
            // txtPositivoNegativo
            // 
            this.txtPositivoNegativo.Location = new System.Drawing.Point(206, 226);
            this.txtPositivoNegativo.Name = "txtPositivoNegativo";
            this.txtPositivoNegativo.Size = new System.Drawing.Size(168, 20);
            this.txtPositivoNegativo.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(488, 329);
            this.Controls.Add(this.txtPositivoNegativo);
            this.Controls.Add(this.txtParImpar);
            this.Controls.Add(this.lblPoN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnejecutar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnejecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoN;
        private System.Windows.Forms.TextBox txtParImpar;
        private System.Windows.Forms.TextBox txtPositivoNegativo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

