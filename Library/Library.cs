using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static class Library
    {
        public static Reader CreateAccount(string emailAddress, int  amount, int readerID)
        {
            var reader = new Reader (emailAddress, readerID);
            reader.Borrow(amount);
            return reader;

        }
    }
}
