using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDeFrance
{
    internal class Cykelrytter
    {
        const double calorieForbrug_PerKgxKm = 0.33;
        public double Kropsvægt_Kg { get; set; }
        private double[] etape_Km = new double[3] { 13, 202, 182 };
        public double[] resultatEtape = new double[3]; //Array værdierne bliver oprettet via metoden BeregnCalorieForbrug_PerCykelrytter()
        public double resultatEtapeSum = 0;

        public Cykelrytter(double kropsvægt_kg) //CONSTRUCTOR. Kropsvægt skal angives ved oprettelse af objektet Cykelrytter
        {
            Kropsvægt_Kg = kropsvægt_kg;
            BeregnCalorieForbrug_PerCykelrytter();
        }

        public void BeregnCalorieForbrug_PerCykelrytter() //METODE, bliver kaldt direkte fra construtor.
        {
            for (int i = 0; i < 3; i++)
            {
                resultatEtape[i] = calorieForbrug_PerKgxKm * Kropsvægt_Kg * etape_Km[i]; //Beregner kalorie forbrændt per etape
                resultatEtapeSum += resultatEtape[i]; //Beregner samlet kalorie forbrændt
            }
        }

    }
}