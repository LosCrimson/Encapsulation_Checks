using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    public struct Check
    {

        private string receiver;
        private string sender;
        private double total;
        private string checkId;

        public string Receiver
        { 
           get { return receiver; }
           set { receiver = value; }
        }
        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        public double Total
        { 
            get { return total; }
            set 
            {
                if (value < 100){total = value;}else {value = 100;}
            }
        }

        public string CheckId
        {
            get { return checkId; }
            set 
            { 
                DateTime dateTime = new DateTime(int.Parse(value), int.Parse(value), int.Parse(value));
                checkId = "NR_" + dateTime.ToString("yyyy-MM-dd") + "_01"; 
            }
        }

        public Check(string receiver, string sender, double total)
        {
            this.receiver = receiver;
            this.sender = sender;
            this.total = total;
            this.checkId = "NR_" + DateTime.Now.ToString("yyyy-MM-dd") + "_01";
        }
        
        //public string CheckId(int number, DateTime yearMonthDay)
        //{
        //    string sum = number.ToString() + yearMonthDay.ToString() + "01";
        //    return sum;
        //}

    }
}
