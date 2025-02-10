using Dominio;
using Negocio.Interface;
using Negocio.Repository.ProductoRepository;
using Negocio.Repository.UserRepository;
using Negocio.Service;
using Negocio.Service.ProductoService;
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
    public partial class frmProducto : Form
    {
        private List<Producto> lista = new List<Producto>();
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {


            try
            {
                //inicio objeto listaArticulo
                IReadRepository<Producto> listaProducto = new ReadProductoRepository();
                ReadProductoService _servicio = new ReadProductoService(listaProducto);

                lista = _servicio.Select();
               // dgvProducto.Columns.Clear();
                dgvProducto.DataSource = lista;

                //this.OcultarColumna();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        //private void OcultarColumna()
        //{
        //    dgvProducto.Columns["IdProcto"].Visible = false;
        //    dgvProducto.Columns["Clave"].Visible = false;
        //    dgvProducto.Columns["FechaRegistro"].Visible = false;


        //}

       
    }
}
