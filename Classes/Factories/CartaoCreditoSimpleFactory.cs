using Classes.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Factories
{
    public class CartaoCreditoSimpleFactory
    {
        public static AbstractCartaoCredito CriarCartaoCredito(string tipoCartao)
        {
            AbstractCartaoCredito abstractCartaoCredito;

            switch (tipoCartao)
            {
                case "M": 
                    abstractCartaoCredito = new CartaoCreditoMasterCardBlack();
                    break;

                case "V":
                    abstractCartaoCredito = new CartaoCreditoVisaGold();
                    break;

                default:
                    throw new Exception("Tipo de cartão inválido");
            }

            return abstractCartaoCredito;
        }
    }
}
