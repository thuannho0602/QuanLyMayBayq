using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBBApplication.Models
{
    public class AccountLoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class CreateUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string HovaTen { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
    }
    public class AccountGoogleLogin
    {
        public string Token { get; set; }
    }

    public class AccountAzureLogin
    {
        public string Token { get; set; }
    }
}
