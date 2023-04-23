namespace LibraryManagement.model
{
    public class Book
    {

        public String title { get; set; }

        public String description { get; set; }

        public Book()
        {
            this.title = "This book does not have a title yet";
            this.description = "This book does not have a description set";
        }
        
        public Book(String title, String description)
        {
            this.title = title;
            this.description = description;
        }
    }
}
