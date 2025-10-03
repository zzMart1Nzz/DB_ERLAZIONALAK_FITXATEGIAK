using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_Taldea5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Size = new Size(960, 490);
        }

        private void btnSaioHasi_Click(object sender, EventArgs e)
        {
            // Usuario y contraseña fijos para pruebas
            string erabiltzaileZuzena = "admin";
            string PasswordZuzena = "1234";

            // Tomamos los valores de los TextBox
            string usuario = txtErabiltzailea.Text;
            string contrasena = txtPassword.Text;

            // Validamos
            if (usuario == erabiltzaileZuzena && contrasena == PasswordZuzena)
            {
                // Mensaje de éxito
                MessageBox.Show("Login exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario o layout
                this.Close();
            }
            else
            {
                // Mensaje de fallo
                MessageBox.Show("Usuario o contraseña incorrectos. Intenta de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpiar los TextBox
                txtErabiltzailea.Clear();
                txtPassword.Clear();

                // Opcional: poner el cursor en el primer TextBox
                txtErabiltzailea.Focus();
            }
        }

    }
}
