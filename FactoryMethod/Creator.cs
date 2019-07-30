using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Conceptual
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public string SomeOperation()
        {
            var product = FactoryMethod();
            string result = "Creator: The same creator's code has just worked with "
                + product.Operation();
            return result;
        }
    }
}
