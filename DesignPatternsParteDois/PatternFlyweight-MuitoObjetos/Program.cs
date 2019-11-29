using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFlyweight_MuitoObjetos
{
    class Program
    {
        private static string[] colors = { "Red", "Green", "Blue", "White", "Black" };

        static void Main(string[] args)
        {
            #region Exemplo Notas
            NotasMusicais notas = new NotasMusicais();

            IList<INota> musica = new List<INota>() {
               notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa"),

            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("re"),
            notas.Pega("re"),

            notas.Pega("do"),
            notas.Pega("sol"),
            notas.Pega("fa"),
            notas.Pega("mi"),
            notas.Pega("mi"),
            notas.Pega("mi"),

            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa")
            };

            Piano piano = new Piano();
            //piano.Toca(musica);
            #endregion

            Console.Clear();

            #region Exemplo Tutorials Point
            for (int i = 0; i < 20; ++i)
            {
                Circle circle = (Circle)ShapeFactory.getCircle(getRandomColor());
                circle.xPos = getRandomX();
                circle.yPos = getRandomY();
                circle.radius = 100;
                circle.Draw();
            }
            #endregion

            Console.ReadKey();
        }

        private static string getRandomColor()
        {
            return colors[new Random().Next(0, 4)];
        }

        private static int getRandomX()
        {
            return new Random().Next() * 100;
        }

        private static int getRandomY()
        {
            return new Random().Next() * 100;
        }

    }
}
