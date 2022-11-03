namespace Library
{
    internal class Guess : Person
    {
        public Guess()
        {
        }

        List<Bill> history = new List<Bill>();
        string format = "dd/mm/yyyy";

        public int IdentityID()
        {
            int max = 0;
            foreach (Bill bill in history)
            {
                if (bill.ID >= max)
                {
                    max = bill.ID + 1;
                }
            }
            return max;
        }

        public void Input()
        {
            Console.Write("Enter number of data: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type borrowing's Information!!");
            for (int i = 0; i < N; i++)
            {
                Bill bill = new Bill();
                bill.ID = IdentityID();
                bill.CreateBill();
                history.Add(bill);
            }

        }
        public void Display()
        {

            Console.WriteLine("{0, 20}   ||{1, 10}   ||{2, 15}   ||{3, 15}  ||", "ID", "Guess ID", "StartDay", "EndDate");
            foreach (Bill bill in history)
            {
                Console.WriteLine("{0, 20}   ||{1, 10}   ||{2, 15}   ||{3, 15}  ||"
                    , bill.ID, ID, bill.StartDate?.ToString(format), bill.EndDate?.ToString(format));
                bill.Display();
            }
        }
        public Bill FindByID(int id)
        {
            Bill result = null;
            foreach (Bill bill in history)
            {
                if (bill.ID == id)
                {
                    result = bill;
                }
            }
            return result;
        }
        public void Update()
        {

            Console.Write("Enter ID to update : ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Bill bill = FindByID(ID);
            if (bill != null)
            {
                bill.UpdateBill();
            }
        }
        public void Delete()
        {
            Console.Write("Enter ID of deleting bill: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Bill bill = FindByID(d);
            if (bill != null)
            {
                history.Remove(bill);
            }
        }

    }

}
