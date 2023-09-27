using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryFacadeExample
{
    public class LibraryFacade
    {
        private string _userName;

        private int _password;

        private CheckPassword checkPassword;
        private UserNameCheck nameCheck;
        private BookCheck bookCheck;

        private WelcomeToLibrary welcome;

        public LibraryFacade(string userName, int password)
        {
            welcome = new WelcomeToLibrary();
            _userName = userName;
            _password = password;
            checkPassword = new CheckPassword();
            nameCheck = new UserNameCheck();
            bookCheck = new BookCheck();
        }

        public string GetUserName()
        {
            return _userName;
        }

        public int GetPassword()
        { return _password; }

        public void OpenLibrary()
        {
            bookCheck.AddBook();
            bookCheck.GetBooks();
            if (nameCheck.CheckUserName(GetUserName()) && checkPassword.PasswordCheck(GetPassword()))
            {
                Console.Write("Please select the operation you want to perform:\n" +
                    "1.Rent Book\n" +
                    "2.Return Book\n ");
                int selection;
                Int32.TryParse(Console.ReadLine(), out selection);
                if (selection == 1)
                {
                    Console.Write("Please write the name of the book you want to rent.");
                    string nameofBook = Console.ReadLine();
                    RentBook(nameofBook);
                }
                if (selection == 2)
                {
                    Console.Write("Please write the name of the book you want to return.");
                    string nameofBook = Console.ReadLine();
                    ReturnBook(nameofBook);
                }
            }
            else
            {
                Console.WriteLine("Password or username is not valid.");
            }
        }

        public void RentBook(string nameofBook)
        {
            if (bookCheck.CheckBook(nameofBook))
            {
                bookCheck.Books.Remove(nameofBook);
            }
        }

        public void ReturnBook(string nameofBook)
        {
            if (bookCheck.CheckBook(nameofBook) == false)
            {
                Console.WriteLine("Book is not rented");
            }
            bookCheck.Books.Add(nameofBook);
            Console.WriteLine("Book is returned successfully.");
        }
    }
}