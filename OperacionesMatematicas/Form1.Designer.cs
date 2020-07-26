namespace OperacionesMatematicas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.BTNSUMAR = new System.Windows.Forms.Button();
            this.BTNRESTAR = new System.Windows.Forms.Button();
            this.BTNMULTIPLICAR = new System.Windows.Forms.Button();
            this.BTNDIVIDIR = new System.Windows.Forms.Button();
            this.BTNLIMPIAR = new System.Windows.Forms.Button();
            this.LBLRESULTADO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Cientifica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa un numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa otro numero";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero1.Location = new System.Drawing.Point(378, 109);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(152, 38);
            this.txtnumero1.TabIndex = 3;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero2.Location = new System.Drawing.Point(378, 184);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(152, 38);
            this.txtnumero2.TabIndex = 4;
            // 
            // BTNSUMAR
            // 
            this.BTNSUMAR.Location = new System.Drawing.Point(150, 263);
            this.BTNSUMAR.Name = "BTNSUMAR";
            this.BTNSUMAR.Size = new System.Drawing.Size(92, 31);
            this.BTNSUMAR.TabIndex = 5;
            this.BTNSUMAR.Text = "SUMAR";
            this.BTNSUMAR.UseVisualStyleBackColor = true;
            this.BTNSUMAR.Click += new System.EventHandler(this.BTNSUMAR_Click);
            // 
            // BTNRESTAR
            // 
            this.BTNRESTAR.Location = new System.Drawing.Point(285, 263);
            this.BTNRESTAR.Name = "BTNRESTAR";
            this.BTNRESTAR.Size = new System.Drawing.Size(92, 31);
            this.BTNRESTAR.TabIndex = 6;
            this.BTNRESTAR.Text = "RESTAR";
            this.BTNRESTAR.UseVisualStyleBackColor = true;
            this.BTNRESTAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNMULTIPLICAR
            // 
            this.BTNMULTIPLICAR.Location = new System.Drawing.Point(414, 263);
            this.BTNMULTIPLICAR.Name = "BTNMULTIPLICAR";
            this.BTNMULTIPLICAR.Size = new System.Drawing.Size(92, 31);
            this.BTNMULTIPLICAR.TabIndex = 7;
            this.BTNMULTIPLICAR.Text = "MULTIPLICAR";
            this.BTNMULTIPLICAR.UseVisualStyleBackColor = true;
            this.BTNMULTIPLICAR.Click += new System.EventHandler(this.BTNMULTIPLICAR_Click);
            // 
            // BTNDIVIDIR
            // 
            this.BTNDIVIDIR.Location = new System.Drawing.Point(553, 263);
            this.BTNDIVIDIR.Name = "BTNDIVIDIR";
            this.BTNDIVIDIR.Size = new System.Drawing.Size(92, 31);
            this.BTNDIVIDIR.TabIndex = 8;
            this.BTNDIVIDIR.Text = "DIVIDIR";
            this.BTNDIVIDIR.UseVisualStyleBackColor = true;
            this.BTNDIVIDIR.Click += new System.EventHandler(this.BTNDIVIDIR_Click);
            // 
            // BTNLIMPIAR
            // 
            this.BTNLIMPIAR.Location = new System.Drawing.Point(573, 130);
            this.BTNLIMPIAR.Name = "BTNLIMPIAR";
            this.BTNLIMPIAR.Size = new System.Drawing.Size(101, 53);
            this.BTNLIMPIAR.TabIndex = 9;
            this.BTNLIMPIAR.Text = "LIMPIAR CAMPOS";
            this.BTNLIMPIAR.UseVisualStyleBackColor = true;
            this.BTNLIMPIAR.Click += new System.EventHandler(this.BTNLIMPIAR_Click);
            // 
            // LBLRESULTADO
            // 
            this.LBLRESULTADO.AutoSize = true;
            this.LBLRESULTADO.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESULTADO.Location = new System.Drawing.Point(357, 353);
            this.LBLRESULTADO.Name = "LBLRESULTADO";
            this.LBLRESULTADO.Size = new System.Drawing.Size(37, 41);
            this.LBLRESULTADO.TabIndex = 10;
            this.LBLRESULTADO.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLRESULTADO);
            this.Controls.Add(this.BTNLIMPIAR);
            this.Controls.Add(this.BTNDIVIDIR);
            this.Controls.Add(this.BTNMULTIPLICAR);
            this.Controls.Add(this.BTNRESTAR);
            this.Controls.Add(this.BTNSUMAR);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Button BTNSUMAR;
        private System.Windows.Forms.Button BTNRESTAR;
        private System.Windows.Forms.Button BTNMULTIPLICAR;
        private System.Windows.Forms.Button BTNDIVIDIR;
        private System.Windows.Forms.Button BTNLIMPIAR;
        private System.Windows.Forms.Label LBLRESULTADO;
    }
}

