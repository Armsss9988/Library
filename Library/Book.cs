namespace Library
{
    internal class Book // class name
    {
        // Field
        private Staff? _staff;

        private int _id; // variable 
        private string _title;
        private string _author;
        private string _name;
        private int _quantity;
        // Property
        public int ID { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Author { get { return _author; } set { _author = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        public Staff? Staff { get { return _staff; } set { _staff = value; } }

        // Method
        public void AddBook()

        {
            Console.Write("Book Name: ");
            _name = Console.ReadLine();
            Console.Write("Author: ");
            _author = Console.ReadLine();
            Console.Write("Title: ");
            _title = Console.ReadLine();
            Console.Write("Quantity: ");
            _quantity = Convert.ToInt32(Console.ReadLine());

        }
        public void UpdateBook()
        {

            Console.Write("Book Name: ");
            string name = Console.ReadLine();
            if (name != null && name.Length > 0)
            {
                _name = name;
            }
            Console.Write("Author: ");
            string author = Console.ReadLine();
            if (author != null && author.Length > 0)
            {
                _author = author;
            }
            Console.Write("Title: ");
            string title = Console.ReadLine();
            if (title != null && title.Length > 0)
            {
                _title = title;
            }
            Console.Write("Quantity: ");
            string quantity = Console.ReadLine();
            if (quantity != null && quantity.Length > 0)
            {
                _quantity = Convert.ToInt32(quantity);
            }

        }

    }
}
