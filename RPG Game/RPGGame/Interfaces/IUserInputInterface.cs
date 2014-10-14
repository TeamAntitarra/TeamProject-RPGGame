using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Interfaces
{
    public interface IUserInputInterface
    {
        event EventHandler OnRightPressed;
        event EventHandler OnLeftPressed;
        event EventHandler OnUpPressed;
        event EventHandler OnDownPressed;
        event EventHandler OnMouseClicked;
    }
}
