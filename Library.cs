using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    class Library : IEnumerable<Book>
    {

        public List<Book> Books { get; set; }

        public Library(params Book[] newBooks)
        {
            this.Books = new List<Book>(newBooks);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books = books;
            }

            public Book Current => books[currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                currentIndex++;
                if (currentIndex >= this.books.Count)
                {
                    return false;
                }
                return true;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
