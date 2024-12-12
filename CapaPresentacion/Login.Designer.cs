namespace CapaPresentacion
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconImgVnta = new FontAwesome.Sharp.IconPictureBox();
            this.ibtIngresar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.txtBPass = new System.Windows.Forms.TextBox();
            this.txtbDocumento = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconImgVnta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl1.Location = new System.Drawing.Point(0, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(221, 260);
            this.lbl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA VENTA";
            // 
            // iconImgVnta
            // 
            this.iconImgVnta.BackColor = System.Drawing.Color.SteelBlue;
            this.iconImgVnta.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconImgVnta.IconColor = System.Drawing.Color.White;
            this.iconImgVnta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconImgVnta.IconSize = 91;
            this.iconImgVnta.Location = new System.Drawing.Point(59, 58);
            this.iconImgVnta.Name = "iconImgVnta";
            this.iconImgVnta.Size = new System.Drawing.Size(91, 91);
            this.iconImgVnta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconImgVnta.TabIndex = 2;
            this.iconImgVnta.TabStop = false;
            // 
            // ibtIngresar
            // 
            this.ibtIngresar.BackColor = System.Drawing.SystemColors.Control;
            this.ibtIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibtIngresar.IconColor = System.Drawing.Color.Black;
            this.ibtIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtIngresar.IconSize = 21;
            this.ibtIngresar.Location = new System.Drawing.Point(243, 181);
            this.ibtIngresar.Name = "ibtIngresar";
            this.ibtIngresar.Size = new System.Drawing.Size(96, 33);
            this.ibtIngresar.TabIndex = 3;
            this.ibtIngresar.Text = "Ingresar";
            this.ibtIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtIngresar.UseVisualStyleBackColor = false;
            this.ibtIngresar.Click += new System.EventHandler(this.ibtIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 21;
            this.btnCancelar.Location = new System.Drawing.Point(378, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 33);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBPass
            // 
            this.txtBPass.Location = new System.Drawing.Point(257, 117);
            this.txtBPass.Name = "txtBPass";
            this.txtBPass.PasswordChar = '*';
            this.txtBPass.Size = new System.Drawing.Size(191, 20);
            this.txtBPass.TabIndex = 5;
            // 
            // txtbDocumento
            // 
            this.txtbDocumento.Location = new System.Drawing.Point(257, 58);
            this.txtbDocumento.Name = "txtbDocumento";
            this.txtbDocumento.Size = new System.Drawing.Size(191, 20);
            this.txtbDocumento.TabIndex = 6;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(257, 39);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(82, 13);
            this.lblDni.TabIndex = 7;
            this.lblDni.Text = "Nro Documento";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(257, 101);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 260);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtbDocumento);
            this.Controls.Add(this.txtBPass);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.ibtIngresar);
            this.Controls.Add(this.iconImgVnta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconImgVnta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconImgVnta;
        private FontAwesome.Sharp.IconButton ibtIngresar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.TextBox txtBPass;
        private System.Windows.Forms.TextBox txtbDocumento;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblPass;
    }
}