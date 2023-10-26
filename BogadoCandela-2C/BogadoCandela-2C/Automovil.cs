namespace Entidades
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
