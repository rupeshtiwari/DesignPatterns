using System;

namespace DesignPatterns.Creational.Prototype
{
    public abstract class Animal : ICloneable
    {
        public abstract Object Clone();
    }
}
