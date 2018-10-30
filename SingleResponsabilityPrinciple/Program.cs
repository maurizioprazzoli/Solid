using System;
using System.Collections.Generic;

namespace SingleResponsabilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            var rectangle = new Rectangle(3, 4);

            var pc = new PerimeterCalculator();

            /*
             * ***************
             * SRP Violation *
             * ***************
            La classe PerimeterCalculator, esegue due funzionalità: calcolare il perimetro degli oggetti e
            stampare il risultato.
            */
             pc.CalculateTotalPerimeter(new IGeometricShape[] { square, rectangle });

            /*
             * 
             * Bisognerebbe modificare la classe PerimeterCalculator sebbene il calcolo del perimetro non ne sia affetto.
             * Per tale motivo è meglio separare in due classi separate così che una modifica ad una delle due operazioni,
             * avvenga limitatamente ad una delle due classi: 
             * 
             * 
             */
            var pc2 = new PerimeterCalculatorV2();
            var pp = new PerimeterPrinter();

            var totalPerimeter = pc2.CalculateTotalPerimeter(new IGeometricShape[] { square, rectangle });
            pp.PrintTotalPerimeter(totalPerimeter);

            Console.ReadLine();

        }
    }
}
