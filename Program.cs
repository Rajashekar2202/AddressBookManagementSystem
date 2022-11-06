namespace AddressBookManagement
{
    class Program
    {
        public static List<CreateContacts> contactList = new List<CreateContacts>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBookManagmentSystem");

            CreateContacts contact1 = new CreateContacts();
            Console.WriteLine("Enter first name: ");
            contact1.firstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            contact1.lastName = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            contact1.address = Console.ReadLine();

            Console.WriteLine("Enter city: ");
            contact1.city = Console.ReadLine();

            Console.WriteLine("Enter state: ");
            contact1.state = Console.ReadLine();

            Console.WriteLine("Enter phone: ");
            contact1.phone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter email: ");
            contact1.email = Console.ReadLine();

            Console.WriteLine("Enter zipcode: ");
            contact1.zipcode = Convert.ToInt32(Console.ReadLine());


            contactList.Add(contact1);
        }
    }
}