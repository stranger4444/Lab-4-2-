using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal interface IConnectable
    {
        void З_єднатися(Комп_ютер іншийКомпютер);
        void Відключитися(Комп_ютер іншийКомпютер);
        void ВідправитиДані(Комп_ютер отримувач, string дані);
        void ПрийнятиДані(Комп_ютер відправник, string дані);
    }
}
