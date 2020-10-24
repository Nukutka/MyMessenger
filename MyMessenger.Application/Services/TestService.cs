﻿using Microsoft.Extensions.DependencyInjection;
using MyMessenger.Core.Factories;
using MyMessenger.Domain.Entities.Users;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyMessenger.Application.Services
{
    public class TestService : ApplicationService
    {
        private readonly IRepository<User> userRepository;
        private readonly UserFactory userFactory;

        public TestService(IRepository<User> userRepository, UserFactory userFactory)
        {
            this.userRepository = userRepository;
            this.userFactory = userFactory;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            var users = await userRepository.GetListAsync();
            return users;
        }

        public async Task<User> InsertUser(User inputUser)
        {
            var user = userFactory.CreateUser(inputUser);
            await userRepository.InsertAsync(user);

            return user;
        }
    }
}
