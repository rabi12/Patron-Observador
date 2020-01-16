using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class ControlNotificacionUsuario : IObservable
    {
        List<IObservador> notificaciones;

        public void agregarObservador(IObservador observador)
        {
            notificaciones.Add(observador);
        }

        public void notificarTodos()
        {
            foreach (var codigo in notificaciones)
            {
                codigo.notificar();
            }
        }

        public void quitarObservador(IObservador observador)
        {
            notificaciones.Remove(observador);
        }
    }
}
