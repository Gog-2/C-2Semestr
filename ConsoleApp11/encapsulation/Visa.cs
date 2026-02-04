using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.encapsulation
{
    internal class Visa
    {
        Random rnd = new Random();
        private string[] _countryAvalible = new string[] {"Арстоцка","Колечия","Орбистан"};
        private string _country;
        public string Country
        {
            get { return _country; }
        }
        private bool _isValid;
        public bool IsValid
        {
            get { return _isValid; }
        }
        private int _year;
        public int Year
        {
            get { return _year; }
        }

        public Visa()
        {
            _country = _countryAvalible[rnd.Next(0,_countryAvalible.Length)];
            _isValid = rnd.Next(0, 2) == 1;
            _year = rnd.Next(2000,2050);
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Страна:{_country}\nПаспорт оригинальный:{_isValid}\nГод выдачи: {_year}");
        }
    }
}
