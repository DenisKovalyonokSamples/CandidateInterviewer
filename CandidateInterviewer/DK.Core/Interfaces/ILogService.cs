namespace DK.Core.Interfaces
{
    public interface ILogService<T>
    {
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
    }
}
