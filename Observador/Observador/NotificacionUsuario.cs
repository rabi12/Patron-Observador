using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class NotificacionUsuario : IObservador
    {
        public void notificar()
        {
            Console.WriteLine("Se notifica a Observador");
            enviarCorreo();
        }

        private void enviarCorreo()
        {
            Console.WriteLine("Se envio correo");
        }
    }
}
