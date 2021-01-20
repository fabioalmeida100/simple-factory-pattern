using Classes.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class CartaoCreditoMasterCardBlack: AbstractCartaoCredito
    {
        public CartaoCreditoMasterCardBlack()
        {
            Bandeira = "MasterCard Black";            
        }

        public override void LiberarCartao()
        {
            Console.WriteLine($"Seu cartão da bandeira {Bandeira} foi liberado com limite infinito");
        }
    }
}
