namespace ConcreatePrototype
{
    public class Military : UserPrototype.User
    {
        //Define specific properties
        public string? Rank { get; set; }
        public Military()
        {
        }
        public Military(Military military)
        {
            Name = military.Name;
            Email = military.Email;
            Rank = military.Rank;
        }
        public override Military Clone()
        {
            return new Military(this);
        }
    }
}