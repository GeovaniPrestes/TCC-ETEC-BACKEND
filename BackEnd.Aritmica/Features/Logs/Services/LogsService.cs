using BackEnd.Aritmica.Connection.Interfaces;
using BackEnd.Aritmica.Features.Logs.Enum;
using BackEnd.Aritmica.Features.Logs.Models;
using BackEnd.Aritmica.Features.Logs.Repositories.Interfaces;
using BackEnd.Aritmica.Features.Logs.Services.Interfaces;

namespace BackEnd.Aritmica.Features.Logs.Services
{
    public class LogsService(IConnectionFactory connectionFactory, ILogsRepository logsRepository)
        : ILogsService
    {
        private readonly IConnectionFactory _connectionFactory = connectionFactory;
        private readonly ILogsRepository _logsRepository = logsRepository;

        public void SaveErrorLog(string message, string entity)
        {
            using var dbConnection = _connectionFactory.GetConnection();
            dbConnection.Open();
            using var dbTransaction = dbConnection.BeginTransaction();

            _logsRepository.CreateErrorLog(dbTransaction, GetNewErrorLogModel(message, entity));
        }

        private static LogModel GetNewErrorLogModel(string message, string entity) =>
            new()
            {
                Message = message,
                Entity = entity,
                LogType = LogTypeEnum.Error
            };
    }
}
