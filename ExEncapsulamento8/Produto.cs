using System.Globalization;

namespace ExEncapsulamento8
{
    class Produto
    {   
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // USANDO AUTO-PROPERTIES - 3
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Ao invés de definirmos o atributo aqui e depois criarmos o método especial (os properties),
        // nós podemos já fazer tudo isso na definição do atributo.

        private string _nome; //Como esse atributo tem uma lógica específica(no set), o ideal é usar só o PROPERTIE.
        public double Preco { get; private set; }//Aqui definimos que ela pode ser retornada, mas não pode ser modificada (private set).
        public int Quantidade { get; private set; }//Aqui definimos que ela pode ser retornada, mas não pode ser modificada (private set).


        // private double _preco; //Atributo usando PROPERTIES.
        // private int _quantidade; //Atributo usando PROPERTIES.

    public Produto(string nome, double preco, int quantidade)//método construtor
        {
            _nome = nome;
            //_preco = preco;
            //_quantidade = quantidade;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // USANDO PROPRIEDADES - PROPERTIES - 2
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Nome //Diferente do Get e Set, aqui temos um método especial que faz o get e set.
        {
            get { return _nome; }
            set { _nome = value; } // "value" é o parâmetro, que será passado no "program" para realizar a alteração, o set.
        }

        //public double Preco // O uso da AUTO-PROPERTIE substitui o uso desse método.
        //{
        //    get { return _preco; }
        //}

        //public int Quantidade // O uso da AUTO-PROPERTIE substitui o uso desse método.
        //{
        //    get { return _quantidade; }
        //}
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // USANDO GET E SET - 1
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /*
        public string GetNome()
        {
            return _nome; // O atributo é privado, então para acessa-lo diretamento usamos um método Get que retorna seu valor.
        }

        public void SetNome(string nome)
        {
            _nome = nome; // O atributo é privado, então para modificarmos o seu valor no "program" usamos 
        }                 // um método Set que recebe o novo valor como parâmetro
        
        public double GetPreco()
        {
            return _preco; // Esse atributo não deve ser alterado, então criamos apenas o método Get para ela.
        }

        public int GetQuantidade()
        {
            return _quantidade; // Esse atributo não deve ser alterado, então criamos apenas o método Get para ela.
        }
       */
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
