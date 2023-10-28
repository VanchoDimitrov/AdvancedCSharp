using BackEnd;
using BackEnd.Entities;
using BackEnd.Interfaces;

namespace Implementation;

public static class CustomerFactory
{
    public static ICustomer GetCustomerInstance(
        int id,
        string name,
        string description,
        string address,
        City city,
        Region region,
        string postalCode,
        Country country,
        string phoneNumber,
        string fax,
        string homePage)
    {
        ICustomer? customer = null;

        switch (city)
        {
            case City.Linz:
                customer = Factory<ICustomer, DataRepository.LinzCity>.GetInstance();
                break;
            case City.Vienna:
                customer = Factory<ICustomer, DataRepository.ViennaCity>.GetInstance();
                break;
            default:
                break;
        }

        if (customer != null)
        {
            customer.Id = id;
            customer.Name = name;
            customer.Description = description;
            customer.Address = address;
            customer.City = city;
            customer.Region = region;
            customer.PostalCode = postalCode;
            customer.Country = country;
            customer.PhoneNumber = phoneNumber;
            customer.Fax = fax;
            customer.HomePage = homePage;
        }

        return customer;
    }
}