namespace Entidades
{
    public class Moto : Vehiculo
    {
        protected new string Tipo
        {
            get
            {
                return "Moto";
            }
        }

        public Moto(EPropulsion propulsion)
            :base(propulsion)
        {

        }
    }
}
