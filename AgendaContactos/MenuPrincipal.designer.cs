namespace AgendaContactos
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnCategorias = new FontAwesome.Sharp.IconButton();
            this.btnContactos = new FontAwesome.Sharp.IconButton();
            this.btnPaginaPrincipal = new FontAwesome.Sharp.IconButton();
            this.panePhoto = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.panelFormHijo = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panePhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelSideMenu.Controls.Add(this.iconButton1);
            this.panelSideMenu.Controls.Add(this.btnCategorias);
            this.panelSideMenu.Controls.Add(this.btnContactos);
            this.panelSideMenu.Controls.Add(this.btnPaginaPrincipal);
            this.panelSideMenu.Controls.Add(this.panePhoto);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(230, 486);
            this.panelSideMenu.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 293);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(230, 53);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Tag = "Exportar/Importar";
            this.iconButton1.Text = "Importar/Exportar";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCategorias.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnCategorias.IconColor = System.Drawing.Color.White;
            this.btnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategorias.IconSize = 30;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(0, 240);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(230, 53);
            this.btnCategorias.TabIndex = 7;
            this.btnCategorias.Tag = "Categorias";
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnContactos
            // 
            this.btnContactos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContactos.FlatAppearance.BorderSize = 0;
            this.btnContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactos.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContactos.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnContactos.IconColor = System.Drawing.Color.White;
            this.btnContactos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContactos.IconSize = 30;
            this.btnContactos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactos.Location = new System.Drawing.Point(0, 187);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnContactos.Size = new System.Drawing.Size(230, 53);
            this.btnContactos.TabIndex = 6;
            this.btnContactos.Tag = "Contactos";
            this.btnContactos.Text = "Contactos";
            this.btnContactos.UseVisualStyleBackColor = true;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // btnPaginaPrincipal
            // 
            this.btnPaginaPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaginaPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPaginaPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPaginaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaPrincipal.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPaginaPrincipal.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnPaginaPrincipal.IconColor = System.Drawing.Color.White;
            this.btnPaginaPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaginaPrincipal.IconSize = 30;
            this.btnPaginaPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaginaPrincipal.Location = new System.Drawing.Point(0, 134);
            this.btnPaginaPrincipal.Name = "btnPaginaPrincipal";
            this.btnPaginaPrincipal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPaginaPrincipal.Size = new System.Drawing.Size(230, 53);
            this.btnPaginaPrincipal.TabIndex = 5;
            this.btnPaginaPrincipal.Tag = "Pagina Principal";
            this.btnPaginaPrincipal.Text = "Pagina Principal";
            this.btnPaginaPrincipal.UseVisualStyleBackColor = true;
            this.btnPaginaPrincipal.Click += new System.EventHandler(this.btnPaginaPrincipal_Click);
            // 
            // panePhoto
            // 
            this.panePhoto.Controls.Add(this.pbLogo);
            this.panePhoto.Controls.Add(this.btnMenu);
            this.panePhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panePhoto.Location = new System.Drawing.Point(0, 0);
            this.panePhoto.Name = "panePhoto";
            this.panePhoto.Size = new System.Drawing.Size(230, 134);
            this.panePhoto.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(56, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(133, 110);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(230, 134);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Tag = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelFormHijo
            // 
            this.panelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormHijo.Location = new System.Drawing.Point(230, 0);
            this.panelFormHijo.Name = "panelFormHijo";
            this.panelFormHijo.Size = new System.Drawing.Size(615, 486);
            this.panelFormHijo.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(845, 486);
            this.Controls.Add(this.panelFormHijo);
            this.Controls.Add(this.panelSideMenu);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MenuPrincipal";
            this.Text = "Agenda de Contactos";
            this.panelSideMenu.ResumeLayout(false);
            this.panePhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panePhoto;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnCategorias;
        private FontAwesome.Sharp.IconButton btnContactos;
        private FontAwesome.Sharp.IconButton btnPaginaPrincipal;
        private System.Windows.Forms.Panel panelFormHijo;
        private System.Windows.Forms.PictureBox pbLogo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

