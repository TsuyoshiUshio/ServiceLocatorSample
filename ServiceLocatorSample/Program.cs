using System;

namespace ServiceLocatorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLocator.Instance.Register<IService, OsakaService>();

            var service = ServiceLocator.Instance.GetService<IService>();
            Console.WriteLine(service.Greeting());
            Console.ReadLine();

        }
    }
}
