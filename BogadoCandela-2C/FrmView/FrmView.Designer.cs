namespace FrmView
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            lstVehiculos = new ListBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            pcbFabrica = new PictureBox();
            btnFabricar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 30;
            lstVehiculos.Location = new Point(13, 12);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(1008, 754);
            lstVehiculos.TabIndex = 0;
            lstVehiculos.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(1042, 27);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(300, 48);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de Vehiculo";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipo.FormattingEnabled = true;
            
            cmbTipo.Location = new Point(1051, 100);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(326, 40);
            cmbTipo.TabIndex = 2;
            // 
            // pcbFabrica
            // 
            pcbFabrica.BackgroundImage = (Image)resources.GetObject("pcbFabrica.BackgroundImage");
            pcbFabrica.BackgroundImageLayout = ImageLayout.Zoom;
            pcbFabrica.Location = new Point(1051, 167);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(326, 328);
            pcbFabrica.TabIndex = 3;
            pcbFabrica.TabStop = false;
            // 
            // btnFabricar
            // 
            btnFabricar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnFabricar.Location = new Point(1051, 520);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(326, 108);
            btnFabricar.TabIndex = 4;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(1051, 658);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(326, 108);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 802);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(pcbFabrica);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(lstVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fabrica de Vehiculos";
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private Label lblTipo;
        private ComboBox cmbTipo;
        public PictureBox pcbFabrica;
        private Button btnFabricar;
        private Button btnEliminar;
    }
}