using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    public interface IObservable
    {
        void notificarTodos();
        void agregarObservador(IObservador observador);
        void quitarObservador(IObservador observador);

    }
}
