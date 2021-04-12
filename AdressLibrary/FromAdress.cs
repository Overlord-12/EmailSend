using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressLibrary
{
    public class FromAdress
    {
        private static string Adress { get; set; }


        public FromAdress(string adress)
        {
            Adress = adress;
        }
        public static string GetAdress()
        {
            return Adress;
        }
    }
}
