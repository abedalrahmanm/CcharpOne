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
<<<<<<< HEAD
        public void sscfunction()
        {
             this.ssc = Salary * Convert.ToDecimal( 0.075) ;
           
=======

        public decimal sscfunction()
        {
             ssc = Salary * Convert.ToDecimal( 0.075) ;
            return ssc;
>>>>>>> a8b55abe46e08f46b06aec05e54d58003cf62e99
        }
    }
}
