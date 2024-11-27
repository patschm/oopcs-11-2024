using Bogus;

namespace Lambdas;

internal class Program
{
    static string OrderByFirstName(Person p)
    {
        return p.Firstname;
    }
    static string OrderByLastName(Person p)
    {
        return p.Lastname;
    }

    static bool FilterLastNameByA(Person p)
    {
        return p.Lastname.StartsWith("A");
    }
    static bool FilterLastNameByB(Person p)
    {
        return p.Lastname.StartsWith("B");
    }

    static void Main(string[] args)
    {
        var people = CreatePeople(100);

        // var iets = people.OrderBy(OrderByLastName);
        string par = Console.ReadLine();
        var iets = people.Where(p =>p.Lastname.StartsWith(par));
       

        foreach(Person person in iets)
        {
            Console.WriteLine($"{person.Firstname} {person.Lastname}  ({person.Age})");
        }
    }

    static Person[] CreatePeople(int hoeveel)
    {
        return new Faker<Person>()
            .RuleFor(p => p.Firstname, f => f.Name.FirstName())
            .RuleFor(p => p.Lastname, f => f.Name.LastName())
            .RuleFor(p => p.Age, f => f.Random.Int(0, 123))
            .Generate(hoeveel)
            .ToArray();
    }
}
