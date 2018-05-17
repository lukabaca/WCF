using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using Client.ServiceReference;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            
                LibraryServiceClient client = new LibraryServiceClient();
                
                Console.WriteLine(client.getBook(1).title);
                
               
            
                Console.WriteLine("Borrowed books");
                foreach(BookInfo bookInfo in client.getListOfBorrowedItems())
                {
                    Console.WriteLine("Book: " + bookInfo.book.title + " Borrowed Date: " + bookInfo.borrowDate + " Return Date: " + bookInfo.returnDate + " by User: " + bookInfo.book.status.userID);
                }
                

            
                Console.WriteLine("Wypozyczone ksiazki przez userId: 1");
                foreach(BookInfo bookInfo in client.getBorrowedBooks(1))
                {
                    Console.WriteLine("Book: " + bookInfo.book.title + " Borrowed Date: " + bookInfo.borrowDate + " Return Date: " + bookInfo.returnDate + " by User: " + bookInfo.book.status.userID);
                }


                if(client.borrowBook(3, 1))
                {
                    Console.WriteLine("Borrowing book was succesful!");
                }
                else
                {
                    Console.WriteLine("Book is now not available");
                }

                Console.ReadLine();
           

                client.Close();
        }
    }
}
