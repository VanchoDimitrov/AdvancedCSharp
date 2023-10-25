namespace BackEnd
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public string InsertCustomer(ICustomer customer)
        {
            return "Customer Saved";
        }

        public string UpdateCustomer(int id, ICustomer customer)
        {
            return "Customer Updated";
        }
    }
}