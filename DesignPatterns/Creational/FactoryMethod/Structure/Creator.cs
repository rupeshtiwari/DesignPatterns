namespace DesignPatterns.Creational.FactoryMethod.Structure
{
    public class Creator
    {
        public virtual Product CreateProduct()
        {
            return new Product();
        }
    }
}