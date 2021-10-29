using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affärslager
{
    internal class MedlemRepository
    {
        internal List<Medlem> Medlemmar = new List<Medlem>();

        internal void LäggTillMedlem(string medlemsNr, string mNamn, string telNr, string epost)
        {
            Medlemmar.Add(new Medlem(medlemsNr, mNamn, telNr, epost));
        }

        internal void LaddaMedlemmar()
        {
            if (HämtaMedlem().Count() == 0)
            {
                LäggTillMedlem("1", "Anna", "033-122724", "anna@gmail.com");
                LäggTillMedlem("2", "Johan", "033-124578", "johan@gmail.com");
                LäggTillMedlem("3", "Nicklas", "033-337578", "nicklas@gmail.com");
                LäggTillMedlem("4", "Lina", "033-981246", "lina@gmail.com");
                LäggTillMedlem("5", "Pekka", "033-921245", "pekka@gmail.com");
            }
        }

        internal List<Medlem> HämtaMedlem()
        {
            return Medlemmar;
        }

        internal Medlem HittaValdMedlem(string id)
        {
            Medlem valdMedlem = null;
            foreach(Medlem medlem in Medlemmar)
            {
                if(medlem.MedlemsNr == id)
                {
                    valdMedlem = medlem;
                }
            }

            return valdMedlem;
        }
    }
}
