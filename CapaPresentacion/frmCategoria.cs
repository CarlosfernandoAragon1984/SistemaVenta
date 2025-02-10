using Dominio;
using Negocio.Interface;
using Negocio.Repository.CategoriaRepository;
using Negocio.Repository.UserRepository;
using Negocio.Service;
using Negocio.Service.CategoriaService;
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
    public partial class frmCategoria : Form
    {
        private List<Categoria> lista = new List<Categoria>();
        private Categoria newCategoria;
        public frmCategoria()
        {
            InitializeComponent();
            //  dgvCategoria.CellFormatting += dgvCategoria_CellFormatting;
            
        }

       

        private void frmCategoria_Load(object sender, EventArgs e)
        {
           
            this.Cargar();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
        }
        private void Cargar()
        {

             IReadRepository<Categoria> listaC = new ReadCategoriaRepository();
             ReadCategoriaService servicio = new ReadCategoriaService(listaC);

            try
            {
               // inicio objeto listaArticulo
                lista = servicio.Select();
                //foreach  (Categoria item in lista)
                //{
                //    dgvCategoria.Rows.Add(new object[] { item.IdCategoria,
                //        item.Descripcion,item.Descripcion,
                //    item.Estado==true? 1:0,
                //    item.Estado==true? "Activo":"Inactivo",
                //    });
                //}
               
                dgvCategoria.DataSource = lista;

                this.OcultarColumna();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        private void OcultarColumna()
        {
            dgvCategoria.Columns["IdCategoria"].Visible = false;
            dgvCategoria.Columns["FechaRegistro"].Visible = false;
            


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria UpdateCat= new Categoria();
                UpdateCat.IdCategoria = Int16.Parse(txtIdCategoria.Text);
                UpdateCat.Descripcion=txbDescripcion.Text;
                if (cboEstado.Text == "Activo")
                {
                    UpdateCat.Estado = true;
                }
                else
                {
                    UpdateCat.Estado = false;
                }
                IUpdateRepository<Categoria> _categoria=new UpdateCategoriaRepository();    
                UpdateCategoriaService service=new UpdateCategoriaService(_categoria);
                service.Update(UpdateCat);

                if (UpdateCat.IdCategoria != 0)
                {
                    MessageBox.Show("Modificado exitosamente");
                }


                Cargar();
            }
            catch (Exception)
            {

                throw;
            }

        }

       

        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                Categoria seleccionado;
                seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                txtIdCategoria.Text = (string)seleccionado.IdCategoria.ToString();
                txbDescripcion.Text = seleccionado.Descripcion;
                if (seleccionado.Estado)
                {
                    cboEstado.Text = "Activo";
                }
                if (!seleccionado.Estado)
                {
                    cboEstado.Text = "Inactivo";
                }
            }
                
        }

        //private void dgvCategoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (e.ColumnIndex == dgvCategoria.Columns["Estado"].Index) // Suponiendo que "Estado" es el nombre de la columna
        //    {
        //        if (e.Value != null && e.Value is bool)
        //        {
        //            e.Value = (bool)e.Value ? "Activo" : "No Activo";
        //            e.FormattingApplied = true;
        //        }
        //    }
        //}
    }
}
