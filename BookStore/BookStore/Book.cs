using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookStore
{
    [DataContract]
    public class Book
    {
        [DataMember]
        private int bookID;
        [DataMember]
        private DateTime borrowDate;
        [DataMember]
        private DateTime returnDate;
        [DataMember]
        private String title;
        [DataMember]
        private Status status;

        private static int bookIDGenerator = 1;
        public Book()
        {

        }

        public Book(String title)
        {
            this.bookID = bookIDGenerator++;
            this.title = title;

            this.status = new Status(false);
        }

        public Book(DateTime borrowDate, DateTime returnDate, String title, Status status)
        {
            this.bookID = bookIDGenerator++;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
            this.title = title;
            this.status = status;
        }

       
        public int BookID
        {
            get
            {
                return bookID;
            }

            set
            {
                bookID = value;
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
       
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }
        
        public Status Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }


    }
}
