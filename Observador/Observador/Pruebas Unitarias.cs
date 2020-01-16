using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class PruebasUnitarias : IObservador
    {
        public void notificar()
        {
            Console.WriteLine("Se notifico al Observador");
            EjecutarPruebUnitaria();
        }

        private bool EjecutarPruebUnitaria()
        {
            Console.WriteLine("Se ejecuto Prueba Unitaria");
            return true;
        }
    }
}
