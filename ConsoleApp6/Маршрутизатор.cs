using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Маршрутизатор : Комп_ютер, IConnectable
    {
        public Маршрутизатор(string ipАдреса, int потужність, string типОС)
        : base(ipАдреса, потужність, типОС)
        {
        }

        public void З_єднатися(Комп_ютер іншийКомп_ютер)
        {
            Console.WriteLine($"Маршрутизатор {IPАдреса} з'єднав {іншийКомп_ютер.IPАдреса} з мережею");
        }

        public void Відключитися(Комп_ютер іншийКомп_ютер)
        {
            Console.WriteLine($"Маршрутизатор {IPАдреса} відключив {іншийКомп_ютер.IPАдреса} від мережі");
        }

        public void ВідправитиДані(Комп_ютер отримувач, string дані)
        {
            Console.WriteLine($"Маршрутизатор {IPАдреса} відправив дані на комп'ютер {отримувач.IPАдреса}: {дані}");
        }

        public void ПрийнятиДані(Комп_ютер відправник, string дані)
        {
            Console.WriteLine($"Маршрутизатор {IPАдреса} отримав дані від комп'ютера {відправник.IPАдреса}: {дані}");
        }
    }
}

