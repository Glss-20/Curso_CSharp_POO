using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSalario
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;

        public Funcionario(string nome, double salario) 
        {
            this.Nome = nome;
            this.Salario = salario;
        }
    }
}
