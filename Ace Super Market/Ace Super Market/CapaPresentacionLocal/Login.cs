using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaPresentacionLocal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Boolean verificacion = false;
            CapaLogica.gestor objGestor = new CapaLogica.gestor();

            String Usuario = usuario.Text;
            String Contrasenna = contrasenna.Text;
            verificacion = objGestor.verificarUsuario(Usuario,Contrasenna);

            Process[] localByName = Process.GetProcessesByName("autotoken");

            if (localByName.Length > 0)
            {
                if (Contrasenna.Equals("1234") && verificacion == true)
                {

                    CapaPresentacionLocal.Cambiar_Password principal = new CapaPresentacionLocal.Cambiar_Password();
                    principal.Show();
                    principal.setnombreUsuario(Usuario);
                    this.Close();

                }
                else if (verificacion == true)
                {
                    CapaPresentacionLocal.Principal principal = new CapaPresentacionLocal.Principal();
                    principal.Show();
                    principal.setnombreUsuario(Usuario);
                    this.Close();
                }
                else
                {
                    error.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Porfavor Inicie AutoToken");
            }


            


        }
    }
}
