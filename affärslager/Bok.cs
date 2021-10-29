using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affärslager
{
    public class Bok
    {
        public string ISBN { get; internal set; }
        public string Titel { get; internal set; }
        public bool Bokad { get; internal set; }

        internal Bok(string isbn, string titel, bool bokad)
        {
            this.ISBN = isbn;
            this.Titel = titel;
            this.Bokad = bokad;
        }
    }
}
