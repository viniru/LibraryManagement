using LibraryManagement.service.@interface;
using LibraryManagement.model;

namespace LibraryManagement.service
{
    public class UserService : IUserService
    {
        private Library library;
        public UserService(Library library) {
            this.library = library;
        }

        public bool registerUser(User user) {
            library.addUser(user);
            return true;
        }
    }
}
