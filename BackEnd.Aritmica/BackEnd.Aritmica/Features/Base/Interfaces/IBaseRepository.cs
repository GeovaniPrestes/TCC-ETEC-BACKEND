using System.Data;

namespace BackEnd.Aritmica.Features.Base.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create(IDbTransaction dbTransaction, object baseObject, string sql);
        bool Update(IDbTransaction dbTransaction, object baseObject, string sql);
        T ReturnDetails(IDbConnection dbConnection, string sql);
        IList<T> ReturnList(IDbConnection dbConnection, string sql);
        bool Remove(IDbTransaction dbTransaction, int id, string sql);
    }
}
