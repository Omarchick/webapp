using Telegram.Bot;
using TelegramGptBot;

namespace TelegramTest;

public static class AutoSender
{
    public static void StartSending()
    {
        var taskId = TaskHandler.TaskId;
        string botToken = BotData.Token;
        var botClient = new TelegramBotClient(botToken);
        var sendHelper = new SendHelper();

        var firstScheduledTask = new ScheduledTask(async () => await sendHelper.SendJoke(botClient), 15, taskId, 0);
        var secondScheduledTask = new ScheduledTask(async () => await sendHelper.SendFact(botClient), 20, taskId, 1);
        var thirdScheduledTask = new ScheduledTask(async () => await sendHelper.SendRequest(), 50, taskId, 2);

        firstScheduledTask.Start();
        secondScheduledTask.Start();
        thirdScheduledTask.Start();
    }
}