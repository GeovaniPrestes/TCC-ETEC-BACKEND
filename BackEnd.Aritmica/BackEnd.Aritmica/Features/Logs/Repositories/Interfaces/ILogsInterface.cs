using BackEnd.Aritmica.Features.Logs.Models;
using System.Data;

namespace BackEnd.Aritmica.Features.Logs.Repositories.Interfaces
{
    public interface ILogsInterface
    {
        void SaveErrorLog(IDbTransaction dbTransaction, LogModel log);
        void SaveSuccessLog(IDbTransaction dbTransaction, LogModel log);
    }
}
