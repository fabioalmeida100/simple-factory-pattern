using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.AbstractClasses
{
    public abstract class AbstractCartaoCredito
    {
        protected string Bandeira { get; set; }

        public abstract void LiberarCartao();        
    }
}
