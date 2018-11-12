using System;
using Derivco.Test.Service;

namespace Derivco.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = MenuService.Build();

            MenuService.Print(menu);

            Console.ReadKey();
        }
    }
}
