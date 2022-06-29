using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDeFrance
{
    internal class MethodValidation
    {
        public double InputManager()
        {
            double? input = null;

            do
            {
                string? svar = Console.ReadLine();
                double tempSvar;
                if (double.TryParse(svar, out tempSvar))
                {
                    input = tempSvar;
                }
                else
                {
                    Console.Write("Input invalid. Indtast venligst et tal:\t");
                }
            } while (input == null);
            return (double)input;
        }
    }
}
