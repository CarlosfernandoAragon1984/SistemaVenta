using Dominio;
using Negocio.Interface;
using Negocio.Repository.RolRepository;
using Negocio.Repository.UserRepository;
using Negocio.Service;
using Negocio.Service.RolService;
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
       private Usuario newUser;
        public frmUsuario()
        {
            InitializeComponent();
            
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Cargar();
            // dgvUsuario.CellFormatting += dgvUsuario_CellFormatting;
            IReadRepository<Rol> listaRol = new ReadRolRepository();
            ReadRolService _service= new ReadRolService(listaRol);
            try
            {
                cboRol.DataSource=_service.GetRolList();
                cboRol.ValueMember = "IdRol";
                cboRol.DisplayMember = "Descripcion";
            }
            catch (Exception)
            {

                throw;
            }
            
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                newUser = new Usuario();
                newUser.Documento = txbDocumento.Text;
                newUser.NombreCompleto = txbNombreCompleto.Text;
                newUser.Email = txbCorreo.Text;
                newUser.Telefono = txbTelefono.Text;
                if (txbContraseña.Text == txbConfirmarContraseña.Text)
                {
                    newUser.Clave = txbContraseña.Text;
                }
                else 
                { 
                }
              
                newUser.rol=(Rol)cboRol.SelectedItem;
               
                if (cboEstado.Text=="Activo")
                {
                    newUser.Estado = true;
                }
                else
                {
                    newUser.Estado = false;
                }


                 ICreateRepository<Usuario> _user=new CreateUserRepository();
                 CreateUserService _server= new CreateUserService(_user);
                 _server.Create(newUser);
              
                Cargar();
            }
            catch (Exception)
            {

                throw;
            }
           
           

        }


        //private void dgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (dgvUsuario.Columns[e.ColumnIndex].Name == "Estado")
        //    {
        //        if (e.Value != null && e.Value is bool)
        //        {
        //            e.Value = (bool)e.Value ? "Activo" : "Inactivo";
        //            e.FormattingApplied = true; // Indica que el formato ha sido aplicado
        //        }
        //    }
        //}
    }
}
