using System;

namespace AddressBookManagement
{
    class Program
    {
        public static List<CreateContacts> contactList = new List<CreateContacts>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBookManagmentSystem");
            Console.WriteLine("Do you want to add new contact press 1 if not press 2");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num == 1)
            {
                CreateContacts create = new CreateContacts();

                Console.WriteLine("Enter First Name: ");
                create.firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name: ");
                create.lastName = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                create.address = Console.ReadLine();
                Console.WriteLine("Enter City: ");
                create.city = Console.ReadLine();
                Console.WriteLine("Enter State: ");
                create.state = Console.ReadLine();
                Console.WriteLine("Enter Phone: ");
                create.phone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Email: ");
                create.email = Console.ReadLine();
                Console.WriteLine("Enter Zipcode: ");
                create.zipcode = Convert.ToInt32(Console.ReadLine());

                contactList.Add(create);
                Console.WriteLine("Do you want to Add another Contact then press 1 or press 2 for exit ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Total number of contact in address book:" + contactList.Count);

            foreach (CreateContacts contact in contactList)
            {
                Console.WriteLine(contact.firstName);
            }
        }
    }
}
