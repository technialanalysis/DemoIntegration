using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemo
{
    internal class SomeOtherClas
    {
        public async void SomeMethod() //asynchronous method.
        {
            Console.WriteLine("Before SomeMethod");
            Wait();
            Console.WriteLine("\n");
            Console.WriteLine("After SomeMethod");

        }

        private static async void Wait() //asynchronous method.
        {
            await Task.Delay(10000);
            Console.WriteLine("\n10 Seconds wait Completed\n");
        }
    }
}
