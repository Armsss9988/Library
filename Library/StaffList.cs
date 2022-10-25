namespace Library
{
    internal class StaffList : IManagement
    {
        List<Staff> staffs = new List<Staff>();

        public List<Staff> Staffs()
        {
            return staffs;
        }
        public void Input()
        {
            Console.Write("Enter number of staff:");
            try
            {
                int N = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    Staff staff = new Staff();
                    staff.ID = IdentityID();
                    staff.CreateInformation();
                    staffs.Add(staff);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public Staff FindByID(int id)
        {
            Staff result = null;
            foreach (Staff staff in staffs)
            {
                if (staff.ID == id)
                {
                    result = staff;
                }
            }
            return result;
        }

        public void Update()
        {
            Console.Write("Enter Updating staff's ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Staff staff = FindByID(ID);
            if (staff != null)
            {
                staff.UpdateInformation();
            }
            else
            {
                Console.WriteLine("No ID found!!!");
            }
        }

        public void Delete()
        {
            Console.Write("Enter deleting Staff's ID");
            int ID = Convert.ToInt32(Console.ReadLine());
            Staff staff = FindByID(ID);
            if (staff != null)
            {
                staffs.Remove(staff);
            }
        }

        public void Display()
        {
            foreach (Staff staff in staffs)
            {
                staff.DisplayInformation();
            }
        }

        public List<Staff> GetStaffs()
        {
            return staffs;
        }

        public int IdentityID()
        {
            int max = 0;
            foreach (Staff staff in staffs)
            {
                if (staff.ID >= max)
                {
                    max = staff.ID + 1;
                }
            }
            return max;
        }
    }


}
