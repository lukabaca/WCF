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
        private String title;

        [DataMember]
        private Boolean borrowed;

        private static int bookIDGenerator = 1;
        public Book()
        {

        }

        public Book(String title)
        {
            this.bookID = bookIDGenerator++;
            this.title = title;
            this.borrowed = false;
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

        public Boolean Borrowed
        {
            get
            {
                return borrowed;
            }

            set
            {
                borrowed = value;
            }
        }

    }
}
