using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Practic.PracticLesson2
{
    internal class CarStats
    {
        private double _power;
        private double _weight;
        private float _driverSkill;
        public void PowerDensity()
        {
            double powerDensity = _power / _weight;
            Console.WriteLine($"Power Density: {powerDensity} HP/kg");
        }
        public CarStats(double power, double weight, float driverSkill)
        {
            _power = power;
            _weight = weight;
            _driverSkill = Math.Clamp(driverSkill, 0f, 1f);
        
        }
        public static CarStats operator +(CarStats car1, CarStats car2)
        {
            car1._power = (car1._power + car2._power) * 0.85;
            car1._weight += car2._weight;
            car1._driverSkill = (car1._driverSkill + car2._driverSkill) / 2;
            return car1;
        }
        public static CarStats operator -(CarStats car1, CarStats car2)
        {
            car1._power = (car1._power - car2._power) * 0.85;
            car1._weight -= car2._weight;
            car1._driverSkill = (car1._driverSkill - car2._driverSkill) / 2;
            return car1;
        }
        public static CarStats operator *(CarStats car1, CarStats car2)
        {
            car1._power *= car2._power;
            car1._weight *= car2._weight;
            car1._driverSkill = (car1._driverSkill * car2._driverSkill) / 2;
            return car1;
        }
        public override string ToString()
        {
            return $"Power: {_power} HP, Weight: {_weight} kg, Driver Skill: {_driverSkill}";
        }
        public static explicit operator double(CarStats car)
        {
            return car._power / car._weight;
        }
    }
}
