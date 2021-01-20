using Classes.Factories;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o tipo de cartão de crédito desejado:");
            Console.WriteLine("M - MasterCard Black");
            Console.WriteLine("V - Visa Gold");
            var tipoCartao = Console.ReadLine();

            var cartaoCredito = CartaoCreditoSimpleFactory.CriarCartaoCredito(tipoCartao.ToUpper());
            cartaoCredito.LiberarCartao();            
        }
    }
}
