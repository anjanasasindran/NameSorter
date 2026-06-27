using NameSorter.Models;

namespace NameSorter.Utils;

public static class NameParser
{
    public static PersonName Parse(string fullName)
    {
        var parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length < 2)
            throw new ArgumentException("Invalid name format");

        var lastName = parts[^1];
        var givenNames = parts.Take(parts.Length - 1).ToList();

        return new PersonName(givenNames, lastName);
    }
}