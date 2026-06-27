using NameSorter.Services;
using NameSorter.Utils;

if (args.Length == 0)
{
    Console.WriteLine("Please provide input file path.");
    return;
}

var inputPath = args[0];
var outputPath = "sorted-names-list.txt";

IFileService fileService = new FileService();
INameSorters sorter = new NameSorter.Services.NameSorters();

// Read
var lines = fileService.ReadLines(inputPath);

// Parse
var people = lines.Select(NameParser.Parse).ToList();

// Sort
var sorted = sorter.Sort(people);

// Convert back to string
var result = sorted.Select(p => p.ToString()).ToList();

// Print
foreach (var name in result)
{
    Console.WriteLine(name);
}

// Write
fileService.WriteLines(outputPath, result);

Console.WriteLine($"\nSorted names written to {outputPath}");