using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.ControlPoint.ControllPoint2
{
    internal interface IExtremeTransport
    {
        protected bool CanDoStunts { get;}
        public virtual void PerformStunt()
        {
                Console.WriteLine("Performing a stunt!");
        }
        protected double RiskFactor { get; }
    }
}
