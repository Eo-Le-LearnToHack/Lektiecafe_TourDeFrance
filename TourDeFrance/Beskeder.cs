using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDeFrance
{
    internal class Beskeder
    {
        public Boolean StartProgrammetIgen()
        {
            bool bol = true;
            Console.WriteLine("Tryk på en vilkårlig tast for at starte programmet forfra. (Skriv 'Exit' for at lukke programmet ned)");
            string? resultat = Console.ReadLine();
            if (resultat == "Exit")
                {
                bol = false;
                }
            Console.Clear();
            return bol;
        }

        public void Velkomsttekst()
        {
            Console.WriteLine("De 3 cykelryttere vejer hhv. 84, 69 og 97 kg");
            Console.WriteLine();
        }

    }
}
