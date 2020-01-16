using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class Instalador : IObservador
    {
        public void notificar()
        {
            Console.WriteLine("Se notifica a Observador");
            instalandoVersion();
        }

        private void instalandoVersion()
        {
            Console.WriteLine("Se instalo nueva versión.");
        }
    }
}
