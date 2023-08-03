namespace TelegramTest
{
    public static class TaskHandler
    {
        public static Guid TaskId { get; set; } = Guid.NewGuid();
        public static DateTime Now
        {
            get => DateTime.Now;
        }
        public static DateTime[] NextTimes = new DateTime[3];
    }
}
