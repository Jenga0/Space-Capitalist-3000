using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Space_Capitalist_3000
{

    public enum ScreenState
    {
        TransitionOn,
        Active,
        TransitionOff,
        Hidden,
    }

    public abstract class Screen
    {

        //by default i want screens to replace eachother,
        //popups will be small screens that do not replace current screen
        public bool IsPopup
        {
            get { return IsPopup; }
            protected set { IsPopup = value; }
        }
        bool isPopup = false;



    }
}
