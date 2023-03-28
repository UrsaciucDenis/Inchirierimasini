using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inchirierimasini
{
    public class Persoana
    {
        private string nume;
        private string prenume;
        private int CNP;
    }

    //constructor implicit
    public Persoana()
    {
        nume = prenume = string.Empty;
    }
    public Persoana (string nume, string prenume, int CNP)
    {
        this.nume = nume;
        this.prenume = prenume;
        this.CNP = CNP;
    }


}
