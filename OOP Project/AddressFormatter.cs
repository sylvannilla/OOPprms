using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public static class AddressFormatter
    {
        public static string Format(string street, string city, string state, string postal)
        {
            return $"{street}, \n{city}, \n{state}, {postal}";
        }
    }
}