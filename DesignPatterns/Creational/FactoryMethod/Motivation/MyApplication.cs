namespace DesignPatterns.Creational.FactoryMethod.Motivation
{
    public class MyApplication : Application
    {
        public override Document CreateDocument()
        {
            return new MyDocument();
        }
    }
}