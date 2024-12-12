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
    public partial class frmUsuario : Form
    {
       private List<Usuario> lista = new List<Usuario>();
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
          
            IReadRepository<Usuario> listaUser = new RepositoryUserRead();
            ServicioUserRead servicio = new ServicioUserRead(listaUser);

            try
            {
                //inicio objeto listaArticulo
                lista = servicio.ListUser();
                dgvUsuario.DataSource = lista;
                this.OcultarColumna();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

           
        }
        private void OcultarColumna()
        {
            dgvUsuario.Columns["IdUsuario"].Visible = false;
            dgvUsuario.Columns["Clave"].Visible = false;
            dgvUsuario.Columns["FechaRegistro"].Visible = false;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Cargar();
            cboRol.Items.Add("Id");
            cboEstado.Items.Add("Nombre");
            
        }
    }
}
