using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class ControlCodigo : IObservable
    {
        List<IObservador> codigoFuente;

        public void agregarObservador(IObservador observador)
        {
            codigoFuente.Add(observador);
        }

        public void notificarTodos()
        {
            foreach (var codigo in codigoFuente)
            {
                codigo.notificar();
            }
        }

        public void quitarObservador(IObservador observador)
        {
            codigoFuente.Remove(observador);
        }
    }
}
