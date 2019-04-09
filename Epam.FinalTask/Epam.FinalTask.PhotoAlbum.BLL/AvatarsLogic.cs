﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.FinalTask.PhotoAlbum.BLL.Contracts;
using Epam.FinalTask.PhotoAlbum.DAL.Contracts;
using Epam.FinalTask.PhotoAlbum.Entities;
using Epam.FinalTask.PhotoAlbum.FakeDAL;

namespace Epam.FinalTask.PhotoAlbum.BLL
{
    public class AvatarsLogic : IAvatarsLogic
    {
        private readonly IAvatarsDao avatarsDao;

        public AvatarsLogic(IAvatarsDao avatarsDao)
        {
            this.avatarsDao = new FakeAvatarsDao();
        }

        public Avatar GetUserAvatarByUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
