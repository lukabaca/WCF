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
            new Book(new DateTime(2018,5,1,8,30,52), new DateTime(2018,5,2,8,30,52), "Pan Tadeusz", new Status(1, true)),
            new Book(new DateTime(2018,1,1,8,30,52), new DateTime(2018,1,12,9,30,52), "Lalka", new Status(2, true)),
            new Book("Dziady"),


        };

        private static List<int> userIdList = new List<int>()
        {1, 2};

     
        Status ILibraryService.borrowBook(int bookID)
        {
            foreach (Book book in bookList)
            {
                if (book.BookID == bookID)
                {
                   
                    return book.Status;
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
        List<Book> ILibraryService.getBorrowedBooks(int userID)
        {
            if(!isUserInLibrary(userID))
            {
                throw new UserNotFoundException();
            }
            List<Book> userBorrowedBookList = new List<Book>();

            foreach(Book book in bookList)
            {
                if (book.Status.UserID == userID)
                {
                    userBorrowedBookList.Add(book);
                }
            }

            return userBorrowedBookList;

        }

        List<Book> ILibraryService.getListOfBorrowedItems()
        {
            List<Book> borrowedBookList = new List<Book>();

            foreach(Book book in bookList)
            {
                if(book.Status.Borrowed)
                {
                    borrowedBookList.Add(book);
                }
            }

            return borrowedBookList;
        }


    }
}
