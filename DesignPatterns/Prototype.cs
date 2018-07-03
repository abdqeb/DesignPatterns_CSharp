using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeCloning
{
    public interface Cloneable
    {
        Prototype Clone();
    }

    public abstract class Prototype : Cloneable
    {
        public abstract Prototype Clone();
    }

    public class ConcretePrototype1 : Prototype
    {
        public override Prototype Clone()
        {
            return this.Clone();
        }
    }

    public class ConcretePrototype2 : Prototype
    {
        public override Prototype Clone()
        {
            return this.Clone();
        }
    }
}
