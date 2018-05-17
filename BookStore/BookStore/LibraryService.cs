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
            new Book("Pan Tadeusz", new Status(1, true)), new Book("Dziady", new Status(2, true)), new Book("Lalka")


        };

      


        private static List<BookInfo> borrowedBookList = new List<BookInfo>()
        {
            new BookInfo(bookList.ElementAt(0), new DateTime(2018, 5, 1, 8, 30, 52), new DateTime(2018, 5, 2, 8, 30, 52)),

            new BookInfo(bookList.ElementAt(1), new DateTime(2018, 1, 1, 8, 30, 52), new DateTime(2018, 1, 12, 9, 30, 52))
        };
           

        private static List<int> userIdList = new List<int>()
        {1, 2};


        Boolean ILibraryService.borrowBook(int bookID, int userID)
        {
            if(!isUserInLibrary(userID))
            {
                throw new UserNotFoundException("User was not found in library");
            }

            foreach (Book book in bookList)
            {
                if (book.BookID == bookID)
                {
                    if(!book.Status.Borrowed)
                    {
                        book.Status.Borrowed = true;
                        book.Status.UserID = userID;

                        BookInfo bookInfo = new BookInfo(book, new DateTime(2001, 1, 1, 8, 30, 52), new DateTime(2001, 11, 2, 8, 30, 52));
                        borrowedBookList.Add(bookInfo);

                        return true;
                    }
                    return false;
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

            foreach(BookInfo bookInfo in borrowedBookList)
            {
                if (bookInfo.Book.Status.UserID == userID)
                {
                    userBorrowedBookList.Add(bookInfo);
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
