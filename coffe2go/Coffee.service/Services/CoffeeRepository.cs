using coffe2go.Datastore;
using coffe2go.Entities;


namespace coffe2go.Services;

public class CoffeeRepository : ICoffeRepository
{
    private readonly CoffeeDatastore _context;

    public CoffeeRepository(CoffeeDatastore context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));;
    }

    public IEnumerable<Coffee> GetCoffeeCatalog()
    {
        return _context.Coffees.ToList();
    }

    public Coffee? GetCoffee(int id)
    {
        var result = _context.Coffees.FirstOrDefault(c => c.Id == id);
        return result;
    }
}