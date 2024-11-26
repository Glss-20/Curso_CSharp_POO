using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGenerics29
{
    class CalculationsService //Aqui só o método da classe é genérico.
    {                                                       
        public T Max<T>(List<T> list) where T : IComparable // O "where" significa que o tipo "T" tem que ser do tipo "Icomparable".
         {
            if (list.Count == 0)
            {
                throw new ArgumentException("List Empty!");
            }

            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
