using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo.DesignPatterns.AbstractFactory.Conceptual
{
    interface IAbstractProductB
    {
        string UsefullFunctionB();
        string AnotherUsefullFunctionB(IAbstractProductA collaborator);
    }
}
