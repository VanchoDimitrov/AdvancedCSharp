
using BackEnd;

public class Program
{
    // delegate return type can change based on the return type method.
    delegate string InsertCustomerDelegate(ICustomer customer);
    delegate string UpdateCustomerDelegate(int id, ICustomer customer);

    public static void Main()
    {
        var customer = new Customer()
        {
            Id = 1,
            Name = "Customer 1",
        };

        InsertCustomerDelegate insertCustomerDelegate = new InsertCustomerDelegate(customer.InsertCustomer);
        string insertResult = insertCustomerDelegate(customer);
        Console.WriteLine(insertResult);

        UpdateCustomerDelegate updateCustomerDelegate = new UpdateCustomerDelegate(customer.UpdateCustomer);
        string updateResult = updateCustomerDelegate(1, customer);
        Console.WriteLine(updateResult);

        Console.ReadKey();
    }
}