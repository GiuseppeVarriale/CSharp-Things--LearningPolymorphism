using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance4.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double aditionalCharge) : base(name, hours, valuePerHour)
        {
            AditionalCharge = aditionalCharge;
        }

        public override double Payment()
        {
            double payment = base.Payment() + AditionalCharge * 1.10;
            return payment;
        }
    }
}
