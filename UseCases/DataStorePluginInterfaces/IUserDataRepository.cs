using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IUserDataRepository
    {
        Response Create(UserData model);
        Response Update(UserData model);
        UserData GetById(int id);
        IEnumerable<UserData> GetAll();
        Response Delete(int id);
    }
}
