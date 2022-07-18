namespace AgendaContactos
{
    partial class VisualizarContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarContactos));
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.txtBoxFiltro = new System.Windows.Forms.TextBox();
            this.bttnBuscar = new FontAwesome.Sharp.IconButton();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContactos
            // 
            this.dgvContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContactos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(12, 66);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(591, 396);
            this.dgvContactos.TabIndex = 0;
            this.dgvContactos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellClick);
            // 
            // txtBoxFiltro
            // 
            this.txtBoxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiltro.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxFiltro.Location = new System.Drawing.Point(12, 25);
            this.txtBoxFiltro.Name = "txtBoxFiltro";
            this.txtBoxFiltro.Size = new System.Drawing.Size(260, 20);
            this.txtBoxFiltro.TabIndex = 1;
            this.txtBoxFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bttnBuscar.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bttnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bttnBuscar.IconColor = System.Drawing.SystemColors.Highlight;
            this.bttnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttnBuscar.IconSize = 25;
            this.bttnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnBuscar.Location = new System.Drawing.Point(278, 17);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(80, 33);
            this.bttnBuscar.TabIndex = 2;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(551, 8);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(52, 48);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 36;
            this.pbFoto.TabStop = false;
            // 
            // VisualizarContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(615, 486);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.txtBoxFiltro);
            this.Controls.Add(this.dgvContactos);
            this.Name = "VisualizarContactos";
            this.Text = "VisualizarContactos";
            this.Load += new System.EventHandler(this.VisualizarContactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.TextBox txtBoxFiltro;
        private FontAwesome.Sharp.IconButton bttnBuscar;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}