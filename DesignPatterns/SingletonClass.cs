using System;

namespace DesignPatterns
{
    public class CityDB
    {
        //In all cases, this is the same
protected CityDB() { }

        //Lazy Instance using locks (works in C# but not JAVA)
        private static CityDB _lazyLockedInstance = null;
        private static object lazyLockObject = new object();
        public static CityDB LazyLockedInstance
        {
            get
            {
                if (_lazyLockedInstance == null)
                {
                    //For thread safety
                    lock (lazyLockObject)
                    {
                        if (_lazyLockedInstance == null)
                            _lazyLockedInstance = new CityDB();
                    }
                }
                return _lazyLockedInstance;
            }
        }

        //Lazy Instance using nested class (works in C# & JAVA)
        public static CityDB LazyNestedInstance
        {
            get
            {
                return Nested.Instance;
            }
        }

        private class Nested
        {
            //Explicit static constructor tells the C# compiler not to mark type as beforefieldinit
            static Nested() {}
            internal static readonly CityDB Instance = new CityDB();
        }


        //Eager Instance
        //This is thread safe due to CLR takes care of initalization and thread safety
        private static readonly CityDB _eagerInstance = new CityDB();
        public static CityDB EagerInstance
        {
            get
            {
                return _eagerInstance;
            }
        }

        //.NET assisted Lazy Instance
        //The Lazy class takes care of making sure this object is thread safe
        private static readonly System.Lazy<CityDB> _trulyLazyInstance = new System.Lazy<CityDB>();
        public static CityDB TrulyLazyInstance
        {
            get
            {
                return _trulyLazyInstance.Value;
            }
        }

        //This is what we are truly after.
        public string SecretMessage
        {
            get
            {
                return "Hello World!";
            }
        }
    }
}
