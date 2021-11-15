namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            var helloWorldCls = new Class1();
            Console.WriteLine (helloWorldCls.GenerateHelloWorld());

            Console.WriteLine("What is your name");            
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}");
            Console.WriteLine($"{Environment.NewLine}Press any key to exit.");
            Console.ReadKey(true);
        }
        
    }
}
