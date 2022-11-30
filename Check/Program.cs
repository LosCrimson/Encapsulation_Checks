using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CheckService checkService = new CheckService();

            while(true) 
            {
                checkService.CreateCheck();
            }
        }
    }
}
