namespace TelegramTest;

public class ScheduledTask
{
    private Func<Task> action;
    private double minute;
    private Guid taskId;
    private int taskIndex;

    public ScheduledTask(Func<Task> action, double minute, Guid taskId, int taskIndex)
    {
        this.action = action;
        this.minute = minute;
        this.taskId = taskId;
        this.taskIndex = taskIndex;
    }

    public void Start()
    {
        Task.Run(YourAction);
    }

    private async Task YourAction()
    {
        while (taskId == TaskHandler.TaskId)
        {
            var now = DateTime.Now;
            var nextTime = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute / (int)minute * (int)minute, 0);
            var nextExecutionTime = nextTime.AddMinutes(minute);

            TaskHandler.NextTimes[taskIndex] = nextExecutionTime;

            if (nextExecutionTime > now) await Task.Delay(nextExecutionTime - now);

            await action.Invoke();
        }
    }
}