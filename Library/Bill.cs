using System.Globalization;

namespace Library
{
    internal class Bill
    {
        private int _id;
        private List<BillInformation> _billInformation = new();
        private DateTime? _startDate;
        private DateTime? _endDate;
        public List<BillInformation> GetBillInformation()
        {
            return _billInformation;
        }
        public int ID { get { return _id; } set { _id = value; } }

        public DateTime? StartDate { get { return _startDate; } set { _startDate = value; } }
        public DateTime? EndDate { get { return _endDate; } set { _endDate = value; } }
        CultureInfo provider = CultureInfo.InvariantCulture;
        string format = "dd/mm/yyyy";



        public void CreateBill()
        {
            Console.Write("Enter Start Day (dd/mm/yyyy): ");
            string start = Console.ReadLine();
            _startDate = DateTime.ParseExact(start, format, provider);
            Console.Write("Enter End Day (dd/mm/yyyy): ");
            string end = Console.ReadLine();
            _endDate = DateTime.ParseExact(end, format, provider);
        }

        public void UpdateBill()
        {
            Console.WriteLine("Updating (Enter to skip update): ");
            Console.WriteLine("Update start date: ");
            string start = Console.ReadLine();
            if (start != null && start.Length > 0)
            {
                StartDate = DateTime.ParseExact(start, format, provider);
            }
            Console.WriteLine("Update end date:");
            string end = Console.ReadLine();
            if (end != null && end.Length > 0)
            {
                EndDate = DateTime.ParseExact(end, format, provider);
            }

        }
        // BIll information function:
        public BillInformation FindByID(int billInforID)
        {
            BillInformation result = null;
            foreach (BillInformation billInfor in _billInformation)
            {
                if (billInfor.ID == billInforID)
                {
                    result = billInfor;
                }
            }
            return result;
        }
        public void Input()
        {
            BillInformation billInfor = new();
            billInfor.CreateBillInformation();
            _billInformation.Add(billInfor);
        }
        public void Update()
        {
            Console.Write("Enter ID: ");
            int billInforID = Convert.ToInt32(Console.ReadLine());
            BillInformation updateBillInfor = FindByID(billInforID);
            updateBillInfor.UpdateBillInformation();
        }
        public void Delete()
        {
            Console.Write("Enter ID: ");
            int billInforID = Convert.ToInt32(Console.ReadLine());
            BillInformation deleteBillInfor = FindByID(billInforID);
            _billInformation.Remove(deleteBillInfor);
        }
        public void Display()
        {
            foreach (BillInformation billInfor in _billInformation)
            {
                billInfor.DisplayBillInformation();
            }
        }
    }
}
