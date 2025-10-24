using BackEnd.Aritmica.Features.Logs.Services.Interfaces;
using BackEnd.Aritmica.Features.Person.Models;
using BackEnd.Aritmica.Features.Person.Repositories.Interfaces;
using System.Data;

namespace BackEnd.Aritmica.Features.Person.Repositories;

public class StudentRepository(ILogsService logsService) : PersonRepository(logsService), IStudentRepository
{
    public bool SaveStudent(IDbTransaction dbTransaction, StudentModel student)
    {
        try
        {
            var idPerson = SavePerson(dbTransaction, student);
            return true;
        }
        catch (Exception exception)
        {
            logsService.SaveErrorLog(exception.Message, nameof(PersonRepository));
            return false;
        }
        
    }

    public IList<StudentModel> ListStudents(IDbConnection dbConnection)
    {
        throw new NotImplementedException();
    }

    public bool DeactiveStudent(IDbTransaction dbTransaction, int idStudent)
    {
        throw new NotImplementedException();
    }

    public StudentModel ReturnStudent(IDbConnection dbConnection, int idStudent)
    {
        throw new NotImplementedException();
    }
}