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

        public int vysledekScitani;
        public int vysledekOdcitani;
        public int vysledekNasobeni;
        public int vysledekDeleni;

        public MatematickyPriklad VygenerujCislaProScitani() // metoda vygeneruje čísla pro sčítání a jejich součet
        {
            Random generatorNahodnychCisel = new Random();
            a = generatorNahodnychCisel.Next(0,50); //vygeneruje se číslo a
            b = generatorNahodnychCisel.Next(0, 50); //vygeneruje se číslo b
            vysledekScitani = a + b; //vygeneruje součet
            return new MatematickyPriklad(a, b, vysledekScitani);
        }

        public MatematickyPriklad VygenerujCislaOdecitani() // metoda vygeneruje čísla pro odčítání a jejich rozdíl
        {
            Random generatorNahodnychCisel = new Random();
            a = generatorNahodnychCisel.Next(1, 50); //vygeneruje se číslo a
            b = generatorNahodnychCisel.Next(0, a ); //vygeneruje se číslo b
            vysledekOdcitani = a - b; //vygeneruje rozdíl
            return new MatematickyPriklad(a, b, vysledekOdcitani);
        }

        public MatematickyPriklad VygenerujCislaNasobeni() // metoda vygeneruje čísla pro násobení a jejich součin
        {
            Random generatorNahodnychCisel = new Random();
            a = generatorNahodnychCisel.Next(1, 10); //vygeneruje se číslo a
            b = generatorNahodnychCisel.Next(0, 10); //vygeneruje se číslo b
            vysledekNasobeni = a * b; //vygeneruje se součin
            return new MatematickyPriklad(a, b, vysledekNasobeni);
        }

        public MatematickyPriklad VygenerujCislaDeleni() // metoda vygeneruje čísla pro dělení a jejich součin
        {
            Random generatorNahodnychCisel = new Random();
            a = generatorNahodnychCisel.Next(1, 50); //vygeneruje se číslo a
            while(true)
            {
            b = generatorNahodnychCisel.Next(1, a); //vygeneruje číslo b tak, aby dělení bylo beze zbytku.
                if ( a % b == 0)
                {
                    break;
                }
            }
            vysledekDeleni = a / b; //vygeneruje se podíl
            return new MatematickyPriklad(a, b, vysledekDeleni);
        }
    }
}
