using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    using Artifacts;
    using TransactionSystem;
    public class UsersLibraryAccount : ITransactionEntity
    {
        private List<Book> borrowedBooks = new List<Book>(); 

        public long Id { get; set; }

        public string Name { get; set; }

        public bool Deposit(string id, decimal value)
        {
            this.borrowedBooks.Remove(new Book());

            return true;
        }

        public bool Withdraw(string id, decimal value)
        {
            this.borrowedBooks.Add(new Book());

            return true;
        }
    }
       

}
