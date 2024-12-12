using Dominio;
using Negocio.Interface;
using Negocio.Repository.UserRepository;
using Negocio.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            IReadRepository<Usuario> listaUser = new RepositoryUserRead();
            ServicioUserRead servicio = new ServicioUserRead(listaUser);
            usuario = servicio.ListUser().Where(u => u.Documento == txtbDocumento.Text && u.Clave == txtBPass.Text).FirstOrDefault();
            if (usuario != null)
            {
                Inicio form = new Inicio(usuario);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no Encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
