namespace DesignPatterns.Creational.Prototype
{
    public class CloneFactory
    {
        public static Animal GetClone(Animal animal)
        {
            return (Animal)animal.Clone();
        }
    }
}