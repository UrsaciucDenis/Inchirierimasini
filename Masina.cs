using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirierimasini
{
    public class Masina
    {
        private string marca;
        private string model;
        private int capacitatemotor;
        private int pret;


        //constructor implicit
        public Masina()
        {
            marca = model = string.Empty;
        }

        //comstructor cu parametrii
        public Masina(string marca, string model, int capacitatemotor, int pret)
        {
            this.marca = marca;
            this.model = model;
            this.capacitatemotor = capacitatemotor;
            this.pret = pret;

        }
    }
}
