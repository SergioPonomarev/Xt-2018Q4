﻿using System;

namespace Epam.Task3.VectorGraphicsEditor.Entities
{
    public abstract class Figure
    {
        public abstract Point Center { get; set; }

        public abstract string ShowFigure();
    }
}