
namespace Lab03
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
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.chkAutenticacion = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(52, 73);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(169, 22);
            this.txtServidor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base de Datos";
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(52, 154);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.Size = new System.Drawing.Size(169, 22);
            this.txtBaseDatos.TabIndex = 3;
            // 
            // chkAutenticacion
            // 
            this.chkAutenticacion.AutoSize = true;
            this.chkAutenticacion.Checked = true;
            this.chkAutenticacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutenticacion.Location = new System.Drawing.Point(52, 202);
            this.chkAutenticacion.Name = "chkAutenticacion";
            this.chkAutenticacion.Size = new System.Drawing.Size(186, 21);
            this.chkAutenticacion.TabIndex = 5;
            this.chkAutenticacion.Text = "Autentificacion Integrada";
            this.chkAutenticacion.UseVisualStyleBackColor = true;
            this.chkAutenticacion.CheckedChanged += new System.EventHandler(this.chkAutenticacion_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(247, 73);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(162, 22);
            this.txtUsuario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(247, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 22);
            this.txtPassword.TabIndex = 9;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConectar.Location = new System.Drawing.Point(52, 248);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(88, 35);
            this.btnConectar.TabIndex = 10;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEstado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstado.Location = new System.Drawing.Point(162, 248);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(88, 35);
            this.btnEstado.TabIndex = 11;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Red;
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDesconectar.Location = new System.Drawing.Point(273, 248);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(104, 35);
            this.btnDesconectar.TabIndex = 12;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(163, 301);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(101, 32);
            this.btnPersona.TabIndex = 13;
            this.btnPersona.Text = "Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 367);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkAutenticacion);
            this.Controls.Add(this.txtBaseDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServidor);
            this.Name = "Form1";
            this.Text = "Conexion a un origen de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.CheckBox chkAutenticacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnPersona;
    }
}

