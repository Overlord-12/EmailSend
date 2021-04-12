using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressLibrary
{
    public class MailAdr
    {
        private static string Name { get; set; }

        private static string Adress { get; set; }


        public MailAdr(string name, string adress)
        {
            Name = name;
            Adress = adress;

        }
        public string GetAdress()
        {
            return Adress;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
