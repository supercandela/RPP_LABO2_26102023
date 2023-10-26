namespace BogadoCandela_2C
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        /// <summary>
        /// Propiedad Vehiculos retornará la lista de vehiculos.Sera de solo lectura.
        /// </summary>
        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }
        /// <summary>
        /// Constructor de clase. La lista de vehiculos sólo podrá ser instanciada en el constructor privado.
        /// </summary>
        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Fabrica(int capacidad)
            :this()
        {
            this.capacidad = capacidad;
        }

        /// <summary>
        /// El operador + deberá ser capaz de agregar un vehículo a la lista.
        /// a.La capacidad se utilizará para dar un límite a la cantidad de vehiculos.
        /// b.Si hay lugar, se agregará al nuevo vehiculo y se retornará la fábrica modificada.
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            
            if (fabrica.vehiculos.Count < fabrica.capacidad)
            {
                fabrica.vehiculos.Add(vehiculo);
            }
            return fabrica;
        }

        /// <summary>
        /// El operador – deberá ser capaz de sacar a un vehiculo de la lista.
        /// a.Se buscará el primer vehiculo del mismo tipo (TYPE) y chasis para ser removido.
        /// b.Sólo se quitará la primera aparición de un vehiculo que coincida.
        /// c.Se retornará la fábrica modificada.
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in fabrica.vehiculos)
            {
                if (v == vehiculo)
                {
                    fabrica.vehiculos.Remove(v);
                }
            }
            return fabrica;
        }
    }
}
