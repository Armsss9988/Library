namespace Library
{
    internal class Staff : Person
    {

        private string? _role;
        public string? Role { get { return _role; } set { _role = value; } }

        public void CheckRole(string role)
        {
            if (role.ToLower() == "book manager" || role.ToLower() == "library manager")
            {
                _role = role;
                Console.WriteLine("Role added!!!");
            }
            else
            {
                Console.WriteLine("No role found!");
            }
        }
        public override void CreateInformation()
        {
            base.CreateInformation();
            Console.Write("Enter Staff Role('Book Manager', 'Library Manager'): ");
            CheckRole(Console.ReadLine());
        }
        public override void UpdateInformation()
        {
            base.UpdateInformation();
            Console.WriteLine("Update role: ");
            CheckRole(Console.ReadLine());

        }
        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Role: " + Role);
        }
    }
}
