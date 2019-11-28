using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver_ExecutandoAcoesDiferentes
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }
        public override void update()
        {
            Console.WriteLine("Octal String: " + Convert.ToString(subject.getState(), 8));
        }
    }
}
