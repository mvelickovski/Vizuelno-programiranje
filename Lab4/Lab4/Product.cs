using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Product
    {
        public string ime { get; set; }
        public string kategorija { get; set; }
        public double cena { get; set; }
        public Product(string ime,string kategorija,double cena)
        {
            this.ime = ime;
            this.kategorija = kategorija;
            this.cena = cena;
        }
        public override string ToString()
        {
            return ime;
        }
    }
}
