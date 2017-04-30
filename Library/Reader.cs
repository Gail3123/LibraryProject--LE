using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Reader
    {
        #region Variables
        private static int lastReaderNumber = 0;
        #endregion 
       
        #region Properties
        public string EmailAddress { get; set; }
        public int ReaderNumber { get; private set; }
        public int ReaderID { get; set; }
        public int BookAmount { get;private set; }

        #endregion

        #region Method
        public int Borrow(int amount)
        {
            BookAmount += amount;
            return BookAmount;
        }
        public int Return(int amount)
        {
            BookAmount -= amount;
            return BookAmount;
        }
        #endregion

        #region Constructors
        public Reader()
        {
            ReaderNumber = ++lastReaderNumber;
        }

        public Reader(String emailAddress) : this()
        {
            EmailAddress = emailAddress;
        }
        public Reader (string emailAddress, int readerID) : this(emailAddress)
        {
            ReaderID  = readerID ;
        }
        #endregion
    }
}
