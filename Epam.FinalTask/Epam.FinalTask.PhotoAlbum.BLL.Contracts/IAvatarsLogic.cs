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

        void SetDefaultAvatar(Avatar avatar);
    }
}
