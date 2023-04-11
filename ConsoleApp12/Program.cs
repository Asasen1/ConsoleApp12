using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string userName = null;
            bool esc = false;
            while (!esc)
            {
                Console.WriteLine("Menu: \nSetName \nChangeConsoleColor \nSetPassword \nWriteName \nEsc");
                string userInput = Console.ReadLine();
                Console.Clear();
                switch (userInput)
                {
                    case "SetName":
                        Console.WriteLine("Enter the name:");
                        userName = Console.ReadLine();
                        Console.WriteLine($"Your name update: {userName}");
                        break;
                    case "ChangeConsoleColor":
                        Console.WriteLine("Choose the color:");
                        string userColor = Console.ReadLine();
                        Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), userColor, true);
                        Console.Clear();
                        Console.WriteLine($"Цвет консоли изменен на {userColor}");
                        break;
                    case "SetPassword":
                        Console.WriteLine("Enter new password, integer:");
                        int userPassword = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"New password: {userPassword}");
                        break;
                    case "WriteName":
                        if (userName != null)
                            Console.WriteLine($"Your name: {userName}");
                        else
                            Console.WriteLine("Name not found");
                        break;
                    case "Esc":
                        esc = true;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}
