namespace BogadoCandela_2C
{
    public class Automovil : Vehiculo
    {
        protected override string Tipo
        {
            get
            {
                return "Automovil";
            }
        }
        public Automovil()
            :base(EPropulsion.Hibrida)
        {

        }
    }
}
