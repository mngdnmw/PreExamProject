using JokeAppBLL.BusinessObjects;
using System.Collections.Generic;

namespace JokeAppBLL
{
    public interface IService<IEntityBO>
    {
        //C
        IEntityBO Create(IEntityBO joke);
        //R
        List<IEntityBO> GetAll();
        IEntityBO Get(int Id);
        //U There is no update in the reposity, but there is in the Service
        IEntityBO Update(IEntityBO joke);
        //D
        IEntityBO Delete(int Id);
    }
    
}
