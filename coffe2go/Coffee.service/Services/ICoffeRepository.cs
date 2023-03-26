using coffe2go.Entities;

namespace coffe2go.Services;

public interface ICoffeRepository
{
    IEnumerable<Coffee> GetCoffeeCatalog();
    Coffee? GetCoffee(int id);
}