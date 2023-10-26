using System;
using System.Text;

namespace BogadoCandela_2C
{
    internal class Camioneta : Vehiculo
    {
        private bool cabinaSimple;

        protected override string Tipo
        {
            get
            {
                return "Camioneta";
            }
        }

        public Camioneta(EPropulsion propulsion, bool cabinaSimple)
            :base(propulsion, true)
        {
            this.cabinaSimple = cabinaSimple;
        }
        /// <summary>
        /// GetInfo informará todos sus datos y agregará si la camioneta es cabina simple o doble: " (todos los datos de la camioneta), con cabina: [Simple(true) o Doble(false)]".
        /// </summary>
        /// <returns></returns>
        protected new string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            if (this.cabinaSimple)
            {
                sb.Append($", con cabina: [Simple]");
            }
            else
            {
                sb.Append($", con cabina: [Doble]");
            }
            return sb.ToString();
        }
    }
}
