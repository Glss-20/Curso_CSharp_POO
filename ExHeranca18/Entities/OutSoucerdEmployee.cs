using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca18.Entities
{
    class OutSoucerdEmployee : Employee    
    {
        public double AdditionalCharge {  get; set; }

        public OutSoucerdEmployee() 
        { 
        }


        public OutSoucerdEmployee(string name, int hours, double valuePerHour, double additionalCharge)
         : base(name, hours, valuePerHour) 
        {
            AdditionalCharge = additionalCharge;
        }


        public override double Payment()
        // O "override" é porque estamos sobrescrevendo esse método, que é um método da superclass,
        // isso porque esse método possui um comportamento diferente para essa classe.
        {
            return base.Payment() + 1.1 * AdditionalCharge;
            // O "base.Payment()" está reaproveitando a funcinalidade que o método tinha na superclass.
        }
    }
}
