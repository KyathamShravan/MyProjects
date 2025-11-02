using Microsoft.EntityFrameworkCore;
using UserManagement.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UserManagement.Services
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options) 
    {
        public DbSet<UserData> UserDatas { get; set; }=null!;
    }
}
