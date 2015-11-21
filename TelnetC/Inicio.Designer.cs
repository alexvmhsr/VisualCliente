namespace TelnetC
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Probar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblOK = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lblKO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Probar
            // 
            this.btn_Probar.Location = new System.Drawing.Point(214, 110);
            this.btn_Probar.Name = "btn_Probar";
            this.btn_Probar.Size = new System.Drawing.Size(75, 23);
            this.btn_Probar.TabIndex = 1;
            this.btn_Probar.Text = "Probar";
            this.btn_Probar.UseVisualStyleBackColor = true;
            this.btn_Probar.Click += new System.EventHandler(this.btn_Probar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar IP del Servidor:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(157, 24);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 4;
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOK.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblOK.Location = new System.Drawing.Point(12, 128);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(157, 20);
            this.lblOK.TabIndex = 6;
            this.lblOK.Text = "Conexión Correcta";
            this.lblOK.Visible = false;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(53, 173);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ingresar.TabIndex = 7;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(182, 173);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lblKO
            // 
            this.lblKO.AutoSize = true;
            this.lblKO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKO.ForeColor = System.Drawing.Color.Red;
            this.lblKO.Location = new System.Drawing.Point(12, 98);
            this.lblKO.Name = "lblKO";
            this.lblKO.Size = new System.Drawing.Size(170, 20);
            this.lblKO.TabIndex = 9;
            this.lblKO.Text = "Conexión Incorrecta";
            this.lblKO.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Puerto:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(158, 51);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(100, 20);
            this.txtPuerto.TabIndex = 11;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 220);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKO);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lblOK);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Probar);
            this.Name = "Inicio";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Probar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblOK;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lblKO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPuerto;
    }
}

