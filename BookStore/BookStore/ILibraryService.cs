using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookStore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILibraryService
    {
        [OperationContract]
        List<BookInfo> getListOfBorrowedItems();

        [OperationContract]
        List<BookInfo> getBorrowedBooks(int userID);

        [OperationContract]
        Book getBook(int bookID);

        [OperationContract]
        Boolean borrowBook(int bookID);

       
    }

   
}
