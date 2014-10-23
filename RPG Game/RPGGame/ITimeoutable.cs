using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGGame
{
    public interface ITimeoutable
    {
        int MillisecTimeout { get; set; }
        int CurrentTImeout { get; set; }
        bool HasTimedOut { get; set; }
    }
}