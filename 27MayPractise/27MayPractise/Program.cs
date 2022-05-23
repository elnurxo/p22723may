using System;

namespace _27MayPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello P227 everyone!");

            #region TASK 1 - Verilmis tesxt-in icinde reqem olub olmadigini tapan program.

            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string text = Console.ReadLine();
            bool check = false;
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                count++;
                for (int j = 0; j < digits.Length; j++)
                {
                    if (text[i] == digits[j])
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                    break;
            }
            if (check)
                Console.WriteLine("textin icinde reqem var");
            else
                Console.WriteLine("textde reqem yoxdur");

            Console.WriteLine(count);
            #endregion



            #region Students listi var, soyadi aliyev olan telebelerin sayini qaytarsin.

            string[] students = { "aliyev", "khalilov", "mammadov", "akbarli" };
            int counter = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == "aliyev")
                {
                    counter++;
                }
            }

            Console.WriteLine("Soyadi aliyev olan telebelerin sayi: " + counter);

            #endregion


            #region Sifre admin123-dur. Eger sifre yalnisdirsa try again desin ve yeniden teleb etsin sifreni,duzdurse welcome yazsin.


            Console.Write("Enter the password: ");
            string password= Console.ReadLine();
            do
            {
                if (password!="admin123")
                {
                    Console.Write("Try Again: ");
                    password = Console.ReadLine();
                }
                
            } while (password!="admin123");

            Console.WriteLine("Welcome  :)");
            #endregion
        }
    }
}
