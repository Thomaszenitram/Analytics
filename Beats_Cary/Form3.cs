using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beats_Cary
{
    public partial class fr_registro : Form
    {
        public fr_registro()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fr_registro_Load(object sender, EventArgs e)
        {
            HabilitarBotonRegistro();
        }

        private void nom_reg_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonRegistro();
        }

        private void corr_reg_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonRegistro();
        }

        private void cla_reg_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonRegistro();
        }

        private void cla2_reg_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonRegistro();
        }

        private void HabilitarBotonRegistro()
        {
            // Verificar si todos los campos tienen texto
            reg_btn.Enabled = !string.IsNullOrEmpty(nom_reg.Text) &&
                              !string.IsNullOrEmpty(corr_reg.Text) &&
                              !string.IsNullOrEmpty(cla_reg.Text) &&
                              !string.IsNullOrEmpty(cla2_reg.Text);
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            // Verificar si las contraseñas coinciden
            if (cla_reg.Text != cla2_reg.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Inténtalo de nuevo.");
                return;
            }

            string nombre = nom_reg.Text;
            string correo = corr_reg.Text;
            string contraseña = cla_reg.Text;

            MessageBox.Show("Registro exitoso!");

            nom_reg.Text = "";
            corr_reg.Text = "";
            cla_reg.Text = "";
            cla2_reg.Text = "";

            fr_grafica formularioLogin = new fr_grafica();
            formularioLogin.Show();
            this.Hide();
        }

        private void ini_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fr_grafica formularioLogin = new fr_grafica();  // Crear instancia del formulario de inicio de sesión
            formularioLogin.Show();  // Mostrar el formulario de inicio de sesión
            this.Hide();  // Ocultar el formulario de registro actual
        }
    }
}
