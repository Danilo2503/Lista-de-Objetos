using System;
using System.Collections.Generic;
using Lista_de_Objetos.classes;

namespace Lista_de_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cartao> cartoes = new List<Cartao>();

            cartoes.Add(new Cartao(1, "MasterCard"));
            cartoes.Add(new Cartao(2, "Visa"));
            cartoes.Add(new Cartao(3, "American Express"));
            cartoes.Add(new Cartao(4, "Hipercard"));

            foreach(var c in cartoes){
                Console.WriteLine(cartoes);
            }
        }
    }
}
