namespace ASP_NET_Lessons.Models
{
    public class Notification
    {
        public enum Types
        {
            success,
            error,
            info,
            warning
        }

        public string Message { get; set; } = "";
        public Notification.Types Type { get; set; } = Types.info;
    }
}