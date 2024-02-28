using PhoneCrude.Models;

namespace PhoneCrude.Services
{
    internal class PhoneBookService
    {
        public PhoneBook[] PhoneBooks { get; set; } = new PhoneBook[10];

       private int id = 1;
        public void ReadAllPhoneBook()
        {
            for (int iteration = 0; iteration < 10; iteration++)
            {
                if (PhoneBooks[iteration] is not null)
                {
                    Console.WriteLine($"{PhoneBooks[iteration].Id}- {PhoneBooks[iteration].Name} {PhoneBooks[iteration].PhoneNumber}");
                }
            }
        }
        public void AddPhoneBook(PhoneBook phoneBook)
        {
            phoneBook.Id = id++;
            for(int iteration = 0; iteration < 10; iteration++)
            {
                if (PhoneBooks[iteration] is null)
                {
                    PhoneBooks[iteration] = phoneBook;
                    break;
                }
            }
        }

        public void DeletePhoneBookById(int id)
        {
            for (int i = 0; i < PhoneBooks.Length; i++)
            {
                if (PhoneBooks[i] != null && PhoneBooks[i].Id == id)
                {
                    PhoneBooks[i] = null;
                    Console.WriteLine($"PhoneBook with ID {id} deleted successfully.");
                    return; 
                }
            }
            Console.WriteLine($"PhoneBook with ID {id} not found.");
        }

        public void Update(int id, string name, string phoneNumber)
        {
            for(int iteration = 0; iteration < PhoneBooks.Length; iteration++)
            {
                if (PhoneBooks[iteration] is not null && PhoneBooks[iteration].Id == id)
                {
                    PhoneBooks[iteration].Name = name;
                    PhoneBooks[iteration].PhoneNumber = phoneNumber;
                    Console.WriteLine($"PhoneBook with ID {id} updated successfully.");
                    return;
                }
            }
            Console.WriteLine($"PhoneBook with ID {id} not found.");
        }

        public void DisplayById(int id)
        {
            for( int iteration = 0;iteration < PhoneBooks.Length; iteration++)
            {
                if (PhoneBooks[iteration] is not null && PhoneBooks[iteration].Id == id)
                {
                    Console.WriteLine($"{PhoneBooks[iteration].Id}- {PhoneBooks[iteration].Name} {PhoneBooks[iteration].PhoneNumber}");
                    return;
                }
            }
            Console.WriteLine($"PhoneBook with ID {id} not found.");

        }
    }


}
