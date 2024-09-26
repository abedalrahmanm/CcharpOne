using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpApp
{
    public class Student
    {
        public string StudentName;
        public int mark1;
        public int mark2;
        public int mark3;
        public string GetAvgName (Student _student) 
        {
            string avgname = string.Empty;

           double avg = (mark1 + mark2 + mark3) / 3;
            if (avg < 50)
                avgname="fail";
            else if (avg >= 50 && avg < 60)
                avgname="fair";
            else if (avg >= 60 && avg < 70)
                avgname="accept";
            else if (avg >= 70 && avg < 80)
                avgname = "good";
            else if (avg >= 80 && avg < 90)
                avgname = "very good";
            else if(avg >= 90 && avg <= 100)
                avgname = "exelent";
            else
            {
                avgname = "invalid value";

            }

            avgname = StudentName +", you'r "+avgname + ", your Avarage is:" + avg;
            return avgname;
        }

        public string GetAvgName(string name, int mark1, int mark2,int mark3)
        {

            string avgname = string.Empty;

            double avg = (mark1 + mark2 + mark3) / 3;

            switch (avg)
            {
                case (< 50): avgname = "failed";
                    break;
                case (>=50 and <60):
                    avgname = "fair";
                    break;
                case (>= 60 and < 70):
                    avgname = "accept";
                    break;
                case (>= 70 and < 80):
                    avgname = "good";
                    break;
                case (>= 80 and < 90):
                    avgname = "very good";
                    break;
                case (>= 90 and < 100):
                    avgname = "exelent";
                    break;
                default:
                    avgname = "ERROR!";
                    break;
            }

            avgname = StudentName + ", you'r " + avgname + ", your Avarage is:" + avg;
            return avgname;
        }

        }
}
