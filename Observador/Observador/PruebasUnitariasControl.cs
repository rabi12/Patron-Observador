using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    public class PruebasUnitariasControl : IObservable
    {
        List<IObservador> pruebasUnitarias;

        public void agregarObservador(IObservador observador)
        {
            pruebasUnitarias.Add(observador);
        }

        public void notificarTodos()
        {
            foreach (var codigo in pruebasUnitarias)
            {
                codigo.notificar();
            }
        }

        public void quitarObservador(IObservador observador)
        {
            pruebasUnitarias.Remove(observador);
        }
    }
}
