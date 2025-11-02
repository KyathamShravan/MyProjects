using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserManagement.Models;
using UserManagement.Services;

namespace UserManagement.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public List<UserData> UserDataList = new();
        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()

        {
            UserDataList = context.UserDatas.OrderByDescending(i=> i.Id).ToList();
        }
    }
}
