using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    public class CheckService
    {

        public void CreateCheck()
        {
            PrintChecksList();
            Console.WriteLine("Who is the receiver: ");
            string receiver = Console.ReadLine();
            Console.WriteLine("Who is the sender: ");
            string sender = Console.ReadLine();
            Console.WriteLine("What is the total: ");
            double total = Convert.ToDouble(Console.ReadLine());
            Check check = new Check(receiver, sender, total);
            CheckRepository.checks.Add(check);
        }

        public void PrintChecksList()
        {
            foreach (var check in CheckRepository.checks)
            {
                Console.WriteLine("Receiver: " + check.Receiver + " Sender: " + check.Sender + " Total: " + check.Total + " Id: " + check.CheckId);
            }
        }

    }
}
