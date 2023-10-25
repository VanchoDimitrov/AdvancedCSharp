namespace BackEnd;

public interface ICustomer
{
    int Id { get; set; }
    string Name { get; set; }
    string InsertCustomer(ICustomer customer);
    string UpdateCustomer(int id, ICustomer customer);
}