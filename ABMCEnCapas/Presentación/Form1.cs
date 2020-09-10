using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMCEnCapas
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtUsuario.Text) || String.IsNullOrEmpty (txtContraseña.Text) )
            {
                mensajeError("Por favor ingrese usuario y/o contraseña");
            }
            else
            {
              
            }


        }

        private void mensajeError(string msj)
        {
            lblMensajeError.Text = "        "+msj;
            lblMensajeError.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

