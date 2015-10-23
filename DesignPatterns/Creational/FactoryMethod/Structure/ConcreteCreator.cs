namespace DesignPatterns.Creational.FactoryMethod.Structure
{
    public class ConcreteCreator : Creator
    {
        public override Product CreateProduct()
        {
            return new MyProduct();
        }
    }
}