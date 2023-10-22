public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public static bool operator ==(Person person1, Person person2)
    {
        if (ReferenceEquals(person1, null))
        {
            return ReferenceEquals(person2, null);
        }

        return person1.Equals(person2);
    }
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
    public static bool operator !=(Person person1, Person person2)
    {
        return !(person1 == person2);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Person other = (Person)obj;
        return Name == other.Name && Age == other.Age;
    }
    public static void Main(string[] args)
    {
        Person person1 = new Person { Name = "Alice", Age = 30 };
        Person person2 = new Person { Name = "Bob", Age = 25 };
        Person person3 = new Person { Name = "Alice", Age = 30 };
        
        bool areEqual = (person1 == person2); 
        bool areNotEqual = (person1 != person2);

        bool areEqual2 = (person1 == person3); 
        bool areNotEqual2 = (person1 != person3); 
        Console.WriteLine(areEqual);
        Console.WriteLine(areNotEqual);
        Console.WriteLine(areEqual2);
        Console.WriteLine(areNotEqual2);

    }
}


