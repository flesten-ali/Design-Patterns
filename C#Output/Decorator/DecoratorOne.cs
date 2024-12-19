 
namespace C_Output.Decorator
{
    internal class DecoratorOne : IPerson
    {
        private readonly IPerson _person;
        public DecoratorOne(IPerson person)
        {
            _person = person;
        }

        public int Id { get ; set ; }
        public string Name { get  ; set; }

        public void GetPerson()
        {
            Console.WriteLine("start Some additonal behavior from first Decorator");
            _person.GetPerson();
            Console.WriteLine("End additonal behavior from first Decorator");
        }
    }
}
