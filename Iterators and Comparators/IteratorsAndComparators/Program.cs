using System.Collections;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public SortedSet<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new SortedSet<string>(authors);
        }

        public int CompareTo(Book other)
        {
            if (Year == other.Year)
            {
                return Title.CompareTo(other.Title);
            }

            return Year.CompareTo(other.Year);
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
    public class Library : IEnumerable<Book>
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

        readonly SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class StartUp
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book);
            }
        }
    }
}