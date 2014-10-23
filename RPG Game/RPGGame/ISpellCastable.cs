using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGGame
{
    public interface ISpellCastable
    {
        void CastSpell(int x, int y);
    }
}