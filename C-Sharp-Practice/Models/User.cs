using C_Sharp_Practice.Exceptions;
using C_Sharp_Practice.Models.Common;
using C_Sharp_Practice.Services;
using C_Sharp_Practice.Utils;

namespace C_Sharp_Practice.Models
{
    class User : BaseEntity
    {
        private string username;
        private string password;
        private static int id;

        public string? Username
        {
            get => username;
            set
            {
                //null, "    "
                if (!string.IsNullOrWhiteSpace(value))
                    username = value;
            }
        }
        //Password = "a"
        //console.writeline(Password)
        public string? Password
        {
            get => password;
            set
            {
                //UserService userService = new();
                if (new UserService().CheckPassword(value))
                    password = value;
                else
                    throw new IncorrectPasswordException(Helpers.errorMessages["IncorrectPassword"]);
            }
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            id++;
            Id = id;
        }

        public string GetInfo() => $"Id: {Id} - Username: {Username}";
    }
}
