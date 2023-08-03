using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TelegramTest;

namespace WebApplication2.Pages
{
    public class StartModel : PageModel
    {
        public void OnGet()
        {
            TaskHandler.TaskId = Guid.NewGuid();
            AutoSender.StartSending();
        }
    }
}
