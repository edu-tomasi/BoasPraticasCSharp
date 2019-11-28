using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver_ExecutandoAcoesDiferentes
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }
        public override void update()
        {
            Console.WriteLine("Hex String: " + subject.getState().ToString("X4").ToUpper());
        }
    }
}
