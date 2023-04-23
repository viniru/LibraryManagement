using LibraryManagement.model;

namespace LibraryManagement.service.@interface
{
    public interface IBookInventoryService
    {
        public bool addBook(Book book);

        public Book getBook(string bookId);

        public bool borrowBook(string bookId, string userId);

        public bool returnBook(string bookId, string userId);

    }


}
