namespace C_Output.Composit.CompositDP
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void PrimaryOperation() => Console.WriteLine($"This is leaf {Name}");
    }
}
