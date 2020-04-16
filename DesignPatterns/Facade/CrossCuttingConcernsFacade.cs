using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class CrossCuttingConcernsFacade
    {
        public ILogging logging;
        public ICaching caching;
        public IAuthorize authorize;

        public CrossCuttingConcernsFacade()
        {
            logging = new Logging();
            caching = new Caching();
            authorize = new Authorize();
        }
    }
}
