namespace Library
{
    internal class BillInformation
    {
        private int _id;
        private Book? _book;
        private int _quantity;

        public int ID { get { return _id; } set { _id = value; } }
        public Book? Book { get { return _book; } set { _book = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }

        Library library = Library.GetLibrary();

        public void CheckBook(int bookID)
        {
            foreach (Book book in library.GetBooksList())
            {
                if (book.ID == bookID)
                {
                    _book = book;
                }
            }
            if (_book != null)
            {
                Console.WriteLine("Book information added");
            }
            else
            {
                Console.WriteLine("ID not found");
            }
        }
        public void CreateBillInformation()
        {
            Console.Write("Book ID:");
            int bookID = Convert.ToInt32(Console.ReadLine());
            CheckBook(bookID);
            Console.WriteLine("Quantity: ");
            _quantity = Convert.ToInt32(Console.ReadLine());
        }
        public void UpdateBillInformation()
        {
            Console.WriteLine("Updating (Enter to skip update): ");
            Console.WriteLine("Update Book: ");
            string book = Console.ReadLine();
            if (book != null && book.Length > 0)
            {
                int bookID = Convert.ToInt32(book);
                CheckBook(bookID);
            }
            Console.WriteLine("Update Quantity: ");
            string quantity = Console.ReadLine();
            if (quantity != null && quantity.Length > 0)
            {
                _quantity = Convert.ToInt32(quantity);
            }
        }
        public void DisplayBillInformation()
        {
            Console.WriteLine("ID: ", +_id);
            Console.WriteLine("Book: ID:{0} Name:{1} ", _book?.ID, _book?.Name);
            Console.WriteLine("Quantity: " + _quantity);
            Console.WriteLine("=============================================================");
        }
    }
}
