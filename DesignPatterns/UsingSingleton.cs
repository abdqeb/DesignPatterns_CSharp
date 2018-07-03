using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class UsingSingleton
    {
        public UsingSingleton ()
        {
            //This would result in compiler error
            //CityDB x = new CityDB();

            string msg = CityDB.LazyLockedInstance.SecretMessage;
            msg = CityDB.LazyNestedInstance.SecretMessage;
            msg = CityDB.EagerInstance.SecretMessage;
            msg = CityDB.TrulyLazyInstance.SecretMessage;
        }
    }
}
