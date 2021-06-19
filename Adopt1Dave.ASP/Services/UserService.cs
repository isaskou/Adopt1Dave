using Adopt1Dave.ASP.Models;
using Adopt1Dave.ASP.Models.Forms;
using Adopt1Dave.ASP.Services.Interfaces;
using Adopt1Dave.DAL;
using Adopt1Dave.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adopt1Dave.ASP.Services
{
    public class UserService : IService<UserModel, RegisterForm>
    {
        private readonly DataContext _dc;

        public UserService(DataContext dc)
        {
            _dc = dc;
        }

        public UserModel GetByEmailPassword(string email, string password)
        {
            //TODO
            throw new NotImplementedException();
        }

        public UserModel MapToUserModel(User user)
        {
            //TODO
            throw new NotImplementedException();

        }
        public void Insert(RegisterForm form)
        {
            UserModel model = new UserModel()
            {
                Email = form.Email,
                PasswordIn = form.Password
            };

            User entity = new User()
            {
                Email = model.Email,
                Password = model.PasswordOut
            };

            _dc.Users.Add(entity);

            _dc.SaveChanges();

            form.Id = entity.UserId;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public RegisterForm GetById(int id)
        {
            throw new NotImplementedException();
        }


        public void Update(RegisterForm form)
        {
            throw new NotImplementedException();
        }
    }
}
