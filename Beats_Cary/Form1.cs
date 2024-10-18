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
    public partial class fr_grafica : Form
    {
        public fr_grafica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usu_ini_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonRegistro();
        }

        private void cla_ini_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonRegistro();
        }

        private void HabilitarBotonRegistro()
        {
            // Verificar si todos los campos tienen texto
            btn_ini.Enabled = !string.IsNullOrEmpty(usu_ini.Text) &&
                              !string.IsNullOrEmpty(cla_ini.Text);
        }

        private void reg_ini_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fr_registro formularioRegistro = new fr_registro();  //Se hace el llamado del formulario de registro
            formularioRegistro.Show(); //Se muestra el formulario de registro
            this.Hide();
        }

        private void box_ini_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
