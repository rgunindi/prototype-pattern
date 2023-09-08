using UserPrototype;

internal class PrototypeRegistry
{
    private Dictionary<string, User> _prototypes = new Dictionary<string, User>();
    public PrototypeRegistry()
    {
    }
    public void AddPrototype(string prototypeName, User user)
    {
        _prototypes.Add(prototypeName, user);
    }
    public User GetPrototype(string prototypeName)
    {
        return _prototypes[prototypeName].Clone();
    }
}

