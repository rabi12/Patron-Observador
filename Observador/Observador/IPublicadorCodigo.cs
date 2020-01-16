using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    interface IPublicadorCodigo
    {
        void subirCodigo(string autor, string comentario);
    }
}
