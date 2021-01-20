using Classes.Factories;
using System;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o tipo de cartão que deseja:");
            Console.WriteLine("V - Visa Gold");
            Console.WriteLine("M - MasterCard Black");
            var tipoCartao = Console.ReadLine();

            var cartaoCredito = CartaoCreditoSimpleFactory.CriarCartaoCredito(tipoCartao);
            cartaoCredito.LiberarCartao();
        }
    }
}
