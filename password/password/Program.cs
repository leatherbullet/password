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

            for (int i = userTryInput; i > 0; i--)
            {
                Console.WriteLine("для доступа введите пароль.\n количество попыток:" + i);
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("секретное сообщение");
                    break;
                }
                else
                {
                    Console.WriteLine("попробуйте еще раз");
                }
            } 
        }
    }
}
