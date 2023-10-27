using Entidades;

namespace FrmView
{
    public partial class FrmView : Form
    {
        private Fabrica fabrica;
        public FrmView()
        {
            InitializeComponent();
            this.InicialilzarFabrica();
            this.Refrescar();
        }
        private void FrmView_Load(object sender, EventArgs e)
        {
            this.cmbTipo.Items.AddRange(new object[] { "Automóvil", "Camioneta", "Moto" });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVehiculos.SelectedIndex;
            this.fabrica = this.fabrica - this.fabrica.Vehiculos[indice];
            this.Refrescar();
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            this.fabrica = this.fabrica + this.CrearVehiculo();
            this.Refrescar();
        }

        private Vehiculo CrearVehiculo()
        {
            string tipo = this.cmbTipo.ValueMember;
            switch (tipo)
            {
                case "Automóvil":
                    return new Automovil();
                case "Camioneta":
                    return new Camioneta(EPropulsion.Combustion, false);
                case "Moto":
                    return new Moto(EPropulsion.Hibrida);
            }
            return new Automovil();
        }

        private void InicialilzarFabrica()
        {
            this.fabrica = new Fabrica(10);
            this.fabrica = this.fabrica + this.CrearVehiculo();
        }

        private void Refrescar()
        {
            this.lstVehiculos.DataSource = null;
            this.lstVehiculos.DataSource = this.fabrica.Vehiculos;
        }
    }
}