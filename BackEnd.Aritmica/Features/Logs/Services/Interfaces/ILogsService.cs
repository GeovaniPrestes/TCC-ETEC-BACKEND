namespace BackEnd.Aritmica.Features.Logs.Services.Interfaces
{
    public interface ILogsService
    {
        void SaveErrorLog(string message, string entity);
    }
}
