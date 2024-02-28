using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "12345";
            int userTryInput = 3;
            string userInput;

            while (userTryInput-- > 0)
            {
                Console.WriteLine($"введите пароль: ");
                userInput = Console.ReadLine();
                
                if (password == userInput)
                {
                    Console.WriteLine("тайное сообщение");
                    break;
                }
                else
                {
                    Console.WriteLine($"пароль не верный. у вас осталось {userTryInput} попытки");
                }
            }
        }
    }
}
