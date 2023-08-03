using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TelegramTest;

namespace WebApplication2.Pages
{
    public class StopModel : PageModel
    {
        public void OnGet()
        {
            TaskHandler.TaskId = Guid.NewGuid();
        }
    }
}
