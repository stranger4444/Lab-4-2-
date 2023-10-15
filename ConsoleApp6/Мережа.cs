using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Мережа
    {
        private List<Комп_ютер> Комп_ютери;

        public Мережа()
        {
            Комп_ютери = new List<Комп_ютер>();
        }

        public void ДодатиКомп_ютер(Комп_ютер комп_ютер)
        {
            Комп_ютери.Add(комп_ютер);
        }

        public void ПередатиДані(Комп_ютер відправник, Комп_ютер отримувач, string дані)
        {
            if (Комп_ютери.Contains(відправник) && Комп_ютери.Contains(отримувач))
            {
                Console.WriteLine($"Передача даних від {відправник.IPАдреса} до {отримувач.IPАдреса}: {дані}");
                відправник.ВідправитиДані(отримувач, дані);
                отримувач.ПрийнятиДані(відправник, дані);
            }
            else
            {
                Console.WriteLine("Не вдалося передати дані - один з комп'ютерів не з'єднаний з мережею.");
            }
        }
    }
}
