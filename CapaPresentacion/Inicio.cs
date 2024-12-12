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
using FontAwesome.Sharp;
using Negocio.Service.PermisoService;
using Negocio.Repository.PermisoRepository;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private readonly Usuario _usuario;
        private static IconMenuItem _menuActivo=null;
        private static Form _formularioActivo=null;
        public Inicio(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
           
        }

      

        private void Inicio_Load(object sender, EventArgs e)
        {
            List< Permiso > lista= new List<Permiso>();
            IReadRepositoryID<Permiso> listaPermiso = new RepositoryPermisoReadId();
            ServicePermisoReadId servicio = new ServicePermisoReadId(listaPermiso);
            lista= servicio.ListPermisoID(_usuario);
            foreach (IconMenuItem icommenu in menu.Items)
            {
                bool encontrado = lista.Any(l => l.NombreMenu == icommenu.Name);
                if (encontrado==false)
                {
                    icommenu.Visible = false;
                }
            }
            lblUsuario.Text = _usuario.NombreCompleto;
        }

        private void AbriFormulario(IconMenuItem menu,Form formulario)
        {
            if (_menuActivo != null)
            {
                _menuActivo.BackColor = Color.White;
            }  
            menu.BackColor = Color.Silver;
            _menuActivo=menu;
            if (_formularioActivo!=null)
            {
                _formularioActivo.Close();
            }
            _formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void iconMantenedor_Click(object sender, EventArgs e)
        {

        }

        private void iconUsuario_Click(object sender, EventArgs e)
        {
            AbriFormulario((IconMenuItem)sender, new frmUsuario());
        }

        private void iconCategoria_Click(object sender, EventArgs e)
        {
            AbriFormulario(iconMantenedor, new frmCategoria());
        }

        private void iconProducto_Click(object sender, EventArgs e)
        {
            AbriFormulario(iconMantenedor, new frmProducto());
        }

        private void iconRegistrarVentas_Click(object sender, EventArgs e)
        {
            AbriFormulario(iconVentas, new frmVenta());
        }
        private void iconVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbriFormulario(iconVentas, new frmDetalleVenta());
        }

        private void iconRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbriFormulario(iconCompra, new frmCompras());
        }

        private void iconVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbriFormulario(iconCompra, new frmDetalleCompra());
        }

        private void iconProveedores_Click(object sender, EventArgs e)
        {
            AbriFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void iconClientes_Click(object sender, EventArgs e)
        {
            AbriFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void iconReportes_Click(object sender, EventArgs e)
        {
            AbriFormulario((IconMenuItem)sender, new frmReportes());
        }
    }
}
