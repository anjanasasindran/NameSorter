namespace NameSorter.Services;

public interface IFileService
{
    List<string> ReadLines(string path);
    void WriteLines(string path, List<string> lines);
}