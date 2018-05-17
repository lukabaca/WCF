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
                Console.WriteLine(client.borrowBook(1).userID);

                Console.WriteLine(client.getBook(1).title);

                Console.WriteLine(client.getBook(-2).title);

                Console.ReadLine();
           

            client.Close();
        }
    }
}
