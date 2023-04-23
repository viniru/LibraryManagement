using LibraryManagement.model;

namespace LibraryManagement.service
{
    public class Library
    {
        public BookInventory bookInventory { get; }

        private HashSet<User> users;

        private Dictionary<string, HashSet<string>> borrowings;

        public Library()
        {
            bookInventory = new BookInventory();
            users = new HashSet<User>();
            borrowings = new Dictionary<string, HashSet<string>>();
        }

        public void addUser(User user)
        {
            users.Add(user);
        }

        public void removeUser(User user)
        {
            users.Remove(user);
        }

        public void borrow(string userId, string bookTitle)
        {
            
            if(!borrowings.ContainsKey(userId) ) {
                borrowings[userId] = new HashSet<string>();
            }
            if (borrowings[userId].Contains(bookTitle))
            {
                throw new Exception("book already taken by user");
            }
            bookInventory.removeBook(bookTitle);
            borrowings[userId].Add(bookTitle);
        }

        public bool returnBook(string userId, string bookTitle)
        {
            if(!borrowings.ContainsKey(userId) )
            {
                return false;
            }
            if (!borrowings[userId].Contains(bookTitle)) { return false; }
            Book book = bookInventory.getBook(bookTitle);
            bookInventory.addBook(book);
            borrowings[userId].Remove(bookTitle);
            return true;
        }

    }
}
