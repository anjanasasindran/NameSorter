namespace NameSorter.Services;

public class FileService : IFileService
{
    public List<string> ReadLines(string path)
    {
        return File.ReadAllLines(path).ToList();
    }

    public void WriteLines(string path, List<string> lines)
    {
        File.WriteAllLines(path, lines);
    }
}