namespace Entidades
{
    public class Automovil : Vehiculo
    {
        protected new string Tipo
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
