using LibraryFacadeExample;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Username:");
        string userName = Console.ReadLine();
        Console.WriteLine("Password:");
        int password;
        int.TryParse(Console.ReadLine(), out password);

        LibraryFacade libraryFacade = new LibraryFacade(userName, password);

        libraryFacade.OpenLibrary();
    }
}