namespace AgendaContactos
{
    partial class InformacionContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionContacto));
            this.lblActualizarContacto = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.checkBoxIsFavorito = new System.Windows.Forms.CheckBox();
            this.checkBoxIsEmergencia = new System.Windows.Forms.CheckBox();
            this.txtBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.maskedTxtBoxTelefonoResidencial = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxTelefonoTrabajo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxTelefonoPersonal = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxApodo = new System.Windows.Forms.TextBox();
            this.lblApodo = new System.Windows.Forms.Label();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTelefonoPersonal = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.bttnSubirFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActualizarContacto
            // 
            this.lblActualizarContacto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActualizarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarContacto.Location = new System.Drawing.Point(0, 0);
            this.lblActualizarContacto.Name = "lblActualizarContacto";
            this.lblActualizarContacto.Size = new System.Drawing.Size(663, 71);
            this.lblActualizarContacto.TabIndex = 38;
            this.lblActualizarContacto.Text = "Actualizar Contacto";
            this.lblActualizarContacto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(479, 86);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(172, 205);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 39;
            this.pbFoto.TabStop = false;
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.gbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.Location = new System.Drawing.Point(12, 86);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(461, 346);
            this.gbDatosPersonales.TabIndex = 40;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // checkBoxIsFavorito
            // 
            this.checkBoxIsFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsFavorito.AutoSize = true;
            this.checkBoxIsFavorito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsFavorito.Location = new System.Drawing.Point(16, 315);
            this.checkBoxIsFavorito.Name = "checkBoxIsFavorito";
            this.checkBoxIsFavorito.Size = new System.Drawing.Size(133, 19);
            this.checkBoxIsFavorito.TabIndex = 42;
            this.checkBoxIsFavorito.Text = "Contacto favorito";
            this.checkBoxIsFavorito.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsEmergencia
            // 
            this.checkBoxIsEmergencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsEmergencia.AutoSize = true;
            this.checkBoxIsEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsEmergencia.Location = new System.Drawing.Point(149, 314);
            this.checkBoxIsEmergencia.Name = "checkBoxIsEmergencia";
            this.checkBoxIsEmergencia.Size = new System.Drawing.Size(182, 19);
            this.checkBoxIsEmergencia.TabIndex = 41;
            this.checkBoxIsEmergencia.Text = "Contacto de emergencia";
            this.checkBoxIsEmergencia.UseVisualStyleBackColor = true;
            // 
            // txtBoxCorreoElectronico
            // 
            this.txtBoxCorreoElectronico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCorreoElectronico.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCorreoElectronico.Location = new System.Drawing.Point(161, 233);
            this.txtBoxCorreoElectronico.Name = "txtBoxCorreoElectronico";
            this.txtBoxCorreoElectronico.Size = new System.Drawing.Size(288, 14);
            this.txtBoxCorreoElectronico.TabIndex = 40;
            // 
            // maskedTxtBoxTelefonoResidencial
            // 
            this.maskedTxtBoxTelefonoResidencial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTxtBoxTelefonoResidencial.BackColor = System.Drawing.SystemColors.Menu;
            this.maskedTxtBoxTelefonoResidencial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTxtBoxTelefonoResidencial.Location = new System.Drawing.Point(161, 139);
            this.maskedTxtBoxTelefonoResidencial.Mask = "(999) 000-0000";
            this.maskedTxtBoxTelefonoResidencial.Name = "maskedTxtBoxTelefonoResidencial";
            this.maskedTxtBoxTelefonoResidencial.PromptChar = ' ';
            this.maskedTxtBoxTelefonoResidencial.Size = new System.Drawing.Size(288, 14);
            this.maskedTxtBoxTelefonoResidencial.TabIndex = 39;
            this.maskedTxtBoxTelefonoResidencial.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTxtBoxTelefonoTrabajo
            // 
            this.maskedTxtBoxTelefonoTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTxtBoxTelefonoTrabajo.BackColor = System.Drawing.SystemColors.Menu;
            this.maskedTxtBoxTelefonoTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTxtBoxTelefonoTrabajo.Location = new System.Drawing.Point(161, 112);
            this.maskedTxtBoxTelefonoTrabajo.Mask = "(999) 000-0000";
            this.maskedTxtBoxTelefonoTrabajo.Name = "maskedTxtBoxTelefonoTrabajo";
            this.maskedTxtBoxTelefonoTrabajo.PromptChar = ' ';
            this.maskedTxtBoxTelefonoTrabajo.Size = new System.Drawing.Size(288, 14);
            this.maskedTxtBoxTelefonoTrabajo.TabIndex = 38;
            this.maskedTxtBoxTelefonoTrabajo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTxtBoxTelefonoPersonal
            // 
            this.maskedTxtBoxTelefonoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTxtBoxTelefonoPersonal.BackColor = System.Drawing.SystemColors.Menu;
            this.maskedTxtBoxTelefonoPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTxtBoxTelefonoPersonal.Location = new System.Drawing.Point(159, 85);
            this.maskedTxtBoxTelefonoPersonal.Mask = "(999) 000-0000";
            this.maskedTxtBoxTelefonoPersonal.Name = "maskedTxtBoxTelefonoPersonal";
            this.maskedTxtBoxTelefonoPersonal.PromptChar = ' ';
            this.maskedTxtBoxTelefonoPersonal.Size = new System.Drawing.Size(288, 14);
            this.maskedTxtBoxTelefonoPersonal.TabIndex = 37;
            this.maskedTxtBoxTelefonoPersonal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBoxApodo
            // 
            this.txtBoxApodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApodo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxApodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxApodo.Location = new System.Drawing.Point(159, 287);
            this.txtBoxApodo.Name = "txtBoxApodo";
            this.txtBoxApodo.Size = new System.Drawing.Size(288, 14);
            this.txtBoxApodo.TabIndex = 27;
            // 
            // lblApodo
            // 
            this.lblApodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApodo.AutoSize = true;
            this.lblApodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApodo.Location = new System.Drawing.Point(16, 287);
            this.lblApodo.Name = "lblApodo";
            this.lblApodo.Size = new System.Drawing.Size(47, 15);
            this.lblApodo.TabIndex = 26;
            this.lblApodo.Text = "Apodo";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDescripcion.Location = new System.Drawing.Point(159, 260);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(288, 14);
            this.txtBoxDescripcion.TabIndex = 24;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNacimiento.Location = new System.Drawing.Point(160, 201);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(289, 21);
            this.dtpNacimiento.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(14, 230);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(126, 15);
            this.lblCorreoElectronico.TabIndex = 21;
            this.lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategoria.BackColor = System.Drawing.SystemColors.Menu;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(159, 166);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(291, 23);
            this.cbCategoria.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefono de Trabajo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(14, 258);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 15);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblTelefonoPersonal
            // 
            this.lblTelefonoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoPersonal.AutoSize = true;
            this.lblTelefonoPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoPersonal.Location = new System.Drawing.Point(13, 88);
            this.lblTelefonoPersonal.Name = "lblTelefonoPersonal";
            this.lblTelefonoPersonal.Size = new System.Drawing.Size(124, 15);
            this.lblTelefonoPersonal.TabIndex = 13;
            this.lblTelefonoPersonal.Text = "Telefono Personal";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(14, 173);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 15);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(14, 145);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(143, 15);
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
            this.txtBoxApellido.Location = new System.Drawing.Point(159, 58);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(290, 14);
            this.txtBoxApellido.TabIndex = 8;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(14, 59);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 15);
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
            this.txtBoxNombre.Location = new System.Drawing.Point(159, 32);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(290, 14);
            this.txtBoxNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombres";
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnEliminar.FlatAppearance.BorderSize = 0;
            this.bttnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bttnEliminar.Location = new System.Drawing.Point(478, 396);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(172, 34);
            this.bttnEliminar.TabIndex = 41;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.bttnActualizar.FlatAppearance.BorderSize = 0;
            this.bttnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnActualizar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bttnActualizar.Location = new System.Drawing.Point(478, 356);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(172, 34);
            this.bttnActualizar.TabIndex = 42;
            this.bttnActualizar.Text = "Actualizar";
            this.bttnActualizar.UseVisualStyleBackColor = false;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // bttnSubirFoto
            // 
            this.bttnSubirFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSubirFoto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnSubirFoto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bttnSubirFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubirFoto.Location = new System.Drawing.Point(478, 301);
            this.bttnSubirFoto.Name = "bttnSubirFoto";
            this.bttnSubirFoto.Size = new System.Drawing.Size(173, 34);
            this.bttnSubirFoto.TabIndex = 43;
            this.bttnSubirFoto.Text = "Cambiar Foto";
            this.bttnSubirFoto.UseVisualStyleBackColor = true;
            this.bttnSubirFoto.Click += new System.EventHandler(this.bttnSubirFoto_Click);
            // 
            // InformacionContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 449);
            this.Controls.Add(this.bttnSubirFoto);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.lblActualizarContacto);
            this.Name = "InformacionContacto";
            this.Text = "InfomacionContacto";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblActualizarContacto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.CheckBox checkBoxIsFavorito;
        private System.Windows.Forms.CheckBox checkBoxIsEmergencia;
        private System.Windows.Forms.TextBox txtBoxCorreoElectronico;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelefonoResidencial;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelefonoTrabajo;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelefonoPersonal;
        private System.Windows.Forms.TextBox txtBoxApodo;
        private System.Windows.Forms.Label lblApodo;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTelefonoPersonal;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Button bttnSubirFoto;
    }
}