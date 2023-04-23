namespace LibraryManagement.model
{
    public class User
    {
        public string id { get; set; }
        public String name { get; set; }
        public User(string id, String name) {
            this.name = name;
            this.id = id;   
        }

        public User(User user)
        {
            this.id=user.id;
            this.name = user.name;
        }
        public User()
        {

        }
    }
}
