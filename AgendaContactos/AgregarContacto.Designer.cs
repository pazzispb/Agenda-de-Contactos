namespace AgendaContactos
{
    partial class AgregarContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarContacto));
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTelefonoPersonal = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnCrear = new System.Windows.Forms.Button();
            this.bttnSubirFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxApodo = new System.Windows.Forms.TextBox();
            this.lblApodo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTxtBoxTelefonoPersonal = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxTelefonoTrabajo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxTelefonoResidencial = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.checkBoxIsEmergencia = new System.Windows.Forms.CheckBox();
            this.checkBoxIsFavorito = new System.Windows.Forms.CheckBox();
            this.lblAgregarContacto = new System.Windows.Forms.Label();
            this.gbDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatosPersonales.Controls.Add(this.checkBoxIsFavorito);
            this.gbDatosPersonales.Controls.Add(this.checkBoxIsEmergencia);
            this.gbDatosPersonales.Controls.Add(this.txtBoxCorreoElectronico);
            this.gbDatosPersonales.Controls.Add(this.maskedTxtBoxTelefonoResidencial);
            this.gbDatosPersonales.Controls.Add(this.maskedTxtBoxTelefonoTrabajo);
            this.gbDatosPersonales.Controls.Add(this.maskedTxtBoxTelefonoPersonal);
            this.gbDatosPersonales.Controls.Add(this.txtBoxApodo);
            this.gbDatosPersonales.Controls.Add(this.lblApodo);
            this.gbDatosPersonales.Controls.Add(this.txtBoxDescripcion);
            this.gbDatosPersonales.Controls.Add(this.dtpNacimiento);
            this.gbDatosPersonales.Controls.Add(this.label2);
            this.gbDatosPersonales.Controls.Add(this.lblCorreoElectronico);
            this.gbDatosPersonales.Controls.Add(this.cbCategoria);
            this.gbDatosPersonales.Controls.Add(this.label3);
            this.gbDatosPersonales.Controls.Add(this.lblDescripcion);
            this.gbDatosPersonales.Controls.Add(this.lblTelefonoPersonal);
            this.gbDatosPersonales.Controls.Add(this.lblCategoria);
            this.gbDatosPersonales.Controls.Add(this.lblSexo);
            this.gbDatosPersonales.Controls.Add(this.txtBoxApellido);
            this.gbDatosPersonales.Controls.Add(this.lblApellido);
            this.gbDatosPersonales.Controls.Add(this.txtBoxNombre);
            this.gbDatosPersonales.Controls.Add(this.lblNombre);
            this.gbDatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbDatosPersonales.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.Location = new System.Drawing.Point(12, 86);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(413, 343);
            this.gbDatosPersonales.TabIndex = 5;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNacimiento.Location = new System.Drawing.Point(149, 207);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(252, 21);
            this.dtpNacimiento.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(14, 237);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(112, 15);
            this.lblCorreoElectronico.TabIndex = 21;
            this.lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategoria.BackColor = System.Drawing.SystemColors.Menu;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(148, 178);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(251, 23);
            this.cbCategoria.TabIndex = 20;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(14, 262);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(74, 15);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblTelefonoPersonal
            // 
            this.lblTelefonoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoPersonal.AutoSize = true;
            this.lblTelefonoPersonal.Location = new System.Drawing.Point(13, 94);
            this.lblTelefonoPersonal.Name = "lblTelefonoPersonal";
            this.lblTelefonoPersonal.Size = new System.Drawing.Size(107, 15);
            this.lblTelefonoPersonal.TabIndex = 13;
            this.lblTelefonoPersonal.Text = "Telefono Personal";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(14, 181);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(64, 15);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(14, 153);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(122, 15);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Telefono Residencial";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApellido.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxApellido.Location = new System.Drawing.Point(148, 60);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(253, 14);
            this.txtBoxApellido.TabIndex = 8;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(14, 64);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 15);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellidos";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNombre.Location = new System.Drawing.Point(148, 28);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(253, 14);
            this.txtBoxNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombres";
            this.lblNombre.Click += new System.EventHandler(this.lblCedula_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnCancelar.FlatAppearance.BorderSize = 0;
            this.bttnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnCancelar.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.ForeColor = System.Drawing.Color.Black;
            this.bttnCancelar.Location = new System.Drawing.Point(8, 435);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(204, 34);
            this.bttnCancelar.TabIndex = 34;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = false;
            // 
            // bttnCrear
            // 
            this.bttnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnCrear.BackColor = System.Drawing.Color.Transparent;
            this.bttnCrear.FlatAppearance.BorderSize = 0;
            this.bttnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnCrear.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCrear.ForeColor = System.Drawing.Color.Black;
            this.bttnCrear.Location = new System.Drawing.Point(218, 435);
            this.bttnCrear.Name = "bttnCrear";
            this.bttnCrear.Size = new System.Drawing.Size(206, 34);
            this.bttnCrear.TabIndex = 31;
            this.bttnCrear.Text = "Agregar";
            this.bttnCrear.UseVisualStyleBackColor = false;
            // 
            // bttnSubirFoto
            // 
            this.bttnSubirFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSubirFoto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnSubirFoto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnSubirFoto.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubirFoto.Location = new System.Drawing.Point(430, 435);
            this.bttnSubirFoto.Name = "bttnSubirFoto";
            this.bttnSubirFoto.Size = new System.Drawing.Size(173, 34);
            this.bttnSubirFoto.TabIndex = 36;
            this.bttnSubirFoto.Text = "Subir Foto";
            this.bttnSubirFoto.UseVisualStyleBackColor = true;
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(431, 86);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(172, 343);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 35;
            this.pbFoto.TabStop = false;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDescripcion.Location = new System.Drawing.Point(148, 259);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(251, 14);
            this.txtBoxDescripcion.TabIndex = 24;
            // 
            // txtBoxApodo
            // 
            this.txtBoxApodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApodo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxApodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxApodo.Location = new System.Drawing.Point(148, 286);
            this.txtBoxApodo.Name = "txtBoxApodo";
            this.txtBoxApodo.Size = new System.Drawing.Size(251, 14);
            this.txtBoxApodo.TabIndex = 27;
            // 
            // lblApodo
            // 
            this.lblApodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApodo.AutoSize = true;
            this.lblApodo.Location = new System.Drawing.Point(16, 288);
            this.lblApodo.Name = "lblApodo";
            this.lblApodo.Size = new System.Drawing.Size(45, 15);
            this.lblApodo.TabIndex = 26;
            this.lblApodo.Text = "Apodo";
            this.lblApodo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefono de Trabajo";
            // 
            // maskedTxtBoxTelefonoPersonal
            // 
            this.maskedTxtBoxTelefonoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTxtBoxTelefonoPersonal.BackColor = System.Drawing.SystemColors.Menu;
            this.maskedTxtBoxTelefonoPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTxtBoxTelefonoPersonal.Location = new System.Drawing.Point(148, 89);
            this.maskedTxtBoxTelefonoPersonal.Mask = "(999) 000-0000";
            this.maskedTxtBoxTelefonoPersonal.Name = "maskedTxtBoxTelefonoPersonal";
            this.maskedTxtBoxTelefonoPersonal.Size = new System.Drawing.Size(251, 14);
            this.maskedTxtBoxTelefonoPersonal.TabIndex = 37;
            // 
            // maskedTxtBoxTelefonoTrabajo
            // 
            this.maskedTxtBoxTelefonoTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTxtBoxTelefonoTrabajo.BackColor = System.Drawing.SystemColors.Menu;
            this.maskedTxtBoxTelefonoTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTxtBoxTelefonoTrabajo.Location = new System.Drawing.Point(150, 119);
            this.maskedTxtBoxTelefonoTrabajo.Mask = "(999) 000-0000";
            this.maskedTxtBoxTelefonoTrabajo.Name = "maskedTxtBoxTelefonoTrabajo";
            this.maskedTxtBoxTelefonoTrabajo.Size = new System.Drawing.Size(251, 14);
            this.maskedTxtBoxTelefonoTrabajo.TabIndex = 38;
            // 
            // maskedTxtBoxTelefonoResidencial
            // 
            this.maskedTxtBoxTelefonoResidencial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTxtBoxTelefonoResidencial.BackColor = System.Drawing.SystemColors.Menu;
            this.maskedTxtBoxTelefonoResidencial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTxtBoxTelefonoResidencial.Location = new System.Drawing.Point(150, 147);
            this.maskedTxtBoxTelefonoResidencial.Mask = "(999) 000-0000";
            this.maskedTxtBoxTelefonoResidencial.Name = "maskedTxtBoxTelefonoResidencial";
            this.maskedTxtBoxTelefonoResidencial.Size = new System.Drawing.Size(251, 14);
            this.maskedTxtBoxTelefonoResidencial.TabIndex = 39;
            // 
            // txtBoxCorreoElectronico
            // 
            this.txtBoxCorreoElectronico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCorreoElectronico.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCorreoElectronico.Location = new System.Drawing.Point(150, 232);
            this.txtBoxCorreoElectronico.Name = "txtBoxCorreoElectronico";
            this.txtBoxCorreoElectronico.Size = new System.Drawing.Size(251, 14);
            this.txtBoxCorreoElectronico.TabIndex = 40;
            // 
            // checkBoxIsEmergencia
            // 
            this.checkBoxIsEmergencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsEmergencia.AutoSize = true;
            this.checkBoxIsEmergencia.Location = new System.Drawing.Point(149, 315);
            this.checkBoxIsEmergencia.Name = "checkBoxIsEmergencia";
            this.checkBoxIsEmergencia.Size = new System.Drawing.Size(168, 19);
            this.checkBoxIsEmergencia.TabIndex = 41;
            this.checkBoxIsEmergencia.Text = "Contacto de emergencia";
            this.checkBoxIsEmergencia.UseVisualStyleBackColor = true;
            this.checkBoxIsEmergencia.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxIsFavorito
            // 
            this.checkBoxIsFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsFavorito.AutoSize = true;
            this.checkBoxIsFavorito.Location = new System.Drawing.Point(16, 315);
            this.checkBoxIsFavorito.Name = "checkBoxIsFavorito";
            this.checkBoxIsFavorito.Size = new System.Drawing.Size(125, 19);
            this.checkBoxIsFavorito.TabIndex = 42;
            this.checkBoxIsFavorito.Text = "Contacto favorito";
            this.checkBoxIsFavorito.UseVisualStyleBackColor = true;
            this.checkBoxIsFavorito.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lblAgregarContacto
            // 
            this.lblAgregarContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAgregarContacto.AutoSize = true;
            this.lblAgregarContacto.Font = new System.Drawing.Font("Montserrat SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.lblAgregarContacto.Location = new System.Drawing.Point(140, 20);
            this.lblAgregarContacto.Name = "lblAgregarContacto";
            this.lblAgregarContacto.Size = new System.Drawing.Size(312, 44);
            this.lblAgregarContacto.TabIndex = 37;
            this.lblAgregarContacto.Text = "Agregar Contacto";
            // 
            // AgregarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 486);
            this.Controls.Add(this.lblAgregarContacto);
            this.Controls.Add(this.bttnSubirFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnCrear);
            this.Controls.Add(this.gbDatosPersonales);
            this.Name = "AgregarContacto";
            this.Text = "AgregarContacto";
            this.Load += new System.EventHandler(this.AgregarContacto_Load);
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTelefonoPersonal;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnCrear;
        private System.Windows.Forms.Button bttnSubirFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtBoxApodo;
        private System.Windows.Forms.Label lblApodo;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.CheckBox checkBoxIsFavorito;
        private System.Windows.Forms.CheckBox checkBoxIsEmergencia;
        private System.Windows.Forms.TextBox txtBoxCorreoElectronico;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelefonoResidencial;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelefonoTrabajo;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelefonoPersonal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAgregarContacto;
    }
}