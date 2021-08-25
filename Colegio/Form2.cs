using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colegio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            String servidor = txtServidor.Text;
            String puerto = txtPuerto.Text;
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;
            String bd = txtBd.Text;

            String cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + " ; Port=" + puerto + "; User Id=" + usuario + "; Password=" + password;
        }
    }
}
