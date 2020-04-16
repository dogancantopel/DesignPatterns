using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class CustomerManager
    {
        //private ILogging _logging;
        //private ICaching _caching;
        //private IAuthorize _authorize;
        private CrossCuttingConcernsFacade ccf;
        public CustomerManager()
        {
            //_logging = logging;
            //_caching = caching;
            //_authorize = authorize;,
            ccf = new CrossCuttingConcernsFacade();
        }
        public void Save()
        {
            //_logging.Log();
            //_caching.Cache();
            //_authorize.CheckUser();
            ccf.authorize.CheckUser();
            ccf.caching.Cache();
            ccf.logging.Log();
            Console.WriteLine("Saved");
        }
    }
}
