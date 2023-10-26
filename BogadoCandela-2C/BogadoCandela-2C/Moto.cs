﻿namespace BogadoCandela_2C
{
    public class Moto : Vehiculo
    {
        protected override string Tipo
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