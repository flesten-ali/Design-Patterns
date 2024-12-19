using C_Output.Classes;
using C_Output.Composit.BuiltInComposit;
using C_Output.Composit.CompositDP;
using C_Output.Composit.FileSystemComposit;
using C_Output.Decorator;
using C_Output.Factory;
using C_Output.FunctionalProgramming;
using C_Output.MyAdapter;
using C_Output.Observer.General;
using C_Output.Observer.GeneralPassingStateUsingRefrence;
using C_Output.Observer.TicketManagmentSys;
using C_Output.Strategy;
using DesignPatterns.FunctionalProgramming;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace DesignPatterns
{
    public class Program
    {
        private readonly IContactAdapter _contactAdapter;

        public Program(IContactAdapter contactAdapter)
        {
            _contactAdapter = contactAdapter;
        }
        public static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            var stock=  new TicketStock();
            orderService.AddTicketServiceObserver(stock);
            orderService.AddTicketServiceObserver(new TicketSeller());
            orderService.OrderIsFulfilled(new TicketBooked { Id = 1 , Name = "new ticket"});

            orderService.RemoveTicketServiceObserver(stock);
            orderService.OrderIsFulfilled(new TicketBooked { Id = 2, Name = "another ticket" });



            Console.ReadKey();
        }

        private static void ObserverSendStateUsingRefrence()
        {
            var subject = new Observable2();
            var observerOne = new ObserverOne2(subject);
            var observerTwo = new ObserverTwo2(subject);
            observerOne.ChangeSubjectState();
        }

        private static void ObserverSendStateUsingParameters()
        {
            Observable observable = new Observable();
            observable.AddObserver(new ObserverOne());
            observable.AddObserver(new ObserverTwo());

            observable.ChangeStateOfObservable(new ChanedState());
        }

        private static void BuiltINStrategy()
        {
            //Order [] a= { new Order() , new Order()};
            var arr = new[]
            {
                new Order() , new Order()
            };
            Array.Sort(arr, new CompareOrder());
        }

        private static void UseStrategy()
        {
            Context c = new Context();
            // c.SendingStrategy = new EmailSender();
            c.send(new SMSSender());
            Console.ReadKey();
        }

        private static void HowLINQWork()
        {
            var FetchDate = OneByOne().ToList();

            foreach (var item in FetchDate)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<int>  OneByOne()
        {
             Console.WriteLine("Hello from one by one");

            for (int i = 0; i < 2; i++)
            {
                yield return i;
            } 
        }

        private static void Composit()
        {
            CompositExample.start();
        }

        private static void FunctionalProgramming()
        {
            FunctionalProgramming2.LinqWay5();
        }

        private void AfterUsingAdapter()
        {
            // after using adapter to solve problem 
            //msg type is injected using constructor

            Program program = new Program(new EmailAdapter(new EmailService(), "example@gmail.com"));
            program = new Program(new SMSAdapter(new SMSMsgService(), 0569876));
            program.AfterUsingAdapter();
            //msg type is injected using constructor
            _contactAdapter.Contact();

        }
        private static void WhyToUseAdapter()
        {
            //Problem without Adapter 
            //we want to make Common Compatible interface for services that call just contact method()
            //No ocp
            //No SRP
            //No Pholymerphyism
            var msgType = MsgType.SMS;
            if (msgType == MsgType.Email)
            {
                var email = new EmailService();
                email.SendEmail("example@gmail.com");

            }
            else
            {
                var msg = new SMSMsgService();
                msg.SendSMS(0569876);

            }
        }

        private static void BuiltInDecorator()
        {
            using (var file = new FileStream("path", FileMode.Open))
            {
                var decoratorOne = new BufferedStream(file);
                //var decoratorTwo = new CryptoStream(decoratorOne,, CryptoStreamMode.Read);

            }
        }

        private static void DecoratorPattern()
        {
            Person person = new Person();

            var decoratedOne = new DecoratorOne(person);

            var decoratedTwo = new DecoratorTwo(decoratedOne);
            decoratedTwo.GetPerson();
        }

        private static void BuiltInComposit()
        {
            var xml = XElement.Load("XMLFile.xml");
            foreach (var item in xml.FindAllFiles((item) => !item.HasElements))
            {
                Console.WriteLine($"File is {item.Attribute("name")}");
            }
        }

        private static void CompositFileWithBuilder()
        {
            var builder = new FileSystemBuilder("root");
            builder.AddDirectory("dir1");
            builder.AddFile("file1Dir1");
            builder.SetCurrentDirectory("root");
            builder.AddFile("Root-file");

            builder.Root.PrimaryOperation();
        }

        private static void ExampleOneOfComposit()
        {
            Composit root = new Composit("Root");
            var dir1 = new Composit("dir1");
            var file1 = new Leaf("1-File1");
            var file2 = new Leaf("1-File2");
            dir1.Add(file1);
            dir1.Add(file2);


            var dir2 = new Composit("dir2");
            var file12 = new Composit("2-File1");

            dir2.Add(file12);

            root.Add(dir1);
            root.Add(dir2);



            root.PrimaryOperation();
        }
    }
}

































//static void Main(string[] args)
//{
//    A();
//    B();
//}

//private static async Task A()
//{
//    await Task.Delay(5000);
//    Console.WriteLine("Hello From A");
//}

//private static async Task B()
//{
//    await Task.Delay(2000);
//    Console.WriteLine("Hello From B");
////}
///

//public static async Task Main(string[] args)
//{
//    await A();
//    await B();
//}

//private static async Task A()
//{
//    await Task.Delay(5000);
//    Console.WriteLine("Hello From A");
//}

//private static async Task B()
//{
//    await Task.Delay(2000);
//    Console.WriteLine("Hello From B");
//}



//static void Main(string[] args)
//{
//    A();
//    B();
//    while (true)
//    {

//    }
//}

//private static async Task A()
//{
//    await Task.Delay(5000);
//    Console.WriteLine("Hello From A");
//}

//private static async Task B()
//{
//    await Task.Delay(2000);
//    Console.WriteLine("Hello From B");
//}

//public record Student(int Id, string Name);

//public static void Main(string[] args)
//{
//    var student1 = new Student(1, "Khalid");
//    var student2 = new Student(1, "Khalid");

//    Console.WriteLine(student1 == student2);
//    Console.WriteLine(student1.Equals(student2));
//}