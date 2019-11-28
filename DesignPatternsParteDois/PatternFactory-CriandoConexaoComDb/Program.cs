using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory_CriandoConexaoComDb
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo ConnectionFactory
            /* //METODO PROCEDURAL
                 * IDbConnection conexao = new SqlConnection();
                 * conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=meuBanco";
                 * conexao.Open(); 
                 */

            // UTILIZAÇÃO DA FACTORY QUE RETORNA A CONEXÃO COM O BANCO DE DADOS.
            //IDbConnection conexao = new ConnectionFactory().GetConnection();

            //IDbCommand comando = conexao.CreateCommand();
            //comando.CommandText = "select * from tabela";
            #endregion

            #region Exemplo ShapeFactory
            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Circle and call its draw method.
            IShape shape1 = shapeFactory.getShape("CIRCLE");
            //call draw method of Circle.
            shape1.Draw();

            //get an object of Rectangle and call its draw method.
            IShape shape2 = shapeFactory.getShape("RECTANGLE");
            //call draw method of Rectangle.
            shape2.Draw();

            //get an object of Square and call its draw method.
            IShape shape3 = shapeFactory.getShape("SQUARE");
            //call draw method of Square.
            shape3.Draw();

            //get an object of Circle using a basis constructor.
            IShape shape4 = shapeFactory.getShape(new Circle());
            shape4.Draw();

            #endregion

            Console.ReadKey();
        }
    }
}
