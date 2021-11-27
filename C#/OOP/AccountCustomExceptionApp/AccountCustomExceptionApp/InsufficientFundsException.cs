using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp
{
    class InsufficientFundsException : Exception
    {
        private string _message;
        public InsufficientFundsException()
        {
            //_message = $"No funds in acc {acc.GetAccountNumber()}";
        }

        public InsufficientFundsException(Account acc)
        {
            _message = $"a/c no : {acc.GetAccountNumber()} have insufficient funds to withdraw \n" +
                $"you cant withdraw more than {acc.GetBalance() - 500}\n" +
                $"you should have minimum balance of 500\n" +
                $"transaction Declined";
        }

        public override string Message
        {
            get
            {
                return _message;
            }
            
        }


    }
}
