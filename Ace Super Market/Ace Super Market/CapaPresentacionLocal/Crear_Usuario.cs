using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaPresentacionLocal
{
    public partial class Crear_Usuario : Form
    {
        public Crear_Usuario()
        {
            InitializeComponent();
        }

        private void cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrar_MouseEnter(object sender, EventArgs e)
        {
            this.cerrar.Image = ((System.Drawing.Image)(Properties.Resources.cerrar_over));
        }

        private void cerrar_MouseLeave(object sender, EventArgs e)
        {
            this.cerrar.Image = ((System.Drawing.Image)(Properties.Resources.cerrar));
        }

        private void minimizar_MouseEnter(object sender, EventArgs e)
        {
            this.minimizar.Image = ((System.Drawing.Image)(Properties.Resources.minimizar_over));
        }

        private void minimizar_MouseLeave(object sender, EventArgs e)
        {
            this.minimizar.Image = ((System.Drawing.Image)(Properties.Resources.minimizar));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Dusuario = new Dictionary<string, string>();
            CapaLogica.gestor objG = new CapaLogica.gestor();
            String pnombre = nombre.Text;
            String pusuaeio = usuario.Text;

            String rol = rolPrincipal() + rolVenta() + rolProductos() + rolAjustes();


            Dusuario.Add("nombre",pnombre);
            Dusuario.Add("usuario", pusuaeio);
            Dusuario.Add("contrasenna","1234");
            Dusuario.Add("rol", rol);
            objG.crearUsuario(Dusuario);
            nombre.Text = "";
            usuario.Text = "";
                    
        }

        private string rolPrincipal()
        {
            String rol;

            if (cVenta.Checked)
            {
                rol = "1";
            }
            else
            {
                rol = "0";
            }
            if (cInventario.Checked)
            {
                rol = rol + ",1";
            }
            else
            {
                rol = rol + ",0";
            }
            if (cAjustes.Checked)
            {
                rol = rol + ",1";
            }
            else
            {
                rol = rol + ",0";
            }
            if (cClientes.Checked)
            {
                rol = rol + ",1";
            }
            else
            {
                rol = rol + ",0";
            }
            if (cReportes.Checked)
            {
                rol = rol + ",1";
            }
            else
            {
                rol = rol + ",0";
            }
            if (cFinanzas.Checked)
            {
                rol = rol + ",1";
            }
            else
            {
                rol = rol + ",0";
            }
            return rol;
        }
        private string rolVenta()
        {
            String rol;

            if (cIngresarVenta.Checked)
            {
                rol = ",1";
            }
            else
            {
                rol = ",0";
            }
            return rol;
        }

        private string rolProductos()
        {
            String rol;

            if (cIngresarProductos.Checked)
            {
                rol = ",1";
            }
            else
            {
                rol = ",0";
            }
            return rol;
        }

        private string rolAjustes()
        {
            String rol;

            if (cCrearUsuario.Checked)
            {
                rol = ",1";
            }
            else
            {
                rol =",0";
            }
            if (cModificarUsuario.Checked)
            {
                rol = rol + ",1";
            }
            else
            {
                rol = rol + ",0";
            }
            return rol;
        }
    }
}
