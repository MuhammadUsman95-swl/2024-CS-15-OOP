using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credentials
{
    internal class Program
    {
       const int Maxcount = 10;
       static string[] username = new string[Maxcount];
       static string[] password = new string[Maxcount];
       static string[] role = new string[Maxcount];
       static int count = 0;
        static void Main(string[] args)
        {
            string Username = "", Password = "", Role = "";
            int option = 0;
            while (option != 3)
            {
                option = Menu();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter username....");
                        Username = Console.ReadLine();
                        Console.WriteLine("Enter Password.....");
                        Password = Console.ReadLine();
                        Console.WriteLine("Enter role....");
                        Role = Console.ReadLine();
                        bool checkCredential = signIn(Username, Password, Role);
                        if(checkCredential)
                        {
                            Console.WriteLine("Successfully Signed In......");
                        }
                        else 
                        {
                            Console.WriteLine("Fail to signed in.Check credentials....");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter your username...");
                        Username = Console.ReadLine();
                        Console.WriteLine("Enter your password...");
                        Password = Console.ReadLine();
                        Console.WriteLine("Enter your role....");
                        Role = Console.ReadLine();
                        string result = signUp(Username, Password, Role);
                        Console.WriteLine(result);
                        break;
                    case 3:
                        Console.WriteLine("Press any key to exit......");
                        break;
                }
                Console.WriteLine("Press any key.............");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
        static string signUp(string Username, string Password, string Role)
        {
            bool isExist = false;
            for(int i = 0; i < 10; i++)
            {
                if(username[i] ==  Username && Password == password[i] && Role == role[i])
                    {
                        isExist = true;
                    }
            }
            if (isExist)
            {
                return "The account already exist.";
            }
            else 
            {
                username[count] = Username;
                password[count] = Password;
                role[count] = Role;
                count++;
                return "The account is successfully created.";
            }
        }
        static bool signIn(string Username, string Password, string Role)
        {
            bool isPresent = false;
            for (int i = 0; i < 10; i++)
            {
                if (username[i] == Username && Password == password[i] && Role == role[i])
                {
                    isPresent = true;
                }
            }
            return isPresent;
        }
        static int Menu()
        {
            int option = 0;
            Console.WriteLine(" ======= LOGIN PAGE =====");
            Console.WriteLine("|      1 >> Sign In      |");
            Console.WriteLine("|      2 >> Sign Up      |");
            Console.WriteLine("|      3 >> Exit         |");
            Console.WriteLine("|________________________|");
            Console.WriteLine();
            Console.WriteLine("Press a valid option....");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
