using System;

namespace Observador
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicadorCodigo publicador = new PublicadorCodigo();
            IObservador codigoObservable = new Codigo();
            IObservador pruebaObservable = new PruebasUnitarias();
            IObservador versionObservable = new Instalador();
            IObservador usuarioObservable = new NotificacionUsuario();


            publicador.subcribir(codigoObservable);
            publicador.subcribir(pruebaObservable);
            publicador.subcribir(versionObservable);
            publicador.subcribir(usuarioObservable);

            publicador.subirCodigo("rabi.aranda","Patron Observador");

            Console.ReadKey();
        }
    }
}
