using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFacadeExample
{
    public class BookCheck
    {
        public List<string> Books = new List<string>();

        public void AddBook()
        {
            Books.Add("C#");
            Books.Add("Java");
            Books.Add("HTML");
            Books.Add("C++");
        }

        public void GetBooks()
        {
            Console.WriteLine("Available Books:");
            Books.ForEach(i => Console.WriteLine("{0}\n", i));
        }

        public bool CheckBook(string nameofBook)
        {
            if (!(Books.Contains(nameofBook)))
            {
                Console.WriteLine("The book was rented! ");
                return false;
            }
            return true;
            Console.WriteLine("Book is available for rent.");
        }
    }
}