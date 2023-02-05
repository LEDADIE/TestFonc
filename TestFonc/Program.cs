// See https://aka.ms/new-console-template for more information

foreach (var item in dataFile())
{
  Console.WriteLine(item.ToString());
}

Console.ReadKey();
///
/// DECLARATION DES FONCTIONS
///
static IEnumerable<string> dataFile()
{
  string[] lines = File.ReadAllLines(@"D:\Source\Repos\TestFonc\TestFonc\Datas\dataFile.txt");
  return lines;
}