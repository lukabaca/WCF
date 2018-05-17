using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BookStore
{
    [DataContract]
    public class BookInfo
    {
        [DataMember]
        Book book;

        [DataMember]
        private DateTime borrowDate;

        [DataMember]
        private DateTime returnDate;


        public BookInfo()
        {

        }

        public BookInfo(Book book, DateTime borrowDate, DateTime returnDate)
        {
            this.book = book;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
            
        }

        public Book Book
        {
            get
            {
                return book;
            }

            set
            {
                book = value;
            }
        }

        public DateTime BorrowDate
        {
            get
            {
                return borrowDate;
            }

            set
            {
                borrowDate = value;
            }
        }

        public DateTime ReturnDate
        {
            get
            {
                return returnDate;
            }

            set
            {
                returnDate = value;
            }
        }

       

    }
}
