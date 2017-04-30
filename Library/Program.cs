using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            ///var reader = new Reader("test@test.com");
            ///Console.WriteLine($"Reader Number:{reader.ReaderNumber},Reader ID:{reader.ReaderID },Email Address:{reader.EmailAddress },Book Amount:{reader.BookAmount }");


            /// var reader2 = new Reader("test2@test.com");
            ///Console.WriteLine($"Reader Number:{reader2.ReaderNumber},Reader ID:{reader2.ReaderID },Email Address:{reader2.EmailAddress},Book Amount:{reader2.BookAmount }");
            Console.WriteLine("****Welcome to my library*****");
            while (true)
            {

                Console.WriteLine("0.Exit");

                Console.WriteLine("1.Sign up");
                Console.WriteLine("2.Borrow");
                Console.WriteLine("3.Return");
                Console.WriteLine("4.Print all lists");
                Console.WriteLine("Please select a choice from the above");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for coming");
                        return;

                    case "1":
                        Console.Write("Email Address:");
                        var emailAddress = Console.ReadLine();
                        Console.Write("ReaderID:");
                        var readerID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Book Amount:");
                        var amount = Convert.ToInt32(Console.ReadLine());
                        var reader = Library .CreateAccount(emailAddress, amount, readerID );
                        Console.WriteLine($"Reader Number:{reader.ReaderNumber},ReaderID:{reader.ReaderID },Email Address:{reader.EmailAddress },Book Amount:{reader.BookAmount }");
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        break;

                }

            }
        }
    }
}
