using NameSorter.Models;

namespace NameSorter.Services;

public interface INameSorters
{
    List<PersonName> Sort(List<PersonName> names);
}

