using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class ControlVersiones : IObservable
    {
        List<IObservador> versiones;

        public void agregarObservador(IObservador observador)
        {
            versiones.Add(observador);
        }

        public void notificarTodos()
        {
            foreach (var version in versiones)
            {
                version.notificar();
            }
        }

        public void quitarObservador(IObservador observador)
        {
            versiones.Remove(observador);
        }
    }
}
