namespace Library
{
    internal class GuessList : IManagement
    {
        List<Guess> _guests = new List<Guess>();


        public List<Guess> GetGuests()
        {
            return _guests;
        }
        public int IdentityID()
        {
            int max = 0;
            foreach (Guess guess in _guests)
            {
                if (guess.ID >= max)
                {
                    max = guess.ID + 1;
                }
            }
            return max;
        }

        public void Input()
        {
            Console.Write("Enter number of guess:");
            try
            {
                int N = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    Guess guess = new Guess();
                    guess.ID = IdentityID();
                    guess.CreateInformation();
                    _guests.Add(guess);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void Display()
        {
            Console.WriteLine("{0, 20}    ||{1, 20}    ||{2, 20}    ||{3, 20}    ||", "ID", "Name", "Email", "Phone Number");
            foreach (Guess guess in _guests)
            {
                Console.WriteLine("{0, 20}    ||{1, 20}    ||{2, 20}    ||{3, 20}    ||", guess.ID, guess.Name, guess.Email, guess.PhoneNumber);
            }
        }
        public Guess FindByID(int id)
        {
            Guess result = null;
            foreach (Guess guess in _guests)
            {
                if (guess.ID == id)
                {
                    result = guess;
                }
            }
            return result;
        }
        public void Update()
        {
            Console.Write("Enter Updating guess's ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Guess guess = FindByID(ID);
            if (guess != null)
            {
                guess.UpdateInformation();
            }
            else
            {
                Console.WriteLine("No ID found!!!");
            }
        }
        public void Delete()
        {
            Console.Write("Enter deleting Guess's ID");
            int ID = Convert.ToInt32(Console.ReadLine());
            Guess guess = FindByID(ID);
            if (guess != null)
            {
                _guests.Remove(guess);
            }
        }
    }
}
