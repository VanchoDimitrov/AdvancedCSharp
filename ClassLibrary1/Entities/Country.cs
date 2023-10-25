using BackEnd.Interfaces;

namespace BackEnd.Entities;

public class Country : ICountry
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}