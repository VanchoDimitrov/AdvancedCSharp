using BackEnd.Entities;

namespace BackEnd.Interfaces;

public interface ICountry
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }

}