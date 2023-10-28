using BackEnd.Entities;
using BackEnd.Interfaces;

namespace Implementation
{
    public class DataRepository
    {
        public static void SeedData(List<ICustomer> customers)
        {
            var region = new Region()
            {
                Id = 1,
                Name = "Region 1",
            };

            var country = new Country()
            {
                Id = 1,
                Name = "Austria",
                Description = "EU",
            };

            ICustomer customer1 = CustomerFactory.GetCustomerInstance(
                1,
                "Customer 1",
                "Top Customer",
                "Address 1",
                BackEnd.Entities.City.Linz,
                region,
                "1000",
                country,
                "123456789",
                "987654321",
                "www.something.com");
            customers.Add(customer1);

            ICustomer customer2 = CustomerFactory.GetCustomerInstance(
                2,
                "Customer 2",
                "Top Customer",
                "Address 1",
                BackEnd.Entities.City.Linz,
                region,
                "1000",
                country,
                "123456789",
                "987654321",
                "www.something.com");
            customers.Add(customer2);

            ICustomer customer3 = CustomerFactory.GetCustomerInstance(
                3,
                "Customer 3",
                "Top Customer",
                "Address 1",
                BackEnd.Entities.City.Linz,
                region,
                "1000",
                country,
                "123456789",
                "987654321",
                "www.something.com");
            customers.Add(customer3);
        }

        public class LinzCity : Customer
        {
            public override double Balance
            {
                get => base.Balance + (base.Balance + 20);
            }
        }

        public class ViennaCity : Customer
        {
            public override double Balance
            {
                get => base.Balance + (base.Balance + 40);
            }
        }
    }
}
