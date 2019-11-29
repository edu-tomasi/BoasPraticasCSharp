using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFlyweight_MuitoObjetos
{
    class Piano
    {
        public void Toca(IList<INota> musica, int velocidade = 300)
        {
            foreach (INota nota in musica)
            {
                Console.Beep(nota.Frequencia, velocidade);
            }
        }
    }
}
