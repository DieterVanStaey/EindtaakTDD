using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindtaakTDD
{
    public class Persoon
    {
        public List<string> Voornamen { get; set; }

        public Persoon(List<string> voornamen)
        {
            if (voornamen == null)
                throw new ArgumentNullException();
            if (voornamen.Count == 0)
                throw new ArgumentException();
            if (voornamen.Count != voornamen.Distinct().Count())
                throw new ArgumentException();
            foreach (var voornaam in voornamen)
            {
                if (voornaam == String.Empty)
                    throw new ArgumentException();
            }
            Voornamen = voornamen;

        }
        public override string ToString()
        {
            string namenString = String.Empty;
            foreach (var voornaam in Voornamen)
            {
                namenString += voornaam + " ";
            }
            return namenString;
        }
    }
}
