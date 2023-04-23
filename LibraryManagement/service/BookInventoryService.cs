using LibraryManagement.model;
using LibraryManagement.service.@interface;

namespace LibraryManagement.service
{
    public class BookInventoryService : IBookInventoryService
    {
        private Library library;

        public BookInventoryService(Library library) {
            this.library = library;
        }

        bool IBookInventoryService.addBook(Book book)
        {
            library.bookInventory.addBook(book);
            return true;
        }

        bool IBookInventoryService.borrowBook(string bookId, string userId)
        {
            library.borrow(bookId, userId);
            return true;
        }

        Book IBookInventoryService.getBook(String bookId)
        {
            return library.bookInventory.getBook(bookId);
        }

        bool IBookInventoryService.returnBook(string bookId, string userId)
        {
            return library.returnBook(bookId, userId);
        }
    }
}

/*
 * Library
 * register user
 * add book
 * get book
 * borrow book
 * return book
 */