using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Utils
{
    public static class Helpers
    {
        public static Dictionary<string, string> errorMessages = 
            new Dictionary<string, string>()
        {
            { "IncorrectPassword", "Password incorrect" }
        };
    }
}
