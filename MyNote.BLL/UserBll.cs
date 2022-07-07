﻿using System;
using System.Collections.Generic;
using MyNote.IDAL;
using MyNote.Model;

namespace MyNote.BLL
{
    public class UserBll
    {
        private readonly IUserDal _userDal;

        public UserBll(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetUserList()
        {
            return _userDal.GetUserList();
        }

        public User GetUser(int userNo)
        {
            if (userNo <= 0)
            {
                throw new ArgumentException();
            }
            return _userDal.GetUser(userNo);
        }

        public bool SaveUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentException();
            }

            return _userDal.SaveUser(user);
        }
    }
}