using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDeFrance
{
    internal class Program //Selve programmet
    {
        static public void Main(String[] args) // Main Method i programmet
        {
            bool loop = true;
            do
            {
                MethodValidation methodValidation = new(); //Oprettelse af methodValidation med reference til klassen MethodValidation
                Beskeder beskeder = new(); //Oprettelse af beskeder med reference til klassen Beskeder
                double[] cykelRytterKropsvægt = new double[3]; //Kropsvægt af alle tre cykelryttere gemt i array
                Cykelrytter[] cykelRytter = new Cykelrytter[3]; //Oprettelse af cykelRytter array med reference til klassen Cykelrytter

                beskeder.Velkomsttekst();
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Angiv kropsvægten i kg for cykelrytter nr. {i + 1}:\t");
                    cykelRytterKropsvægt[i] = methodValidation.InputManager(); //Tildeling af kropsvægt til de 3 cykelryttere og kontoller om input er af korrekt format (double)
                    cykelRytter[i] = new(cykelRytterKropsvægt[i]); //Instantiere cykelrytteren med kropsvægten defineret for oven
                }

                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Cykelrytternr. {i + 1}:");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Resultat for etape {i + 1}:\t {cykelRytter[i].resultatEtape[j]:N0} kalorier forbrændt."); //Udskriv resultat for hver etape
                    }
                    Console.WriteLine($"Summen af etaperne:\t {cykelRytter[i].resultatEtapeSum:N0} kalorier forbrændt"); //Udskriv resultat for summen af alle etaperne
                    Console.WriteLine();
                }

                loop = beskeder.StartProgrammetIgen();
            } while (loop); //do while loop for at programmet gentager sig selv igen og igen.
        }
    }
}