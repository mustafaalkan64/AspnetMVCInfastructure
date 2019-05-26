using AktifTelekom.DAL;
using AktifTelekom.DAL.Uow;
using AktifTelekomMVCProject.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AktifTelekomMVCProject.Business.Services
{
    public class UsersService: IUsersService
    {
        private readonly IUnitOfWork _uow;
        public UsersService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task Add(Users entity)
        {
            await _uow.UsersRepository.Add(entity);
        }

        public async Task Delete(Users entity)
        {
            await _uow.UsersRepository.Delete(entity);
        }

        public async Task DeleteById(int id)
        {
            await _uow.UsersRepository.Delete(a => a.Id.Equals(id));
        }

        public async Task<List<Users>> GetAll()
        {
            return await _uow.UsersRepository.GetAll();
        }

        public async Task<Users> GetById(int id)
        {
            return await _uow.UsersRepository.FindBy(a => a.Id.Equals(id));
        }

        public async Task Update(Users entity)
        {
            await _uow.UsersRepository.Update(entity);
        }
    }
}
