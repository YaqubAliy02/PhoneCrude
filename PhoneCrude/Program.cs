using PhoneCrude.Models;
using PhoneCrude.Services;
using System.Diagnostics;
using System.Linq.Expressions;

namespace PhoneCrud
{
    class Program
    {
        static void Main(string[] args)
        {

            PhoneBookService phoneBookService = new PhoneBookService();
            bool process = true;
            do
                
            {
                PrintMenu();

                Console.Write("Enter your choice:");
                string userChoice = Console.ReadLine(); //Why I gave user's input with string format because if I give in int format when user enter string format like("fsdf") the program gives unhandiling exception 

                char[] chars = userChoice.ToCharArray();
                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                        PhoneBook phoneBook = new PhoneBook();
                        Console.Write("Enter name: ");
                        string nameOfItem = Console.ReadLine();
                        phoneBook.Name = nameOfItem;
                        Console.Write("Enter phoneNumber: ");
                        string phoneNumberOfItem = Console.ReadLine();
                        phoneBook.PhoneNumber = phoneNumberOfItem;
                        phoneBookService.AddPhoneBook(phoneBook);
                        break;

                    case "2":
                        Console.Clear();
                        phoneBookService.ReadAllPhoneBook();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Enter an id which you want to delete");
                        Console.Write("Enter id:");
                        string deleteWithIdStr = Console.ReadLine();
                        int deleteWithId = Convert.ToInt32(deleteWithIdStr);
                        phoneBookService.DeletePhoneBookById(deleteWithId);
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Enter an id which you want  to edit");
                        Console.Write("Enter an id:");
                        string idStr = Console.ReadLine();
                        int id = Convert.ToInt32(idStr);
                        Console.Write("Enter name:");
                        string name = Console.ReadLine();
                        Console.Write("Enter phoneNumber:");
                        string phoneNumber = Console.ReadLine();
                        phoneBookService.Update(id, name, phoneNumber);
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Enter an id which you want  to edit");
                        Console.Write("Enter an id:");
                        string userId = Console.ReadLine();
                        int  displayId = Convert.ToInt32(userId);
                        phoneBookService.DisplayById(displayId);
                        break;

                    case "0":
                        Console.Clear();
                        if (userChoice == "0")
                        {
                            process = false;
                            Console.WriteLine("Thank you for coming to our console app!!! '");
                        }
                        break;

                    default:

                        Console.WriteLine("You entered wrong input, Try again");
                        break;
                }

            }
            while (process);

        }
            public static void PrintMenu()
        {
            Console.WriteLine("1.CreatePhoneBooks");
            Console.WriteLine("2.DisplayAllPhoneBooks");
            Console.WriteLine("3.DeletePhoneBookById");
            Console.WriteLine("4.Update");
            Console.WriteLine("5.DisplayById");
            Console.WriteLine("0.Exit");
        }
     
    }
}