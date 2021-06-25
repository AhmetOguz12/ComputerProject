using Business.Concrete;
using DataAccess.Conrete;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerManager computerManager = new ComputerManager(new InMemoryComputerDal());

            foreach (var computer in computerManager.GetAll())
            {
                Console.WriteLine(computer.ComputerName);
            }
        }
    }
}
