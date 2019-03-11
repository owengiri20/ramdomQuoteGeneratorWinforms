using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsWF
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public string height;

        public List<String> Friends = new List<string>();
        public Dictionary<string, string> contact = new Dictionary<string, string>();
    }
   
}
