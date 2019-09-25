using System;
using System.Collections.Generic;

namespace PasswordEncryptionAuthentication
{
    public class Encryption : Formula
    {
        static void Main(string[] args)
        {
            bool valid;
            int choice;
            Dictionary<string, string> Account = new Dictionary<string, string>();
            Console.WriteLine("Please select one option:");
        AddAnotherAccount:
            Console.WriteLine("\n1 : Create an account \n2 : Authenticate a user \n3 : Exit the system");
            do
            {
                valid = int.TryParse(Console.ReadLine(), out choice);
                if (!valid || choice < 1 || choice > 3)
                {
                    Console.WriteLine("\nInvalid input");
                    valid = false;
                }
            } while (!valid);
            if (choice == 1)
            {
                Console.WriteLine("\nEnter a username");
                string username = Console.ReadLine();
                Console.WriteLine("\nEnter a password");
                string password = Console.ReadLine(),
                       encryptedPassword = EncryptInput(password);
                Account.Add(username, encryptedPassword);
                Console.WriteLine("\nWould you like to create another account?");
                goto AddAnotherAccount;
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nEnter username");
                string username = Console.ReadLine();
                Console.WriteLine("\nPlease enter a password: ");
                string password = Console.ReadLine(),
                    encryptedPassword = EncryptInput(password);
                if (Account[username] == encryptedPassword)
                {
                    Console.WriteLine("\nYou are authenticated");
                    goto AddAnotherAccount;
                }
                else
                {
                    Console.WriteLine("\nWrong credentials/User does not exist");
                    goto AddAnotherAccount;
                }
            }
            if (choice == 3)
            {
                foreach (KeyValuePair<string, string> User in Account)
                {
                    Console.WriteLine($"\nUsername = {User.Key}, Password = {User.Value}");
                }
            }
        }
    }
}
