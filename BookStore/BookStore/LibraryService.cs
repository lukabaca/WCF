using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookStore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class LibraryService : ILibraryService
    {
        private static List<Book> bookList = new List<Book>()
        {
            new Book("Pan Tadeusz"), new Book("Dziady"), new Book("Lalka")


        };

        public LibraryService()
        {
            bookList.ElementAt(0).Borrowed = true;
            bookList.ElementAt(1).Borrowed = true;


            borrowedBookList.Add(new BookInfo(bookList.ElementAt(0), new DateTime(2018, 5, 1, 8, 30, 52), new DateTime(2018, 5, 2, 8, 30, 52), 1));

            borrowedBookList.Add(new BookInfo(bookList.ElementAt(1), new DateTime(2018, 1, 1, 8, 30, 52), new DateTime(2018, 1, 12, 9, 30, 52), 2));
        }

        private static List<BookInfo> borrowedBookList = new List<BookInfo>()
        {
            
        };
           

        private static List<int> userIdList = new List<int>()
        {1, 2};

     
        Boolean ILibraryService.borrowBook(int bookID)
        {
            foreach (Book book in bookList)
            {
                if (book.BookID == bookID)
                {
                    
                    return book.Borrowed;
                }
            }
            throw new BookNotFoundException();
        }

        Book ILibraryService.getBook(int bookID)
        {
            foreach(Book book in bookList)
            {
                if(book.BookID == bookID)
                {
                    return book;
                }
            }
            throw new BookNotFoundException("Book with this ID was not found in library");
        }

        private Boolean isUserInLibrary(int userID)
        {
            foreach(int userId in userIdList)
            {
                if(userId == userID)
                {
                    return true;
                }
            }
            return false;
        }
        List<BookInfo> ILibraryService.getBorrowedBooks(int userID)
        {
            if(!isUserInLibrary(userID))
            {
                throw new UserNotFoundException();
            }
            List<BookInfo> userBorrowedBookList = new List<BookInfo>();

            foreach(BookInfo book in borrowedBookList)
            {
                if (book.UserID == userID)
                {
                    userBorrowedBookList.Add(book);
                }
            }

            return userBorrowedBookList;

        }

        List<BookInfo> ILibraryService.getListOfBorrowedItems()
        {
            return borrowedBookList;
        }


    }
}
