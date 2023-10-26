using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System;

namespace BogadoCandela_2C
{
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        private EPropulsion propulsion;

        /// <summary>
        /// Propiedad Propulsión. Propiedad de sólo lectura.
        /// </summary>
        public EPropulsion Propulsion
        {
            get
            {
                return this.propulsion;
            }
        }

        /// <summary>
        /// Propiedad Tipo.
        /// </summary>
        protected abstract string Tipo
        {
            
        }

        /// <summary>
        /// Constructor de Clase. Por defecto, setea esAWD como falso.
        /// </summary>
        /// <param name="propulsion"></param>
        protected Vehiculo(EPropulsion propulsion)
            :this(propulsion, false)
        {

        }
        /// <summary>
        /// Constructor de clase. 
        /// </summary>
        /// <param name="propulsion">Enumerable de tipo EPropulsion. Señala el tipo de propulsion del vehículo</param>
        /// <param name="esAWD">Bool. Indica si el vehículo es 4x4</param>
        protected Vehiculo(EPropulsion propulsion, bool esAWD)
        {
            this.propulsion = propulsion;
            this.esAWD = esAWD;
            this.numeroDeChasis = Guid.NewGuid();
        }
        /// <summary>
        /// Retorna la información del vehiculo. 
        /// Utilizar el método Format de String para lograrlo.
        /// </summary>
        /// <returns></returns>
        protected string GetInfo()
        {
            //con el siguiente formato: "[Tipo] con propulsión a [Propulsion], [SI/NO] es AWD, numero de chasis[numeroDeChasis]." 
            string s = "{0} con propulsión a {1}, {2} es AWD, numero de chasis {3}";
            string msg = string.Format(s, this.Tipo, this.propulsion, this.esAWD ? "SI" : "NO", this.numeroDeChasis);
            return msg;
        }
        /// <summary>
        /// ToString expondrá la informacion del vehículo.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.GetInfo();
        }
        /// <summary>
        /// Operator == retornará TRUE si ambos objetos son del mismo tipo (TYPE) y a su vez poseen el mismo número de chasis.
        /// </summary>
        /// <param name="v1">Vehículo 1 a comparar</param>
        /// <param name="v2">Vehículo 2 a comparar</param>
        /// <returns>Bool</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1.GetType() == v2.GetType() && v1.numeroDeChasis == v2.numeroDeChasis)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}