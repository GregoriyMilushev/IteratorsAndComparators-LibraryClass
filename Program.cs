using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookThree = new Book("The Documents in the Case", 1930);
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            libraryTwo.Books.Sort(new BookComperator());

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book);
            }

        }
    }
}
