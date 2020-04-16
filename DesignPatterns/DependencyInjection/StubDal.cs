using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class StubDal : IProductDal
    {
        private static StubDal _stubDal;
        private static object _lock = new object();
        private StubDal(){}
        public static StubDal  GetStubDal()
        {
            lock(_lock)
            {
                if(_stubDal==null)
                {
                    _stubDal = new StubDal();
                }
            }
            return _stubDal;
        }

        public void Save()
        {
        }
    }
}
