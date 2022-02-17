using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalypenzNyilvantartas
{
  class Osztalypenz
  {
    public string Nev { get; set; }

    public int Osszeg { get; set; }

    public string FizetesTipus { get; set; }

    public string Datum { get; set; }

    public Osztalypenz(string sor)
    {
      string[] a = sor.Split(';');
      Nev = a[0];
      Osszeg = Convert.ToInt32(a[1]);
      FizetesTipus = a[2];
      Datum = a[3];
    }

    public Osztalypenz(string nev, int osszeg, string fizetesTipus, string datum)
    {
      Nev = nev;
      Osszeg = osszeg;
      FizetesTipus = fizetesTipus;
      Datum = datum;
    }
  }
}
