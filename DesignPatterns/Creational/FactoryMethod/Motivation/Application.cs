namespace DesignPatterns.Creational.FactoryMethod.Motivation
{
    public class Application
    {
        public virtual Document CreateDocument()
        {
            return new Document();
        }
    }
}