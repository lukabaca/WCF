using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    [DataContract]
    public class Status
    {
        [DataMember]
        private int userID;
        [DataMember]
        private Boolean borrowed;

        public Status()
        {
            this.borrowed = false;
            this.userID = -1;
        }

        public Status(int userID, Boolean borrowed)
        {
            this.userID = userID;
            this.borrowed = borrowed;
        }

        public Status(Boolean borrowed)
        {
            this.borrowed = borrowed;
        }

        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public bool Borrowed
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
