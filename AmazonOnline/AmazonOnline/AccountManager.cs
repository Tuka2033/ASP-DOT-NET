using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnline
{
    class AccountManager
    {
        public static Boolean Login(string uid, string pwd)
        {
            return (uid == "Tuka" && pwd == "Tuka");    
        }
        public static void Register(int id,string cName,String lName,string email,int contactNumber)
        {
            Customer customer = new Customer(id, cName, lName, email, contactNumber);
        }
        public static void ChangePassword(string pwd)
        {

        }
    }
}
