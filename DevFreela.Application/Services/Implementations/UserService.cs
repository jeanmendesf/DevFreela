﻿using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewUserInputModel inputModel)
        {
            throw new NotImplementedException();
        }

        public List<UserViewModel> Get()
        {
            var users = _dbContext.Users;

            var usersViewModel = users
                .Select(u => new UserViewModel(u.Id, u.FullName, u.Email, u.BirthDate))
                .ToList();

             return usersViewModel;
        }

        public UserViewModel GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            var userViewModel = new UserViewModel(
                user.Id,
                user.FullName,
                user.Email,
                user.BirthDate);

            return userViewModel;
        }

        public void Update(UpdateUserInputModel inputModel)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == inputModel.Id);

            user.Update(inputModel.FullName, inputModel.Email, inputModel.BirthDate);            
        }
    }
}
