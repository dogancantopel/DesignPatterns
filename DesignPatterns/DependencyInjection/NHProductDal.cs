using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class NHProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Save with NH");
        }
    }
}
