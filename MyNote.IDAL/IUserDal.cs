using System;
using System.Collections.Generic;
using MyNote.Model;

namespace MyNote.IDAL
{
    public interface IUserDal
    {
        List<User> GetUserList();
        User GetUser(int userNo);
        bool SaveUser(User user);
    } 
}