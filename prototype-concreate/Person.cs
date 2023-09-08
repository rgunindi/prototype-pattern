namespace ConcreatePrototype
{
    public class Person :UserPrototype.User
    {
        //Define specific properties
        public string? CivilStatus { get; set; }
        public Person()
        {
        }
        public Person(Person person)
        {
            Name = person.Name;
            Email = person.Email;
            CivilStatus = person.CivilStatus;
        }
        public override Person Clone()
        {
            return new Person(this);
        }
    }
    
}