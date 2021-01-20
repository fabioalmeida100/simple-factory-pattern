using Classes.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class CartaoCreditoVisaGold: AbstractCartaoCredito
    {
        public CartaoCreditoVisaGold()        
        {
            Bandeira = "Visa Gold";            
        }

        public override void LiberarCartao()
        {
            Console.WriteLine($"Seu cartão da bandeira {Bandeira} foi liberado com limite de R$ 1.500,00");
        }
    }
}
