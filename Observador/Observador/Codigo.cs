using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    public class Codigo : IObservador
    {
        public void notificar()
        {
            Console.WriteLine("Se notifico al Observador");
            Compilar();
        }

        private bool Compilar()
        {
            Console.WriteLine("Codigo compilado");
            return true;
        }
    }
}
