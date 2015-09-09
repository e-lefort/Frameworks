using Bridge;
using System;

namespace Bridge.AngularJS
{
    [Ignore]
    public class Promise<T>
    {
        public Promise()
        {
        }

        public Promise<T> Then(Action<T> then)
        {
            return null;
        }

        public Promise<T> Success(Action<T> callback)
        {
            return null;
        }

        public Promise<T> Then(Func<T, T> then)
        {
            return null;
        }

        public Promise<T> Success(Func<T, T> callback)
        {
            return null;
        }
    }
}

