using BackEnd.Interfaces;

namespace BackEnd.Entities;

public class Region : IRegion
{
    public int Id { get; set; }
    public string Name { get; set; }
}