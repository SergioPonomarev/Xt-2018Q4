﻿using System;

namespace Epam.Task3.Game
{
    class Banana : BuffObject
    {
        public Banana(Position position) : base(position)
        {
        }

        public override IBuffable GetBuff(int buff)
        {
            throw new NotImplementedException();
        }
    }
}
