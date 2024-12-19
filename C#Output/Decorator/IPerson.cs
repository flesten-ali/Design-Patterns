namespace C_Output.Decorator
{
    public interface IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        void GetPerson();
    }
}