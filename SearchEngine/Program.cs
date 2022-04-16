
using SearchEngine.Service;

SearchService serviceSearch = new();

Console.WriteLine("Axtaris sozu daxil edin");

var words = Console.ReadLine();

foreach (var word in serviceSearch.Searching(words))
{
    Console.WriteLine(word.Title + " " + word.Description);
}