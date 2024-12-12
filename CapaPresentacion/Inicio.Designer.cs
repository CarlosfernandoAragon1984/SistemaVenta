namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.iconUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.iconMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.iconCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.iconProducto = new FontAwesome.Sharp.IconMenuItem();
            this.iconVentas = new FontAwesome.Sharp.IconMenuItem();
            this.iconCompra = new FontAwesome.Sharp.IconMenuItem();
            this.iconProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.iconClientes = new FontAwesome.Sharp.IconMenuItem();
            this.iconReportes = new FontAwesome.Sharp.IconMenuItem();
            this.iconAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.iconRegistrarVentas = new FontAwesome.Sharp.IconMenuItem();
            this.iconVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.iconRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.iconVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconUsuario,
            this.iconMantenedor,
            this.iconVentas,
            this.iconCompra,
            this.iconProveedores,
            this.iconClientes,
            this.iconReportes,
            this.iconAcercaDe});
            this.menu.Location = new System.Drawing.Point(0, 63);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(1101, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // iconUsuario
            // 
            this.iconUsuario.AutoSize = false;
            this.iconUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconUsuario.IconColor = System.Drawing.Color.Black;
            this.iconUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsuario.IconSize = 50;
            this.iconUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconUsuario.Name = "iconUsuario";
            this.iconUsuario.Size = new System.Drawing.Size(122, 69);
            this.iconUsuario.Text = "Usuario";
            this.iconUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconUsuario.Click += new System.EventHandler(this.iconUsuario_Click);
            // 
            // iconMantenedor
            // 
            this.iconMantenedor.AutoSize = false;
            this.iconMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconCategoria,
            this.iconProducto});
            this.iconMantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.iconMantenedor.IconColor = System.Drawing.Color.Black;
            this.iconMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMantenedor.IconSize = 50;
            this.iconMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMantenedor.Name = "iconMantenedor";
            this.iconMantenedor.Size = new System.Drawing.Size(80, 69);
            this.iconMantenedor.Text = "Mantenedor";
            this.iconMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMantenedor.Click += new System.EventHandler(this.iconMantenedor_Click);
            // 
            // iconCategoria
            // 
            this.iconCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconCategoria.IconColor = System.Drawing.Color.Black;
            this.iconCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCategoria.Name = "iconCategoria";
            this.iconCategoria.Size = new System.Drawing.Size(180, 22);
            this.iconCategoria.Text = "Categoría";
            this.iconCategoria.Click += new System.EventHandler(this.iconCategoria_Click);
            // 
            // iconProducto
            // 
            this.iconProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconProducto.IconColor = System.Drawing.Color.Black;
            this.iconProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProducto.Name = "iconProducto";
            this.iconProducto.Size = new System.Drawing.Size(180, 22);
            this.iconProducto.Text = "Producto";
            this.iconProducto.Click += new System.EventHandler(this.iconProducto_Click);
            // 
            // iconVentas
            // 
            this.iconVentas.AutoSize = false;
            this.iconVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconRegistrarVentas,
            this.iconVerDetalleVenta});
            this.iconVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconVentas.IconColor = System.Drawing.Color.Black;
            this.iconVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVentas.IconSize = 50;
            this.iconVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconVentas.Name = "iconVentas";
            this.iconVentas.Size = new System.Drawing.Size(80, 69);
            this.iconVentas.Text = "Ventas";
            this.iconVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconCompra
            // 
            this.iconCompra.AutoSize = false;
            this.iconCompra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconRegistrarCompra,
            this.iconVerDetalleCompra});
            this.iconCompra.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.iconCompra.IconColor = System.Drawing.Color.Black;
            this.iconCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCompra.IconSize = 50;
            this.iconCompra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconCompra.Name = "iconCompra";
            this.iconCompra.Size = new System.Drawing.Size(80, 69);
            this.iconCompra.Text = "Compras";
            this.iconCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconProveedores
            // 
            this.iconProveedores.AutoSize = false;
            this.iconProveedores.Checked = true;
            this.iconProveedores.CheckOnClick = true;
            this.iconProveedores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iconProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconProveedores.IconColor = System.Drawing.Color.Black;
            this.iconProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProveedores.IconSize = 50;
            this.iconProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconProveedores.Name = "iconProveedores";
            this.iconProveedores.Size = new System.Drawing.Size(80, 69);
            this.iconProveedores.Text = "Proveedores";
            this.iconProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconProveedores.Click += new System.EventHandler(this.iconProveedores_Click);
            // 
            // iconClientes
            // 
            this.iconClientes.AutoSize = false;
            this.iconClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconClientes.IconColor = System.Drawing.Color.Black;
            this.iconClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClientes.IconSize = 50;
            this.iconClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconClientes.Name = "iconClientes";
            this.iconClientes.Size = new System.Drawing.Size(80, 69);
            this.iconClientes.Text = "Clientes";
            this.iconClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconClientes.Click += new System.EventHandler(this.iconClientes_Click);
            // 
            // iconReportes
            // 
            this.iconReportes.AutoSize = false;
            this.iconReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconReportes.IconColor = System.Drawing.Color.Black;
            this.iconReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconReportes.IconSize = 50;
            this.iconReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconReportes.Name = "iconReportes";
            this.iconReportes.Size = new System.Drawing.Size(80, 69);
            this.iconReportes.Text = "Reportes";
            this.iconReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconReportes.Click += new System.EventHandler(this.iconReportes_Click);
            // 
            // iconAcercaDe
            // 
            this.iconAcercaDe.AutoSize = false;
            this.iconAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconAcercaDe.IconColor = System.Drawing.Color.Black;
            this.iconAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAcercaDe.IconSize = 50;
            this.iconAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconAcercaDe.Name = "iconAcercaDe";
            this.iconAcercaDe.Size = new System.Drawing.Size(80, 69);
            this.iconAcercaDe.Text = "Acerca de";
            this.iconAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Size = new System.Drawing.Size(1101, 63);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Sistema de Venta";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContenedor.Location = new System.Drawing.Point(0, 136);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1101, 422);
            this.pnlContenedor.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl.Location = new System.Drawing.Point(718, 33);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(50, 15);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsuario.Location = new System.Drawing.Point(777, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "NNNNN";
            // 
            // iconRegistrarVentas
            // 
            this.iconRegistrarVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconRegistrarVentas.IconColor = System.Drawing.Color.Black;
            this.iconRegistrarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRegistrarVentas.Name = "iconRegistrarVentas";
            this.iconRegistrarVentas.Size = new System.Drawing.Size(180, 22);
            this.iconRegistrarVentas.Text = "Registrar";
            this.iconRegistrarVentas.Click += new System.EventHandler(this.iconRegistrarVentas_Click);
            // 
            // iconVerDetalleVenta
            // 
            this.iconVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconVerDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.iconVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVerDetalleVenta.Name = "iconVerDetalleVenta";
            this.iconVerDetalleVenta.Size = new System.Drawing.Size(180, 22);
            this.iconVerDetalleVenta.Text = "Ver Detalle";
            this.iconVerDetalleVenta.Click += new System.EventHandler(this.iconVerDetalleVenta_Click);
            // 
            // iconRegistrarCompra
            // 
            this.iconRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.iconRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRegistrarCompra.Name = "iconRegistrarCompra";
            this.iconRegistrarCompra.Size = new System.Drawing.Size(180, 22);
            this.iconRegistrarCompra.Text = "Registrar";
            this.iconRegistrarCompra.Click += new System.EventHandler(this.iconRegistrarCompra_Click);
            // 
            // iconVerDetalleCompra
            // 
            this.iconVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.iconVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVerDetalleCompra.Name = "iconVerDetalleCompra";
            this.iconVerDetalleCompra.Size = new System.Drawing.Size(180, 22);
            this.iconVerDetalleCompra.Text = "Ver Detalle";
            this.iconVerDetalleCompra.Click += new System.EventHandler(this.iconVerDetalleCompra_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1101, 558);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconMenuItem iconAcercaDe;
        private FontAwesome.Sharp.IconMenuItem iconUsuario;
        private FontAwesome.Sharp.IconMenuItem iconMantenedor;
        private FontAwesome.Sharp.IconMenuItem iconVentas;
        private FontAwesome.Sharp.IconMenuItem iconCompra;
        private FontAwesome.Sharp.IconMenuItem iconProveedores;
        private FontAwesome.Sharp.IconMenuItem iconClientes;
        private FontAwesome.Sharp.IconMenuItem iconReportes;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem iconCategoria;
        private FontAwesome.Sharp.IconMenuItem iconProducto;
        private FontAwesome.Sharp.IconMenuItem iconRegistrarVentas;
        private FontAwesome.Sharp.IconMenuItem iconVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem iconRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem iconVerDetalleCompra;
    }
}

