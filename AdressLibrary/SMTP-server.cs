using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressLibrary
{
   public class SMTP_server
    {
        private  string smtp { get; set; }
        public SMTP_server(string server)
        {
            smtp = server;
            
        }

        public string DataBase()
        {
            return smtp;
        }
    }
}
