using Microsoft.EntityFrameworkCore;
using MyMessenger.Application.Services.Abstraction;
using MyMessenger.Core.Factories;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Enums.Users;
using MyMessenger.Security.Hash.Abstraction;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MyMessenger.Application.Services.Users
{
    public class UserService : BaseService
    {
        private readonly IRepository<User> userRepository;
        private readonly UserFactory userFactory;
        private readonly IHashFunction hashFunction;

        public UserService(IRepository<User> userRepository, UserFactory userFactory, IHashFunction hashFunction)
        {
            this.userRepository = userRepository;
            this.userFactory = userFactory;
            this.hashFunction = hashFunction;
        }

        public IQueryable<User> GetUsersQuery()
        {
            return userRepository.AsQueryable();
        }

        public async Task<User> GetUserAsync(Guid id)
        {
            var user = await userRepository.FirstOrDefaultAsync(u => u.Id == id);

            if (user == null) ExceptionManager.EntityNotFound();

            return user;
        }

        public async Task<User> GetUserByLoginAsync(string login)
        {
            var user = await userRepository.FirstOrDefaultAsync(u => u.Login == login);

            if (user == null) ExceptionManager.EntityNotFound();

            return user;
        }

        public async Task<User> InsertUserAsync(User inputUser)
        {
            var hashPassword = hashFunction.GenerateHashCode(inputUser.HashPassword);
            var user = userFactory.CreateUser(inputUser.Login, inputUser.Role, hashPassword, inputUser.Firstname, inputUser.Lastname, inputUser.Email, UserActiveStatuses.Offline);

            await userRepository.InsertAsync(user);

            return user;
        }

        public async Task<User> UpdateUserAsync(Guid id, User inputUser)
        {
            var hashPassword = hashFunction.GenerateHashCode(inputUser.HashPassword);
            var user = userFactory.CreateUser(id, inputUser.Login, inputUser.Role, hashPassword, inputUser.Firstname, inputUser.Lastname, inputUser.Email, UserActiveStatuses.Offline);

            await userRepository.UpdateAsync(user);

            return user;
        }

        public async Task DeleteUserAsync(Guid id)
        {
            await userRepository.DeleteAsync(u => u.Id == id);
        }
    }
}
