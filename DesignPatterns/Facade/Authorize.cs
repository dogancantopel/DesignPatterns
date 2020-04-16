using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Authorize:IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("Check User");
        }
    }
}
