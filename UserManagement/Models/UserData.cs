using Microsoft.EntityFrameworkCore;

namespace UserManagement.Models
{
    public class UserData
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public string UserEmail { get; set; } = string.Empty;   
        public string Password { get; set; } = string.Empty;

        public string Service { get; set; } = string.Empty;


    }
}
