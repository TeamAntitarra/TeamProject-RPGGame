﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Interfaces
{
    public interface IPaintInterface
    {
        void AddObject(IRenderable renderableObject);

        void RemoveObject(IRenderable renderableObject);

        void RedrawObject(IRenderable renderableObject);
    }
}
