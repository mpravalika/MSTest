using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CustomException : Exception
    {
        public CustomException(string s) : base(s)
        {

        }
    }
    public class BLAge
    {
        public int Age(DateTime Dob)
        {
            int age = (int)(DateTime.Now.Subtract(Dob).TotalDays / 365);
            if (age < 18 )
            {
                throw new CustomException("age should be >18");
            }
            else if(age>60)
            {
                throw new CustomException("age should be <60");
            }
            else
                return age;
        }
    }
}
