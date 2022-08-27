using project1;
class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите название файла в виде [имя_файла].[формат]");
        string name = Console.ReadLine().ToLower();

        FileParser name1 = FileParser.GetParser(name);
        while (name1 == null)
        {
            Console.WriteLine("Название некорректное. Введите корректное название файла в виде[имя_файла].[формат]");
            name = Console.ReadLine().ToLower();
            name1 = FileParser.GetParser(name);
        }
        name1.Parse();
    }
}