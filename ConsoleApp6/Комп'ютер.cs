using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Комп_ютер
    {
        public string IPАдреса { get; set; }
        public int Потужність { get; set; }
        public string ТипОС { get; set; }

        public Комп_ютер(string ipАдреса, int потужність, string типОС)
        {
            IPАдреса = ipАдреса;
            Потужність = потужність;
            ТипОС = типОС;
        }
    }
}
