


namespace DesignPatterns.FunctionalProgramming
{
    public static class FunctionalProgramming2
    {

        static List<int> list = new List<int>(){ 1, 2, 3};
        private static Func<int, int> MyCompositFunction = Composit(AddOne,Square,Suptract);

        public static void LinqWay1()
        {
             list.Select(AddOne).Select(Square).Select(Suptract)
                .ToList().ForEach((x) => Console.WriteLine(x));
        }
        public static void LinqWay2()
        {
            list.Select(x=>AddOne(x)).Select(x=>Square(x)).Select(x=>Suptract(x))
               .ToList().ForEach((x) => Console.WriteLine(x));
        }
        public static void LinqWay3()
        {
            list.Select(x => Suptract(Square(AddOne(x))))
               .ToList().ForEach((x) => Console.WriteLine(x));
        }
        public static void LinqWay4()
        {
            list.Select(MyCompositFunction)
               .ToList().ForEach((x) => Console.WriteLine(x));
        }

        public static void LinqWay5()
        {
            list.Select(Calculate())
               .ToList().ForEach((x) => Console.WriteLine(x));
        }
        public static Func<int,int> Calculate()
        {
            Func<int, int> d1 = AddOne;
            Func<int, int> d2 = Square;
            Func<int, int> d3 = Suptract;
            return d1.ComposeTwo(d2).ComposeTwo(d3);
        }
        public static Func<int, int> ComposeTwo(this Func<int, int> F1, Func<int, int> F2)
        {
            return (x) => F2(F1(x));
        }
        public static Func<int,int> Composit(Func<int, int> addOne, Func<int, int> square, Func<int, int> subtract)
        {
            return (x) => subtract(square(addOne(x)));
        }
        public static int AddOne(int x)
        {
            return x + 1;
        }

         public static int Square(int x)
        {
            return x * x;
        }

         public static int Suptract(int x)
         {
            return x - 2;
         }




    }
}
