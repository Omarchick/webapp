using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telegram.Bot;
using TelegramGptBot;
using TelegramTest;

namespace WebApplication2.Pages
{
    public class JokeModel : PageModel
    {
        public void OnGet()
        {
            string botToken = BotData.Token;
            var botClient = new TelegramBotClient(botToken);
            var sendHelper = new SendHelper();
            sendHelper.SendJoke(botClient);
        }
    }
}
