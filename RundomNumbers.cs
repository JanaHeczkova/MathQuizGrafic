using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuizGrafic
{
    internal class RundomNumbers
    {
        public int a;
        public int b;
        private int c;

        public int vysledekScitani;
        public int vysledekOdcitani;
        public int vysledekNasobeni;
        public int vysledekDeleni;

        public void VygenerujCislaProScitani() // metoda vygeneruje čísla pro sčítání a jejich součet
        {
            Random generatorNahodnychCisel = new Random();
            a = generatorNahodnychCisel.Next(0,50); //vygeneruje se číslo a
            b = generatorNahodnychCisel.Next(0, 50); //vygeneruje se číslo b
            vysledekScitani = a + b; //vygeneruje součet
        }

        public void VygenerujCislaOdecitani() // metoda vygeneruje čísla pro odčítání a jejich rozdíl
        {
            Random generatorNahodnychCisel = new Random();
            a = generatorNahodnychCisel.Next(1, 50); //vygeneruje se číslo a
            b = generatorNahodnychCisel.Next(0, a ); //vygeneruje se číslo b
            vysledekOdcitani = a - b; //vygeneruje rozdíl
        }

        public void VygenerujCislaNasobeni() // metoda vygeneruje čísla pro násobení a jejich součin
        {
            Random generatorNahodnychCisel = new Random();
            a = generatorNahodnychCisel.Next(1, 10); //vygeneruje se číslo a
            b = generatorNahodnychCisel.Next(0, 10); //vygeneruje se číslo b
            vysledekNasobeni = a * b; //vygeneruje se součin
        }

        public void VygenerujCislaDeleni() // metoda vygeneruje čísla pro dělení a jejich součin
        {
            Random generatorNahodnychCisel = new Random();
            a = generatorNahodnychCisel.Next(1, 50); //vygeneruje se číslo a
            while(true)
            {
            b = generatorNahodnychCisel.Next(1, a);
                if ( a % b == 0)
                {
                    break;
                }
            }
            vysledekDeleni = a / b; //vygeneruje se podíl
        }
    }
}
