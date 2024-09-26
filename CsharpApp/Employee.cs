using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpApp
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime HiringDate { get; set; }
        public decimal Salary { get; set; }
        public decimal ssc { get; set; }

        public decimal sscfunction()
        {
             ssc = Salary * Convert.ToDecimal( 0.075) ;
            return ssc;
        }
    }
}
