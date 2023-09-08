namespace UserPrototype
{
    public abstract class User
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public abstract User Clone();
        public User() { }
        public User(User user)
        {
            Name = user.Name;
            Email = user.Email;
        }
    }

}