using coffe2go.Entities;

namespace coffe2go.Datastore;

public class CoffeeDatastore
{
    public static CoffeeDatastore CoffeeData { get; } = new CoffeeDatastore();
    public List<Coffee> Coffees { get; set; }

    public CoffeeDatastore()
    {
        Coffees = new List<Coffee>()
        {
            new Coffee()
            {
                Id = 1,
                CoffeeType = "Espresso",
                Size = "Single",
                Price = 25.95
            },
            new Coffee()
            {
                Id = 2,
                CoffeeType = "Espresso",
                Size = "Double",
                Price = 28.95
            },
            new Coffee()
            {
                Id = 3,
                CoffeeType = "Latte",
                Size = "Small",
                Price = 32
            },
            new Coffee()
            {
                Id = 4,
                CoffeeType = "Latte",
                Size = "Large",
                Price = 35
            },
            new Coffee()
            {
                Id = 5,
                CoffeeType = "Pour over",
                Size = "Small",
                Price = 27
            },

        };

    }
}