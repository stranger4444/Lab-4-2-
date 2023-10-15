using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Сервер : Комп_ютер, IConnectable
    {
        public Сервер(string ipАдреса, int потужність, string типОС)
        : base(ipАдреса, потужність, типОС)
    {
    }

    public void З_єднатися(Комп_ютер іншийКомпютер)
    {
        Console.WriteLine($"Сервер {IPАдреса} з'єднався з комп'ютером {іншийКомпютер.IPАдреса}");
    }

    public void Відключитися(Комп_ютер іншийКомп_ютер)
    {
        Console.WriteLine($"Сервер {IPАдреса} відключився від комп'ютера {іншийКомп_ютер.IPАдреса}");
    }

    public void ВідправитиДані(Комп_ютер отримувач, string дані)
    {
        Console.WriteLine($"Сервер {IPАдреса} відправив дані на комп'ютер {отримувач.IPАдреса}: {дані}");
    }

    public void ПрийнятиДані(Комп_ютер відправник, string дані)
    {
        Console.WriteLine($"Сервер {IPАдреса} отримав дані від комп'ютера {відправник.IPАдреса}: {дані}");
    }
    }
}
