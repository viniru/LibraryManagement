using Microsoft.AspNetCore.Mvc;
using LibraryManagement.model;
using LibraryManagement.service.@interface;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly IBookInventoryService bookInventoryService;
        private readonly IUserService userService;

        public LibraryController(IBookInventoryService bookInventoryService, IUserService userService) {
            this.bookInventoryService = bookInventoryService;
            this.userService = userService;
        }

        [HttpGet("book/{bookTitle}", Name = "GetBook")]
        public Book GetBook(string bookTitle)
        {
            return bookInventoryService.getBook(bookTitle);
        }

        [HttpPost("book", Name = "AddBook")]
        public bool AddBook(Book book)
        {
            return bookInventoryService.addBook(book);
        }

        [HttpPost("user", Name = "RegisterUser")]
        public bool RegisterUser(User user)
        {
            return userService.registerUser(user);
        }

        [HttpPost("borrow-book/{bookTitle}/{userId}", Name = "BorrowBook")]
        public bool BorrowBook(string userId, string bookTitle)
        {
            return bookInventoryService.borrowBook(userId, bookTitle);
        }

        [HttpPost("return-book/{bookTitle}/{userId}", Name = "ReturnBook")]
        public bool ReturnBook(string userId, string bookTitle)
        {
            return bookInventoryService.returnBook(userId, bookTitle);
        }


    }
}
