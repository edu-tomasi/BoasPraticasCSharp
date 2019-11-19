using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator_ImpostosCompostos
{
    public abstract class Filtro
    {
        public abstract List<Conta> Filtro(List<Conta> listaConta);
    }
}
