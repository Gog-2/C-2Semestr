using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.encapsulation
{
    internal class BorderGuard
    {
        public string CheckVisa(Visa visa)
        {
            if (visa.Country == "Колечия") return "Вражеская страна";
            if (!visa.IsValid) return "ПОТДДЕЛКА!";
            if (visa.Year - 2026 <= -5) return "ПРОСРОЧЕНО";
            if (visa.Year - 2026 > 0) return "Некоректный год выпуска!";
            return "Вьезд разрешен";
        }
    }
}
