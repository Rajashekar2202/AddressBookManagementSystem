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
            Console.WriteLine("Do you want to Edit Contact details then press 1 or pres 2 for continue: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num == 1)
            {
                Console.WriteLine("Enter First Name to Edit details: ");
                string firstName = Console.ReadLine();
                bool found = false;
                for (int i = 0; i < contactList.Count; i++)
                {

                    if (contactList[i].firstName == firstName)
                    {
                        found = true;

                        Console.WriteLine("Enter First Name: ");
                        contactList[i].firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name: ");
                        contactList[i].lastName = Console.ReadLine();
                        Console.WriteLine("Enter address: ");
                        contactList[i].address = Console.ReadLine();
                        Console.WriteLine("Enter City: ");
                        contactList[i].city = Console.ReadLine();
                        Console.WriteLine("Enter State: ");
                        contactList[i].state = Console.ReadLine();
                        Console.WriteLine("Enter Phone: ");
                        contactList[i].phone = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Email: ");
                        contactList[i].email = Console.ReadLine();
                        Console.WriteLine("Enter Zipcode: ");
                        contactList[i].zipcode = Convert.ToInt32(Console.ReadLine());

                        break;
                    }
                }
                if (!found)
                    Console.WriteLine("The Contact with given person {0} is not in address book", firstName);
                Console.WriteLine("Current Contacts in Address Book");
                foreach (CreateContacts contact in contactList)
                {
                    Console.WriteLine(contact.firstName);
                }
                Console.WriteLine("Do you want to Edit Contact press 1 to edit or press 2 to cancle.");
                num = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}



