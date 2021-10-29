using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace affärslager
{
    internal class BokRepository
    {
        internal List<Bok> Böcker = new List<Bok>();
              
        internal void LäggTillBöcker(string isbn, string titel, bool bokad)
        {
           Böcker.Add(new Bok(isbn, titel, bokad));
        }

        internal List<Bok> HämtaBöcker()
        {
            return Böcker;
        }

        internal void LaddaBöcker()
        {
            if (HämtaBöcker().Count() == 0)
            {
                LäggTillBöcker("1244B", "Pelle Svanslös", false);
                LäggTillBöcker("5466S", "Harry Potter", false);
                LäggTillBöcker("8686E", "Outlander", false);
                LäggTillBöcker("3456M", "Pro C# 7", false);
                LäggTillBöcker("3455", "War and Peace", false);
                LäggTillBöcker("9084G", "Don Quixote", false);
                LäggTillBöcker("12465F", "Inte ett ord", false);
                LäggTillBöcker("3850D", "Rättsinformatik", false);
            }

        }

        internal void GörBokadTillTrue(string titel)
        {
            foreach(Bok b in Böcker)
            {
                if(b.Titel == titel)
                {
                    b.Bokad = true;
                }
            }
        }

        internal void GörBokadTillFalse(string titel)
        {
            foreach (Bok b in Böcker)
            {
                if (b.Titel == titel)
                {
                    b.Bokad = false;
                }
            }
        }

        internal List<Bok> HämtaLedigaBöcker()
        {
            List<Bok> ledigaBöcker = new List<Bok>();

            foreach(Bok bok in Böcker)
            {
                if(bok.Bokad == false)
                {
                    ledigaBöcker.Add(bok);
                }
            }

            return ledigaBöcker;
        }

    }
}
