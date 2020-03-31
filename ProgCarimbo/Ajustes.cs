using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCarimbo
{
    interface Ajustes
    {
        void carregar(string COR, int CARGA);
        void trocarCor(string COR);
        void trocarTexto(string TEXTO);
    }
}
