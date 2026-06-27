using NameSorter.Models;

namespace NameSorter.Services;

public class NameSorters : INameSorters
{
    public List<PersonName> Sort(List<PersonName> names)
    {
        return names
            .OrderBy(n => n.LastName)
            .ThenBy(n => string.Join(" ", n.GivenNames))
            .ToList();
    }
}