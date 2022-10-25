namespace Library
{
    internal class Person
    {
        private int _id;
        private string _name;
        private string _email;
        private string _phoneNumber;

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }

        public virtual void CreateInformation()
        {
            Console.WriteLine("Information: ");
            Console.Write("Enter Name:");
            Name = Console.ReadLine();
            Console.Write("Enter Email:");
            Email = Console.ReadLine();
            Console.Write("Enter Phone Number:");
            PhoneNumber = Console.ReadLine();
        }
        public virtual void UpdateInformation()
        {
            Console.WriteLine("Updating (Enter to skip update): ");
            Console.WriteLine("Update name: ");
            string name = Console.ReadLine();
            if (name != null && name.Length > 0)
            {
                _name = name;
            }
            Console.WriteLine("Update author: ");
            string email = Console.ReadLine();
            if (email != null && email.Length > 0)
            {
                _email = email;
            }
            Console.WriteLine("Update Phone Number:");
            string phoneNumber = Console.ReadLine();
            if (phoneNumber != null && phoneNumber.Length > 0)
            {
                _phoneNumber = phoneNumber;
            }
        }
        public virtual void DisplayInformation()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone Number: " + PhoneNumber);
        }
    }
}
