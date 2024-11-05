using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEnumAndComposition14.Entities
{
    class Departament
    {

        public string Name { get; set; } // Mesmo com auto propertie tem os métodos construtores abaixo.

        public Departament() // Construtor sem parâmetros, para criar um objeto sem definir nenhum valor inicialmente.
        { 
        
        }

        public Departament(string name) // Construtor com parâmetro, permite que você crie o objeto já com um valor inicial para a propriedade "Name".
        {
            Name = name;
        }
    }
}
