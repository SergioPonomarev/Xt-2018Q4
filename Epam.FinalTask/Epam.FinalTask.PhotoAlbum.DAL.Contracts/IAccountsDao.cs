﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.FinalTask.PhotoAlbum.DAL.Contracts
{
    public interface IAccountsDao
    {
        string GetPassByLogin(string login);

        bool SetPassToUser(string userName, string hashedPass);
    }
}
