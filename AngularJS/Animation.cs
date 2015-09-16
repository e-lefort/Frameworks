using System;

namespace Bridge.AngularJS
{
    public class Animation
    {
        // Function which returns a function to cancel animation
        public Func<Action> EventName;

        public Animation()
        {
        }
    }
}

