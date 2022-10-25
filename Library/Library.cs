namespace Library
{
    internal class Library : IManagement
    {
        private List<Book> books = new List<Book>();
        private static Library _library;
        private Library() { }
        public static Library GetLibrary()
        {
            if (_library == null)
            {
                _library = new Library();
            }
            return _library;
        }
        public List<Book> GetBooksList()
        {
            return books;
        }

        public int IdentityID()
        {
            int max = 0;
            foreach (Book book in books)
            {
                if (book.ID >= max)
                {
                    max = book.ID + 1;
                }
            }
            return max;
        }

        public void Input()
        {
            Console.Write("Enter number of book: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type book's Information!!");
            for (int i = 0; i < N; i++)
            {
                Book book = new();
                book.ID = IdentityID();
                Console.WriteLine("Book's information: ");
                book.AddBook();
                books.Add(book);
            }
        }
        public void Display()
        {
            Console.WriteLine("{0, 5}   ||{1, 15}   ||{2, 15}   ||{3, 15}   ||{4, 15}   ||{5, 15}   ||", "ID", "Name", "Author", "Title", "Quantity", "Staff");
            foreach (Book book in books)
            {
                Console.WriteLine("{0, 5}   ||{1, 15}   ||{2, 15}   ||{3, 15}   ||{4, 15}   ||{5, 15}   ||", book.ID, book.Name, book.Author, book.Title, book.Quantity, book.Staff?.Name);
            }
        }
        public Book FindByID(int id)
        {
            Book result = null;
            foreach (Book book in books)
            {
                if (book.ID == id)
                {
                    result = book;
                }
            }
            return result;
        }
        public void Update()
        {
            Console.Write("Enter ID to update : ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Book book = FindByID(ID);
            if (book != null)
            {
                book.UpdateBook();
            }
            else
            {
                Console.WriteLine("No ID found!!!");
            }
        }
        public void Delete()
        {
            Console.Write("Enter ID of deleting book: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Book book = FindByID(d);
            if (book != null)
            {
                books.Remove(book);
            }
        }


    }

}
