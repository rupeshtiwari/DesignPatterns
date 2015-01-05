namespace DesignPatterns.Creational.Prototype
{
    public class Sheep : Animal
    {
        public string Name { get; set; }
        public override object Clone()
        {
            return MemberwiseClone();
        }
    }
}