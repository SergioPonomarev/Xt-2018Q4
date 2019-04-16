﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.FinalTask.PhotoAlbum.Entities;

namespace Epam.FinalTask.PhotoAlbum.BLL.Contracts
{
    public interface IAvatarsLogic
    {
        Avatar GetUserAvatarByUserName(string userName);

        Avatar GetDefaultAvatar();

        void SetDefaultAvatar(Avatar avatar);

        void SetAvatarToUser(Avatar newAvatar, string userName);
    }
}