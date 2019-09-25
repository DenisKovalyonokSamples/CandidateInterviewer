namespace DK.Core.Interfaces
{
    public interface INotificationService
    {
        bool SendEmail(string message, string receiver);
    }
}
