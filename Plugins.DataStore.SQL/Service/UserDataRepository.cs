using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL.Service
{
    public class UserDataRepository:IUserDataRepository
    {
        private readonly PortalContext db;
        public UserDataRepository(PortalContext _db)
        {
            db = _db;
        }
        public Response Create(UserData model)
        {
            var response = new Response();
            try
            {
                db.Add(model);
                db.SaveChanges();
                response.Id = model.Id;
                response.Objects = model;
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.ToString();
            }
            return response;
        }

        public Response Update(UserData model)
        {
            var response = new Response();
            UserData data = db.UserDatas.Where(m => m.Id == model.Id).FirstOrDefault();
            if (data != null)
            {
                data.Name = model.Name;
                data.PhoneNumber = model.PhoneNumber;
                data.Email = model.Email;
                data.CapsuleName = model.CapsuleName;
                try
                {
                    db.SaveChanges();
                    response.Id = model.Id;
                    response.Objects = model;
                    response.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    response.Message = ex.ToString();
                }
            }
            return response;
        }

        public Response Delete(int id)
        {
            var response = new Response();
            UserData data = db.UserDatas.Where(m => m.Id == id).FirstOrDefault();
            if (data != null)
            {
                try
                {
                    db.Remove(data);
                    db.SaveChanges();
                    response.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    response.Message = ex.ToString();
                }
            }
            return response;
        }

        public UserData GetById(int id)
        {
            return db.UserDatas.Where(m => m.Id == id).FirstOrDefault();
        }

        public IEnumerable<UserData> GetAll()
        {
            return db.UserDatas.ToList();
        }
    }
}
