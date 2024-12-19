using C_Output.Classes;

namespace C_Output.Factory
{
    public static class SimpleFactory
    {

        public static Class1 CreateClass1()
        {
            return new Class1();

        }
        public static Class2 CreateClass2()
        {
            return new Class2();
        }



    }
}
