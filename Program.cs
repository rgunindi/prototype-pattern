using ConcreatePrototype;
internal class Program
{
    private static void Main(string[] args)
    {
        var UserList = new List<UserPrototype.User>();
        var testPrototypeList = new List<UserPrototype.User>();
        var civilian = new Person
        {
            Name = "John Doe",
            Email = "john@gmail.com",
            CivilStatus = "Single"
        };
        UserList.Add(civilian);

        var soldier = new Military
        {
            Name = "Deny Don",
            Email = "deny@gmail.com",
            Rank = "Major"
        };
        UserList.Add(soldier);

        var civilian2 = civilian.Clone();
        civilian2.Name = "001";
        civilian2.Email = "hitman@xxx.com";
        var soldier2 = soldier.Clone();
        soldier2.Name = "James Bond";
        soldier2.Email = "bond@b.com";
        soldier2.Rank = "007";
        testPrototypeList.Add(civilian2);
        testPrototypeList.Add(soldier2);
        foreach (var user in UserList)
        {
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Email: {user.Email}");
            if (user is Person person)
            {
                Console.WriteLine($"Civil Status: {person.CivilStatus}");
            }
            else if (user is Military military)
            {
                Console.WriteLine($"Rank: {military.Rank}");
            }
            Console.WriteLine();
        }

        foreach (var user in testPrototypeList)
        {
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Email: {user.Email}");
            if (user is Person person)
            {
                Console.WriteLine($"Civil Status: {person.CivilStatus}");
            }
            else if (user is Military military)
            {
                Console.WriteLine($"Rank: {military.Rank}");
            }
            Console.WriteLine();
        }
        // Using PrototypeRegistry
        var registry = new PrototypeRegistry();
        registry.AddPrototype("civilian", civilian);
        registry.AddPrototype("soldier", soldier);

        var civilian3 = registry.GetPrototype("civilian");
        civilian3.Name = "002";
        var soldier3 = registry.GetPrototype("soldier");
        soldier3.Name = "003";

        Console.WriteLine($"Name: {civilian3.Name} {nameof(civilian3)} provided by {nameof(registry)}");
        Console.WriteLine($"Name: {soldier3.Name} {nameof(soldier3)} provided by {nameof(registry)}");
    }
}