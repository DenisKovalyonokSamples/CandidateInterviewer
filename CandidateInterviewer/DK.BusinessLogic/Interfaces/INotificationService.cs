namespace DK.BusinessLogic.Interfaces
{
    public interface INotificationService
    {
        bool SendEmail(string message, string receiver);
    }
}
