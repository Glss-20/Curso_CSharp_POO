using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGeneric28
{
    internal class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValeu(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Print Service is full!");
            }
            _values[_count] = value; // Armazena o valor passado no parâmetro, no primeira posição do vetor.
            _count++; // Conta e 
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Print Service is empty!");
            }
            return _values[0];
        }
        
        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.Write(_values[i] + " - ");
            }
            Console.WriteLine("");
        }


    }
}
