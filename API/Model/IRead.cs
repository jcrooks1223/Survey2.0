using System.Collections.Generic;
namespace API.Model
{
    public interface IRead
    {
       public List<Survey> GetAllSurvey();
    }
}