namespace Library
{
    public class Program
    {
        static void Main(String[] args)
        {
            Library bookList = Library.GetLibrary();
            GuessList guessList = new GuessList();
            StaffList staffList = new StaffList();

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("*========================================*");
                    Console.WriteLine("||        Library Management!!!         ||");
                    Console.WriteLine("*=================******=================*");
                    Console.WriteLine("||        1.Book management.            ||");
                    Console.WriteLine("||        2.Guess management.           ||");
                    Console.WriteLine("||        3.Staff management.           ||");
                    Console.WriteLine("||        4.Bill management.            ||");
                    Console.WriteLine("||        5.Exit.                       ||");
                    Console.WriteLine("*========================================*");
                    Console.Write("Choose option: ");
                    int k = Convert.ToInt32(Console.ReadLine());
                    switch (k)
                    {
                        case 1:
                            bool h = true;
                            while (h)
                            {
                                Console.Clear();
                                Console.WriteLine("*========================================*");
                                Console.WriteLine("||        Library Management!!!         ||");
                                Console.WriteLine("*=================******=================*");
                                Console.WriteLine("||        1.Add book.                   ||");
                                Console.WriteLine("||        2.Update book.                ||");
                                Console.WriteLine("||        3.Delete book.                ||");
                                Console.WriteLine("||        4.Display booklist.           ||");
                                Console.WriteLine("||        5.Book manager of book.       ||");
                                Console.WriteLine("||        6.Back.                       ||");
                                Console.WriteLine("*========================================*");
                                Console.Write("Choose option:");
                                int l = Convert.ToInt32(Console.ReadLine());


                                switch (l)
                                {

                                    case 1:
                                        Console.WriteLine("Add Book!!!");
                                        bookList.Input();

                                        Console.WriteLine("Input success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.WriteLine("Update book!!!");
                                        bookList.Update();
                                        Console.WriteLine("Update success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.WriteLine("Delete book!!!");
                                        bookList.Delete();
                                        Console.WriteLine("Delete success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.WriteLine("Display book list!!!");
                                        bookList.Display();
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 5:
                                        Staff staff = null;
                                        while (staff == null)
                                        {
                                            Console.WriteLine("Enter staff ID:");
                                            string stringStaffID = Console.ReadLine();
                                            if (stringStaffID == null || stringStaffID.Length == 0)
                                            {
                                                break;
                                            }
                                            staff = staffList.FindByID(Convert.ToInt32(stringStaffID));
                                            if (staff?.Role?.ToLower() != "book manager")
                                            {
                                                Console.WriteLine("This staff is not found or not a book manager");
                                                Console.ReadLine();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Enter book's ID for this staff");
                                                Book book = bookList.FindByID(Convert.ToInt32(Console.ReadLine()));
                                                book.Staff = staff;
                                            }
                                        }
                                        break;
                                    case 6:
                                        h = false;
                                        break;

                                    default:
                                        Console.WriteLine("Invalid Input");
                                        break;
                                }
                            }
                            break;
                        case 2:
                            h = true;
                            while (h)
                            {
                                Console.Clear();
                                Console.WriteLine("*========================================*");
                                Console.WriteLine("||        1. Add guess.                 ||");
                                Console.WriteLine("||        2. Update guess.              ||");
                                Console.WriteLine("||        3. Delete guess.              ||");
                                Console.WriteLine("||        4. Display guess.             ||");
                                Console.WriteLine("||        5. Back.                      ||");
                                Console.WriteLine("*========================================*");
                                Console.Write("Choose option:");
                                int m = Convert.ToInt32(Console.ReadLine());
                                switch (m)
                                {
                                    case 1:
                                        Console.WriteLine("Add Guess!!!");
                                        guessList.Input();
                                        Console.WriteLine("Input success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.WriteLine("Update guess!!!");
                                        guessList.Update();
                                        Console.WriteLine("Update success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.WriteLine("Delete guess!!!");
                                        guessList.Delete();
                                        Console.WriteLine("Delete success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.WriteLine("Display guess list!!!");
                                        guessList.Display();
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 5:
                                        h = false;
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input");
                                        break;
                                }
                            }
                            break;
                        case 3:
                            h = true;
                            while (h)
                            {
                                Console.Clear();
                                Console.WriteLine("*========================================*");
                                Console.WriteLine("||        1. Add staff.                 ||");
                                Console.WriteLine("||        2. Update staff.              ||");
                                Console.WriteLine("||        3. Delete staff.              ||");
                                Console.WriteLine("||        4. Display staff.             ||");
                                Console.WriteLine("||        5. Back.                      ||");
                                Console.WriteLine("*========================================*");
                                Console.Write("Choose option:");
                                int mt = Convert.ToInt32(Console.ReadLine());
                                switch (mt)
                                {
                                    case 1:
                                        Console.WriteLine("Add Staff!!!");
                                        staffList.Input();
                                        Console.WriteLine("Input success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.WriteLine("Update staff!!!");
                                        staffList.Update();
                                        Console.WriteLine("Update success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.WriteLine("Delete staff!!!");
                                        staffList.Delete();
                                        Console.WriteLine("Delete success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.WriteLine("Display staff list!!!");
                                        staffList.Display();
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 5:
                                        h = false;
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input");
                                        break;
                                }
                            }
                            break;

                        case 4:
                            h = true;
                            Guess guess = null;
                            while (guess == null)
                            {
                                Console.WriteLine("Enter Guess ID:");
                                string stringGuessID = Console.ReadLine();
                                if (stringGuessID == null || stringGuessID.Length == 0)
                                {
                                    break;
                                }
                                guess = guessList.FindByID(Convert.ToInt32(stringGuessID));
                            }
                            while (h)
                            {
                                Console.Clear();
                                Console.WriteLine("Guess: {0} .   ID: {1}", guess.Name, guess.ID);
                                Console.WriteLine("*=======================================*");
                                Console.WriteLine("||        1.Add bill.                  ||");
                                Console.WriteLine("||        2.Update bill.               ||");
                                Console.WriteLine("||        3.Delete bill.               ||");
                                Console.WriteLine("||        4.Display bill history.      ||");
                                Console.WriteLine("||        5.Bill information.          ||");
                                Console.WriteLine("||        6.Back.                      ||");
                                Console.WriteLine("*=======================================*");
                                Console.Write("Choose option:");
                                string so = Console.ReadLine();
                                int o = Convert.ToInt32(so);
                                switch (o)
                                {
                                    case 1:
                                        Console.WriteLine("Add Bill!!!");
                                        guess.AddBill();
                                        Console.WriteLine("Add success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.WriteLine("Update bill!!!");
                                        guess.UpdateBill();
                                        Console.WriteLine("Update success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.WriteLine("Delete bill!!!");
                                        guess.DeleteBill();
                                        Console.WriteLine("Delete success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.WriteLine("Display history!!!");
                                        guess.DisplayBill();
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 5:
                                        bool hl = true;
                                        Bill bill = null;
                                        while (bill == null)
                                        {
                                            Console.WriteLine("Enter Bill ID:");
                                            string stringBillID = Console.ReadLine();
                                            if (stringBillID == null || stringBillID.Length == 0)
                                            {
                                                break;
                                            }
                                            bill = guess.FindByID(Convert.ToInt32(stringBillID));
                                        }
                                        while (hl)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Guess: {0} .   ID: {1}", guess.Name, guess.ID);
                                            Console.WriteLine("Bill ID: ");
                                            Console.WriteLine("*=======================================*");
                                            Console.WriteLine("||        1.Add bill information.      ||");
                                            Console.WriteLine("||        2.Update bill information.   ||");
                                            Console.WriteLine("||        3.Delete bill information.   ||");
                                            Console.WriteLine("||        4.Display bill information.  ||");
                                            Console.WriteLine("||        5.Back.                      ||");
                                            Console.WriteLine("*=======================================*");
                                            Console.Write("Choose option:");
                                            int ol = Convert.ToInt32(Console.ReadLine());
                                            switch (ol)
                                            {
                                                case 1:
                                                    Console.WriteLine("Add Bill Information!!!");
                                                    bill.AddBillInformation();
                                                    Console.WriteLine("Add success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Update bill!!!");
                                                    bill.UpdateBillInformation();
                                                    Console.WriteLine("Update success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 3:
                                                    Console.WriteLine("Delete bill!!!");
                                                    bill.DeleteBillInformation();
                                                    Console.WriteLine("Delete success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 4:
                                                    Console.WriteLine("Display history!!!");
                                                    bill.DisplayBillInformation();
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 5:
                                                    hl = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid Input");
                                                    break;
                                            }
                                        }
                                        break;
                                    case 6:
                                        h = false;
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input");
                                        break;
                                }
                            }
                            break;
                        case 5:
                            return;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;


                    }




                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}