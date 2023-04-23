namespace LibraryManagement.model
{
    public class BookInventory
    {
        private Dictionary<string, Book> idToBookMap { get; }
        private Dictionary<String, int> bookAvailabilityMap { get; }
        public BookInventory() {
            idToBookMap = new Dictionary<string, Book>();
            bookAvailabilityMap = new Dictionary<string, int>();
        }

        public void addBook(Book book)
        {
            if (!idToBookMap.ContainsKey(book.title))
            {
                idToBookMap[book.title] = book;
                bookAvailabilityMap.Add(book.title, 1);
            } else
            {
                bookAvailabilityMap[book.title]++;
            }
        }

        public void removeBook(String title)
        {
            if (bookAvailabilityMap.GetValueOrDefault(title) == 0) {
                throw new Exception("inventory is empty for the book");
            } else { bookAvailabilityMap[title]--; }
        }

        public Book getBook(String title)
        {
            return idToBookMap[title];
        }

        public bool containsBook(String title)
        {
            return idToBookMap.ContainsKey(title);
        }

    }
}
