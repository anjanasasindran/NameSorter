namespace NameSorter.Models;

public class PersonName
{
    public List<string> GivenNames { get; set; }
    public string LastName { get; set; }

    public PersonName(List<string> givenNames, string lastName)
    {
        GivenNames = givenNames;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"{string.Join(" ", GivenNames)} {LastName}";
    }
}