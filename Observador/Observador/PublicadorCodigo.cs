using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    public class PublicadorCodigo : IPublicadorCodigo
    {
        List<IObservador> lista;

        public PublicadorCodigo()
        {
            lista = new List<IObservador>();
        }

        public void subirCodigo(string autor, string comentario)
        {
            Console.WriteLine("Se sube codigo. Autor:"+ autor + " Descripcion:"+ comentario);
            foreach (var observador in lista)
            {
                observador.notificar();
            }
        }

        public void subcribir(IObservador observador)
        {
            lista.Add(observador);
        }
    }
}
