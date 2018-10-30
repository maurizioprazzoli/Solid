using System;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            var rectangle = new Rectangle(3, 4);

            var pc = new PerimeterCalculator();
            var pp = new PerimeterPrinter();

            /*
             *  OPEN CLOSE Violation
             *  Ogni volta che viene aggiunta una nuova classe che estende GeometricShape, bisognerà aggiungere un nuovo ramo all’if dentro il ciclo for.
             * 
             */
            var totalPerimeter = pc.CalculateTotalPerimeter(new GeometricShapeBase[] { square, rectangle });
            pp.PrintTotalPerimeter(totalPerimeter);

            /*
             *  Una migliore soluzione consiste come primo passo nella (ri)creazione del metodo calcolaPerimetro() all’interno dell’interfaccia FormaGeometrica:
             */

            var pcV2 = new PerimeterCalculatorV2();
            var totalPerimeterV2 = pcV2.CalculateTotalPerimeter(new GeometricShapeBase[] { square, rectangle });
            pp.PrintTotalPerimeter(totalPerimeterV2);

            Console.ReadLine();
        }
    }
}
