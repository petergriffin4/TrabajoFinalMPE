using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTRAappPanaderia2.InicioSes
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }
        private void ConfigurarFormulario()
        {
           

            
            textBoxCorreo.TabIndex = 0;
            textBoxContrasena.TabIndex = 1;
            buttonIniciarSesion.TabIndex = 2;
            buttonCancelar.TabIndex = 3;

            buttonIniciarSesion.Click += ButtonIniciarSesion_Click;
            buttonCancelar.Click += ButtonCancelar_Click;
        }

        private void ButtonIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = textBoxCorreo.Text.Trim();
            string contrasena = textBoxContrasena.Text.Trim();

            if (!correo.Contains("@"))
            {
                MessageBox.Show("Error: El correo debe contener un '@'.", "Validación de Correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!correo.EndsWith("@pan.ni"))
            {
                MessageBox.Show("Error: El correo debe terminar en '@pan.ni'.", "Validación de Correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(correo, "^[a-zA-Z0-9]{4,}@pan.ni$"))
            {
                MessageBox.Show("Error: El correo solo puede contener letras y números, con al menos 4 letras antes de '@'.", "Validación de Correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contrasena.Length < 8)
            {
                MessageBox.Show("Error: La contraseña debe tener al menos 8 caracteres.", "Validación de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(contrasena, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Error: La contraseña solo puede contener letras y números.", "Validación de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

            Form1 formPrincipal = new Form1(); 
            formPrincipal.Show();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent1()
        {
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
            this.textBoxCorreo.Location = new System.Drawing.Point(100, 150);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(200, 20);
            this.textBoxCorreo.TabIndex = 0;
            
            this.textBoxContrasena.Location = new System.Drawing.Point(100, 200);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(200, 20);
            this.textBoxContrasena.TabIndex = 1;
            
            this.buttonIniciarSesion.Location = new System.Drawing.Point(100, 250);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciarSesion.TabIndex = 2;
            this.buttonIniciarSesion.Text = "Iniciar Sesión";
            this.buttonIniciarSesion.UseVisualStyleBackColor = true;
            
            this.buttonCancelar.Location = new System.Drawing.Point(225, 250);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.Button buttonCancelar;
    }

}
