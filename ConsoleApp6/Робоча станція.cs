using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Робоча_станція : Комп_ютер, IConnectable
    {
        public Робоча_станція(string ipАдреса, int потужність, string типОС)
       : base(ipАдреса, потужність, типОС)
        {
        }

        public void З_єднатися(Комп_ютер іншийКомп_ютер)
        {
            Console.WriteLine($"Робоча станція {IPАдреса} з'єднана з комп'ютером {іншийКомп_ютер.IPАдреса}");
        }

        public void Відключитися(Комп_ютер іншийКомп_ютер)
        {
            Console.WriteLine($"Робоча станція {IPАдреса} відключилася від комп'ютера {іншийКомп_ютер.IPАдреса}");
        }

        public void ВідправитиДані(Комп_ютер отримувач, string дані)
        {
            Console.WriteLine($"Робоча станція {IPАдреса} відправила дані на комп'ютер {отримувач.IPАдреса}: {дані}");
        }

        public void ПрийнятиДані(Комп_ютер відправник, string дані)
        {
            Console.WriteLine($"Робоча станція {IPАдреса} отримала дані від комп'ютера {відправник.IPАдреса}: {дані}");
        }
    }
}
