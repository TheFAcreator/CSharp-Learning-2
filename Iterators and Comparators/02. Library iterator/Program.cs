using System.Collections;

namespace IteratorsAndComparators
{
    class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }
    }
    class Library : IEnumerable<Book>
    {
        private class LibraryIterator : IEnumerator<Book>
        {
            public Book Current => books[index];

            object IEnumerator.Current => Current;

            readonly List<Book> books;
            int index = -1;

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                index++;

                return index < books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }

        readonly List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class StartUp
    {
        static void Main(string[] args)
        {

        }
    }
}