using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class BookComperator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            if (x.Title == y.Title)
            {
                return -x.Year.CompareTo(y.Year);
            }

            return x.Title.CompareTo(y.Title);
        }
    }
}
