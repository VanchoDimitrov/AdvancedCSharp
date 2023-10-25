using System.Runtime.InteropServices;
using BackEnd.Interfaces;

namespace Implementation;

public class Program
{
    public static void Main()
    {
        List<ICustomer> customers = new List<ICustomer>();

        DataRepository.SeedData(customers);

        Console.WriteLine("Total Balance: {0}", customers.Sum(x=>x.Balance));

    }
}