﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookInfo", Namespace="http://schemas.datacontract.org/2004/07/BookStore")]
    [System.SerializableAttribute()]
    public partial class BookInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServiceReference.Book bookField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime borrowDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime returnDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServiceReference.Book book {
            get {
                return this.bookField;
            }
            set {
                if ((object.ReferenceEquals(this.bookField, value) != true)) {
                    this.bookField = value;
                    this.RaisePropertyChanged("book");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime borrowDate {
            get {
                return this.borrowDateField;
            }
            set {
                if ((this.borrowDateField.Equals(value) != true)) {
                    this.borrowDateField = value;
                    this.RaisePropertyChanged("borrowDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime returnDate {
            get {
                return this.returnDateField;
            }
            set {
                if ((this.returnDateField.Equals(value) != true)) {
                    this.returnDateField = value;
                    this.RaisePropertyChanged("returnDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/BookStore")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int bookIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServiceReference.Status statusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bookID {
            get {
                return this.bookIDField;
            }
            set {
                if ((this.bookIDField.Equals(value) != true)) {
                    this.bookIDField = value;
                    this.RaisePropertyChanged("bookID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServiceReference.Status status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Status", Namespace="http://schemas.datacontract.org/2004/07/BookStore")]
    [System.SerializableAttribute()]
    public partial class Status : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool borrowedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int userIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool borrowed {
            get {
                return this.borrowedField;
            }
            set {
                if ((this.borrowedField.Equals(value) != true)) {
                    this.borrowedField = value;
                    this.RaisePropertyChanged("borrowed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int userID {
            get {
                return this.userIDField;
            }
            set {
                if ((this.userIDField.Equals(value) != true)) {
                    this.userIDField = value;
                    this.RaisePropertyChanged("userID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ILibraryService")]
    public interface ILibraryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getListOfBorrowedItems", ReplyAction="http://tempuri.org/ILibraryService/getListOfBorrowedItemsResponse")]
        Client.ServiceReference.BookInfo[] getListOfBorrowedItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getListOfBorrowedItems", ReplyAction="http://tempuri.org/ILibraryService/getListOfBorrowedItemsResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference.BookInfo[]> getListOfBorrowedItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getBorrowedBooks", ReplyAction="http://tempuri.org/ILibraryService/getBorrowedBooksResponse")]
        Client.ServiceReference.BookInfo[] getBorrowedBooks(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getBorrowedBooks", ReplyAction="http://tempuri.org/ILibraryService/getBorrowedBooksResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference.BookInfo[]> getBorrowedBooksAsync(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getBook", ReplyAction="http://tempuri.org/ILibraryService/getBookResponse")]
        Client.ServiceReference.Book getBook(int bookID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getBook", ReplyAction="http://tempuri.org/ILibraryService/getBookResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference.Book> getBookAsync(int bookID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/borrowBook", ReplyAction="http://tempuri.org/ILibraryService/borrowBookResponse")]
        bool borrowBook(int bookID, int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/borrowBook", ReplyAction="http://tempuri.org/ILibraryService/borrowBookResponse")]
        System.Threading.Tasks.Task<bool> borrowBookAsync(int bookID, int userID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibraryServiceChannel : Client.ServiceReference.ILibraryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibraryServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference.ILibraryService>, Client.ServiceReference.ILibraryService {
        
        public LibraryServiceClient() {
        }
        
        public LibraryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.ServiceReference.BookInfo[] getListOfBorrowedItems() {
            return base.Channel.getListOfBorrowedItems();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference.BookInfo[]> getListOfBorrowedItemsAsync() {
            return base.Channel.getListOfBorrowedItemsAsync();
        }
        
        public Client.ServiceReference.BookInfo[] getBorrowedBooks(int userID) {
            return base.Channel.getBorrowedBooks(userID);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference.BookInfo[]> getBorrowedBooksAsync(int userID) {
            return base.Channel.getBorrowedBooksAsync(userID);
        }
        
        public Client.ServiceReference.Book getBook(int bookID) {
            return base.Channel.getBook(bookID);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference.Book> getBookAsync(int bookID) {
            return base.Channel.getBookAsync(bookID);
        }
        
        public bool borrowBook(int bookID, int userID) {
            return base.Channel.borrowBook(bookID, userID);
        }
        
        public System.Threading.Tasks.Task<bool> borrowBookAsync(int bookID, int userID) {
            return base.Channel.borrowBookAsync(bookID, userID);
        }
    }
}
