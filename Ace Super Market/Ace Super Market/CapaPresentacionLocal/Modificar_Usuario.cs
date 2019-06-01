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
    public partial class Modificar_Usuario : Form
    {
        private String contrasenna;
        public Modificar_Usuario()
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

        private void usuario_TextChanged(object sender, EventArgs e)
        {
            CapaLogica.gestor objG = new CapaLogica.gestor();
            Dictionary<string, string> Dusuario = new Dictionary<string, string>();
            String pusuario = usuario.Text;

            Dusuario = objG.buscarUsuario(pusuario);

            nombreUsuario.Text = Dusuario["nombreUsuario"];
            contrasenna = Dusuario["contrasenna"];
            String[] prol = Dusuario["rol"].Split(',');

            if (prol.Length == 9)
            {

                bPrincipal.Enabled = true;
                bVenta.Enabled = true;
                bInventario.Enabled = true;
                bAjustes.Enabled = true;
                rolPrincipal(prol);
                rolVenta(prol);
                rolProductos(prol);
                rolAjustes(prol);

            }
            else
            {
                bPrincipal.Enabled = false;
                bVenta.Enabled = false;
                bInventario.Enabled = false;
                bAjustes.Enabled = false;

            }


            

           // MessageBox.Show(prol.Length.ToString());
            objG.buscarUsuario(pusuario);

        }

        private string rolPrincipal(String[] prol)
        {
            String rol;

            if ((cVenta.Checked) || (prol[0].Equals("1")))
            {
                rol = "1";
                cVenta.Checked = true;

            }
            else
            {
                rol = "0";
            }
            if ((cInventario.Checked) || (prol[1].Equals("1")))
            {
                rol = rol + ",1";
                cInventario.Checked = true;
            }
            else
            {
                rol = rol + ",0";
            }
            if ((cAjustes.Checked) || (prol[2].Equals("1")))
            {
                rol = rol + ",1";
                cAjustes.Checked = true;
            }
            else
            {
                rol = rol + ",0";
            }
            if ((cClientes.Checked) || (prol[3].Equals("1")))
            {
                rol = rol + ",1";
                cClientes.Checked = true;
            }
            else
            {
                rol = rol + ",0";
            }
            if ((cReportes.Checked) || (prol[4].Equals("1")))
            {
                rol = rol + ",1";
                cReportes.Checked = true;
            }
            else
            {
                rol = rol + ",0";
            }
            if ((cFinanzas.Checked) || (prol[5].Equals("1")))
            {
                rol = rol + ",1";
                cFinanzas.Checked = true;
            }
            else
            {
                rol = rol + ",0";
            }

            return rol;
        }
        private string rolVenta(String[] prol)
        {
            String rol;

            if ((cIngresarVenta.Checked) || (prol[3].Equals("1")))
            {
                rol = ",1";
                cIngresarVenta.Checked = true;
            }
            else
            {
                rol = ",0";
            }
            return rol;
        }

        private string rolProductos(String[] prol)
        {
            String rol;

            if ((cIngresarProductos.Checked) || (prol[4].Equals("1")))
            {
                rol = ",1";
                cIngresarProductos.Checked = true;
            }
            else
            {
                rol = ",0";
            }
            return rol;
        }

        private string rolAjustes(String[] prol)
        {
            String rol;

            if ((cCrearUsuario.Checked) || (prol[5].Equals("1")))
            {
                rol = ",1";
                cCrearUsuario.Checked = true;
            }
            else
            {
                rol = ",0";
            }
            if ((cModificarUsuario.Checked) || (prol[6].Equals("1")))
            {
                rol = rol + ",1";
                cModificarUsuario.Checked = true;
            }
            else
            {
                rol = rol + ",0";
            }
            return rol;
        }



        private void modificarUsuario_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Dusuario = new Dictionary<string, string>();
            CapaLogica.gestor objG = new CapaLogica.gestor();
            Boolean verificacion = false;
            String pnombre = nombreUsuario.Text;
            String pusuario = usuario.Text;

            String[] prol = new String[] {"0","0","0","0","0","0","0","0","0" };

            String rol = rolPrincipal(prol) + rolVenta(prol) + rolProductos(prol) + rolAjustes(prol);

            if (String.IsNullOrEmpty(usuario.Text) || 
                String.IsNullOrEmpty(nombreUsuario.Text))
            {
                MessageBox.Show("Existen Campos Vacios", "MAMADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Dusuario.Add("nombre", pnombre);
                Dusuario.Add("usuario", pusuario);
                Dusuario.Add("rol", rol);
                if (modificarContrasenna.Checked)
                {
                    Dusuario.Add("contrasenna", "1234");
                    verificacion = objG.modificarContrasenna(pusuario,"1234");
                }
                else
                {
                    Dusuario.Add("contrasenna", contrasenna);
                    
                }



                verificacion = objG.crearUsuario(Dusuario);


                if (verificacion == true)
                {
                    MessageBox.Show("Exito al realizar los cambios", "FELICIDADES MAMADOR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    modificarContrasenna.Checked = false;
                    nombreUsuario.Text = "";
                    bPrincipal.Enabled = false;
                    bVenta.Enabled = false;
                    bInventario.Enabled = false;
                    bAjustes.Enabled = false;
                    usuario.Text = "";

                }
            }


        }


    }
}
